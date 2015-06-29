namespace ArduinoSupervisorio
{
    partial class FormDefault
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxMove = new System.Windows.Forms.GroupBox();
            this.checkBoxBloquearMovimentacao = new System.Windows.Forms.CheckBox();
            this.buttonMoveEsquerda = new System.Windows.Forms.Button();
            this.buttonMoveDireita = new System.Windows.Forms.Button();
            this.buttonMoveTras = new System.Windows.Forms.Button();
            this.buttonMoveFrente = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxDisplayInfo = new System.Windows.Forms.TextBox();
            this.groupBoxDistancias = new System.Windows.Forms.GroupBox();
            this.groupBoxVelocidade = new System.Windows.Forms.GroupBox();
            this.groupBoxConfigSerial = new System.Windows.Forms.GroupBox();
            this.buttonClearDisplayInfo = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonUpdatePorts = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.labelSelectBaudRate = new System.Windows.Forms.Label();
            this.labelSelectPortaCom = new System.Windows.Forms.Label();
            this.comboBoxSelectBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectPortaCom = new System.Windows.Forms.ComboBox();
            this.groupBoxMove.SuspendLayout();
            this.groupBoxConfigSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Controls.Add(this.checkBoxBloquearMovimentacao);
            this.groupBoxMove.Controls.Add(this.buttonMoveEsquerda);
            this.groupBoxMove.Controls.Add(this.buttonMoveDireita);
            this.groupBoxMove.Controls.Add(this.buttonMoveTras);
            this.groupBoxMove.Controls.Add(this.buttonMoveFrente);
            this.groupBoxMove.Enabled = false;
            this.groupBoxMove.Location = new System.Drawing.Point(12, 128);
            this.groupBoxMove.Name = "groupBoxMove";
            this.groupBoxMove.Size = new System.Drawing.Size(376, 301);
            this.groupBoxMove.TabIndex = 0;
            this.groupBoxMove.TabStop = false;
            this.groupBoxMove.Text = "Move";
            // 
            // checkBoxBloquearMovimentacao
            // 
            this.checkBoxBloquearMovimentacao.AutoSize = true;
            this.checkBoxBloquearMovimentacao.Location = new System.Drawing.Point(6, 278);
            this.checkBoxBloquearMovimentacao.Name = "checkBoxBloquearMovimentacao";
            this.checkBoxBloquearMovimentacao.Size = new System.Drawing.Size(141, 17);
            this.checkBoxBloquearMovimentacao.TabIndex = 4;
            this.checkBoxBloquearMovimentacao.Text = "Bloquear Movimentação";
            this.checkBoxBloquearMovimentacao.UseVisualStyleBackColor = true;
            this.checkBoxBloquearMovimentacao.CheckedChanged += new System.EventHandler(this.checkBoxBloquearMovimentacao_CheckedChanged);
            // 
            // buttonMoveEsquerda
            // 
            this.buttonMoveEsquerda.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveEsquerda.Location = new System.Drawing.Point(58, 101);
            this.buttonMoveEsquerda.Name = "buttonMoveEsquerda";
            this.buttonMoveEsquerda.Size = new System.Drawing.Size(75, 72);
            this.buttonMoveEsquerda.TabIndex = 3;
            this.buttonMoveEsquerda.Text = "◄";
            this.buttonMoveEsquerda.UseVisualStyleBackColor = true;
            this.buttonMoveEsquerda.Click += new System.EventHandler(this.buttonMoveEsquerda_Click);
            // 
            // buttonMoveDireita
            // 
            this.buttonMoveDireita.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveDireita.Location = new System.Drawing.Point(239, 101);
            this.buttonMoveDireita.Name = "buttonMoveDireita";
            this.buttonMoveDireita.Size = new System.Drawing.Size(75, 72);
            this.buttonMoveDireita.TabIndex = 2;
            this.buttonMoveDireita.Text = "►";
            this.buttonMoveDireita.UseVisualStyleBackColor = true;
            // 
            // buttonMoveTras
            // 
            this.buttonMoveTras.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveTras.Location = new System.Drawing.Point(149, 171);
            this.buttonMoveTras.Name = "buttonMoveTras";
            this.buttonMoveTras.Size = new System.Drawing.Size(75, 72);
            this.buttonMoveTras.TabIndex = 1;
            this.buttonMoveTras.Text = "▼";
            this.buttonMoveTras.UseVisualStyleBackColor = true;
            this.buttonMoveTras.Click += new System.EventHandler(this.buttonMoveTras_Click);
            // 
            // buttonMoveFrente
            // 
            this.buttonMoveFrente.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveFrente.Location = new System.Drawing.Point(149, 29);
            this.buttonMoveFrente.Name = "buttonMoveFrente";
            this.buttonMoveFrente.Size = new System.Drawing.Size(75, 72);
            this.buttonMoveFrente.TabIndex = 0;
            this.buttonMoveFrente.Text = "▲";
            this.buttonMoveFrente.UseVisualStyleBackColor = true;
            this.buttonMoveFrente.Click += new System.EventHandler(this.buttonMoveFrente_Click);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // textBoxDisplayInfo
            // 
            this.textBoxDisplayInfo.Location = new System.Drawing.Point(12, 445);
            this.textBoxDisplayInfo.Multiline = true;
            this.textBoxDisplayInfo.Name = "textBoxDisplayInfo";
            this.textBoxDisplayInfo.ReadOnly = true;
            this.textBoxDisplayInfo.Size = new System.Drawing.Size(874, 180);
            this.textBoxDisplayInfo.TabIndex = 1;
            // 
            // groupBoxDistancias
            // 
            this.groupBoxDistancias.Location = new System.Drawing.Point(403, 128);
            this.groupBoxDistancias.Name = "groupBoxDistancias";
            this.groupBoxDistancias.Size = new System.Drawing.Size(239, 301);
            this.groupBoxDistancias.TabIndex = 2;
            this.groupBoxDistancias.TabStop = false;
            this.groupBoxDistancias.Text = "Distâncias";
            // 
            // groupBoxVelocidade
            // 
            this.groupBoxVelocidade.Location = new System.Drawing.Point(659, 128);
            this.groupBoxVelocidade.Name = "groupBoxVelocidade";
            this.groupBoxVelocidade.Size = new System.Drawing.Size(227, 301);
            this.groupBoxVelocidade.TabIndex = 3;
            this.groupBoxVelocidade.TabStop = false;
            this.groupBoxVelocidade.Text = "Velocidade";
            // 
            // groupBoxConfigSerial
            // 
            this.groupBoxConfigSerial.Controls.Add(this.buttonClearDisplayInfo);
            this.groupBoxConfigSerial.Controls.Add(this.buttonDesconectar);
            this.groupBoxConfigSerial.Controls.Add(this.buttonUpdatePorts);
            this.groupBoxConfigSerial.Controls.Add(this.buttonConectar);
            this.groupBoxConfigSerial.Controls.Add(this.labelSelectBaudRate);
            this.groupBoxConfigSerial.Controls.Add(this.labelSelectPortaCom);
            this.groupBoxConfigSerial.Controls.Add(this.comboBoxSelectBaudRate);
            this.groupBoxConfigSerial.Controls.Add(this.comboBoxSelectPortaCom);
            this.groupBoxConfigSerial.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfigSerial.Name = "groupBoxConfigSerial";
            this.groupBoxConfigSerial.Size = new System.Drawing.Size(874, 98);
            this.groupBoxConfigSerial.TabIndex = 4;
            this.groupBoxConfigSerial.TabStop = false;
            this.groupBoxConfigSerial.Text = "Configuração de Conexão";
            // 
            // buttonClearDisplayInfo
            // 
            this.buttonClearDisplayInfo.Location = new System.Drawing.Point(640, 46);
            this.buttonClearDisplayInfo.Name = "buttonClearDisplayInfo";
            this.buttonClearDisplayInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonClearDisplayInfo.TabIndex = 7;
            this.buttonClearDisplayInfo.Text = "Limpar";
            this.buttonClearDisplayInfo.UseVisualStyleBackColor = true;
            this.buttonClearDisplayInfo.Click += new System.EventHandler(this.buttonClearDisplayInfo_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Enabled = false;
            this.buttonDesconectar.Location = new System.Drawing.Point(429, 46);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(92, 23);
            this.buttonDesconectar.TabIndex = 6;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // buttonUpdatePorts
            // 
            this.buttonUpdatePorts.Location = new System.Drawing.Point(527, 46);
            this.buttonUpdatePorts.Name = "buttonUpdatePorts";
            this.buttonUpdatePorts.Size = new System.Drawing.Size(107, 23);
            this.buttonUpdatePorts.TabIndex = 5;
            this.buttonUpdatePorts.Text = "Atualizar Portas";
            this.buttonUpdatePorts.UseVisualStyleBackColor = true;
            this.buttonUpdatePorts.Click += new System.EventHandler(this.buttonUpdatePorts_Click);
            // 
            // buttonConectar
            // 
            this.buttonConectar.Enabled = false;
            this.buttonConectar.Location = new System.Drawing.Point(347, 46);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 23);
            this.buttonConectar.TabIndex = 4;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // labelSelectBaudRate
            // 
            this.labelSelectBaudRate.AutoSize = true;
            this.labelSelectBaudRate.Location = new System.Drawing.Point(178, 29);
            this.labelSelectBaudRate.Name = "labelSelectBaudRate";
            this.labelSelectBaudRate.Size = new System.Drawing.Size(55, 13);
            this.labelSelectBaudRate.TabIndex = 3;
            this.labelSelectBaudRate.Text = "BaudRate";
            // 
            // labelSelectPortaCom
            // 
            this.labelSelectPortaCom.AutoSize = true;
            this.labelSelectPortaCom.Location = new System.Drawing.Point(7, 29);
            this.labelSelectPortaCom.Name = "labelSelectPortaCom";
            this.labelSelectPortaCom.Size = new System.Drawing.Size(59, 13);
            this.labelSelectPortaCom.TabIndex = 2;
            this.labelSelectPortaCom.Text = "Porta COM";
            // 
            // comboBoxSelectBaudRate
            // 
            this.comboBoxSelectBaudRate.Enabled = false;
            this.comboBoxSelectBaudRate.FormattingEnabled = true;
            this.comboBoxSelectBaudRate.Location = new System.Drawing.Point(181, 48);
            this.comboBoxSelectBaudRate.Name = "comboBoxSelectBaudRate";
            this.comboBoxSelectBaudRate.Size = new System.Drawing.Size(160, 21);
            this.comboBoxSelectBaudRate.TabIndex = 1;
            // 
            // comboBoxSelectPortaCom
            // 
            this.comboBoxSelectPortaCom.FormattingEnabled = true;
            this.comboBoxSelectPortaCom.Location = new System.Drawing.Point(7, 48);
            this.comboBoxSelectPortaCom.Name = "comboBoxSelectPortaCom";
            this.comboBoxSelectPortaCom.Size = new System.Drawing.Size(168, 21);
            this.comboBoxSelectPortaCom.TabIndex = 0;
            this.comboBoxSelectPortaCom.TextChanged += new System.EventHandler(this.comboBoxSelectPortaCom_TextChanged);
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 637);
            this.Controls.Add(this.groupBoxConfigSerial);
            this.Controls.Add(this.groupBoxVelocidade);
            this.Controls.Add(this.groupBoxDistancias);
            this.Controls.Add(this.textBoxDisplayInfo);
            this.Controls.Add(this.groupBoxMove);
            this.MaximizeBox = false;
            this.Name = "FormDefault";
            this.Text = "Arduino Supervisório";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDefault_FormClosed);
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxMove.PerformLayout();
            this.groupBoxConfigSerial.ResumeLayout(false);
            this.groupBoxConfigSerial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMove;
        private System.Windows.Forms.CheckBox checkBoxBloquearMovimentacao;
        private System.Windows.Forms.Button buttonMoveEsquerda;
        private System.Windows.Forms.Button buttonMoveDireita;
        private System.Windows.Forms.Button buttonMoveTras;
        private System.Windows.Forms.Button buttonMoveFrente;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox textBoxDisplayInfo;
        private System.Windows.Forms.GroupBox groupBoxDistancias;
        private System.Windows.Forms.GroupBox groupBoxVelocidade;
        private System.Windows.Forms.GroupBox groupBoxConfigSerial;
        private System.Windows.Forms.Button buttonUpdatePorts;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label labelSelectBaudRate;
        private System.Windows.Forms.Label labelSelectPortaCom;
        private System.Windows.Forms.ComboBox comboBoxSelectBaudRate;
        private System.Windows.Forms.ComboBox comboBoxSelectPortaCom;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Button buttonClearDisplayInfo;
    }
}

