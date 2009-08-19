namespace SimNav
{
    partial class ConfiguraPuertoSerialDialog
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
            this.groupBox_datosConeccion = new System.Windows.Forms.GroupBox();
            this.comboBox_ptoComunicaciones = new System.Windows.Forms.ComboBox();
            this.comboBox_bitParada = new System.Windows.Forms.ComboBox();
            this.comboBox_paridad = new System.Windows.Forms.ComboBox();
            this.comboBox_bitsDatos = new System.Windows.Forms.ComboBox();
            this.comboBox_velocidadPuerto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox_tiempo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_aceptarConfigPuertoSerial = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button_cancelarConfiguracionPuerto = new System.Windows.Forms.Button();
            this.groupBox_datosConeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_datosConeccion
            // 
            this.groupBox_datosConeccion.Controls.Add(this.comboBox_ptoComunicaciones);
            this.groupBox_datosConeccion.Controls.Add(this.comboBox_bitParada);
            this.groupBox_datosConeccion.Controls.Add(this.comboBox_paridad);
            this.groupBox_datosConeccion.Controls.Add(this.comboBox_bitsDatos);
            this.groupBox_datosConeccion.Controls.Add(this.comboBox_velocidadPuerto);
            this.groupBox_datosConeccion.Controls.Add(this.label6);
            this.groupBox_datosConeccion.Controls.Add(this.label5);
            this.groupBox_datosConeccion.Controls.Add(this.label4);
            this.groupBox_datosConeccion.Controls.Add(this.label3);
            this.groupBox_datosConeccion.Controls.Add(this.label2);
            this.groupBox_datosConeccion.Location = new System.Drawing.Point(7, 29);
            this.groupBox_datosConeccion.Name = "groupBox_datosConeccion";
            this.groupBox_datosConeccion.Size = new System.Drawing.Size(300, 207);
            this.groupBox_datosConeccion.TabIndex = 3;
            this.groupBox_datosConeccion.TabStop = false;
            this.groupBox_datosConeccion.Text = "Datos de Conexión";
            // 
            // comboBox_ptoComunicaciones
            // 
            this.comboBox_ptoComunicaciones.FormattingEnabled = true;
            this.comboBox_ptoComunicaciones.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBox_ptoComunicaciones.Location = new System.Drawing.Point(144, 25);
            this.comboBox_ptoComunicaciones.Name = "comboBox_ptoComunicaciones";
            this.comboBox_ptoComunicaciones.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ptoComunicaciones.TabIndex = 11;
            this.comboBox_ptoComunicaciones.Text = "Puertos Disponibles";
            // 
            // comboBox_bitParada
            // 
            this.comboBox_bitParada.FormattingEnabled = true;
            this.comboBox_bitParada.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "Ninguno"});
            this.comboBox_bitParada.Location = new System.Drawing.Point(144, 138);
            this.comboBox_bitParada.Name = "comboBox_bitParada";
            this.comboBox_bitParada.Size = new System.Drawing.Size(121, 21);
            this.comboBox_bitParada.TabIndex = 10;
            this.comboBox_bitParada.Text = "1";
            // 
            // comboBox_paridad
            // 
            this.comboBox_paridad.FormattingEnabled = true;
            this.comboBox_paridad.Items.AddRange(new object[] {
            "Par",
            "Impar",
            "Ninguno",
            "Marca",
            "Espacio"});
            this.comboBox_paridad.Location = new System.Drawing.Point(144, 110);
            this.comboBox_paridad.Name = "comboBox_paridad";
            this.comboBox_paridad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_paridad.TabIndex = 9;
            this.comboBox_paridad.Text = "Ninguno";
            // 
            // comboBox_bitsDatos
            // 
            this.comboBox_bitsDatos.FormattingEnabled = true;
            this.comboBox_bitsDatos.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_bitsDatos.Location = new System.Drawing.Point(144, 82);
            this.comboBox_bitsDatos.Name = "comboBox_bitsDatos";
            this.comboBox_bitsDatos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_bitsDatos.TabIndex = 8;
            this.comboBox_bitsDatos.Text = "8";
            // 
            // comboBox_velocidadPuerto
            // 
            this.comboBox_velocidadPuerto.FormattingEnabled = true;
            this.comboBox_velocidadPuerto.Items.AddRange(new object[] {
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "115200"});
            this.comboBox_velocidadPuerto.Location = new System.Drawing.Point(144, 52);
            this.comboBox_velocidadPuerto.Name = "comboBox_velocidadPuerto";
            this.comboBox_velocidadPuerto.Size = new System.Drawing.Size(121, 21);
            this.comboBox_velocidadPuerto.TabIndex = 7;
            this.comboBox_velocidadPuerto.Text = "4800";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Puerto Comunicaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bit de Parada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Paridad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bit de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bits por Segundo";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(210, 247);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 13);
            this.label31.TabIndex = 13;
            this.label31.Text = "ms";
            // 
            // comboBox_tiempo
            // 
            this.comboBox_tiempo.FormattingEnabled = true;
            this.comboBox_tiempo.Items.AddRange(new object[] {
            "100",
            "500",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000"});
            this.comboBox_tiempo.Location = new System.Drawing.Point(151, 242);
            this.comboBox_tiempo.Name = "comboBox_tiempo";
            this.comboBox_tiempo.Size = new System.Drawing.Size(56, 21);
            this.comboBox_tiempo.TabIndex = 12;
            this.comboBox_tiempo.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tiempo de Transmisión";
            // 
            // button_aceptarConfigPuertoSerial
            // 
            this.button_aceptarConfigPuertoSerial.Location = new System.Drawing.Point(171, 286);
            this.button_aceptarConfigPuertoSerial.Name = "button_aceptarConfigPuertoSerial";
            this.button_aceptarConfigPuertoSerial.Size = new System.Drawing.Size(126, 38);
            this.button_aceptarConfigPuertoSerial.TabIndex = 14;
            this.button_aceptarConfigPuertoSerial.Text = "Aceptar Configuración";
            this.button_aceptarConfigPuertoSerial.UseVisualStyleBackColor = true;
            this.button_aceptarConfigPuertoSerial.Click += new System.EventHandler(this.button_aceptarConfigPuertoSerial_Click);
            // 
            // button_cancelarConfiguracionPuerto
            // 
            this.button_cancelarConfiguracionPuerto.Location = new System.Drawing.Point(16, 286);
            this.button_cancelarConfiguracionPuerto.Name = "button_cancelarConfiguracionPuerto";
            this.button_cancelarConfiguracionPuerto.Size = new System.Drawing.Size(126, 38);
            this.button_cancelarConfiguracionPuerto.TabIndex = 15;
            this.button_cancelarConfiguracionPuerto.Text = "Cancelar";
            this.button_cancelarConfiguracionPuerto.UseVisualStyleBackColor = true;
            this.button_cancelarConfiguracionPuerto.Click += new System.EventHandler(this.button_cancelarConfiguracionPuerto_Click);
            // 
            // ConfiguraPuertoSerialDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 336);
            this.Controls.Add(this.button_cancelarConfiguracionPuerto);
            this.Controls.Add(this.button_aceptarConfigPuertoSerial);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.groupBox_datosConeccion);
            this.Controls.Add(this.comboBox_tiempo);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguraPuertoSerialDialog";
            this.Text = "Configuración del Puerto Serial";
            this.Load += new System.EventHandler(this.ConfiguraPuertoSerialDialog_Load);
            this.groupBox_datosConeccion.ResumeLayout(false);
            this.groupBox_datosConeccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_datosConeccion;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_aceptarConfigPuertoSerial;
        private System.IO.Ports.SerialPort serialPort;
        public System.Windows.Forms.ComboBox comboBox_tiempo;
        public System.Windows.Forms.ComboBox comboBox_ptoComunicaciones;
        public System.Windows.Forms.ComboBox comboBox_bitParada;
        public System.Windows.Forms.ComboBox comboBox_paridad;
        public System.Windows.Forms.ComboBox comboBox_bitsDatos;
        public System.Windows.Forms.ComboBox comboBox_velocidadPuerto;
        private System.Windows.Forms.Button button_cancelarConfiguracionPuerto;
    }
}