using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SimNav
{
    public partial class Form1 : Form
    {

        /* declaracion de variable de control de usuario para configuracion puerto
         * variable ObjetoPuertoSerial es del tipo PuertoSerial que es un tipo de dato creado por
         * el programador y se utiliza para gurdar todos los datos de configuracion del puerto serial 
         * que se va a utilizar para la transmision de datos.
         * Los datos que se obtienen del usuario se obtienen a traves de un cuadro de dialogo de configuracion 
         * de puerto serial tambien creado por el programador*/
        
         public PuertoSerial ObjetoPuertoSerial;

         public PuertoSerial puertoSerial_GPS;
         public PuertoSerial puertoSerial_DGPS;
         public PuertoSerial puertoSerial_GYRO;
         public PuertoSerial puertoSerial_ECOSONDA;
         public PuertoSerial puertoSerial_ANEMOMETRO;
         public PuertoSerial puertoSerial_CORREDERA;
         public PuertoSerial puertoSerial_AIS;
         public PuertoSerial puertoSerial_GPSBluetooth;

         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_GPS;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_DGPS;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_GYRO;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_ECOSONDA;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_ANEMOMETRO;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_CORREDERA;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_AIS;
         public EtiquetaEstadoPuertoSerial etiqueta_puertoSerial_GPSBluetooth;

        
         bool puertoSerialGeneral_ISActivo;
         bool puertoSerialGPS_ISActivo;
         bool puertoSerialDGPS_ISActivo;
         bool puertoSerialGYRO_ISActivo;
         bool puertoSerialECOSONDA_ISActivo;
         bool puertoSerialANEMOMETRO_ISActivo;
         bool puertoSerialCORREDERA_ISActivo;
         bool puertoSerialAIS_ISActivo;
         bool puertoSerialGPSBluetooth_ISActivo;
        







         public DatosBuquePropio buquePropio;

         public MapControl canvasMapa;


         bool conLoop;
         bool hiloIniciado;
         bool reproduccion;

         private Thread myThread;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ObjetoPuertoSerial = new PuertoSerial();
            puertoSerial_GPS = new PuertoSerial();
            puertoSerial_DGPS = new PuertoSerial();
            puertoSerial_GYRO = new PuertoSerial();
            puertoSerial_ECOSONDA = new PuertoSerial();
            puertoSerial_ANEMOMETRO = new PuertoSerial(); 
            puertoSerial_CORREDERA = new PuertoSerial();
            puertoSerial_AIS = new PuertoSerial();
            puertoSerial_GPSBluetooth = new PuertoSerial();



            colocarEtiquetaEstadoPuertoSerial();


            puertoSerialGeneral_ISActivo = false;
            puertoSerialGPS_ISActivo = false;
            puertoSerialDGPS_ISActivo = false;
            puertoSerialGYRO_ISActivo = false;
            puertoSerialECOSONDA_ISActivo = false;
            puertoSerialANEMOMETRO_ISActivo = false;
            puertoSerialCORREDERA_ISActivo = false;
            puertoSerialAIS_ISActivo = false;
            puertoSerialGPSBluetooth_ISActivo = false;






            buquePropio = new DatosBuquePropio(this);
            conLoop = true;

            canvasMapa = new MapControl(this);
            this.Controls.Add(canvasMapa);
            buquePropio.Location = new Point(370,6);
            //buquePropio.Size = new Size(groupBox_datosConfigurados.Size.Width, groupBox_datosConfigurados.Size.Height);
            canvasMapa.BringToFront();
            canvasMapa.Visible = true;
            hiloIniciado = false;
            reproduccion = false;



        }

        private void button_configurarPuerto_Click(object sender, EventArgs e)
        {
           
            
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.ObjetoPuertoSerial);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
            //button_transmitir.Enabled = true;
           

        }

        private void button_transmitir_Click(object sender, EventArgs e)
        {
            button_transmitir.Enabled = false;
            groupBox_reproduccion.Enabled = false;



            if (existePuertosSerialConfigurado())
            {
                //label_bitDatos.Text = ObjetoPuertoSerial.getBitDatos();
                //label_bitParada.Text = ObjetoPuertoSerial.getBitParada();
                //label_paridad.Text = ObjetoPuertoSerial.getParidad();
                //label_puertoCom.Text = ObjetoPuertoSerial.getNombrePuerto();
                //label_velocidadTransmicion.Text = ObjetoPuertoSerial.getVelocidadPuerto();
                listBox_visorDatosNmea.Items.Add("Inicia Transmision de Datos");
                // se enviaran los datos por puerta serial con loop
                
                    // inicia el hilo principal del programa
                    myThread = new Thread(new ThreadStart(hiloPrincipal));
                    myThread.IsBackground = true;
                    hiloIniciado = true;
                  
                    myThread.Start();

               

                button_configurarPuerto.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe Configurar algún Puerto Serial", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if(ObjetoPuertoSerial.get_estadoPuertoSerial())
            //{
            //    label_bitDatos.Text = ObjetoPuertoSerial.getBitDatos();
            //    label_bitParada.Text = ObjetoPuertoSerial.getBitParada();
            //    label_paridad.Text = ObjetoPuertoSerial.getParidad();
            //    label_puertoCom.Text = ObjetoPuertoSerial.getNombrePuerto();
            //    label_velocidadTransmicion.Text = ObjetoPuertoSerial.getVelocidadPuerto();
            //    listBox_visorDatosNmea.Items.Add("Inicia Transmision de Datos");
            //    // se enviaran los datos por puerta serial con loop
                
            //        // inicia el hilo principal del programa
            //        myThread = new Thread(new ThreadStart(hiloPrincipal));
            //        myThread.IsBackground = true;
            //        hiloIniciado = true;
                  
            //        myThread.Start();

               

            //    button_configurarPuerto.Enabled = false;
            //}
            //else
            //{
            //    MessageBox.Show("Debe Configurar el Puerto Serial", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
    
        }

        private void hiloPrincipal()
        {
            abrirPuertosSerialesDisponibles();
            //ObjetoPuertoSerial.AbrirPuertoSerial();
            string[] data = { "" };
            //ImprimirSalida("inicio de transmision");
            while (myThread.IsAlive)
            {
                if (reproduccion)
                {
                    if (conLoop)
                    {
                        ImprimirArchivoTramasNMEA();
                    }
                    else
                    {
                        ImprimirArchivoTramasNMEA();
                        //button_configurarPuerto.Enabled = true;
                        //button_transmitir.Enabled = true;
                        //button_detener.Enabled = false;
                        this.myThread.Abort();
                        

                    }
                


                    
                }
                else
                {
                    if (checkBox_gpsPropio.Checked) // codigo envio de datos del sensor GPS Bluetooth
                    {
                        data = buquePropio.getDatos_GPSPropio();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("GPS Bluetooth:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());
                            }
                            
                                if (puertoSerialGPSBluetooth_ISActivo)
                                {
                                   puertoSerial_GPSBluetooth.enviarData(datas);
                                   SetText("GPS Bluetooth (puerta alterna):\t" + datas);
                                   Thread.Sleep(puertoSerial_GPSBluetooth.getTiempoTransmisionINT());

                                }
                            
                            
                        }
                    }

                    if (checkBox_estadoGPS.Checked) // codigo envio de datos del sensor GPS
                    {
                        data = buquePropio.getDatos_GPS();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("GPS:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());
                            }
                            if (puertoSerialGPS_ISActivo)
                            {
                                    puertoSerial_GPS.enviarData(datas);
                                    SetText("GPS (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_GPS.getTiempoTransmisionINT());

                             }
                            
                            
                        }
                    }


                    if (checkBox_estadoDGPS.Checked) // codigo envio de datos del sensor GPS
                    {
                        data = buquePropio.getDatos_DGPS();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("DGPS:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());
                            }
                            
                                if (puertoSerialGPS_ISActivo)
                                {
                                    puertoSerial_DGPS.enviarData(datas);
                                    SetText("DGPS (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_DGPS.getTiempoTransmisionINT());

                                }
                            

                        }

                    }
                    if (checkBox_estadoGyro.Checked)// codigo envio de datos del sensor GYRO
                    {
                        data = buquePropio.getDatos_GYRO();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("GYRO:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());
                            }
                            
                                if (puertoSerialGYRO_ISActivo)
                                {
                                    puertoSerial_GYRO.enviarData(datas);
                                    SetText("GYRO (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_GYRO.getTiempoTransmisionINT());

                                }
                            

                        }

                    }
                    if (checkBox_estadoEcosonda.Checked)// codigo envio de datos del sensor ECOSONDA
                    {
                        data = buquePropio.getDatos_ECOSONDA();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("ECOSONDA:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());

                            }
                            
                                if (puertoSerialECOSONDA_ISActivo)
                                {
                                   puertoSerial_ECOSONDA.enviarData(datas);
                                   SetText("ECOSONDA (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_ECOSONDA.getTiempoTransmisionINT());

                                }
                            
                            

                        }
                    }
                    if (checkBox_estadoCorredera.Checked)// codigo envio de datos del sensor CORREDERA
                    {
                        data = buquePropio.getDatos_CORREDERA();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("CORREDERA:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());


                            }
                           
                                if (puertoSerialCORREDERA_ISActivo)
                                {
                                    puertoSerial_CORREDERA.enviarData(datas);
                                    SetText("CORREDERA (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_CORREDERA.getTiempoTransmisionINT());

                                }
                           
                            

                        }
                    }
                    if (checkBox_estadoAnemometro.Checked)// codigo envio de datos del sensor ANEMOMETRO
                    {
                        data = buquePropio.getDatos_ANEMOMETRO();

                        foreach (string datas in data)
                        {
                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("ANEMOMETRO:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());

                            }
                           
                                if (puertoSerialANEMOMETRO_ISActivo)
                                {
                                    puertoSerial_ANEMOMETRO.enviarData(datas);
                                    SetText("ANEMOMETRO (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_ANEMOMETRO.getTiempoTransmisionINT());

                                }
    
                        }
                    }
                    if (checkBox_estadoAIS.Checked)// codigo envio de datos del sensor AIS
                    {
                        data = buquePropio.getDatos_AIS();

                        foreach (string datas in data)
                        {

                            if (puertoSerialGeneral_ISActivo)
                            {
                                ObjetoPuertoSerial.enviarData(datas);
                                SetText("AIS:\t" + datas);
                                Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());


                            }
                            
                                if (puertoSerialAIS_ISActivo)
                                {
                                    puertoSerial_AIS.enviarData(datas);
                                    SetText("AIS (puerta alterna):\t" + datas);
                                    Thread.Sleep(puertoSerial_AIS.getTiempoTransmisionINT());

                                }
                            
                           

                        }
                    }

                
                }
                
            }
            //ObjetoPuertoSerial.CerrarPuertoSerial();
        }

        private void button_configurarDatosBuque_Click(object sender, EventArgs e)
        {
            if (buquePropio.get_estadoHiloNavegacion())
            {
                buquePropio.killProcesoNavegacion();
            }
                this.tabPage_configuracion.Controls.Add(buquePropio);
                buquePropio.Location = new Point(groupBox_datosConfigurados.Location.X, groupBox_datosConfigurados.Location.Y);
                //buquePropio.Size = new Size(groupBox_datosConfigurados.Size.Width, groupBox_datosConfigurados.Size.Height);
                buquePropio.BringToFront();
                buquePropio.Visible = true;
                buquePropio.set_seleccionCoordenadas(true);
                canvasMapa.set_cursorSeleccionCoordenadas();
            
           
            
                
           
            
            
            
                      
           
        }

        private void checkBox_Loop_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Loop.Checked)
            {
                conLoop = true;
            }
            else
            {
                conLoop = false;
            }
        }

        private void button_detener_Click(object sender, EventArgs e)
        {
            desactivarPuertosSerialesDisponibles();
            if (hiloIniciado)
            {
                this.myThread.Abort();
            }
            cerrarPuertosSerialesDisponibles();

           
              //ObjetoPuertoSerial.CerrarPuertoSerial();

            reproduccion = false;
            checkBox_navegacionBuque.Checked = false;
            button_seleccionArchivo.Enabled = true;
            button_configurarPuerto.Enabled = true;
            button_transmitir.Enabled = true;
            groupBox_reproduccion.Enabled = true;
            comprobarEstadoBotonConfigPuerto();
            //desbloquearBotonesPuertosSerialesSensores();

           // this.checkBox_navegacionBuque.Click += new System.EventHandler(this.checkBox_navegacionBuque_CheckedChanged);
        }

        private void ImprimirSalida(string salida)
        {
            listBox_visorDatosNmea.Items.Add(salida);
        }

        // Usando delegados y funciones "callback"
