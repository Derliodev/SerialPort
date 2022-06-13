
namespace Project_SerialPort
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBaudRate = new System.Windows.Forms.ComboBox();
            this.LblBaudRate = new System.Windows.Forms.Label();
            this.LblDatosIngreso = new System.Windows.Forms.Label();
            this.txtEnviarDatos = new System.Windows.Forms.TextBox();
            this.txtDatosRecibidos = new System.Windows.Forms.TextBox();
            this.spPuertos = new System.IO.Ports.SerialPort(this.components);
            this.lblDatosEnviados = new System.Windows.Forms.Label();
            this.cboDataBits = new System.Windows.Forms.ComboBox();
            this.cboStopBits = new System.Windows.Forms.ComboBox();
            this.cboParityB = new System.Windows.Forms.ComboBox();
            this.lblDataBits = new System.Windows.Forms.Label();
            this.lblStopBits = new System.Windows.Forms.Label();
            this.lblParityB = new System.Windows.Forms.Label();
            this.gBxAccesPoint = new System.Windows.Forms.GroupBox();
            this.chBxAccesPoint = new System.Windows.Forms.CheckBox();
            this.cbxServTCP = new System.Windows.Forms.ComboBox();
            this.cbxTipoConx = new System.Windows.Forms.ComboBox();
            this.cbxModos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModos = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.PUERTO = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gBxAccesPoint.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(22, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar Puertos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.Orange;
            this.BtnConectar.Location = new System.Drawing.Point(22, 217);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(196, 32);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.BackColor = System.Drawing.Color.Orange;
            this.BtnEnviarDatos.Location = new System.Drawing.Point(61, 66);
            this.BtnEnviarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(178, 23);
            this.BtnEnviarDatos.TabIndex = 2;
            this.BtnEnviarDatos.Text = "Enviar Datos";
            this.BtnEnviarDatos.UseVisualStyleBackColor = false;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(84, 27);
            this.CboPuertos.Margin = new System.Windows.Forms.Padding(2);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(134, 21);
            this.CboPuertos.TabIndex = 3;
            // 
            // CboBaudRate
            // 
            this.CboBaudRate.FormattingEnabled = true;
            this.CboBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBaudRate.Location = new System.Drawing.Point(87, 106);
            this.CboBaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.CboBaudRate.Name = "CboBaudRate";
            this.CboBaudRate.Size = new System.Drawing.Size(132, 21);
            this.CboBaudRate.TabIndex = 4;
            this.CboBaudRate.Text = "115200";
            // 
            // LblBaudRate
            // 
            this.LblBaudRate.AutoSize = true;
            this.LblBaudRate.Location = new System.Drawing.Point(19, 109);
            this.LblBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblBaudRate.Name = "LblBaudRate";
            this.LblBaudRate.Size = new System.Drawing.Size(58, 13);
            this.LblBaudRate.TabIndex = 5;
            this.LblBaudRate.Text = "Baud Rate";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.Location = new System.Drawing.Point(278, 35);
            this.LblDatosIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(85, 13);
            this.LblDatosIngreso.TabIndex = 6;
            this.LblDatosIngreso.Text = "Datos Recibidos";
            // 
            // txtEnviarDatos
            // 
            this.txtEnviarDatos.Location = new System.Drawing.Point(61, 29);
            this.txtEnviarDatos.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnviarDatos.Multiline = true;
            this.txtEnviarDatos.Name = "txtEnviarDatos";
            this.txtEnviarDatos.Size = new System.Drawing.Size(178, 28);
            this.txtEnviarDatos.TabIndex = 7;
            // 
            // txtDatosRecibidos
            // 
            this.txtDatosRecibidos.Location = new System.Drawing.Point(377, 29);
            this.txtDatosRecibidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatosRecibidos.Multiline = true;
            this.txtDatosRecibidos.Name = "txtDatosRecibidos";
            this.txtDatosRecibidos.Size = new System.Drawing.Size(260, 120);
            this.txtDatosRecibidos.TabIndex = 8;
            // 
            // spPuertos
            // 
            this.spPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // lblDatosEnviados
            // 
            this.lblDatosEnviados.AutoSize = true;
            this.lblDatosEnviados.Location = new System.Drawing.Point(20, 35);
            this.lblDatosEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosEnviados.Name = "lblDatosEnviados";
            this.lblDatosEnviados.Size = new System.Drawing.Size(37, 13);
            this.lblDatosEnviados.TabIndex = 9;
            this.lblDatosEnviados.Text = "Enviar";
            // 
            // cboDataBits
            // 
            this.cboDataBits.FormattingEnabled = true;
            this.cboDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cboDataBits.Location = new System.Drawing.Point(87, 132);
            this.cboDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboDataBits.Name = "cboDataBits";
            this.cboDataBits.Size = new System.Drawing.Size(132, 21);
            this.cboDataBits.TabIndex = 10;
            this.cboDataBits.Text = "8";
            // 
            // cboStopBits
            // 
            this.cboStopBits.FormattingEnabled = true;
            this.cboStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboStopBits.Location = new System.Drawing.Point(87, 158);
            this.cboStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Size = new System.Drawing.Size(132, 21);
            this.cboStopBits.TabIndex = 11;
            this.cboStopBits.Text = "1";
            // 
            // cboParityB
            // 
            this.cboParityB.FormattingEnabled = true;
            this.cboParityB.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cboParityB.Location = new System.Drawing.Point(87, 184);
            this.cboParityB.Margin = new System.Windows.Forms.Padding(2);
            this.cboParityB.Name = "cboParityB";
            this.cboParityB.Size = new System.Drawing.Size(132, 21);
            this.cboParityB.TabIndex = 12;
            this.cboParityB.Text = "None";
            // 
            // lblDataBits
            // 
            this.lblDataBits.AutoSize = true;
            this.lblDataBits.Location = new System.Drawing.Point(19, 135);
            this.lblDataBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataBits.Name = "lblDataBits";
            this.lblDataBits.Size = new System.Drawing.Size(50, 13);
            this.lblDataBits.TabIndex = 13;
            this.lblDataBits.Text = "Data Bits";
            // 
            // lblStopBits
            // 
            this.lblStopBits.AutoSize = true;
            this.lblStopBits.Location = new System.Drawing.Point(19, 161);
            this.lblStopBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStopBits.Name = "lblStopBits";
            this.lblStopBits.Size = new System.Drawing.Size(49, 13);
            this.lblStopBits.TabIndex = 14;
            this.lblStopBits.Text = "Stop Bits";
            // 
            // lblParityB
            // 
            this.lblParityB.AutoSize = true;
            this.lblParityB.Location = new System.Drawing.Point(19, 187);
            this.lblParityB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParityB.Name = "lblParityB";
            this.lblParityB.Size = new System.Drawing.Size(53, 13);
            this.lblParityB.TabIndex = 15;
            this.lblParityB.Text = "Parity Bits";
            // 
            // gBxAccesPoint
            // 
            this.gBxAccesPoint.BackColor = System.Drawing.Color.LightBlue;
            this.gBxAccesPoint.Controls.Add(this.chBxAccesPoint);
            this.gBxAccesPoint.Controls.Add(this.cbxServTCP);
            this.gBxAccesPoint.Controls.Add(this.cbxTipoConx);
            this.gBxAccesPoint.Controls.Add(this.cbxModos);
            this.gBxAccesPoint.Controls.Add(this.label3);
            this.gBxAccesPoint.Controls.Add(this.label2);
            this.gBxAccesPoint.Controls.Add(this.lblModos);
            this.gBxAccesPoint.Location = new System.Drawing.Point(305, 18);
            this.gBxAccesPoint.Margin = new System.Windows.Forms.Padding(2);
            this.gBxAccesPoint.Name = "gBxAccesPoint";
            this.gBxAccesPoint.Padding = new System.Windows.Forms.Padding(2);
            this.gBxAccesPoint.Size = new System.Drawing.Size(369, 264);
            this.gBxAccesPoint.TabIndex = 16;
            this.gBxAccesPoint.TabStop = false;
            this.gBxAccesPoint.Text = "Configuración Como Acces Point";
            this.gBxAccesPoint.Enter += new System.EventHandler(this.gBxAccesPoint_Enter);
            // 
            // chBxAccesPoint
            // 
            this.chBxAccesPoint.AutoSize = true;
            this.chBxAccesPoint.Location = new System.Drawing.Point(172, 0);
            this.chBxAccesPoint.Margin = new System.Windows.Forms.Padding(2);
            this.chBxAccesPoint.Name = "chBxAccesPoint";
            this.chBxAccesPoint.Size = new System.Drawing.Size(15, 14);
            this.chBxAccesPoint.TabIndex = 6;
            this.chBxAccesPoint.UseVisualStyleBackColor = true;
            this.chBxAccesPoint.CheckedChanged += new System.EventHandler(this.chBxAccesPoint_CheckedChanged);
            // 
            // cbxServTCP
            // 
            this.cbxServTCP.FormattingEnabled = true;
            this.cbxServTCP.Items.AddRange(new object[] {
            "AT+CIPSERVER=0",
            "AT+CIPSERVER=1,80"});
            this.cbxServTCP.Location = new System.Drawing.Point(183, 89);
            this.cbxServTCP.Margin = new System.Windows.Forms.Padding(2);
            this.cbxServTCP.Name = "cbxServTCP";
            this.cbxServTCP.Size = new System.Drawing.Size(152, 21);
            this.cbxServTCP.TabIndex = 5;
            this.cbxServTCP.Text = "AT+CIPSERVER=1,80";
            this.cbxServTCP.SelectedIndexChanged += new System.EventHandler(this.cbxServTCP_SelectedIndexChanged);
            // 
            // cbxTipoConx
            // 
            this.cbxTipoConx.FormattingEnabled = true;
            this.cbxTipoConx.Items.AddRange(new object[] {
            "AT+CIPMUX=?",
            "AT+CIPMUX=1",
            "AT+CIPMUX=2"});
            this.cbxTipoConx.Location = new System.Drawing.Point(183, 62);
            this.cbxTipoConx.Margin = new System.Windows.Forms.Padding(2);
            this.cbxTipoConx.Name = "cbxTipoConx";
            this.cbxTipoConx.Size = new System.Drawing.Size(152, 21);
            this.cbxTipoConx.TabIndex = 4;
            this.cbxTipoConx.Text = "AT+CIPMUX=1";
            this.cbxTipoConx.SelectedIndexChanged += new System.EventHandler(this.cbxTipoConx_SelectedIndexChanged);
            // 
            // cbxModos
            // 
            this.cbxModos.FormattingEnabled = true;
            this.cbxModos.Items.AddRange(new object[] {
            "AT+CWMODE=?",
            "AT+CWMODE=1",
            "AT+CWMODE=2"});
            this.cbxModos.Location = new System.Drawing.Point(183, 31);
            this.cbxModos.Margin = new System.Windows.Forms.Padding(2);
            this.cbxModos.Name = "cbxModos";
            this.cbxModos.Size = new System.Drawing.Size(152, 21);
            this.cbxModos.TabIndex = 3;
            this.cbxModos.Text = "AT+CWMODE=2";
            this.cbxModos.SelectedIndexChanged += new System.EventHandler(this.cbxModos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione tipo conexion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Habilitacion Servicio TCP";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblModos
            // 
            this.lblModos.AutoSize = true;
            this.lblModos.Location = new System.Drawing.Point(20, 34);
            this.lblModos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModos.Name = "lblModos";
            this.lblModos.Size = new System.Drawing.Size(96, 13);
            this.lblModos.TabIndex = 0;
            this.lblModos.Text = "Modos Disponibles";
            this.lblModos.Click += new System.EventHandler(this.lblModos_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(377, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PUERTO
            // 
            this.PUERTO.AutoSize = true;
            this.PUERTO.Location = new System.Drawing.Point(19, 30);
            this.PUERTO.Name = "PUERTO";
            this.PUERTO.Size = new System.Drawing.Size(52, 13);
            this.PUERTO.TabIndex = 18;
            this.PUERTO.Text = "PUERTO";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.PUERTO);
            this.groupBox1.Controls.Add(this.CboPuertos);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblParityB);
            this.groupBox1.Controls.Add(this.BtnConectar);
            this.groupBox1.Controls.Add(this.lblStopBits);
            this.groupBox1.Controls.Add(this.CboBaudRate);
            this.groupBox1.Controls.Add(this.lblDataBits);
            this.groupBox1.Controls.Add(this.LblBaudRate);
            this.groupBox1.Controls.Add(this.cboParityB);
            this.groupBox1.Controls.Add(this.cboDataBits);
            this.groupBox1.Controls.Add(this.cboStopBits);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(259, 264);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexion de Puerto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.txtDatosRecibidos);
            this.groupBox2.Controls.Add(this.BtnEnviarDatos);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.LblDatosIngreso);
            this.groupBox2.Controls.Add(this.txtEnviarDatos);
            this.groupBox2.Controls.Add(this.lblDatosEnviados);
            this.groupBox2.Location = new System.Drawing.Point(24, 303);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(650, 205);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Desarrollado por Leonardo Rios C.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(703, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBxAccesPoint);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBxAccesPoint.ResumeLayout(false);
            this.gBxAccesPoint.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBaudRate;
        private System.Windows.Forms.Label LblBaudRate;
        private System.Windows.Forms.Label LblDatosIngreso;
        private System.Windows.Forms.TextBox txtEnviarDatos;
        private System.Windows.Forms.TextBox txtDatosRecibidos;
        private System.IO.Ports.SerialPort spPuertos;
        private System.Windows.Forms.Label lblDatosEnviados;
        private System.Windows.Forms.ComboBox cboDataBits;
        private System.Windows.Forms.ComboBox cboStopBits;
        private System.Windows.Forms.ComboBox cboParityB;
        private System.Windows.Forms.Label lblDataBits;
        private System.Windows.Forms.Label lblStopBits;
        private System.Windows.Forms.Label lblParityB;
        private System.Windows.Forms.GroupBox gBxAccesPoint;
        private System.Windows.Forms.CheckBox chBxAccesPoint;
        private System.Windows.Forms.ComboBox cbxServTCP;
        private System.Windows.Forms.ComboBox cbxTipoConx;
        private System.Windows.Forms.ComboBox cbxModos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PUERTO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}

