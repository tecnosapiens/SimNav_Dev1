namespace SimNav
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl_controles = new System.Windows.Forms.TabControl();
            this.tabPage_configuracion = new System.Windows.Forms.TabPage();
            this.groupBox_estadoConexion = new System.Windows.Forms.GroupBox();
            this.label_puertoCom = new System.Windows.Forms.Label();
            this.label_bitParada = new System.Windows.Forms.Label();
            this.label_paridad = new System.Windows.Forms.Label();
            this.label_bitDatos = new System.Windows.Forms.Label();
            this.label_velocidadTransmicion = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_datosConfigurados = new System.Windows.Forms.GroupBox();
            this.groupBox_controlBuque = new System.Windows.Forms.GroupBox();
            this.checkBox_verTrayectoria = new System.Windows.Forms.CheckBox();
            this.numericUpDown_anguloTimon = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_velocidadBuque = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox_datosNavegacion = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_millasNavegadas = new System.Windows.Forms.Label();
            this.label_tiempoNavegado = new System.Windows.Forms.Label();
            this.checkBox_navegacionBuque = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label_velViento = new System.Windows.Forms.Label();
            this.label_dirViento = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_profundidad = new System.Windows.Forms.Label();
            this.label_velocidad = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label_rumbo = new System.Windows.Forms.Label();
            this.label_longitud = new System.Windows.Forms.Label();
            this.label_latitud = new System.Windows.Forms.Label();
            this.button_configurarDatosBuque = new System.Windows.Forms.Button();
            this.tabPage_sensores = new System.Windows.Forms.TabPage();
            this.groupBox_panelSensores = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_GPSBluetooth = new System.Windows.Forms.Button();
            this.checkBox_gpsPropio = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_AIS = new System.Windows.Forms.Button();
            this.checkBox_estadoAIS = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_CORREDERA = new System.Windows.Forms.Button();
            this.checkBox_estadoCorredera = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_ANEMOMETRO = new System.Windows.Forms.Button();
            this.checkBox_estadoAnemometro = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_ECOSONDA = new System.Windows.Forms.Button();
            this.checkBox_estadoEcosonda = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_GYRO = new System.Windows.Forms.Button();
            this.checkBox_estadoGyro = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_DGPS = new System.Windows.Forms.Button();
            this.checkBox_estadoDGPS = new System.Windows.Forms.CheckBox();
            this.groupBox_GPS = new System.Windows.Forms.GroupBox();
            this.button_configPuertoSerial_GPS = new System.Windows.Forms.Button();
            this.checkBox_estadoGPS = new System.Windows.Forms.CheckBox();
            this.tabPage_reproducción = new System.Windows.Forms.TabPage();
            this.groupBox_reproduccion = new System.Windows.Forms.GroupBox();
            this.checkBox_Loop = new System.Windows.Forms.CheckBox();
            this.button_seleccionArchivo = new System.Windows.Forms.Button();
            this.label_nombreArchivo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_detener = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            this.button_transmitir = new System.Windows.Forms.Button();
            this.button_configurarPuerto = new System.Windows.Forms.Button();
            this.listBox_visorDatosNmea = new System.Windows.Forms.ListBox();
            this.groupBox_pantallaTramasNMEA = new System.Windows.Forms.GroupBox();
            this.openFileDialog_seleccionArchivo = new System.Windows.Forms.OpenFileDialog();
            this.checkBox_ocultarPanelTramasNMEA = new System.Windows.Forms.CheckBox();
            this.tabPage_estadoConexion = new System.Windows.Forms.TabPage();
            this.tabControl_controles.SuspendLayout();
            this.tabPage_configuracion.SuspendLayout();
            this.groupBox_estadoConexion.SuspendLayout();
            this.groupBox_datosConfigurados.SuspendLayout();
            this.groupBox_controlBuque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_anguloTimon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_velocidadBuque)).BeginInit();
            this.groupBox_datosNavegacion.SuspendLayout();
            this.tabPage_sensores.SuspendLayout();
            this.groupBox_panelSensores.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_GPS.SuspendLayout();
            this.tabPage_reproducción.SuspendLayout();
            this.groupBox_reproduccion.SuspendLayout();
            this.groupBox_pantallaTramasNMEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_controles
            // 
            this.tabControl_controles.Controls.Add(this.tabPage_configuracion);
            this.tabControl_controles.Controls.Add(this.tabPage_sensores);
            this.tabControl_controles.Controls.Add(this.tabPage_estadoConexion);
            this.tabControl_controles.Controls.Add(this.tabPage_reproducción);
            this.tabControl_controles.Location = new System.Drawing.Point(13, 9);
            this.tabControl_controles.Multiline = true;
            this.tabControl_controles.Name = "tabControl_controles";
            this.tabControl_controles.SelectedIndex = 0;
            this.tabControl_controles.Size = new System.Drawing.Size(351, 830);
            this.tabControl_controles.TabIndex = 0;
            // 
            // tabPage_configuracion
            // 
            this.tabPage_configuracion.Controls.Add(this.groupBox_estadoConexion);
            this.tabPage_configuracion.Controls.Add(this.label1);
            this.tabPage_configuracion.Controls.Add(this.groupBox_datosConfigurados);
            this.tabPage_configuracion.Controls.Add(this.button_configurarDatosBuque);
            this.tabPage_configuracion.Location = new System.Drawing.Point(4, 22);
            this.tabPage_configuracion.Name = "tabPage_configuracion";
            this.tabPage_configuracion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_configuracion.Size = new System.Drawing.Size(343, 804);
            this.tabPage_configuracion.TabIndex = 0;
            this.tabPage_configuracion.Text = "Configuración";
            this.tabPage_configuracion.UseVisualStyleBackColor = true;
            // 
            // groupBox_estadoConexion
            // 
            this.groupBox_estadoConexion.Controls.Add(this.label_puertoCom);
            this.groupBox_estadoConexion.Controls.Add(this.label_bitParada);
            this.groupBox_estadoConexion.Controls.Add(this.label_paridad);
            this.groupBox_estadoConexion.Controls.Add(this.label_bitDatos);
            this.groupBox_estadoConexion.Controls.Add(this.label_velocidadTransmicion);
            this.groupBox_estadoConexion.Controls.Add(this.label37);
            this.groupBox_estadoConexion.Controls.Add(this.label36);
            this.groupBox_estadoConexion.Controls.Add(this.label35);
            this.groupBox_estadoConexion.Controls.Add(this.label23);
            this.groupBox_estadoConexion.Controls.Add(this.label19);
            this.groupBox_estadoConexion.Location = new System.Drawing.Point(18, 660);
            this.groupBox_estadoConexion.Name = "groupBox_estadoConexion";
            this.groupBox_estadoConexion.Size = new System.Drawing.Size(287, 100);
            this.groupBox_estadoConexion.TabIndex = 21;
            this.groupBox_estadoConexion.TabStop = false;
            this.groupBox_estadoConexion.Text = "Estado de Conexión";
            // 
            // label_puertoCom
            // 
            this.label_puertoCom.AutoSize = true;
            this.label_puertoCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puertoCom.ForeColor = System.Drawing.Color.Blue;
            this.label_puertoCom.Location = new System.Drawing.Point(65, 31);
            this.label_puertoCom.Name = "label_puertoCom";
            this.label_puertoCom.Size = new System.Drawing.Size(14, 13);
            this.label_puertoCom.TabIndex = 13;
            this.label_puertoCom.Text = "?";
            // 
            // label_bitParada
            // 
            this.label_bitParada.AutoSize = true;
            this.label_bitParada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bitParada.ForeColor = System.Drawing.Color.Blue;
            this.label_bitParada.Location = new System.Drawing.Point(204, 53);
            this.label_bitParada.Name = "label_bitParada";
            this.label_bitParada.Size = new System.Drawing.Size(14, 13);
            this.label_bitParada.TabIndex = 12;
            this.label_bitParada.Text = "?";
            // 
            // label_paridad
            // 
            this.label_paridad.AutoSize = true;
            this.label_paridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paridad.ForeColor = System.Drawing.Color.Blue;
            this.label_paridad.Location = new System.Drawing.Point(204, 29);
            this.label_paridad.Name = "label_paridad";
            this.label_paridad.Size = new System.Drawing.Size(14, 13);
            this.label_paridad.TabIndex = 7;
            this.label_paridad.Text = "?";
            // 
            // label_bitDatos
            // 
            this.label_bitDatos.AutoSize = true;
            this.label_bitDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bitDatos.ForeColor = System.Drawing.Color.Blue;
            this.label_bitDatos.Location = new System.Drawing.Point(65, 75);
            this.label_bitDatos.Name = "label_bitDatos";
            this.label_bitDatos.Size = new System.Drawing.Size(14, 13);
            this.label_bitDatos.TabIndex = 6;
            this.label_bitDatos.Text = "?";
            // 
            // label_velocidadTransmicion
            // 
            this.label_velocidadTransmicion.AutoSize = true;
            this.label_velocidadTransmicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_velocidadTransmicion.ForeColor = System.Drawing.Color.Blue;
            this.label_velocidadTransmicion.Location = new System.Drawing.Point(65, 53);
            this.label_velocidadTransmicion.Name = "label_velocidadTransmicion";
            this.label_velocidadTransmicion.Size = new System.Drawing.Size(14, 13);
            this.label_velocidadTransmicion.TabIndex = 5;
            this.label_velocidadTransmicion.Text = "?";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(6, 31);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(38, 13);
            this.label37.TabIndex = 4;
            this.label37.Text = "COM:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(145, 53);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(43, 13);
            this.label36.TabIndex = 3;
            this.label36.Text = "BSTP:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(145, 29);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(36, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "PAR:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(28, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "BD:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "BXS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Datos de Navegación del Buque Propio";
            // 
            // groupBox_datosConfigurados
            // 
            this.groupBox_datosConfigurados.Controls.Add(this.groupBox_controlBuque);
            this.groupBox_datosConfigurados.Controls.Add(this.groupBox_datosNavegacion);
            this.groupBox_datosConfigurados.Controls.Add(this.checkBox_navegacionBuque);
            this.groupBox_datosConfigurados.Controls.Add(this.label2);
            this.groupBox_datosConfigurados.Controls.Add(this.label43);
            this.groupBox_datosConfigurados.Controls.Add(this.label42);
            this.groupBox_datosConfigurados.Controls.Add(this.label41);
            this.groupBox_datosConfigurados.Controls.Add(this.label40);
            this.groupBox_datosConfigurados.Controls.Add(this.label39);
            this.groupBox_datosConfigurados.Controls.Add(this.label38);
            this.groupBox_datosConfigurados.Controls.Add(this.label34);
            this.groupBox_datosConfigurados.Controls.Add(this.label30);
            this.groupBox_datosConfigurados.Controls.Add(this.label33);
            this.groupBox_datosConfigurados.Controls.Add(this.label_velViento);
            this.groupBox_datosConfigurados.Controls.Add(this.label_dirViento);
            this.groupBox_datosConfigurados.Controls.Add(this.label29);
            this.groupBox_datosConfigurados.Controls.Add(this.label27);
            this.groupBox_datosConfigurados.Controls.Add(this.label_profundidad);
            this.groupBox_datosConfigurados.Controls.Add(this.label_velocidad);
            this.groupBox_datosConfigurados.Controls.Add(this.label28);
            this.groupBox_datosConfigurados.Controls.Add(this.label_rumbo);
            this.groupBox_datosConfigurados.Controls.Add(this.label_longitud);
            this.groupBox_datosConfigurados.Controls.Add(this.label_latitud);
            this.groupBox_datosConfigurados.Location = new System.Drawing.Point(14, 47);
            this.groupBox_datosConfigurados.Name = "groupBox_datosConfigurados";
            this.groupBox_datosConfigurados.Size = new System.Drawing.Size(300, 542);
            this.groupBox_datosConfigurados.TabIndex = 27;
            this.groupBox_datosConfigurados.TabStop = false;
            // 
            // groupBox_controlBuque
            // 
            this.groupBox_controlBuque.Controls.Add(this.checkBox_verTrayectoria);
            this.groupBox_controlBuque.Controls.Add(this.numericUpDown_anguloTimon);
            this.groupBox_controlBuque.Controls.Add(this.numericUpDown_velocidadBuque);
            this.groupBox_controlBuque.Controls.Add(this.label16);
            this.groupBox_controlBuque.Controls.Add(this.label15);
            this.groupBox_controlBuque.Controls.Add(this.label20);
            this.groupBox_controlBuque.Controls.Add(this.label21);
            this.groupBox_controlBuque.Enabled = false;
            this.groupBox_controlBuque.Location = new System.Drawing.Point(9, 434);
            this.groupBox_controlBuque.Name = "groupBox_controlBuque";
            this.groupBox_controlBuque.Size = new System.Drawing.Size(282, 102);
            this.groupBox_controlBuque.TabIndex = 36;
            this.groupBox_controlBuque.TabStop = false;
            this.groupBox_controlBuque.Text = "Control del Buque";
            // 
            // checkBox_verTrayectoria
            // 
            this.checkBox_verTrayectoria.AutoSize = true;
            this.checkBox_verTrayectoria.Checked = true;
            this.checkBox_verTrayectoria.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_verTrayectoria.Location = new System.Drawing.Point(19, 79);
            this.checkBox_verTrayectoria.Name = "checkBox_verTrayectoria";
            this.checkBox_verTrayectoria.Size = new System.Drawing.Size(98, 17);
            this.checkBox_verTrayectoria.TabIndex = 33;
            this.checkBox_verTrayectoria.Text = "Ver Trayectoria";
            this.checkBox_verTrayectoria.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_anguloTimon
            // 
            this.numericUpDown_anguloTimon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_anguloTimon.Location = new System.Drawing.Point(19, 40);
            this.numericUpDown_anguloTimon.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDown_anguloTimon.Minimum = new decimal(new int[] {
            35,
            0,
            0,
            -2147483648});
            this.numericUpDown_anguloTimon.Name = "numericUpDown_anguloTimon";
            this.numericUpDown_anguloTimon.Size = new System.Drawing.Size(55, 26);
            this.numericUpDown_anguloTimon.TabIndex = 30;
            this.numericUpDown_anguloTimon.ValueChanged += new System.EventHandler(this.numericUpDown_anguloTimon_ValueChanged);
            // 
            // numericUpDown_velocidadBuque
            // 
            this.numericUpDown_velocidadBuque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_velocidadBuque.Location = new System.Drawing.Point(184, 39);
            this.numericUpDown_velocidadBuque.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_velocidadBuque.Name = "numericUpDown_velocidadBuque";
            this.numericUpDown_velocidadBuque.Size = new System.Drawing.Size(47, 26);
            this.numericUpDown_velocidadBuque.TabIndex = 29;
            this.numericUpDown_velocidadBuque.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_velocidadBuque.ValueChanged += new System.EventHandler(this.numericUpDown_velocidadBuque_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(176, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Velocidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 27;
            this.label15.Text = "Timón";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(73, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 24);
            this.label20.TabIndex = 32;
            this.label20.Text = "°";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(230, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 18);
            this.label21.TabIndex = 31;
            this.label21.Text = "kn";
            // 
            // groupBox_datosNavegacion
            // 
            this.groupBox_datosNavegacion.Controls.Add(this.label3);
            this.groupBox_datosNavegacion.Controls.Add(this.label4);
            this.groupBox_datosNavegacion.Controls.Add(this.label5);
            this.groupBox_datosNavegacion.Controls.Add(this.label6);
            this.groupBox_datosNavegacion.Controls.Add(this.label_millasNavegadas);
            this.groupBox_datosNavegacion.Controls.Add(this.label_tiempoNavegado);
            this.groupBox_datosNavegacion.Location = new System.Drawing.Point(9, 257);
            this.groupBox_datosNavegacion.Name = "groupBox_datosNavegacion";
            this.groupBox_datosNavegacion.Size = new System.Drawing.Size(269, 96);
            this.groupBox_datosNavegacion.TabIndex = 35;
            this.groupBox_datosNavegacion.TabStop = false;
            this.groupBox_datosNavegacion.Text = "Datos de Navegación";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Vel. Viento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(10, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tiempo Navegación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(219, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Millas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(219, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Hrs.";
            // 
            // label_millasNavegadas
            // 
            this.label_millasNavegadas.AutoSize = true;
            this.label_millasNavegadas.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_millasNavegadas.ForeColor = System.Drawing.Color.Blue;
            this.label_millasNavegadas.Location = new System.Drawing.Point(145, 53);
            this.label_millasNavegadas.Name = "label_millasNavegadas";
            this.label_millasNavegadas.Size = new System.Drawing.Size(31, 19);
            this.label_millasNavegadas.TabIndex = 32;
            this.label_millasNavegadas.Text = "0.0";
            // 
            // label_tiempoNavegado
            // 
            this.label_tiempoNavegado.AutoSize = true;
            this.label_tiempoNavegado.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tiempoNavegado.ForeColor = System.Drawing.Color.Blue;
            this.label_tiempoNavegado.Location = new System.Drawing.Point(140, 19);
            this.label_tiempoNavegado.Name = "label_tiempoNavegado";
            this.label_tiempoNavegado.Size = new System.Drawing.Size(49, 19);
            this.label_tiempoNavegado.TabIndex = 31;
            this.label_tiempoNavegado.Text = "00:00";
            // 
            // checkBox_navegacionBuque
            // 
            this.checkBox_navegacionBuque.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_navegacionBuque.BackColor = System.Drawing.Color.Red;
            this.checkBox_navegacionBuque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_navegacionBuque.ForeColor = System.Drawing.Color.Black;
            this.checkBox_navegacionBuque.Location = new System.Drawing.Point(90, 378);
            this.checkBox_navegacionBuque.Name = "checkBox_navegacionBuque";
            this.checkBox_navegacionBuque.Size = new System.Drawing.Size(95, 36);
            this.checkBox_navegacionBuque.TabIndex = 33;
            this.checkBox_navegacionBuque.Text = "Desactivado";
            this.checkBox_navegacionBuque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_navegacionBuque.UseVisualStyleBackColor = false;
            this.checkBox_navegacionBuque.CheckedChanged += new System.EventHandler(this.checkBox_navegacionBuque_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Estado de Navegación del Buque";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label43.Location = new System.Drawing.Point(6, 232);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(73, 13);
            this.label43.TabIndex = 30;
            this.label43.Text = "Vel. Viento:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label42.Location = new System.Drawing.Point(6, 205);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 13);
            this.label42.TabIndex = 29;
            this.label42.Text = "Dir. Viento:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label41.Location = new System.Drawing.Point(6, 167);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(79, 13);
            this.label41.TabIndex = 28;
            this.label41.Text = "Profundidad:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label40.Location = new System.Drawing.Point(6, 134);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(83, 16);
            this.label40.TabIndex = 18;
            this.label40.Text = "Velocidad:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label39.Location = new System.Drawing.Point(6, 95);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(61, 16);
            this.label39.TabIndex = 17;
            this.label39.Text = "Rumbo:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label38.Location = new System.Drawing.Point(6, 57);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(71, 16);
            this.label38.TabIndex = 14;
            this.label38.Text = "Longitud:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(6, 23);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 16);
            this.label34.TabIndex = 13;
            this.label34.Text = "Latitud:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Blue;
            this.label30.Location = new System.Drawing.Point(154, 232);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(25, 16);
            this.label30.TabIndex = 12;
            this.label30.Text = "Kn";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Blue;
            this.label33.Location = new System.Drawing.Point(151, 203);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(23, 16);
            this.label33.TabIndex = 11;
            this.label33.Text = "[°]";
            // 
            // label_velViento
            // 
            this.label_velViento.AutoSize = true;
            this.label_velViento.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_velViento.ForeColor = System.Drawing.Color.Blue;
            this.label_velViento.Location = new System.Drawing.Point(94, 223);
            this.label_velViento.Name = "label_velViento";
            this.label_velViento.Size = new System.Drawing.Size(39, 29);
            this.label_velViento.TabIndex = 9;
            this.label_velViento.Text = "15";
            // 
            // label_dirViento
            // 
            this.label_dirViento.AutoSize = true;
            this.label_dirViento.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dirViento.ForeColor = System.Drawing.Color.Blue;
            this.label_dirViento.Location = new System.Drawing.Point(94, 194);
            this.label_dirViento.Name = "label_dirViento";
            this.label_dirViento.Size = new System.Drawing.Size(52, 29);
            this.label_dirViento.TabIndex = 8;
            this.label_dirViento.Text = "074";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Blue;
            this.label29.Location = new System.Drawing.Point(161, 169);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(32, 16);
            this.label29.TabIndex = 7;
            this.label29.Text = "mts";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Blue;
            this.label27.Location = new System.Drawing.Point(159, 134);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(25, 16);
            this.label27.TabIndex = 6;
            this.label27.Text = "Kn";
            // 
            // label_profundidad
            // 
            this.label_profundidad.AutoSize = true;
            this.label_profundidad.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profundidad.ForeColor = System.Drawing.Color.Blue;
            this.label_profundidad.Location = new System.Drawing.Point(92, 154);
            this.label_profundidad.Name = "label_profundidad";
            this.label_profundidad.Size = new System.Drawing.Size(68, 37);
            this.label_profundidad.TabIndex = 5;
            this.label_profundidad.Text = "225";
            // 
            // label_velocidad
            // 
            this.label_velocidad.AutoSize = true;
            this.label_velocidad.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_velocidad.ForeColor = System.Drawing.Color.Blue;
            this.label_velocidad.Location = new System.Drawing.Point(92, 119);
            this.label_velocidad.Name = "label_velocidad";
            this.label_velocidad.Size = new System.Drawing.Size(59, 37);
            this.label_velocidad.TabIndex = 4;
            this.label_velocidad.Text = "5.0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Blue;
            this.label28.Location = new System.Drawing.Point(225, 88);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(23, 16);
            this.label28.TabIndex = 3;
            this.label28.Text = "[°]";
            // 
            // label_rumbo
            // 
            this.label_rumbo.AutoSize = true;
            this.label_rumbo.Font = new System.Drawing.Font("Bell MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rumbo.ForeColor = System.Drawing.Color.Blue;
            this.label_rumbo.Location = new System.Drawing.Point(92, 82);
            this.label_rumbo.Name = "label_rumbo";
            this.label_rumbo.Size = new System.Drawing.Size(93, 37);
            this.label_rumbo.TabIndex = 2;
            this.label_rumbo.Text = "315.0";
            // 
            // label_longitud
            // 
            this.label_longitud.AutoSize = true;
            this.label_longitud.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_longitud.ForeColor = System.Drawing.Color.Blue;
            this.label_longitud.Location = new System.Drawing.Point(92, 51);
            this.label_longitud.Name = "label_longitud";
            this.label_longitud.Size = new System.Drawing.Size(200, 31);
            this.label_longitud.TabIndex = 1;
            this.label_longitud.Text = "072° 03´ 59´´ W";
            // 
            // label_latitud
            // 
            this.label_latitud.AutoSize = true;
            this.label_latitud.Font = new System.Drawing.Font("Bell MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_latitud.ForeColor = System.Drawing.Color.Blue;
            this.label_latitud.Location = new System.Drawing.Point(92, 13);
            this.label_latitud.Name = "label_latitud";
            this.label_latitud.Size = new System.Drawing.Size(186, 31);
            this.label_latitud.TabIndex = 0;
            this.label_latitud.Text = "023° 23´ 59´´ S";
            // 
            // button_configurarDatosBuque
            // 
            this.button_configurarDatosBuque.Location = new System.Drawing.Point(18, 595);
            this.button_configurarDatosBuque.Name = "button_configurarDatosBuque";
            this.button_configurarDatosBuque.Size = new System.Drawing.Size(287, 50);
            this.button_configurarDatosBuque.TabIndex = 2;
            this.button_configurarDatosBuque.Text = "Configuración Datos Buque Propio";
            this.button_configurarDatosBuque.UseVisualStyleBackColor = true;
            this.button_configurarDatosBuque.Click += new System.EventHandler(this.button_configurarDatosBuque_Click);
            // 
            // tabPage_sensores
            // 
            this.tabPage_sensores.Controls.Add(this.groupBox_panelSensores);
            this.tabPage_sensores.Location = new System.Drawing.Point(4, 22);
            this.tabPage_sensores.Name = "tabPage_sensores";
            this.tabPage_sensores.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sensores.Size = new System.Drawing.Size(343, 804);
            this.tabPage_sensores.TabIndex = 1;
            this.tabPage_sensores.Text = "Sensores";
            this.tabPage_sensores.UseVisualStyleBackColor = true;
            // 
            // groupBox_panelSensores
            // 
            this.groupBox_panelSensores.Controls.Add(this.groupBox7);
            this.groupBox_panelSensores.Controls.Add(this.groupBox6);
            this.groupBox_panelSensores.Controls.Add(this.groupBox5);
            this.groupBox_panelSensores.Controls.Add(this.groupBox4);
            this.groupBox_panelSensores.Controls.Add(this.groupBox3);
            this.groupBox_panelSensores.Controls.Add(this.groupBox2);
            this.groupBox_panelSensores.Controls.Add(this.groupBox1);
            this.groupBox_panelSensores.Controls.Add(this.groupBox_GPS);
            this.groupBox_panelSensores.Location = new System.Drawing.Point(21, 23);
            this.groupBox_panelSensores.Name = "groupBox_panelSensores";
            this.groupBox_panelSensores.Size = new System.Drawing.Size(284, 733);
            this.groupBox_panelSensores.TabIndex = 15;
            this.groupBox_panelSensores.TabStop = false;
            this.groupBox_panelSensores.Text = "Sensores de Navegación";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button_configPuertoSerial_GPSBluetooth);
            this.groupBox7.Controls.Add(this.checkBox_gpsPropio);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(25, 636);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(241, 81);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "GPS Bluetooth";
            // 
            // button_configPuertoSerial_GPSBluetooth
            // 
            this.button_configPuertoSerial_GPSBluetooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_GPSBluetooth.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_GPSBluetooth.Name = "button_configPuertoSerial_GPSBluetooth";
            this.button_configPuertoSerial_GPSBluetooth.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_GPSBluetooth.TabIndex = 1;
            this.button_configPuertoSerial_GPSBluetooth.Text = "Puerto Serial";
            this.button_configPuertoSerial_GPSBluetooth.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_GPSBluetooth.Click += new System.EventHandler(this.button_configPuertoSerial_GPSBluetooth_Click);
            // 
            // checkBox_gpsPropio
            // 
            this.checkBox_gpsPropio.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_gpsPropio.BackColor = System.Drawing.Color.Red;
            this.checkBox_gpsPropio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_gpsPropio.ForeColor = System.Drawing.Color.Black;
            this.checkBox_gpsPropio.Location = new System.Drawing.Point(9, 32);
            this.checkBox_gpsPropio.Name = "checkBox_gpsPropio";
            this.checkBox_gpsPropio.Size = new System.Drawing.Size(126, 35);
            this.checkBox_gpsPropio.TabIndex = 14;
            this.checkBox_gpsPropio.Text = "Desactivado";
            this.checkBox_gpsPropio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_gpsPropio.UseVisualStyleBackColor = false;
            this.checkBox_gpsPropio.CheckedChanged += new System.EventHandler(this.checkBox_gpsPropio_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_configPuertoSerial_AIS);
            this.groupBox6.Controls.Add(this.checkBox_estadoAIS);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(25, 549);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 81);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "AIS";
            // 
            // button_configPuertoSerial_AIS
            // 
            this.button_configPuertoSerial_AIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_AIS.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_AIS.Name = "button_configPuertoSerial_AIS";
            this.button_configPuertoSerial_AIS.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_AIS.TabIndex = 1;
            this.button_configPuertoSerial_AIS.Text = "Puerto Serial";
            this.button_configPuertoSerial_AIS.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_AIS.Click += new System.EventHandler(this.button_configPuertoSerial_AIS_Click);
            // 
            // checkBox_estadoAIS
            // 
            this.checkBox_estadoAIS.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoAIS.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoAIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoAIS.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoAIS.Location = new System.Drawing.Point(9, 30);
            this.checkBox_estadoAIS.Name = "checkBox_estadoAIS";
            this.checkBox_estadoAIS.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoAIS.TabIndex = 12;
            this.checkBox_estadoAIS.Text = "Desactivado";
            this.checkBox_estadoAIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoAIS.UseVisualStyleBackColor = false;
            this.checkBox_estadoAIS.CheckedChanged += new System.EventHandler(this.checkBox_estadoAIS_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_configPuertoSerial_CORREDERA);
            this.groupBox5.Controls.Add(this.checkBox_estadoCorredera);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(25, 460);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 81);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CORREDERA";
            // 
            // button_configPuertoSerial_CORREDERA
            // 
            this.button_configPuertoSerial_CORREDERA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_CORREDERA.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_CORREDERA.Name = "button_configPuertoSerial_CORREDERA";
            this.button_configPuertoSerial_CORREDERA.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_CORREDERA.TabIndex = 1;
            this.button_configPuertoSerial_CORREDERA.Text = "Puerto Serial";
            this.button_configPuertoSerial_CORREDERA.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_CORREDERA.Click += new System.EventHandler(this.button_configPuertoSerial_CORREDERA_Click);
            // 
            // checkBox_estadoCorredera
            // 
            this.checkBox_estadoCorredera.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoCorredera.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoCorredera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoCorredera.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoCorredera.Location = new System.Drawing.Point(9, 28);
            this.checkBox_estadoCorredera.Name = "checkBox_estadoCorredera";
            this.checkBox_estadoCorredera.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoCorredera.TabIndex = 6;
            this.checkBox_estadoCorredera.Text = "Desactivado";
            this.checkBox_estadoCorredera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoCorredera.UseVisualStyleBackColor = false;
            this.checkBox_estadoCorredera.CheckedChanged += new System.EventHandler(this.checkBox_estadoCorredera_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_configPuertoSerial_ANEMOMETRO);
            this.groupBox4.Controls.Add(this.checkBox_estadoAnemometro);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 81);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ANEMOMETRO";
            // 
            // button_configPuertoSerial_ANEMOMETRO
            // 
            this.button_configPuertoSerial_ANEMOMETRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_ANEMOMETRO.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_ANEMOMETRO.Name = "button_configPuertoSerial_ANEMOMETRO";
            this.button_configPuertoSerial_ANEMOMETRO.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_ANEMOMETRO.TabIndex = 1;
            this.button_configPuertoSerial_ANEMOMETRO.Text = "Puerto Serial";
            this.button_configPuertoSerial_ANEMOMETRO.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_ANEMOMETRO.Click += new System.EventHandler(this.button_configPuertoSerial_ANEMOMETRO_Click);
            // 
            // checkBox_estadoAnemometro
            // 
            this.checkBox_estadoAnemometro.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoAnemometro.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoAnemometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoAnemometro.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoAnemometro.Location = new System.Drawing.Point(9, 30);
            this.checkBox_estadoAnemometro.Name = "checkBox_estadoAnemometro";
            this.checkBox_estadoAnemometro.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoAnemometro.TabIndex = 10;
            this.checkBox_estadoAnemometro.Text = "Desactivado";
            this.checkBox_estadoAnemometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoAnemometro.UseVisualStyleBackColor = false;
            this.checkBox_estadoAnemometro.CheckedChanged += new System.EventHandler(this.checkBox_estadoAnemometro_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_configPuertoSerial_ECOSONDA);
            this.groupBox3.Controls.Add(this.checkBox_estadoEcosonda);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 81);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ECOSONDA";
            // 
            // button_configPuertoSerial_ECOSONDA
            // 
            this.button_configPuertoSerial_ECOSONDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_ECOSONDA.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_ECOSONDA.Name = "button_configPuertoSerial_ECOSONDA";
            this.button_configPuertoSerial_ECOSONDA.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_ECOSONDA.TabIndex = 1;
            this.button_configPuertoSerial_ECOSONDA.Text = "Puerto Serial";
            this.button_configPuertoSerial_ECOSONDA.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_ECOSONDA.Click += new System.EventHandler(this.button_configPuertoSerial_ECOSONDA_Click);
            // 
            // checkBox_estadoEcosonda
            // 
            this.checkBox_estadoEcosonda.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoEcosonda.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoEcosonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoEcosonda.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoEcosonda.Location = new System.Drawing.Point(9, 30);
            this.checkBox_estadoEcosonda.Name = "checkBox_estadoEcosonda";
            this.checkBox_estadoEcosonda.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoEcosonda.TabIndex = 8;
            this.checkBox_estadoEcosonda.Text = "Desactivado";
            this.checkBox_estadoEcosonda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoEcosonda.UseVisualStyleBackColor = false;
            this.checkBox_estadoEcosonda.CheckedChanged += new System.EventHandler(this.checkBox_estadoEcosonda_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_configPuertoSerial_GYRO);
            this.groupBox2.Controls.Add(this.checkBox_estadoGyro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(25, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 81);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GYRO";
            // 
            // button_configPuertoSerial_GYRO
            // 
            this.button_configPuertoSerial_GYRO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_GYRO.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_GYRO.Name = "button_configPuertoSerial_GYRO";
            this.button_configPuertoSerial_GYRO.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_GYRO.TabIndex = 1;
            this.button_configPuertoSerial_GYRO.Text = "Puerto Serial";
            this.button_configPuertoSerial_GYRO.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_GYRO.Click += new System.EventHandler(this.button_configPuertoSerial_GYRO_Click);
            // 
            // checkBox_estadoGyro
            // 
            this.checkBox_estadoGyro.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoGyro.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoGyro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoGyro.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoGyro.Location = new System.Drawing.Point(9, 30);
            this.checkBox_estadoGyro.Name = "checkBox_estadoGyro";
            this.checkBox_estadoGyro.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoGyro.TabIndex = 4;
            this.checkBox_estadoGyro.Text = "Desactivado";
            this.checkBox_estadoGyro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoGyro.UseVisualStyleBackColor = false;
            this.checkBox_estadoGyro.CheckedChanged += new System.EventHandler(this.checkBox_estadoGyro_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_configPuertoSerial_DGPS);
            this.groupBox1.Controls.Add(this.checkBox_estadoDGPS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 81);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DGPS";
            // 
            // button_configPuertoSerial_DGPS
            // 
            this.button_configPuertoSerial_DGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_DGPS.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_DGPS.Name = "button_configPuertoSerial_DGPS";
            this.button_configPuertoSerial_DGPS.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_DGPS.TabIndex = 1;
            this.button_configPuertoSerial_DGPS.Text = "Puerto Serial";
            this.button_configPuertoSerial_DGPS.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_DGPS.Click += new System.EventHandler(this.button_configPuertoSerial_DGPS_Click);
            // 
            // checkBox_estadoDGPS
            // 
            this.checkBox_estadoDGPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoDGPS.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoDGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoDGPS.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoDGPS.Location = new System.Drawing.Point(9, 28);
            this.checkBox_estadoDGPS.Name = "checkBox_estadoDGPS";
            this.checkBox_estadoDGPS.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoDGPS.TabIndex = 2;
            this.checkBox_estadoDGPS.Text = "Desactivado";
            this.checkBox_estadoDGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoDGPS.UseVisualStyleBackColor = false;
            this.checkBox_estadoDGPS.CheckedChanged += new System.EventHandler(this.checkBox_estadoDGPS_CheckedChanged);
            // 
            // groupBox_GPS
            // 
            this.groupBox_GPS.Controls.Add(this.button_configPuertoSerial_GPS);
            this.groupBox_GPS.Controls.Add(this.checkBox_estadoGPS);
            this.groupBox_GPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GPS.Location = new System.Drawing.Point(25, 15);
            this.groupBox_GPS.Name = "groupBox_GPS";
            this.groupBox_GPS.Size = new System.Drawing.Size(241, 81);
            this.groupBox_GPS.TabIndex = 16;
            this.groupBox_GPS.TabStop = false;
            this.groupBox_GPS.Text = "GPS";
            // 
            // button_configPuertoSerial_GPS
            // 
            this.button_configPuertoSerial_GPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_configPuertoSerial_GPS.Location = new System.Drawing.Point(156, 30);
            this.button_configPuertoSerial_GPS.Name = "button_configPuertoSerial_GPS";
            this.button_configPuertoSerial_GPS.Size = new System.Drawing.Size(75, 35);
            this.button_configPuertoSerial_GPS.TabIndex = 1;
            this.button_configPuertoSerial_GPS.Text = "Puerto Serial";
            this.button_configPuertoSerial_GPS.UseVisualStyleBackColor = true;
            this.button_configPuertoSerial_GPS.Click += new System.EventHandler(this.button_configPuertoSerial_GPS_Click);
            // 
            // checkBox_estadoGPS
            // 
            this.checkBox_estadoGPS.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_estadoGPS.BackColor = System.Drawing.Color.Red;
            this.checkBox_estadoGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_estadoGPS.ForeColor = System.Drawing.Color.Black;
            this.checkBox_estadoGPS.Location = new System.Drawing.Point(9, 30);
            this.checkBox_estadoGPS.Name = "checkBox_estadoGPS";
            this.checkBox_estadoGPS.Size = new System.Drawing.Size(126, 35);
            this.checkBox_estadoGPS.TabIndex = 0;
            this.checkBox_estadoGPS.Text = "Desactivado";
            this.checkBox_estadoGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_estadoGPS.UseVisualStyleBackColor = false;
            this.checkBox_estadoGPS.CheckedChanged += new System.EventHandler(this.checkBox_estadoGPS_CheckedChanged);
            // 
            // tabPage_reproducción
            // 
            this.tabPage_reproducción.Controls.Add(this.groupBox_reproduccion);
            this.tabPage_reproducción.Location = new System.Drawing.Point(4, 22);
            this.tabPage_reproducción.Name = "tabPage_reproducción";
            this.tabPage_reproducción.Size = new System.Drawing.Size(343, 804);
            this.tabPage_reproducción.TabIndex = 2;
            this.tabPage_reproducción.Text = "Reproducción";
            this.tabPage_reproducción.UseVisualStyleBackColor = true;
            // 
            // groupBox_reproduccion
            // 
            this.groupBox_reproduccion.Controls.Add(this.checkBox_Loop);
            this.groupBox_reproduccion.Controls.Add(this.button_seleccionArchivo);
            this.groupBox_reproduccion.Controls.Add(this.label_nombreArchivo);
            this.groupBox_reproduccion.Controls.Add(this.label7);
            this.groupBox_reproduccion.Enabled = false;
            this.groupBox_reproduccion.Location = new System.Drawing.Point(22, 55);
            this.groupBox_reproduccion.Name = "groupBox_reproduccion";
            this.groupBox_reproduccion.Size = new System.Drawing.Size(288, 390);
            this.groupBox_reproduccion.TabIndex = 3;
            this.groupBox_reproduccion.TabStop = false;
            this.groupBox_reproduccion.Text = "Reproducción Archivo Datos";
            // 
            // checkBox_Loop
            // 
            this.checkBox_Loop.AutoSize = true;
            this.checkBox_Loop.Checked = true;
            this.checkBox_Loop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Loop.Enabled = false;
            this.checkBox_Loop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Loop.Location = new System.Drawing.Point(48, 139);
            this.checkBox_Loop.Name = "checkBox_Loop";
            this.checkBox_Loop.Size = new System.Drawing.Size(193, 20);
            this.checkBox_Loop.TabIndex = 31;
            this.checkBox_Loop.Text = "Envio de Datos en Loop";
            this.checkBox_Loop.UseVisualStyleBackColor = true;
            this.checkBox_Loop.Visible = false;
            // 
            // button_seleccionArchivo
            // 
            this.button_seleccionArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seleccionArchivo.Location = new System.Drawing.Point(22, 35);
            this.button_seleccionArchivo.Name = "button_seleccionArchivo";
            this.button_seleccionArchivo.Size = new System.Drawing.Size(234, 87);
            this.button_seleccionArchivo.TabIndex = 0;
            this.button_seleccionArchivo.Text = "Seleccionar Archivo";
            this.button_seleccionArchivo.UseVisualStyleBackColor = true;
            this.button_seleccionArchivo.Click += new System.EventHandler(this.button_seleccionArchivo_Click);
            // 
            // label_nombreArchivo
            // 
            this.label_nombreArchivo.AutoSize = true;
            this.label_nombreArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombreArchivo.ForeColor = System.Drawing.Color.Red;
            this.label_nombreArchivo.Location = new System.Drawing.Point(18, 280);
            this.label_nombreArchivo.Name = "label_nombreArchivo";
            this.label_nombreArchivo.Size = new System.Drawing.Size(31, 20);
            this.label_nombreArchivo.TabIndex = 2;
            this.label_nombreArchivo.Text = "C:\\";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Archivo Abierto:";
            // 
            // button_detener
            // 
            this.button_detener.Enabled = false;
            this.button_detener.Location = new System.Drawing.Point(710, 787);
            this.button_detener.Name = "button_detener";
            this.button_detener.Size = new System.Drawing.Size(128, 49);
            this.button_detener.TabIndex = 31;
            this.button_detener.Text = "Detener Data";
            this.button_detener.UseVisualStyleBackColor = true;
            this.button_detener.Click += new System.EventHandler(this.button_detener_Click);
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(866, 786);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(128, 49);
            this.button_limpiar.TabIndex = 28;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            this.button_limpiar.Click += new System.EventHandler(this.button_limpiar_Click);
            // 
            // button_transmitir
            // 
            this.button_transmitir.Enabled = false;
            this.button_transmitir.Location = new System.Drawing.Point(565, 787);
            this.button_transmitir.Name = "button_transmitir";
            this.button_transmitir.Size = new System.Drawing.Size(128, 49);
            this.button_transmitir.TabIndex = 1;
            this.button_transmitir.Text = "Transmitir Data";
            this.button_transmitir.UseVisualStyleBackColor = true;
            this.button_transmitir.Click += new System.EventHandler(this.button_transmitir_Click);
            // 
            // button_configurarPuerto
            // 
            this.button_configurarPuerto.Location = new System.Drawing.Point(398, 786);
            this.button_configurarPuerto.Name = "button_configurarPuerto";
            this.button_configurarPuerto.Size = new System.Drawing.Size(150, 49);
            this.button_configurarPuerto.TabIndex = 0;
            this.button_configurarPuerto.Text = "Configuración Puerto Serial Envio General";
            this.button_configurarPuerto.UseVisualStyleBackColor = true;
            this.button_configurarPuerto.Click += new System.EventHandler(this.button_configurarPuerto_Click);
            // 
            // listBox_visorDatosNmea
            // 
            this.listBox_visorDatosNmea.ForeColor = System.Drawing.Color.DarkBlue;
            this.listBox_visorDatosNmea.FormattingEnabled = true;
            this.listBox_visorDatosNmea.HorizontalScrollbar = true;
            this.listBox_visorDatosNmea.ItemHeight = 16;
            this.listBox_visorDatosNmea.Location = new System.Drawing.Point(20, 21);
            this.listBox_visorDatosNmea.Name = "listBox_visorDatosNmea";
            this.listBox_visorDatosNmea.ScrollAlwaysVisible = true;
            this.listBox_visorDatosNmea.Size = new System.Drawing.Size(776, 180);
            this.listBox_visorDatosNmea.TabIndex = 1;
            // 
            // groupBox_pantallaTramasNMEA
            // 
            this.groupBox_pantallaTramasNMEA.Controls.Add(this.listBox_visorDatosNmea);
            this.groupBox_pantallaTramasNMEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_pantallaTramasNMEA.Location = new System.Drawing.Point(380, 556);
            this.groupBox_pantallaTramasNMEA.Name = "groupBox_pantallaTramasNMEA";
            this.groupBox_pantallaTramasNMEA.Size = new System.Drawing.Size(814, 225);
            this.groupBox_pantallaTramasNMEA.TabIndex = 2;
            this.groupBox_pantallaTramasNMEA.TabStop = false;
            this.groupBox_pantallaTramasNMEA.Text = "Tramas NMEA0183 Enviadas";
            // 
            // openFileDialog_seleccionArchivo
            // 
            this.openFileDialog_seleccionArchivo.FileName = "openFileDialog1";
            // 
            // checkBox_ocultarPanelTramasNMEA
            // 
            this.checkBox_ocultarPanelTramasNMEA.AutoSize = true;
            this.checkBox_ocultarPanelTramasNMEA.Location = new System.Drawing.Point(1019, 787);
            this.checkBox_ocultarPanelTramasNMEA.Name = "checkBox_ocultarPanelTramasNMEA";
            this.checkBox_ocultarPanelTramasNMEA.Size = new System.Drawing.Size(175, 17);
            this.checkBox_ocultarPanelTramasNMEA.TabIndex = 32;
            this.checkBox_ocultarPanelTramasNMEA.Text = "Ocultar Panel Tramas Enviadas";
            this.checkBox_ocultarPanelTramasNMEA.UseVisualStyleBackColor = true;
            this.checkBox_ocultarPanelTramasNMEA.CheckedChanged += new System.EventHandler(this.checkBox_ocultarPanelTramasNMEA_CheckedChanged);
            // 
            // tabPage_estadoConexion
            // 
            this.tabPage_estadoConexion.Location = new System.Drawing.Point(4, 22);
            this.tabPage_estadoConexion.Name = "tabPage_estadoConexion";
            this.tabPage_estadoConexion.Size = new System.Drawing.Size(343, 804);
            this.tabPage_estadoConexion.TabIndex = 3;
            this.tabPage_estadoConexion.Text = "Estado Conexión";
            this.tabPage_estadoConexion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 851);
            this.Controls.Add(this.checkBox_ocultarPanelTramasNMEA);
            this.Controls.Add(this.button_detener);
            this.Controls.Add(this.groupBox_pantallaTramasNMEA);
            this.Controls.Add(this.tabControl_controles);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_configurarPuerto);
            this.Controls.Add(this.button_transmitir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "Form1";
            this.Text = "SIMULADOR DE SENSORES DE NAVEGACION";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MaximizedBoundsChanged += new System.EventHandler(this.Form1_MaximizedBoundsChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.tabControl_controles.ResumeLayout(false);
            this.tabPage_configuracion.ResumeLayout(false);
            this.tabPage_configuracion.PerformLayout();
            this.groupBox_estadoConexion.ResumeLayout(false);
            this.groupBox_estadoConexion.PerformLayout();
            this.groupBox_datosConfigurados.ResumeLayout(false);
            this.groupBox_datosConfigurados.PerformLayout();
            this.groupBox_controlBuque.ResumeLayout(false);
            this.groupBox_controlBuque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_anguloTimon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_velocidadBuque)).EndInit();
            this.groupBox_datosNavegacion.ResumeLayout(false);
            this.groupBox_datosNavegacion.PerformLayout();
            this.tabPage_sensores.ResumeLayout(false);
            this.groupBox_panelSensores.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_GPS.ResumeLayout(false);
            this.tabPage_reproducción.ResumeLayout(false);
            this.groupBox_reproduccion.ResumeLayout(false);
            this.groupBox_reproduccion.PerformLayout();
            this.groupBox_pantallaTramasNMEA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_controles;
        private System.Windows.Forms.TabPage tabPage_configuracion;
        private System.Windows.Forms.TabPage tabPage_sensores;
        private System.Windows.Forms.GroupBox groupBox_estadoConexion;
        private System.Windows.Forms.Label label_puertoCom;
        private System.Windows.Forms.Label label_bitParada;
        private System.Windows.Forms.Label label_paridad;
        private System.Windows.Forms.Label label_bitDatos;
        private System.Windows.Forms.Label label_velocidadTransmicion;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button_transmitir;
        private System.Windows.Forms.Button button_configurarDatosBuque;
        private System.Windows.Forms.GroupBox groupBox_datosConfigurados;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.Label label_dirViento;
        public System.Windows.Forms.Label label_profundidad;
        public System.Windows.Forms.Label label_velocidad;
        public System.Windows.Forms.Label label_rumbo;
        public System.Windows.Forms.Label label_longitud;
        public System.Windows.Forms.Label label_latitud;
        public System.Windows.Forms.Label label_velViento;
        private System.Windows.Forms.Button button_limpiar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox_visorDatosNmea;
        private System.Windows.Forms.Button button_detener;
        public System.Windows.Forms.GroupBox groupBox_pantallaTramasNMEA;
        private System.Windows.Forms.GroupBox groupBox_panelSensores;
        private System.Windows.Forms.CheckBox checkBox_estadoDGPS;
        private System.Windows.Forms.CheckBox checkBox_estadoGPS;
        private System.Windows.Forms.CheckBox checkBox_estadoAIS;
        private System.Windows.Forms.CheckBox checkBox_estadoAnemometro;
        private System.Windows.Forms.CheckBox checkBox_estadoGyro;
        private System.Windows.Forms.CheckBox checkBox_estadoEcosonda;
        private System.Windows.Forms.CheckBox checkBox_estadoCorredera;
        private System.Windows.Forms.CheckBox checkBox_navegacionBuque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_datosNavegacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label_millasNavegadas;
        public System.Windows.Forms.Label label_tiempoNavegado;
        public System.Windows.Forms.Button button_configurarPuerto;
        private System.Windows.Forms.TabPage tabPage_reproducción;
        private System.Windows.Forms.Button button_seleccionArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog_seleccionArchivo;
        private System.Windows.Forms.Label label_nombreArchivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_reproduccion;
        private System.Windows.Forms.GroupBox groupBox_controlBuque;
        private System.Windows.Forms.NumericUpDown numericUpDown_anguloTimon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.NumericUpDown numericUpDown_velocidadBuque;
        private System.Windows.Forms.CheckBox checkBox_gpsPropio;
        private System.Windows.Forms.CheckBox checkBox_verTrayectoria;
        private System.Windows.Forms.CheckBox checkBox_ocultarPanelTramasNMEA;
        private System.Windows.Forms.CheckBox checkBox_Loop;
        private System.Windows.Forms.GroupBox groupBox_GPS;
        private System.Windows.Forms.Button button_configPuertoSerial_GPS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_configPuertoSerial_DGPS;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button_configPuertoSerial_AIS;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_configPuertoSerial_CORREDERA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_configPuertoSerial_ANEMOMETRO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_configPuertoSerial_ECOSONDA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_configPuertoSerial_GYRO;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button_configPuertoSerial_GPSBluetooth;
        private System.Windows.Forms.TabPage tabPage_estadoConexion;
    }
}