//
// Este delegado define un método void
// que recibe un parámetro de tipo string
delegate void SetTextCallback(string text);

private void SetText(string text)
{
    // InvokeRequired required compares the thread ID of the
    // calling thread to the thread ID of the creating thread.
    // If these threads are different, it returns true.
    if (this.listBox_visorDatosNmea.InvokeRequired)
    {
        SetTextCallback d = new SetTextCallback(SetText);
        this.Invoke(d, new object[] { text });
    }
    else
    {
        this.listBox_visorDatosNmea.Items.Add(text);
        this.listBox_visorDatosNmea.TopIndex = (listBox_visorDatosNmea.Items.Count -4);
    }
}

//delegate void SetTextCallback(string text);

public void setLabelLatitud(string text)
{
    // InvokeRequired required compares the thread ID of the
    // calling thread to the thread ID of the creating thread.
    // If these threads are different, it returns true.
    if (this.label_latitud.InvokeRequired)
    {
        SetTextCallback d = new SetTextCallback(setLabelLatitud);
        this.Invoke(d, new object[] { text });
    }
    else
    {
        this.label_latitud.Text = text;
    }
}

public void setLabelLongitud(string text)
{
    // InvokeRequired required compares the thread ID of the
    // calling thread to the thread ID of the creating thread.
    // If these threads are different, it returns true.
    if (this.label_longitud.InvokeRequired)
    {
        SetTextCallback d = new SetTextCallback(setLabelLongitud);
        this.Invoke(d, new object[] { text });
    }
    else
    {
        this.label_longitud.Text = text;
    }
}

