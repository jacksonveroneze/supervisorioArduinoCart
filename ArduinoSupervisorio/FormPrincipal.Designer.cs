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
            this.buttonBreakAll = new System.Windows.Forms.Button();
            this.checkBoxBloquearMovimentacao = new System.Windows.Forms.CheckBox();
            this.buttonMoveEsquerda = new System.Windows.Forms.Button();
            this.buttonMoveDireita = new System.Windows.Forms.Button();
            this.buttonMoveTras = new System.Windows.Forms.Button();
            this.buttonMoveFrente = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBoxDisplayInfo = new System.Windows.Forms.TextBox();
            this.groupBoxDistanciaDianteira = new System.Windows.Forms.GroupBox();
            this.labelDistanciaDianteira = new System.Windows.Forms.Label();
            this.groupBoxVelocidade = new System.Windows.Forms.GroupBox();
            this.labelVelocidadeMinimaValue = new System.Windows.Forms.Label();
            this.labelVelocidadeMaximaValue = new System.Windows.Forms.Label();
            this.labelVelocidadeMediaValue = new System.Windows.Forms.Label();
            this.labelVelocidadeAtual = new System.Windows.Forms.Label();
            this.labelVelocidadeMinimaText = new System.Windows.Forms.Label();
            this.labelVelocidadeMaximaText = new System.Windows.Forms.Label();
            this.labelVelocidadeMediaText = new System.Windows.Forms.Label();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.buttonClearDisplayInfo = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.buttonUpdatePorts = new System.Windows.Forms.Button();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.labelSelectBaudRate = new System.Windows.Forms.Label();
            this.labelSelectPortaCom = new System.Windows.Forms.Label();
            this.comboBoxSelectBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectPortaCom = new System.Windows.Forms.ComboBox();
            this.groupBoxDistanciaTraseira = new System.Windows.Forms.GroupBox();
            this.labelDistanciaTraseira = new System.Windows.Forms.Label();
            this.groupBoxMove.SuspendLayout();
            this.groupBoxDistanciaDianteira.SuspendLayout();
            this.groupBoxVelocidade.SuspendLayout();
            this.groupBoxConfig.SuspendLayout();
            this.groupBoxDistanciaTraseira.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMove
            // 
            this.groupBoxMove.Controls.Add(this.buttonBreakAll);
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
            // buttonBreakAll
            // 
            this.buttonBreakAll.Font = new System.Drawing.Font("Arial Narrow", 8.25F);
            this.buttonBreakAll.Location = new System.Drawing.Point(165, 117);
            this.buttonBreakAll.Name = "buttonBreakAll";
            this.buttonBreakAll.Size = new System.Drawing.Size(40, 40);
            this.buttonBreakAll.TabIndex = 5;
            this.buttonBreakAll.Text = "■";
            this.buttonBreakAll.UseVisualStyleBackColor = true;
            this.buttonBreakAll.Click += new System.EventHandler(this.buttonBreakAll_Click);
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
            this.buttonMoveDireita.Click += new System.EventHandler(this.buttonMoveDireita_Click);
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
            this.textBoxDisplayInfo.Size = new System.Drawing.Size(874, 130);
            this.textBoxDisplayInfo.TabIndex = 1;
            // 
            // groupBoxDistanciaDianteira
            // 
            this.groupBoxDistanciaDianteira.Controls.Add(this.labelDistanciaDianteira);
            this.groupBoxDistanciaDianteira.Location = new System.Drawing.Point(403, 128);
            this.groupBoxDistanciaDianteira.Name = "groupBoxDistanciaDianteira";
            this.groupBoxDistanciaDianteira.Size = new System.Drawing.Size(239, 145);
            this.groupBoxDistanciaDianteira.TabIndex = 2;
            this.groupBoxDistanciaDianteira.TabStop = false;
            this.groupBoxDistanciaDianteira.Text = "Distância dianteira";
            // 
            // labelDistanciaDianteira
            // 
            this.labelDistanciaDianteira.AutoSize = true;
            this.labelDistanciaDianteira.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanciaDianteira.Location = new System.Drawing.Point(48, 65);
            this.labelDistanciaDianteira.Name = "labelDistanciaDianteira";
            this.labelDistanciaDianteira.Size = new System.Drawing.Size(32, 36);
            this.labelDistanciaDianteira.TabIndex = 0;
            this.labelDistanciaDianteira.Text = "_";
            // 
            // groupBoxVelocidade
            // 
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeMinimaValue);
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeMaximaValue);
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeMediaValue);
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeAtual);
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeMinimaText);
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeMaximaText);
            this.groupBoxVelocidade.Controls.Add(this.labelVelocidadeMediaText);
            this.groupBoxVelocidade.Location = new System.Drawing.Point(659, 128);
            this.groupBoxVelocidade.Name = "groupBoxVelocidade";
            this.groupBoxVelocidade.Size = new System.Drawing.Size(227, 301);
            this.groupBoxVelocidade.TabIndex = 3;
            this.groupBoxVelocidade.TabStop = false;
            this.groupBoxVelocidade.Text = "Velocidade";
            // 
            // labelVelocidadeMinimaValue
            // 
            this.labelVelocidadeMinimaValue.AutoSize = true;
            this.labelVelocidadeMinimaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelVelocidadeMinimaValue.Location = new System.Drawing.Point(60, 268);
            this.labelVelocidadeMinimaValue.Name = "labelVelocidadeMinimaValue";
            this.labelVelocidadeMinimaValue.Size = new System.Drawing.Size(13, 13);
            this.labelVelocidadeMinimaValue.TabIndex = 6;
            this.labelVelocidadeMinimaValue.Text = "_";
            // 
            // labelVelocidadeMaximaValue
            // 
            this.labelVelocidadeMaximaValue.AutoSize = true;
            this.labelVelocidadeMaximaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelVelocidadeMaximaValue.Location = new System.Drawing.Point(60, 236);
            this.labelVelocidadeMaximaValue.Name = "labelVelocidadeMaximaValue";
            this.labelVelocidadeMaximaValue.Size = new System.Drawing.Size(13, 13);
            this.labelVelocidadeMaximaValue.TabIndex = 5;
            this.labelVelocidadeMaximaValue.Text = "_";
            // 
            // labelVelocidadeMediaValue
            // 
            this.labelVelocidadeMediaValue.AutoSize = true;
            this.labelVelocidadeMediaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelVelocidadeMediaValue.Location = new System.Drawing.Point(60, 201);
            this.labelVelocidadeMediaValue.Name = "labelVelocidadeMediaValue";
            this.labelVelocidadeMediaValue.Size = new System.Drawing.Size(13, 13);
            this.labelVelocidadeMediaValue.TabIndex = 4;
            this.labelVelocidadeMediaValue.Text = "_";
            // 
            // labelVelocidadeAtual
            // 
            this.labelVelocidadeAtual.AutoSize = true;
            this.labelVelocidadeAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVelocidadeAtual.Location = new System.Drawing.Point(35, 52);
            this.labelVelocidadeAtual.Name = "labelVelocidadeAtual";
            this.labelVelocidadeAtual.Size = new System.Drawing.Size(32, 36);
            this.labelVelocidadeAtual.TabIndex = 1;
            this.labelVelocidadeAtual.Text = "_";
            // 
            // labelVelocidadeMinimaText
            // 
            this.labelVelocidadeMinimaText.AutoSize = true;
            this.labelVelocidadeMinimaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelVelocidadeMinimaText.Location = new System.Drawing.Point(15, 268);
            this.labelVelocidadeMinimaText.Name = "labelVelocidadeMinimaText";
            this.labelVelocidadeMinimaText.Size = new System.Drawing.Size(45, 13);
            this.labelVelocidadeMinimaText.TabIndex = 3;
            this.labelVelocidadeMinimaText.Text = "Mínima:";
            // 
            // labelVelocidadeMaximaText
            // 
            this.labelVelocidadeMaximaText.AutoSize = true;
            this.labelVelocidadeMaximaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelVelocidadeMaximaText.Location = new System.Drawing.Point(15, 236);
            this.labelVelocidadeMaximaText.Name = "labelVelocidadeMaximaText";
            this.labelVelocidadeMaximaText.Size = new System.Drawing.Size(46, 13);
            this.labelVelocidadeMaximaText.TabIndex = 2;
            this.labelVelocidadeMaximaText.Text = "Máxima:";
            // 
            // labelVelocidadeMediaText
            // 
            this.labelVelocidadeMediaText.AutoSize = true;
            this.labelVelocidadeMediaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelVelocidadeMediaText.Location = new System.Drawing.Point(15, 201);
            this.labelVelocidadeMediaText.Name = "labelVelocidadeMediaText";
            this.labelVelocidadeMediaText.Size = new System.Drawing.Size(39, 13);
            this.labelVelocidadeMediaText.TabIndex = 1;
            this.labelVelocidadeMediaText.Text = "Média:";
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.buttonClearDisplayInfo);
            this.groupBoxConfig.Controls.Add(this.buttonDesconectar);
            this.groupBoxConfig.Controls.Add(this.buttonUpdatePorts);
            this.groupBoxConfig.Controls.Add(this.buttonConectar);
            this.groupBoxConfig.Controls.Add(this.labelSelectBaudRate);
            this.groupBoxConfig.Controls.Add(this.labelSelectPortaCom);
            this.groupBoxConfig.Controls.Add(this.comboBoxSelectBaudRate);
            this.groupBoxConfig.Controls.Add(this.comboBoxSelectPortaCom);
            this.groupBoxConfig.Location = new System.Drawing.Point(12, 12);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Size = new System.Drawing.Size(874, 98);
            this.groupBoxConfig.TabIndex = 4;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Configuração de Conexão";
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
            // groupBoxDistanciaTraseira
            // 
            this.groupBoxDistanciaTraseira.Controls.Add(this.labelDistanciaTraseira);
            this.groupBoxDistanciaTraseira.Location = new System.Drawing.Point(403, 284);
            this.groupBoxDistanciaTraseira.Name = "groupBoxDistanciaTraseira";
            this.groupBoxDistanciaTraseira.Size = new System.Drawing.Size(239, 145);
            this.groupBoxDistanciaTraseira.TabIndex = 3;
            this.groupBoxDistanciaTraseira.TabStop = false;
            this.groupBoxDistanciaTraseira.Text = "Distância traseira";
            // 
            // labelDistanciaTraseira
            // 
            this.labelDistanciaTraseira.AutoSize = true;
            this.labelDistanciaTraseira.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanciaTraseira.Location = new System.Drawing.Point(48, 64);
            this.labelDistanciaTraseira.Name = "labelDistanciaTraseira";
            this.labelDistanciaTraseira.Size = new System.Drawing.Size(32, 36);
            this.labelDistanciaTraseira.TabIndex = 0;
            this.labelDistanciaTraseira.Text = "_";
            // 
            // FormDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 585);
            this.Controls.Add(this.groupBoxDistanciaTraseira);
            this.Controls.Add(this.groupBoxConfig);
            this.Controls.Add(this.groupBoxVelocidade);
            this.Controls.Add(this.groupBoxDistanciaDianteira);
            this.Controls.Add(this.textBoxDisplayInfo);
            this.Controls.Add(this.groupBoxMove);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(920, 624);
            this.MinimumSize = new System.Drawing.Size(920, 624);
            this.Name = "FormDefault";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Supervisório";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDefault_FormClosed);
            this.groupBoxMove.ResumeLayout(false);
            this.groupBoxMove.PerformLayout();
            this.groupBoxDistanciaDianteira.ResumeLayout(false);
            this.groupBoxDistanciaDianteira.PerformLayout();
            this.groupBoxVelocidade.ResumeLayout(false);
            this.groupBoxVelocidade.PerformLayout();
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBoxDistanciaTraseira.ResumeLayout(false);
            this.groupBoxDistanciaTraseira.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxDistanciaDianteira;
        private System.Windows.Forms.GroupBox groupBoxVelocidade;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonUpdatePorts;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label labelSelectBaudRate;
        private System.Windows.Forms.Label labelSelectPortaCom;
        private System.Windows.Forms.ComboBox comboBoxSelectBaudRate;
        private System.Windows.Forms.ComboBox comboBoxSelectPortaCom;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Button buttonClearDisplayInfo;
        private System.Windows.Forms.Label labelDistanciaDianteira;
        private System.Windows.Forms.GroupBox groupBoxDistanciaTraseira;
        private System.Windows.Forms.Label labelDistanciaTraseira;
        private System.Windows.Forms.Label labelVelocidadeMinimaValue;
        private System.Windows.Forms.Label labelVelocidadeMaximaValue;
        private System.Windows.Forms.Label labelVelocidadeMediaValue;
        private System.Windows.Forms.Label labelVelocidadeAtual;
        private System.Windows.Forms.Label labelVelocidadeMinimaText;
        private System.Windows.Forms.Label labelVelocidadeMaximaText;
        private System.Windows.Forms.Label labelVelocidadeMediaText;
        private System.Windows.Forms.Button buttonBreakAll;
    }
}

