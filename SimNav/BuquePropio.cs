using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimNav
{
    class BuquePropio
    {
        #region Declaracion de variables de la clase
        int gradoLat;
        int minLat;
        int segLat;
        string dirLat;

        int gradoLon;
        int minLon;
        int segLon;
        string dirLon;
               
        int velocidad;
        double velocidadKM;
        double rumbo;
        int anguloTimon;
        int profundidad;
        double profundidadFeet;
        double profundidadFantom;

        int vientoDireccion;
        int vientoVelocidad;

        double latitud;
        double longitud;
        double latitudInicial;
        double longitudInicial;
        double latFinVector;
        double lonFinVector;

        string horaUTC;
        string fechaUTC;
        string zonaLocal;

        double deltaDistancia;

        public List<PuntoGeografico> trayectoria;
        int contadorTiempo;



        #endregion 

        public BuquePropio()
        {
            gradoLat = 0;
            minLat = 0;
            segLat = 0;
            dirLat = "N";

            gradoLon = 0;
            minLon = 0;
            segLon = 0;
            dirLon = "W";
                        
            velocidad = 0;
            velocidadKM = 0.0;
            rumbo = 0;
            anguloTimon = 0;
            profundidad = 0;
            profundidadFeet = 0.0;
            profundidadFantom = 0.0;

            vientoDireccion = 0;
            vientoVelocidad = 0;

            latitud = 0.0;
            longitud = 0.0;
            latitudInicial = 0.0;
            longitudInicial = 0.0;
            latFinVector = 0.0;
            lonFinVector = 0.0;

            horaUTC =  "";
            fechaUTC = "";
            zonaLocal = "";

            deltaDistancia = 0.0;
            trayectoria = new List<PuntoGeografico>();
            contadorTiempo = 0; ;

        }

        #region Funciones set de variables de la clase
        public void setDatosBuquePropio(int gradolat, int minlat, int seglat, string dirlat, int gradolon, int minlon, int seglon, string dirlon, int vel, int dirBuque, int prof, int vientoDir, int vientoVel)
        {
            gradoLat = gradolat;
            minLat = minlat;
            segLat = seglat;
            dirLat = dirlat;

            gradoLon = gradolon;
            minLon = minlon;
            segLon = seglon;
            dirLon = dirlon;
            
            latitud = convertirLatitud(gradolat, minlat, seglat, dirlat);
            longitud = convertirLongitud(gradolon, minlon, seglon, dirlon);

            latitudInicial = convertirLatitud(gradolat, minlat, seglat, dirlat);
            longitudInicial = convertirLongitud(gradolon, minlon, seglon, dirlon);

            velocidad = vel;
            rumbo = dirBuque;
            profundidad = prof;
            profundidadFeet = prof * (double)3.28;
            profundidadFantom = prof * (double)0.5468;

            vientoDireccion = vientoDir;
            vientoVelocidad = vientoVel;

            ObtenerUTCString();
            convertirVelocidadKM();

        }

        public void setLatitud(double lat) { latitud = lat; }
        public void setLongitud(double lon) { longitud = lon; }
        
        public void setVelocidad(int vel) { velocidad = vel; }
        public void setRumbo(int dirBuque) { rumbo = dirBuque; }
        public void setProfundidad(int sonda)
        {
            profundidad = sonda;
            profundidadFeet = sonda * (double)3.28;
            profundidadFantom = sonda * (double)0.5468;

        }

        public void setVientoDireccion(int dirViento) { vientoDireccion = dirViento; }
        public void setVientoVelocidad(int velViento) { vientoVelocidad = velViento; }
        
        // Cambio de variables de rumbo
        public void set_anguloTimon(int timon){anguloTimon = timon;}
        #endregion 

        #region Funciones get de las variables de la clase
        public double getLatitud() { return latitud; }
        public double getLongitud() { return longitud; }

        public List<PuntoGeografico> getTrayectoria() { return trayectoria; }

        public double getLatitudInicial() { return latitudInicial; }
        public double getLongitudInicial() { return longitudInicial; }

        public double getLatitudFinVector() { return latFinVector; }
        public double getLongitudFinVector() { return lonFinVector; }
        
        public int getVelocidad() { return velocidad; }
        public double getRumbo() { return rumbo; }
        public int getProfundidad() { return profundidad; }
        public double getProfundidadFeet() { return profundidadFeet; }
        public double getProfundidadFantom() { return profundidadFantom; }

        public int getVientoDireccion() { return vientoDireccion; }
        public int getVientoVelocidad() { return vientoVelocidad; }

        public string getLatitudStr()
        {

            return gradoLat.ToString() + "° " + minLat.ToString() + "' " + segLat.ToString() + "'' " + dirLat; 
        }

        public string getLongitudStr()
        {
            return gradoLon.ToString() + "° " + minLon.ToString() + "' " + segLon.ToString() + "'' " + dirLon;
        }

        public string getVelocidadStr() { return velocidad.ToString(); }
        public string getRumboStr() { return rumbo.ToString("000.00"); }
        public string getProfundidadStr() { return profundidad.ToString(); }

        public string getVientoDireccionStr() { return vientoDireccion.ToString(); }
        public string getVientoVelocidadStr() { return vientoVelocidad.ToString(); }
        #endregion 


        #region Funciones de transformacion de datos a formatos de salida y calculo
        private double convertirLatitud(int grado, int minuto, int segundo, string dirlat)
        {
            double lat;
            double decSeg = segundo / 60;
            double decMin = (minuto + decSeg)/60;

            lat = grado + decMin;

            if (dirlat == "S")
            {
                lat = lat * (-1);
            }

            return lat;

            
        }

        private double convertirLongitud(int grado, int minuto, int segundo, string dirlon)
        {
            double lon;
            double decSeg = segundo / 60;
            double decMin = (minuto + decSeg)/60;

            lon = grado + decMin;

            if(dirlon == "W")
            {
                lon = lon * (-1);
            }

            return lon;


        }

        /**
		* Esta función xxxxxxxxx
		* @param double latitud --> 
		* @param double longitud --> 
		* @param ref string cadenaLatitud --> 
		* @param ref string cadenaLongitud --> 
		*/
        public void actualizarCoordenadasDecimalToStringMinSeg(double latitud, double longitud)
        {
            

            double minutos;
            double grados;
            double segundos;
            double entero, enteroMin, decMin, decSeg;

            

            if (longitud < 0)
            { dirLon = "W"; longitud = Math.Abs(longitud); }
            else
            { dirLon = "E"; }

            if (latitud < 0)
            { dirLat = "S"; latitud = Math.Abs(latitud); }
            else
            { dirLat = "N"; }

           

            if (latitud < 90 || latitud > -90 || longitud < 180 || longitud > -180)
            {
                decMin = latitud - (entero = Math.Floor(latitud));
                minutos = decMin * 60;

                decSeg = minutos - (enteroMin = Math.Floor(minutos));
                segundos = decSeg * 60;

                grados = entero;
                minutos = enteroMin;

                if (grados < 0) grados = grados * (-1);
                if (minutos < 0) minutos = minutos * (-1);
                if (segundos < 0) segundos = segundos * (-1);

                gradoLat = (int)grados;
                minLat = (int) minutos;
                segLat = (int)segundos;

                
                //+++++++++++++++++++++    conversion longitud
                decMin = longitud - (entero = Math.Floor(longitud));
                minutos = decMin * 60;
                decSeg = minutos - (enteroMin = Math.Floor(minutos));
                segundos = decSeg * 60;
                grados = entero;
                minutos = enteroMin;
                if (grados < 0) grados = grados * (-1);
                if (minutos < 0) minutos = minutos * (-1);
                if (segundos < 0) segundos = segundos * (-1);

                gradoLon = (int)grados;
                minLon = (int)minutos;
                segLon = (int)segundos;
                
            }
        }

        private void ObtenerUTCString()
		 {
			
			// Get the local time zone and the current local time and year.
				TimeZone localZone = TimeZone.CurrentTimeZone;
				DateTime currentDate = DateTime.Now;
				DateTime currentTime = currentDate.ToUniversalTime();

				horaUTC = currentTime.Hour.ToString("00")+ currentTime.Minute.ToString("00") + currentTime.Second.ToString("00");
				fechaUTC = currentDate.Day.ToString("00") + "," + currentDate.Month.ToString("00") + "," + currentDate.Year.ToString("0000");
				zonaLocal = "05,00";
            
				
		 }

        private void convertirVelocidadKM()
		 {

             velocidadKM = velocidad * 1.85;



         }
        #endregion 

#region Funciones para el calculo de posicion por buque navegando

        public void actualizarPosicionGeografica(int intervaloTiempo)
        {
            contadorTiempo++;
            calculaDistancia(velocidad, intervaloTiempo, ref deltaDistancia);
            actualizarRumbo(rumbo, anguloTimon);
           
            obtenerPuntoXMarcacion_Distancia(rumbo, deltaDistancia, latitud, longitud, ref latitud, ref longitud);
            if (contadorTiempo == 60)
            {
                contadorTiempo = 0;
                PuntoGeografico punto = new PuntoGeografico(latitud, longitud);
                trayectoria.Add(punto);
            }

            actualizarCoordenadasDecimalToStringMinSeg(latitud, longitud);

            
        }

        private void obtenerPuntoXMarcacion_Distancia(double rumbo, double factorDistancia, double lat1, double lon1, ref double latitudActual, ref double  longitudActual)
        {
            

            double rad =  Math.PI/ 180;
			
			//deltaDistancia = (velocidadActual * (deltaTiempo/3600000));
            rumbo = rumbo * rad;
			latitudActual = (lat1 + (factorDistancia/60) * (Math.Cos(rumbo))); // eje Y
			longitudActual = (lon1 + (factorDistancia/60) * (Math.Sin(rumbo))); // eje X
        }

        private void calculaDistancia(int velocidad, int tiempo, ref double dist)
        {
			
			double deltaTiempo = tiempo/(double)3600000;
							        
			//deltaDistancia = (velocidad * (tiempo/3600000));
			dist = (velocidad * deltaTiempo);

        }

        public void actualizarPosicionVector()
        {
        //    double latIniVec = 0;
        //    double lonIniVec = 0;

            //ObtenerPuntoXMv_Dist(latitud, longitud, rumbo+45, 2, ref latIniVec, ref lonIniVec);
            //ObtenerPuntoXMv_Dist(latitud-0.05, longitud-0.05, rumbo, velocidad, ref latFinVector, ref lonFinVector);

            ObtenerPuntoXMv_Dist(latitud, longitud, rumbo, velocidad, ref latFinVector, ref lonFinVector);
            

        }

        public void actualizarRumbo(double rumboActual, int variacion)
        {
            if (anguloTimon != 0)
            {
                rumbo = rumbo + (anguloTimon/10);

            }
            
            if (rumbo < 0)
            {
                rumbo = 359;
            }
            if (rumbo > 359)
            {
                rumbo = 0;
            }
        }


        public void ObtenerPuntoXMv_Dist(double lat1, double lon1, double rumbo, double distancia, ref double lat2, ref double lon2)
        {
            double rad = Math.PI / 180;

            rumbo = rumbo * rad;
            lon2 = (lon1 + ((distancia / 60) * (Math.Sin(rumbo))));
            lat2 = (lat1 + ((distancia / 60) * (Math.Cos(rumbo))));
        }

        /**
		* Esta función xxxxxxxxx
		* @param double lat1 --> 
		* @param double lon1 --> 
		* @param double lat2 --> 
		* @param double lon2 --> 
		* @param ref double rumbo --> 
		* @param ref double distancia --> 
		*/
        public void ObtenerDistancia(double lat1, double lon1, double lat2, double lon2, ref double distancia)
        {
            double cateto_opuesto, cateto_adyacente, hipotenusa;
            //latitud y longitud del primer punto

            if (lat1 < 0) lat1 = lat1 * (-1);
            if (lat2 < 0) lat2 = lat2 * (-1);
            if (lon1 < 0) lon1 = lon1 * (-1);
            if (lon2 < 0) lon1 = lon1 * (-1);

            cateto_opuesto = Math.Abs((lat1 - lat2)); //diferencia de latitudes entre PCR1 y PCR2
            cateto_adyacente = Math.Abs((lon1 - lon2));//diferencia de longitudes entre PCR1 y PCR2

            hipotenusa = Math.Sqrt(Math.Pow(cateto_opuesto, 2) + Math.Pow(cateto_adyacente, 2));
            distancia = hipotenusa * 60;
        }
 #endregion 

#region Funciones para la impresion de las tramas NMEA0183 de sensores de navegacion
        /* */
        public string[] getTramasNMEA_GPS()
        {
            string[] dataSalida = new string[3];
            string data = "";
            string checksum = "";


            //$GPGLL,1807.52,N,09425.15,W,205904,A,A*58
            data = "GPGLL," + latitud.ToString("00.00") + "," + dirLat + "," + longitud.ToString("000.00") + "," + dirLon + "," + horaUTC + ",A";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";

            //$GPVTG,220,T,216,M,00.0,N,00.1,K,A*27
            data = "GPVTG," + rumbo.ToString("0.0") + ",T," + rumbo.ToString("0.0") + ",M," + velocidad.ToString("0.0") + ",N," + velocidadKM.ToString("0.0") + ",N," + ",A";
            checksum = this.generarChecksum(data);
            dataSalida[1] = "$" + data + "*" + checksum + "\r";

            //$GPGGA,205905,1807.5191,N,09425.1493,W,1,06,02.0,15.2,M,-8.3,M,,*48
            data = "GPGLL," + horaUTC + "," + latitud.ToString("00.00") + "," + dirLat + "," + longitud.ToString("000.00") + "," + dirLon + ",1,06,02.0,15.2,M,-8.3,M,,";
            checksum = this.generarChecksum(data);
            dataSalida[2] = "$" + data + "*" + checksum + "\r";

            return dataSalida;
            
        }

        public string[] getTramasNMEA_GPSPropio()
        {

            //$GPGGA,002048.548,3727.2131,S,07224.5627,W,0,0,,127.9,M,22.1,M,,*42
            //$GPRMC,002048.548,V,3727.2131,S,07224.5627,W,0.00,0.00,300609,,,N*77
            //$GPGSA,A,1,,,,,,,,,,,,,,,*1E

            string[] dataSalida = new string[2];
            string data = "";
            string checksum = "";
            string latGGA = "";
            string lonGGA = "";

            CoordenadaGGA(latitud, longitud, ref latGGA, ref lonGGA);


            //$GPGLL,1807.52,N,09425.15,W,205904,A,A*58
            data = "GPGGA," + horaUTC + "," + latGGA + "," + dirLat + "," + lonGGA + "," + dirLon + ",1,06,02.0,15.2,46.9,M,,";
            //data = "GPGGA," + latGGA + "," + dirLat + "," + lonGGA + "," + dirLon + "," + horaUTC + ",A";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";

            //$GPRMC,002051.548,V,3727.2131,S,07224.5627,W,0.00,0.00,300609,,,N*7F

            data = "GPRMC," + horaUTC + "," + "V" + "," + latGGA + "," + dirLat + "," + lonGGA + "," + dirLon + "," + velocidad.ToString("0.0") + "," + rumbo.ToString("0.0") + ",300609,,,N";
            checksum = this.generarChecksum(data);
            dataSalida[1] = "$" + data + "*" + checksum + "\r";

            ////$GPGGA,205905,1807.5191,N,09425.1493,W,1,06,02.0,15.2,M,-8.3,M,,*48
            //data = "GPGLL," + horaUTC + "," + latitud.ToString("0.00") + "," + dirLat + "," + longitud.ToString("0.00") + "," + dirLon + ",1,06,02.0,15.2,M,-8.3,M,,";
            //checksum = this.generarChecksum(data);
            //dataSalida[2] = "$" + data + "*" + checksum + "\r";

            return dataSalida;

        }

        private void CoordenadaGGA(double latitud, double longitud, ref string latGGA, ref string lonGGA)
        {
            double latSinSigno = Math.Abs(latitud);
            int latSola = (int)Math.Truncate(latSinSigno);
            double decimaMin = Math.Abs(latSinSigno - latSola);
            decimaMin = decimaMin * (double)60;
            latGGA = latSola.ToString("00") + decimaMin.ToString("00.0000");


            double lonSinSigno = Math.Abs(longitud);
            int lonSola = (int)Math.Truncate(lonSinSigno);
            decimaMin = Math.Abs(lonSinSigno - lonSola);
            decimaMin = decimaMin * 60;
           

            lonGGA = lonSola.ToString("00") + decimaMin.ToString("00.0000");


        }

        public string[] getTramasNMEA_DGPS()
        {
            string[] dataSalida = new string[3];
            string data = "";
            string checksum = "";


            //$GPGLL,1807.52,N,09425.15,W,205904,A,A*58
            data = "GPGLL," + latitud.ToString("00.00") + "," + dirLat + "," + longitud.ToString("000.00") + "," + dirLon + "," + horaUTC + ",A";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";

            //$GPVTG,220,T,216,M,00.0,N,00.1,K,A*27
            data = "GPVTG," + rumbo.ToString("0.0") + ",T," + rumbo.ToString("0.0") + ",M," + velocidad.ToString("0.0") + ",N," + velocidadKM.ToString("0.0") + ",N," + ",A";
            checksum = this.generarChecksum(data);
            dataSalida[1] = "$" + data + "*" + checksum + "\r";

            //$GPZDA,162337,26,09,2008,05,00*48
            data = "GPZDA," + horaUTC + "," + fechaUTC + "," + zonaLocal + ",";
            checksum = this.generarChecksum(data);
            dataSalida[2] = "$" + data + "*" + checksum + "\r";


            return dataSalida;

        }

        public string[] getTramasNMEA_GYRO()
        {
            string[] dataSalida = new string[1];
            string data = "";
            string checksum = "";


            // $INHDT,214.71,T*14
            data = "INHDT," + rumbo.ToString("0.0") + ",T,";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";
            


            return dataSalida;

        }

        public string[] getTramasNMEA_CORREDERA()
        {
            string[] dataSalida = new string[3];
            string data = "";
            string checksum = "";


            //$VDVBW,0.89,-0.13,A,0.00,0.00,A,,V,,V*7F
            data = "VDVBW," + velocidad.ToString("0.0") + "," + velocidad.ToString("0.0") + ",A" + velocidad.ToString("0.0") + "," + velocidad.ToString("0.0") + ",V";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";

            //$VDVLW,847732.00,N,2413.97,N*58
            data = "$VDVLW," + "0.0,N,0.0,N";
            checksum = this.generarChecksum(data);
            dataSalida[1] = "$" + data + "*" + checksum + "\r";

            //$VDDPT,5.38,0.5,200.0*69
            data = "VDDPT,0.00,0.0,0.0";
            checksum = this.generarChecksum(data);
            dataSalida[2] = "$" + data + "*" + checksum + "\r";


            return dataSalida;

        }

        public string[] getTramasNMEA_ECOSONDA()
        {
            string[] dataSalida = new string[2];
            string data = "";
            string checksum = "";


            //$SDDPT,,-0.0,????*78
            data = "SDDPT," + profundidad.ToString("0.0") + ",-0.0,";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";
            //$SDDBT2000,M,,F*60
            data = "SDDBT,"+profundidad.ToString("0.0")+",F,1000,M,000.00,F";
            checksum = this.generarChecksum(data);
            dataSalida[1] = "$" + data + "*" + checksum + "\r";
          
            return dataSalida;

        }

        public string[] getTramasNMEA_ANEMOMETRO()
        {
            string[] dataSalida = new string[1];
            string data = "";
            string checksum = "";


            //$WIMWV,109,R,009,N,A*22
            data = "WIMWV," + vientoDireccion.ToString("0.0") + ",R," + vientoVelocidad.ToString("0.0") + ",N,A";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";
            

            return dataSalida;

        }

        public string[] getTramasNMEA_AIS()
        {
            string[] dataSalida = new string[3];
            string data = "";
            string checksum = "";


            //!AIVDO,1,1,,,1000avw000I?j:L:Gi;87VfF0000,0*08
            data = "AIVDO,1,1,,,1000avw000I?j:L:Gi;87VfF0000,0";
            checksum = this.generarChecksum(data);
            dataSalida[0] = "$" + data + "*" + checksum + "\r";

            //$AIALR,000000.00,001,V,V,AIS: Tx Malfunction*6B
            data = "AIALR,000000.00,001,V,V,AIS";
            checksum = this.generarChecksum(data);
            dataSalida[1] = "$" + data + "*" + checksum + "\r";

            //!AIVDM,1,1,,A,1592ub0000I?kd`:H;l:qbRP06hh,0*2F
            dataSalida[2] = "AIVDM,1,1,,A,1592ub0000I?kd`:H;l:qbRP06hh,0";
            checksum = this.generarChecksum(data);
            dataSalida[2] = "$" + data + "*" + checksum + "\r";

           
            return dataSalida;

        }

        #endregion 


        private string generarChecksum(string s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
                sum = sum ^ (int)(s[i]);
            return string.Format("{0:X2}", sum);
        }


       
        // funcion de verificacion de checksum en una cadena
        //private bool checksum(string s, string checksum)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < s.Length; i++)
        //        sum = sum ^ (int)(s[i]);
        //    return (checksum == string.Format("{0:X2}", sum));
        //}


    }//fin de clase
}