public void setLabelRumbo(string text)
{
    // InvokeRequired required compares the thread ID of the
    // calling thread to the thread ID of the creating thread.
    // If these threads are different, it returns true.
    if (this.label_rumbo.InvokeRequired)
    {
        SetTextCallback d = new SetTextCallback(setLabelRumbo);
        this.Invoke(d, new object[] { text });
    }
    else
    {
        this.label_rumbo.Text = text;
    }
}

public void setLabelTiempo(string text)
{
    // InvokeRequired required compares the thread ID of the
    // calling thread to the thread ID of the creating thread.
    // If these threads are different, it returns true.
    if (this.label_latitud.InvokeRequired)
    {
        SetTextCallback d = new SetTextCallback(setLabelTiempo);
        this.Invoke(d, new object[] { text });
    }
    else
    {
        this.label_tiempoNavegado.Text = text;
    }
}

public void setLabelMilla(string text)
{
    // InvokeRequired required compares the thread ID of the
    // calling thread to the thread ID of the creating thread.
    // If these threads are different, it returns true.
    if (this.label_latitud.InvokeRequired)
    {
        SetTextCallback d = new SetTextCallback(setLabelMilla);
        this.Invoke(d, new object[] { text });
    }
    else
    {
        this.label_millasNavegadas.Text = text;
    }
}

