using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoSupervisorio
{
    public partial class FormDefault : Form
    {
        string rxString;

        public FormDefault()
        {
            InitializeComponent();
            this.atualizaPortas();
            this.populateComboBoxBaudRate();
        }

        private void checkBoxBloquearMovimentacao_CheckedChanged(object sender, EventArgs e)
        {
            this.buttonMoveFrente.Enabled = !this.buttonMoveFrente.Enabled;
            this.buttonMoveTras.Enabled = !this.buttonMoveTras.Enabled;
            this.buttonMoveEsquerda.Enabled = !this.buttonMoveEsquerda.Enabled;
            this.buttonMoveDireita.Enabled = !this.buttonMoveDireita.Enabled;
        }

        /// <summary>
        /// Método responsável por popular o combobox com as portas COMs disponíveis.
        /// </summary>
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

        private void populateTextBoxDisplayInfo(string value)
        {
            DateTime date = DateTime.Now;

            StringBuilder str = new StringBuilder();
            str.Append(date.ToString("T"));
            str.Append(" - ");
            str.Append(value);
            str.Append("\r\n");

            this.textBoxDisplayInfo.AppendText(str.ToString());
        }

        private void trataDadoRecebido(Object sender, EventArgs e)
        {
            this.populateTextBoxDisplayInfo(this.rxString);
        }

        private void FormDefault_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort.IsOpen == true)
            {
                this.serialPort.Close();
            }
        }

        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            this.atualizaPortas();
        }

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

                this.populateTextBoxDisplayInfo("Conectado");
            }
            catch (Exception)
            {

            }
        }

        private void comboBoxSelectPortaCom_TextChanged(object sender, EventArgs e)
        {
            this.comboBoxSelectBaudRate.Enabled = true;
            this.buttonConectar.Enabled = true;
        }

        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen == false)
            {
                return;
            }

            try
            {
                serialPort.WriteLine("22");
                this.serialPort.Close();

                this.comboBoxSelectPortaCom.Enabled = true;
                this.comboBoxSelectBaudRate.Enabled = true;
                this.buttonConectar.Enabled = true;
                this.buttonDesconectar.Enabled = false;
                this.groupBoxMove.Enabled = false;

                this.populateTextBoxDisplayInfo("Desconectado");
            }
            catch (Exception)
            {

            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead > 0)
            {
                this.rxString = serialPort.ReadLine();
                this.Invoke(new EventHandler(trataDadoRecebido));
            }
        }

        private void buttonClearDisplayInfo_Click(object sender, EventArgs e)
        {
            this.textBoxDisplayInfo.Clear();
        }

        private void buttonMoveFrente_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("1111");
        }

        private void buttonMoveTras_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("22");
        }

        private void buttonMoveEsquerda_Click(object sender, EventArgs e)
        {
            serialPort.WriteLine("1010");
        }
    }
}
