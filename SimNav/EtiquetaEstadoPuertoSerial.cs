using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimNav
{
    public partial class EtiquetaEstadoPuertoSerial : UserControl
    {
        public EtiquetaEstadoPuertoSerial(string tipoSensor)
        {
           
            InitializeComponent();
            label_Sensor.Text = tipoSensor;
        }

        public void set_etiquetaEstadoPuertoSerial(string tiposensor, string puerta, string vel, string bitdatos,  string bitparada, string paridad, string estado)
        {
            this.label_bitDatos.Text = bitdatos;
            this.label_bitParada.Text = bitparada;
            this.label_estadoTransmision.Text= estado;
            this.label_paridad.Text= paridad;
            this.label_puertoCom.Text = puerta;
            this.label_Sensor.Text = tiposensor;
            this.label_velocidadTransmicion.Text = vel;

        }

        public void set_etiquetaEstadoPuerto(PuertoSerial puerto)
        {
            this.label_bitDatos.Text = puerto.getBitDatos();
            this.label_bitParada.Text = puerto.getBitParada();
            this.label_estadoTransmision.Text = "Transmitiendo";
            this.label_paridad.Text = puerto.getParidad();
            this.label_puertoCom.Text = puerto.getNombrePuerto();
            this.label_velocidadTransmicion.Text = puerto.getVelocidadPuerto();

        }

        public void set_estadoTransmision(string estado)
        {
            this.label_estadoTransmision.Text = estado;
        }


    }
}