private void checkBox_estadoGPS_CheckedChanged(object sender, EventArgs e)
{
             if(checkBox_estadoGPS.Checked)
			 {
				 checkBox_estadoGPS.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoGPS.Text = "Activado";
                 button_configPuertoSerial_GPS.Enabled = false;
                 etiqueta_puertoSerial_GPS.set_etiquetaEstadoPuerto(puertoSerial_GPS);
				 
			 }
			 else
			 {
				 checkBox_estadoGPS.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoGPS.Text = "Desactivado";
                 button_configPuertoSerial_GPS.Enabled = true;
                 etiqueta_puertoSerial_GPS.set_estadoTransmision("Sin Transmisión");
				 
			 }
}

private void checkBox_estadoDGPS_CheckedChanged(object sender, EventArgs e)
{
            if(checkBox_estadoDGPS.Checked)
			 {
				 checkBox_estadoDGPS.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoDGPS.Text = "Activado";
                 button_configPuertoSerial_DGPS.Enabled = false;
                 etiqueta_puertoSerial_DGPS.set_etiquetaEstadoPuerto(puertoSerial_DGPS);
				 
			 }
			 else
			 {
				 checkBox_estadoDGPS.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoDGPS.Text = "Desactivado";
                 button_configPuertoSerial_DGPS.Enabled = true;
                 etiqueta_puertoSerial_DGPS.set_estadoTransmision("Sin Transmisión");				 
			 }
}

private void checkBox_estadoGyro_CheckedChanged(object sender, EventArgs e)
{
            if(checkBox_estadoGyro.Checked)
			 {
				 checkBox_estadoGyro.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoGyro.Text = "Activado";
                 button_configPuertoSerial_GYRO.Enabled = false;
                 etiqueta_puertoSerial_GYRO.set_etiquetaEstadoPuerto(puertoSerial_GYRO);
				 
			 }
			 else
			 {
				 checkBox_estadoGyro.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoGyro.Text = "Desactivado";
                 button_configPuertoSerial_GYRO.Enabled = true;
                 etiqueta_puertoSerial_GYRO.set_estadoTransmision("Sin Transmisión");
				 
			 }
}

private void checkBox_estadoEcosonda_CheckedChanged(object sender, EventArgs e)
{
            if(checkBox_estadoEcosonda.Checked)
			 {
				 checkBox_estadoEcosonda.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoEcosonda.Text = "Activado";
                 button_configPuertoSerial_ECOSONDA.Enabled = false;
                 etiqueta_puertoSerial_ECOSONDA.set_etiquetaEstadoPuerto(puertoSerial_ECOSONDA);
				 
			 }
			 else
			 {
				 checkBox_estadoEcosonda.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoEcosonda.Text = "Desactivado";
                 button_configPuertoSerial_ECOSONDA.Enabled = true;
                 etiqueta_puertoSerial_ECOSONDA.set_estadoTransmision("Sin Transmisión");
			 }
}

private void checkBox_estadoAnemometro_CheckedChanged(object sender, EventArgs e)
{
            if(checkBox_estadoAnemometro.Checked)
			 {
				 checkBox_estadoAnemometro.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoAnemometro.Text = "Activado";
                 button_configPuertoSerial_ANEMOMETRO.Enabled = false;
                 etiqueta_puertoSerial_ANEMOMETRO.set_etiquetaEstadoPuerto(puertoSerial_ANEMOMETRO);
				 
			 }
			 else
			 {
				 checkBox_estadoAnemometro.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoAnemometro.Text = "Desactivado";
                 button_configPuertoSerial_ANEMOMETRO.Enabled = true;
                 etiqueta_puertoSerial_ANEMOMETRO.set_estadoTransmision("Sin Transmisión");
				 
			 }
}

private void checkBox_estadoCorredera_CheckedChanged(object sender, EventArgs e)
{
             if(checkBox_estadoCorredera.Checked)
			 {
				 checkBox_estadoCorredera.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoCorredera.Text = "Activado";
                 button_configPuertoSerial_CORREDERA.Enabled = false;
                 etiqueta_puertoSerial_CORREDERA.set_etiquetaEstadoPuerto(puertoSerial_CORREDERA);
				 
			 }
			 else
			 {
				 checkBox_estadoCorredera.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoCorredera.Text = "Desactivado";
                 button_configPuertoSerial_CORREDERA.Enabled = true;
                 etiqueta_puertoSerial_CORREDERA.set_estadoTransmision("Sin Transmisión");
				 
			 }
}

private void checkBox_estadoAIS_CheckedChanged(object sender, EventArgs e)
{
            if(checkBox_estadoAIS.Checked)
			 {
				 checkBox_estadoAIS.BackColor = System.Drawing.Color.Green;
				 checkBox_estadoAIS.Text = "Activado";
                 button_configPuertoSerial_AIS.Enabled = false;
                 etiqueta_puertoSerial_AIS.set_etiquetaEstadoPuerto(puertoSerial_AIS);
				 
			 }
			 else
			 {
				 checkBox_estadoAIS.BackColor = System.Drawing.Color.Red;
				 checkBox_estadoAIS.Text = "Desactivado";
                 button_configPuertoSerial_AIS.Enabled = true;
                 etiqueta_puertoSerial_AIS.set_estadoTransmision("Sin Transmisión");
				 
			 }
}

