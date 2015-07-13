using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace ArduinoSupervisorio
{
    /// <summary>
    /// Classe responsável pelo programa principal.
    /// 
    /// Pacote: #1;1;1;1;1#
    /// 
    /// 1º - Ativa/desativa dispositivo.
    /// 2º - Move/paralisa roda dianteira esquerda.
    /// 3º - Move/paralisa roda dianteira direita.
    /// 4º - Move/paralisa roda traseira esquerda.
    /// 5º - Move/paralisa roda traseira direita.
    /// 
    /// </summary>
    public partial class FormDefault : Form
    {
        private string RxString;
        private IList<double> VelocidadeMedia;

        /// <summary>
        /// Método construtor da classe.
        /// </summary>
        public FormDefault()
        {
            InitializeComponent();
            this.atualizaPortas();
            this.populateComboBoxBaudRate();
        }

        /// <summary>
        /// Método responsável por popular o combobox com as portas COMs disponíveis.
        /// </summary>
        /// <returns>void</returns>
        private void atualizaPortas()
        {
            this.comboBoxSelectPortaCom.Items.Clear();

            foreach (string portName in SerialPort.GetPortNames())
            {
                this.comboBoxSelectPortaCom.Items.Add(portName);
            }

            if (this.comboBoxSelectPortaCom.Items.Count == 1)
            {
                this.comboBoxSelectPortaCom.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Método responsável por popular o combobox do BaudRate.
        /// </summary>
        /// <returns>void</returns>
        private void populateComboBoxBaudRate()
        {
            this.comboBoxSelectBaudRate.Items.Add(300);
            this.comboBoxSelectBaudRate.Items.Add(600);
            this.comboBoxSelectBaudRate.Items.Add(1200);
            this.comboBoxSelectBaudRate.Items.Add(2400);
            this.comboBoxSelectBaudRate.Items.Add(4800);
            this.comboBoxSelectBaudRate.Items.Add(9600);
            this.comboBoxSelectBaudRate.Items.Add(14400);
            this.comboBoxSelectBaudRate.Items.Add(19200);
            this.comboBoxSelectBaudRate.Items.Add(28800);
            this.comboBoxSelectBaudRate.Items.Add(38400);
            this.comboBoxSelectBaudRate.Items.Add(57600);
            this.comboBoxSelectBaudRate.Items.Add(115200);

            this.comboBoxSelectBaudRate.SelectedIndex = 5;
        }

        /// <summary>
        /// Método responsável por popular o campo com as inforções de IO.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>void</returns>
        private void populateTextBoxDisplayInfo(string value)
        {
            DateTime date = DateTime.Now;

            StringBuilder str = new StringBuilder();
            str.Append(date.ToString("T"));
            str.Append(" - ");
            str.Append(value);
            str.Append(Environment.NewLine);

            this.textBoxDisplayInfo.AppendText(str.ToString());
        }

        /// <summary>
        /// Método responsável por tratar os dados recebidos da porta serial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void trataDadoRecebido(Object sender, EventArgs e)
        {
            if (!"".Equals(this.RxString))
            {
                PackageReceive packareReceive = new PackageReceive();
                PackageReceive result = packareReceive.ProcessPackage(this.RxString);

                if (result != null)
                {
                    this.labelDistanciaDianteira.Text = result.DistanciaDianteira.ToString();
                    this.labelDistanciaTraseira.Text = result.DistanciaTraseira.ToString();
                    this.labelVelocidadeAtual.Text = result.Velocidade.ToString();

                    //this.VelocidadeMedia.Add(result.Velocidade);

                    this.populateTextBoxDisplayInfo(this.RxString);
                }
            }
        }

        /// <summary>
        /// Método responsável por enviar o pacote na porta serial para o dispositivo.
        /// </summary>
        /// <param name="command"></param>
        /// <returns>void</returns>
        private void sendCommandSerialPort(string command)
        {
            serialPort.WriteLine(command);
        }

        /// <summary>
        /// Método responsável por fechar a porta serial, caso ainda esteja aberta ao fechar a tela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void FormDefault_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                this.serialPort.Close();
            }
        }

        /// <summary>
        /// Método responsável por atualizar a lista de portas disponíveis.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            this.atualizaPortas();
        }

        /// <summary>
        /// Método responsável por efetuar a conexão com o dispositivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                return;
            }

            serialPort.PortName = comboBoxSelectPortaCom.Items[comboBoxSelectPortaCom.SelectedIndex].ToString();
            serialPort.BaudRate = Convert.ToInt32(comboBoxSelectBaudRate.Items[comboBoxSelectBaudRate.SelectedIndex].ToString()); ;

            try
            {
                serialPort.Open();
                this.comboBoxSelectPortaCom.Enabled = false;
                this.comboBoxSelectBaudRate.Enabled = false;
                this.buttonConectar.Enabled = false;
                this.buttonDesconectar.Enabled = true;
                this.groupBoxMove.Enabled = true;
                this.groupBoxDistanciaDianteira.Enabled = true;
                this.groupBoxDistanciaTraseira.Enabled = true;
                this.groupBoxVelocidade.Enabled = true;
                this.textBoxDisplayInfo.Enabled = true;

                this.populateTextBoxDisplayInfo("Conectado");

                PackageSend packageSend = new PackageSend();
                packageSend.Active = Util.SYSTEM_ACTIVE;
                this.sendCommandSerialPort(packageSend.ToString());
                this.populateTextBoxDisplayInfo(packageSend.ToString());
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Método responsável por fechar a conexão com o dispositivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                return;
            }

            try
            {
                PackageSend packageSend = new PackageSend();
                packageSend.Active = Util.SYSTEM_DESACTIVE;
                this.sendCommandSerialPort(packageSend.ToString());
                this.populateTextBoxDisplayInfo(packageSend.ToString());

                this.serialPort.Close();

                this.comboBoxSelectPortaCom.Enabled = true;
                this.comboBoxSelectBaudRate.Enabled = true;
                this.buttonConectar.Enabled = true;
                this.buttonDesconectar.Enabled = false;
                this.groupBoxMove.Enabled = false;
                this.groupBoxDistanciaDianteira.Enabled = false;
                this.groupBoxDistanciaTraseira.Enabled = false;
                this.groupBoxVelocidade.Enabled = false;
                this.textBoxDisplayInfo.Enabled = false;

                this.populateTextBoxDisplayInfo("Desconectado");
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Método responsável por habilitar o campo BaudRate e o cotão conectar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void comboBoxSelectPortaCom_TextChanged(object sender, EventArgs e)
        {
            this.comboBoxSelectBaudRate.Enabled = true;
            this.buttonConectar.Enabled = true;
        }

        /// <summary>
        /// Método responsável por verificar se tem dados na porta serial.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead > 0)
            {
                this.RxString = serialPort.ReadLine();
                this.Invoke(new EventHandler(trataDadoRecebido));
            }
        }

        /// <summary>
        /// Método responsável por desabiltar/habilitar os botões de movimentação.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void checkBoxBloquearMovimentacao_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonMoveFrente.Enabled = !this.buttonMoveFrente.Enabled;
            this.buttonMoveTras.Enabled = !this.buttonMoveTras.Enabled;
            this.buttonMoveEsquerda.Enabled = !this.buttonMoveEsquerda.Enabled;
            this.buttonMoveDireita.Enabled = !this.buttonMoveDireita.Enabled;
            this.buttonBreakAll.Enabled = !this.buttonBreakAll.Enabled;
        }

        /// <summary>
        /// Método responsável por limpar o campo que exibe as informações de IO.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonClearDisplayInfo_Click(object sender, EventArgs e)
        {
            this.textBoxDisplayInfo.Clear();
        }

        /// <summary>
        /// Método responsável por mover o dispositivo para frente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonMoveFrente_Click(object sender, EventArgs e)
        {
            PackageSend packageSend = new PackageSend();
            packageSend.Active = Util.SYSTEM_ACTIVE;
            packageSend.RodaDianteiraEsquerda = Util.ROTATE_FORWARD;
            packageSend.RodaDianteiraDireita = Util.ROTATE_FORWARD;
            packageSend.RodaTraseiraEsquerda = Util.ROTATE_FORWARD;
            packageSend.RodaTraseiraDireita = Util.ROTATE_FORWARD;

            this.sendCommandSerialPort(packageSend.ToString());
            this.populateTextBoxDisplayInfo(packageSend.ToString());
        }

        /// <summary>
        /// Método responsável por mover o dispositivo para trás.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonMoveTras_Click(object sender, EventArgs e)
        {
            PackageSend packageSend = new PackageSend();
            packageSend.Active = Util.SYSTEM_ACTIVE;
            packageSend.RodaDianteiraEsquerda = Util.ROTATE_BACKWARD;
            packageSend.RodaDianteiraDireita = Util.ROTATE_BACKWARD;
            packageSend.RodaTraseiraEsquerda = Util.ROTATE_BACKWARD;
            packageSend.RodaTraseiraDireita = Util.ROTATE_BACKWARD;

            this.sendCommandSerialPort(packageSend.ToString());
            this.populateTextBoxDisplayInfo(packageSend.ToString());
        }

        /// <summary>
        /// Método responsável por mover o dispositivo para esquerda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonMoveEsquerda_Click(object sender, EventArgs e)
        {
            PackageSend packageSend = new PackageSend();
            packageSend.Active = Util.SYSTEM_ACTIVE;
            packageSend.RodaDianteiraEsquerda = Util.ROTATE_BACKWARD;
            packageSend.RodaDianteiraDireita = Util.ROTATE_FORWARD;
            packageSend.RodaTraseiraEsquerda = Util.ROTATE_BACKWARD;
            packageSend.RodaTraseiraDireita = Util.ROTATE_FORWARD;

            this.sendCommandSerialPort(packageSend.ToString());
            this.populateTextBoxDisplayInfo(packageSend.ToString());
        }

        /// <summary>
        /// Método responsável por mover o dispositivo para direita.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonMoveDireita_Click(object sender, EventArgs e)
        {
            PackageSend packageSend = new PackageSend();
            packageSend.Active = Util.SYSTEM_ACTIVE;
            packageSend.RodaDianteiraEsquerda = Util.ROTATE_FORWARD;
            packageSend.RodaDianteiraDireita = Util.ROTATE_BACKWARD;
            packageSend.RodaTraseiraEsquerda = Util.ROTATE_FORWARD;
            packageSend.RodaTraseiraDireita = Util.ROTATE_BACKWARD;

            this.sendCommandSerialPort(packageSend.ToString());
            this.populateTextBoxDisplayInfo(packageSend.ToString());
        }

        /// <summary>
        /// Método responsável por freiar o dispositivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns>void</returns>
        private void buttonBreakAll_Click(object sender, EventArgs e)
        {
            PackageSend packageSend = new PackageSend();
            packageSend.Active = Util.SYSTEM_ACTIVE;
            this.sendCommandSerialPort(packageSend.ToString());
            this.populateTextBoxDisplayInfo(packageSend.ToString());
        }
    }
}
