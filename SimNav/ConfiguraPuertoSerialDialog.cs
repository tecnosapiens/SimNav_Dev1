using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SimNav
{
    public partial class ConfiguraPuertoSerialDialog : Form
    {

        Form1 mainForm;
        PuertoSerial puertoSerialTemp;
       
      

        public ConfiguraPuertoSerialDialog()
        {
            InitializeComponent();
          
           
        }

        //public ConfiguraPuertoSerialDialog(Form1 mainForm)
        //{
        //    this.mainForm = mainForm;
           
        //    InitializeComponent();

        //}

        public ConfiguraPuertoSerialDialog(Form1 mainForm, PuertoSerial ObjetoPuertoSerial)
        {
            this.mainForm = mainForm;
            puertoSerialTemp = ObjetoPuertoSerial;

            InitializeComponent();

        }


        private void ConfiguraPuertoSerialDialog_Load(object sender, EventArgs e)
        {
            inicializarPuertos();
        }

        private void inicializarPuertos()
		 {
			 

			try
			   {
                   // Se obtiene la lista de los puertos disponibles en el equipo
                   string[] ports = System.IO.Ports.SerialPort.GetPortNames();

                  
                   // se borra la lista del comboBox
                   comboBox_ptoComunicaciones.Items.Clear();
                                    

                   // Agrega los nombres de los puertos disponibles al comboBox del dialogo
                   foreach (string port in ports)
                   {
                       if (!mainForm.estaOcupadoPuertosSerial(port))
                       {
                           
                           comboBox_ptoComunicaciones.Items.Add(port);
                           
                       }
                       //else
                       //{
                       //    comboBox_ptoComunicaciones.ForeColor = Color.Black;
                       //    comboBox_ptoComunicaciones.Items.Add(port);
                       //}
                       
                       
                       
                       
                   }

               			   
               }
               catch (Exception e)
               {
                  MessageBox.Show(e.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               }             
		

		 }

        //private void button_aceptarConfigPuertoSerial_Click(object sender, EventArgs e)
        //{
        //    string puerto;
        //    puerto = comboBox_ptoComunicaciones.Text;
        //    char[] caracteres = {' '} ;
        //    string[] split = puerto.Split(caracteres );
           

        //    if (split.Length == 1)
        //    {
        //        mainForm.ObjetoPuertoSerial.setPuertoSerial(comboBox_ptoComunicaciones.Text,
        //                                                comboBox_bitParada.Text,
        //                                                comboBox_bitsDatos.Text,
        //                                                comboBox_paridad.Text,
        //                                                comboBox_velocidadPuerto.Text,
        //                                                comboBox_tiempo.Text);
        //        mainForm.listBox_visorDatosNmea.Items.Add("Puerto Serial Configurado");
        //        mainForm.button_configurarPuerto.Enabled = false;
        //        mainForm.activarBotonTransmitir();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Debe seleccionar un puerto de comunicación", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        mainForm.listBox_visorDatosNmea.Items.Add("El Puerto Serial no se ha Configurado");
        //    }



            
            
           
        //}

        private void button_aceptarConfigPuertoSerial_Click(object sender, EventArgs e)
        {
            string puerto;
            puerto = comboBox_ptoComunicaciones.Text;
            char[] caracteres = { ' ' };
            string[] split = puerto.Split(caracteres);


            if (split.Length == 1)
            {
                puertoSerialTemp.setPuertoSerial(comboBox_ptoComunicaciones.Text,
                                                        comboBox_bitParada.Text,
                                                        comboBox_bitsDatos.Text,
                                                        comboBox_paridad.Text,
                                                        comboBox_velocidadPuerto.Text,
                                                        comboBox_tiempo.Text);
                mainForm.listBox_visorDatosNmea.Items.Add("Puerto Serial Configurado");
                mainForm.button_configurarPuerto.Enabled = false;
                mainForm.activarBotonTransmitir();
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un puerto de comunicación", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mainForm.listBox_visorDatosNmea.Items.Add("El Puerto Serial no se ha Configurado");
            }






        }

        private void button_cancelarConfiguracionPuerto_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
       
    }
}