private void checkBox_navegacionBuque_CheckedChanged(object sender, EventArgs e)
{
    if (checkBox_navegacionBuque.Checked)
    {
        checkBox_navegacionBuque.BackColor = System.Drawing.Color.Green;
        checkBox_navegacionBuque.Text = "Activado";
        buquePropio.navegacionActiva = true;
        groupBox_controlBuque.Enabled = true;
        button_configurarDatosBuque.Enabled = false;
        

    }
    else
    {
        checkBox_navegacionBuque.BackColor = System.Drawing.Color.Red;
        checkBox_navegacionBuque.Text = "Desactivado";
        buquePropio.navegacionActiva = false;
        groupBox_controlBuque.Enabled = false;
        button_configurarDatosBuque.Enabled = true;

    }
}

public void setCoordenadasCanvas(double latitud, double longitud)
{
    if (buquePropio.get_seleccionCoordenadas())
    {
        buquePropio.actualizarCoordenadas(latitud, longitud);
    }
}

private void button_limpiar_Click(object sender, EventArgs e)
{
    listBox_visorDatosNmea.Items.Clear();
}

private void button_seleccionArchivo_Click(object sender, EventArgs e)
{
    MessageBox.Show("Al utilizar esta funcionalidad dejara inactiva la funcion de Simulacion de Navegación", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

    if (hiloIniciado)
    {
        this.myThread.Abort();
    }

    if (buquePropio.get_estadoHiloNavegacion())
    {
        buquePropio.killProcesoNavegacion();
    }

    checkBox_Loop.Visible = true;
    checkBox_Loop.Enabled = true;
    checkBox_navegacionBuque.Checked = false;
    if (!ObjetoPuertoSerial.get_estadoPuertoSerial())
    {
        button_configurarPuerto.Enabled = true;
    }
  
    //button_transmitir.Enabled = true;


    string nfile;
    

		
			
					
			if  (openFileDialog_seleccionArchivo.ShowDialog()== System.Windows.Forms.DialogResult.OK)
			{
				
                nfile = System.IO.Path.GetFileName(openFileDialog_seleccionArchivo.FileName);
                label_nombreArchivo.Text = nfile;
                button_seleccionArchivo.Enabled = false;
				reproduccion = true;
				
				
			}
			else
			{
				MessageBox.Show("Debes elejir un Archivo","Informacion ",MessageBoxButtons.OK,MessageBoxIcon.Question);
			}
		 






}

void EnviarDataReproduccionSinLoop()
{

    if (reproduccion)
    {
        ImprimirArchivoTramasNMEA();

    }
   
   

}

        void ImprimirArchivoTramasNMEA()
		  {

              string serialData = "";
				System.IO.StreamReader srFile = new System.IO.StreamReader(openFileDialog_seleccionArchivo.FileName);

				while (srFile.ReadLine() != null)
				{
                    
				  serialData = srFile.ReadLine();
                  ObjetoPuertoSerial.enviarData(serialData);
                  SetText(serialData);
                  Thread.Sleep(ObjetoPuertoSerial.getTiempoTransmisionINT());  
				 }
				 srFile.Close();

		  }


        public void activarBotonTransmitir()
        {
            button_transmitir.Enabled = true;
        }

        private void numericUpDown_velocidadBuque_ValueChanged(object sender, EventArgs e)
        {
            buquePropio.set_velocidadBuque((int)numericUpDown_velocidadBuque.Value);
        }

        private void numericUpDown_anguloTimon_ValueChanged(object sender, EventArgs e)
        {
            buquePropio.set_anguloTimon((int)numericUpDown_anguloTimon.Value);
        }

        private void checkBox_gpsPropio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_gpsPropio.Checked)
            {
                checkBox_gpsPropio.BackColor = System.Drawing.Color.Green;
                checkBox_gpsPropio.Text = "Activado";
                etiqueta_puertoSerial_GPSBluetooth.set_etiquetaEstadoPuerto(puertoSerial_GPSBluetooth);

            }
            else
            {
                checkBox_gpsPropio.BackColor = System.Drawing.Color.Red;
                checkBox_gpsPropio.Text = "Desactivado";
                etiqueta_puertoSerial_GPSBluetooth.set_estadoTransmision("Sin Transmision");

            }

        }

        private void checkBox_ocultarPanelTramasNMEA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ocultarPanelTramasNMEA.Checked)
            {
                groupBox_pantallaTramasNMEA.Visible = false;

                canvasMapa.redimensionarCanvas((canvasMapa.Width), (canvasMapa.Height + groupBox_pantallaTramasNMEA.Height));
               
            }
            else
            {
                groupBox_pantallaTramasNMEA.Visible = true;

                canvasMapa.redimensionarCanvas((canvasMapa.Width), (canvasMapa.Height - groupBox_pantallaTramasNMEA.Height));
                
            }
        }

        private void Form1_MaximizedBoundsChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            canvasMapa.redimensionarCanvas((this.Width-tabControl_controles.Width) - 50, canvasMapa.Height);
        }

        private void button_configPuertoSerial_GPS_Click(object sender, EventArgs e)
        {
            
            
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_GPS);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;

        }

        private void button_configPuertoSerial_DGPS_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_DGPS);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void button_configPuertoSerial_GYRO_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_GYRO);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void button_configPuertoSerial_ECOSONDA_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_ECOSONDA);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void button_configPuertoSerial_ANEMOMETRO_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_ANEMOMETRO);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void button_configPuertoSerial_CORREDERA_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_CORREDERA);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void button_configPuertoSerial_AIS_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_AIS);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void button_configPuertoSerial_GPSBluetooth_Click(object sender, EventArgs e)
        {
            ConfiguraPuertoSerialDialog configuracionPuertoSerial = new ConfiguraPuertoSerialDialog(this, this.puertoSerial_GPSBluetooth);

            configuracionPuertoSerial.BringToFront();
            configuracionPuertoSerial.Show();
            button_detener.Enabled = true;
        }

        private void abrirPuertosSerialesDisponibles()
        {
            //Puerto serial General
            if (ObjetoPuertoSerial.get_estadoPuertoSerial())//se comprueba si el puerto serial se encuentra configurado: true= configurado, false=no configurado
            {
                if (!ObjetoPuertoSerial.get_estadoPuertoSerialAbierto())//se pregunta si el puerto serial se encuentra actualmente abierto: true= abierto, false= cerrado
                {
                    ObjetoPuertoSerial.AbrirPuertoSerial();
                    puertoSerialGeneral_ISActivo = true;
                }
            }

            //puerto serial de GPS
            if (puertoSerial_GPS.get_estadoPuertoSerial())
            {
                if (!puertoSerial_GPS.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_GPS.AbrirPuertoSerial();
                    puertoSerialGPS_ISActivo = true;
                }
            }

            //puertoSerial del DGPS
            if (puertoSerial_DGPS.get_estadoPuertoSerial())
            {
                if (!puertoSerial_DGPS.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_DGPS.AbrirPuertoSerial();
                    puertoSerialDGPS_ISActivo = true;
                }
            }

            //puertoSerial del Gyro
            if (puertoSerial_GYRO.get_estadoPuertoSerial())
            {
                if (!puertoSerial_GYRO.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_GYRO.AbrirPuertoSerial();
                    puertoSerialGYRO_ISActivo = true;
                }
            }

            //puertoSerial del ECOSONDA
            if (puertoSerial_ECOSONDA.get_estadoPuertoSerial())
            {
                if (!puertoSerial_ECOSONDA.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_ECOSONDA.AbrirPuertoSerial();
                    puertoSerialECOSONDA_ISActivo = true;
                }
            }

            //puertoSerial del ANEMOMETRO
            if (puertoSerial_ANEMOMETRO.get_estadoPuertoSerial())
            {
                if (!puertoSerial_ANEMOMETRO.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_ANEMOMETRO.AbrirPuertoSerial();
                    puertoSerialANEMOMETRO_ISActivo = true;
                }
            }

            //puertoSerial del CORREDERA
            if (puertoSerial_CORREDERA.get_estadoPuertoSerial())
            {
                if (!puertoSerial_CORREDERA.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_CORREDERA.AbrirPuertoSerial();
                    puertoSerialCORREDERA_ISActivo = true;
                }
            }

            //puertoSerial del AIS
            if (puertoSerial_AIS.get_estadoPuertoSerial())
            {
                if (!puertoSerial_AIS.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_AIS.AbrirPuertoSerial();
                    puertoSerialAIS_ISActivo = true;
                }
            }

            //puertoSerial del GPSBluetooth
            if (puertoSerial_GPSBluetooth.get_estadoPuertoSerial())
            {
                if (!puertoSerial_GPSBluetooth.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_GPSBluetooth.AbrirPuertoSerial();
                    puertoSerialGPSBluetooth_ISActivo = true;
                }
            }
            
        }
        private void desactivarPuertosSerialesDisponibles()
        {
            //Puerto serial General
            puertoSerialGeneral_ISActivo = false;
            puertoSerialGPS_ISActivo = false;
            puertoSerialDGPS_ISActivo = false;
            puertoSerialGYRO_ISActivo = false;
            puertoSerialECOSONDA_ISActivo = false;
            puertoSerialANEMOMETRO_ISActivo = false;
            puertoSerialCORREDERA_ISActivo = false;
            puertoSerialAIS_ISActivo = false;
            puertoSerialGPSBluetooth_ISActivo = false;
            
        }
        private void cerrarPuertosSerialesDisponibles()
        {
            //Puerto serial General
            if (ObjetoPuertoSerial.get_estadoPuertoSerial())//se comprueba si el puerto serial se encuentra configurado: true= configurado, false=no configurado
            {
                if (ObjetoPuertoSerial.get_estadoPuertoSerialAbierto())//se pregunta si el puerto serial se encuentra actualmente abierto: true= abierto, false= cerrado
                {
                    ObjetoPuertoSerial.CerrarPuertoSerial();
                    puertoSerialGeneral_ISActivo = false;
                }
            }

            //puerto serial de GPS
            if (puertoSerial_GPS.get_estadoPuertoSerial())
            {
                if (puertoSerial_GPS.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_GPS.CerrarPuertoSerial();
                    puertoSerialGPS_ISActivo = false;
                }
            }

            //puertoSerial del DGPS
            if (puertoSerial_DGPS.get_estadoPuertoSerial())
            {
                if (puertoSerial_DGPS.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_DGPS.CerrarPuertoSerial();
                    puertoSerialDGPS_ISActivo = false;
                }
            }

            //puertoSerial del Gyro
            if (puertoSerial_GYRO.get_estadoPuertoSerial())
            {
                if (puertoSerial_GYRO.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_GYRO.CerrarPuertoSerial();
                    puertoSerialGYRO_ISActivo = false;
                }
            }

            //puertoSerial del ECOSONDA
            if (puertoSerial_ECOSONDA.get_estadoPuertoSerial())
            {
                if (puertoSerial_ECOSONDA.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_ECOSONDA.CerrarPuertoSerial();
                    puertoSerialECOSONDA_ISActivo = false;
                }
            }

            //puertoSerial del ANEMOMETRO
            if (puertoSerial_ANEMOMETRO.get_estadoPuertoSerial())
            {
                if (!puertoSerial_ANEMOMETRO.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_ANEMOMETRO.CerrarPuertoSerial();
                    puertoSerialANEMOMETRO_ISActivo = false;
                }
            }

            //puertoSerial del CORREDERA
            if (puertoSerial_CORREDERA.get_estadoPuertoSerial())
            {
                if (puertoSerial_CORREDERA.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_CORREDERA.CerrarPuertoSerial();
                    puertoSerialCORREDERA_ISActivo = false;
                }
            }

            //puertoSerial del AIS
            if (puertoSerial_AIS.get_estadoPuertoSerial())
            {
                if (puertoSerial_AIS.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_AIS.CerrarPuertoSerial();
                    puertoSerialAIS_ISActivo = false;
                }
            }

            //puertoSerial del GPSBluetooth
            if (puertoSerial_GPSBluetooth.get_estadoPuertoSerial())
            {
                if (puertoSerial_GPSBluetooth.get_estadoPuertoSerialAbierto())
                {
                    puertoSerial_GPSBluetooth.CerrarPuertoSerial();
                    puertoSerialGPSBluetooth_ISActivo = false;
                }
            }

        }
        private void bloquearBotonesPuertosSerialesSensores()
        {
            button_configPuertoSerial_AIS.Enabled = false;
            button_configPuertoSerial_ANEMOMETRO.Enabled = false;
            button_configPuertoSerial_CORREDERA.Enabled = false;
            button_configPuertoSerial_DGPS.Enabled = false;
            button_configPuertoSerial_ECOSONDA.Enabled = false;
            button_configPuertoSerial_GPSBluetooth.Enabled = false;
            button_configPuertoSerial_GYRO.Enabled = false;
            button_configPuertoSerial_GPS.Enabled = false;
        }
        private void desbloquearBotonesPuertosSerialesSensores()
        {
            button_configPuertoSerial_AIS.Enabled = true;
            button_configPuertoSerial_ANEMOMETRO.Enabled = true;
            button_configPuertoSerial_CORREDERA.Enabled = true;
            button_configPuertoSerial_DGPS.Enabled = true;
            button_configPuertoSerial_ECOSONDA.Enabled = true;
            button_configPuertoSerial_GPSBluetooth.Enabled = true;
            button_configPuertoSerial_GYRO.Enabled = true;
            button_configPuertoSerial_GPS.Enabled = true;
        }
        private bool existePuertosSerialConfigurado()
        {
            //Puerto serial General
            if (ObjetoPuertoSerial.get_estadoPuertoSerial())//se comprueba si el puerto serial se encuentra configurado: true= configurado, false=no configurado
            {
                return true;
            }

            //puerto serial de GPS
            if (puertoSerial_GPS.get_estadoPuertoSerial())
            {
              
                return true;
            }

            //puertoSerial del DGPS
            if (puertoSerial_DGPS.get_estadoPuertoSerial())
            {
               
                return true;
            }

            //puertoSerial del Gyro
            if (puertoSerial_GYRO.get_estadoPuertoSerial())
            {
                
                return true;
            }

            //puertoSerial del ECOSONDA
            if (puertoSerial_ECOSONDA.get_estadoPuertoSerial())
            {
                
                return true;
            }

            //puertoSerial del ANEMOMETRO
            if (puertoSerial_ANEMOMETRO.get_estadoPuertoSerial())
            {
               
                return true;
            }

            //puertoSerial del CORREDERA
            if (puertoSerial_CORREDERA.get_estadoPuertoSerial())
            {
                
                return true;
            }

            //puertoSerial del AIS
            if (puertoSerial_AIS.get_estadoPuertoSerial())
            {
                
                return true;
            }

            //puertoSerial del GPSBluetooth
            if (puertoSerial_GPSBluetooth.get_estadoPuertoSerial())
            {
                
                return true;
            }

            return false;
            
        }
        public bool estaOcupadoPuertosSerial(string puerto)
        {
            //Puerto serial General
            if (ObjetoPuertoSerial.getNombrePuerto() == puerto && checkBox_navegacionBuque.Checked)//se comprueba si el puerto serial se encuentra configurado: true= configurado, false=no configurado
            {
                return true;
            }

            //puerto serial de GPS
            if (puertoSerial_GPS.getNombrePuerto() == puerto && checkBox_estadoGPS.Checked)
            {
                return true;
            }

            //puertoSerial del DGPS
            if (puertoSerial_DGPS.getNombrePuerto() == puerto && checkBox_estadoDGPS.Checked)
            {
                return true;
            }

            //puertoSerial del Gyro
            if (puertoSerial_GYRO.getNombrePuerto() == puerto && checkBox_estadoGyro.Checked)
            {
                return true;
            }

            //puertoSerial del ECOSONDA
            if (puertoSerial_ECOSONDA.getNombrePuerto() == puerto && checkBox_estadoEcosonda.Checked)
            {
                return true;
            }

            //puertoSerial del ANEMOMETRO
            if (puertoSerial_ANEMOMETRO.getNombrePuerto() == puerto && checkBox_estadoAnemometro.Checked)
            {
                return true;
            }

            //puertoSerial del CORREDERA
            if (puertoSerial_CORREDERA.getNombrePuerto() == puerto && checkBox_estadoCorredera.Checked)
            {
                return true;
            }

            //puertoSerial del AIS
            if (puertoSerial_AIS.getNombrePuerto() == puerto && checkBox_estadoAIS.Checked)
            {
                return true;
            }

            //puertoSerial del GPSBluetooth
            if (puertoSerial_GPSBluetooth.getNombrePuerto() == puerto && checkBox_gpsPropio.Checked)
            {
                return true;
            }

            return false;
        }

        private void comprobarEstadoBotonConfigPuerto()
        {
             if (checkBox_gpsPropio.Checked) // codigo envio de datos del sensor GPS Bluetooth
             {
                 button_configPuertoSerial_GPSBluetooth.Enabled = false;
             }
             if (checkBox_estadoGPS.Checked) // codigo envio de datos del sensor GPS
             {
                 button_configPuertoSerial_GPS.Enabled = false;
             }
             if (checkBox_estadoDGPS.Checked) // codigo envio de datos del sensor GPS
             {
                 button_configPuertoSerial_DGPS.Enabled = false;
             }
             if (checkBox_estadoGyro.Checked)// codigo envio de datos del sensor GYRO
             {
                 button_configPuertoSerial_GYRO.Enabled = false;
             }
             if (checkBox_estadoEcosonda.Checked)// codigo envio de datos del sensor ECOSONDA
             {
                 button_configPuertoSerial_ECOSONDA.Enabled = false;
             }
             if (checkBox_estadoCorredera.Checked)// codigo envio de datos del sensor CORREDERA
             {
                 button_configPuertoSerial_CORREDERA.Enabled = false;
             }
             if (checkBox_estadoAnemometro.Checked)// codigo envio de datos del sensor ANEMOMETRO
             {
                 button_configPuertoSerial_ANEMOMETRO.Enabled = false;
             }
             if (checkBox_estadoAIS.Checked)// codigo envio de datos del sensor AIS
             {
                 button_configPuertoSerial_AIS.Enabled = false;
             }
                       
        }

        public void colocarEtiquetaEstadoPuertoSerial()
        {
             etiqueta_puertoSerial_GPS = new EtiquetaEstadoPuertoSerial("GPS");
            this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_GPS);
            etiqueta_puertoSerial_GPS.Location = new Point(10, 10);

             etiqueta_puertoSerial_DGPS = new EtiquetaEstadoPuertoSerial("DGPS");
             this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_DGPS);
             etiqueta_puertoSerial_DGPS.Location = new Point(10, 115);

             etiqueta_puertoSerial_GYRO = new EtiquetaEstadoPuertoSerial("GYRO");
             this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_GYRO);
             etiqueta_puertoSerial_GYRO.Location = new Point(10, 220);


             etiqueta_puertoSerial_ECOSONDA = new EtiquetaEstadoPuertoSerial("ECOSONDA");
             this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_ECOSONDA);
             etiqueta_puertoSerial_ECOSONDA.Location = new Point(10, 325);

             etiqueta_puertoSerial_ANEMOMETRO = new EtiquetaEstadoPuertoSerial("ANEMOMETRO");
             this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_ANEMOMETRO);
             etiqueta_puertoSerial_ANEMOMETRO.Location = new Point(10, 430);

             etiqueta_puertoSerial_CORREDERA = new EtiquetaEstadoPuertoSerial("CORREDERA");
             this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_CORREDERA);
             etiqueta_puertoSerial_CORREDERA.Location = new Point(10, 535);

             etiqueta_puertoSerial_AIS = new EtiquetaEstadoPuertoSerial("AIS");
             this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_AIS);
             etiqueta_puertoSerial_AIS.Location = new Point(10, 640);

             //etiqueta_puertoSerial_GPSBluetooth = new EtiquetaEstadoPuertoSerial("GPS Bluetooth");
             //this.tabPage_estadoConexion.Controls.Add(etiqueta_puertoSerial_GPSBluetooth);
             //etiqueta_puertoSerial_GPSBluetooth.Location = new Point(10, 745);
        }

    }// fin de clase 
}
