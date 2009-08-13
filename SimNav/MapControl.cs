using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace SimNav
{
    public partial class MapControl : UserControl
    {

        public bool flagMapaAbierto;
        
        int handle;
       
        
        double CoordX;
        double CoordY;

        double CoordXSel;
        double CoordYSel;
       


        private Bitmap bmMem;//bitmap del control que se trabajara
        Graphics mem;
        Pen pluma;
        Pen plumaTrayectoria;
        Font fuente;
        SolidBrush brochaTexto;
        Form1 mainForm;

        public bool verTrayectoria;
        bool enSeleccionCoord;
        bool estaSelPos;

        List<int> handleMap; //guarda los handles de las capas cartograficas abiertas



        public MapControl(Form1 mainForma)
        {
            flagMapaAbierto = false;
            handle = 0;
            CoordX = 0;
            CoordY = 0;
            CoordXSel = 0;
            CoordYSel = 0;
       
            InitializeComponent();
            mainForm = mainForma;
            verTrayectoria = false;
            enSeleccionCoord = false;
            estaSelPos = false;

           
            
           
        }

        private void MapControl_Load(object sender, EventArgs e)
        {
            //**Inicializando el componente legend1 para que tome control del canvas de MapWinGIS**//
            legend1.Map = (MapWinGIS.Map)axMap1.GetOcx();
            
            handleMap = new List<int>();
            //ObjGraficado = this.pictureBox1.CreateGraphics();
            bmMem = new Bitmap(this.axMap1.Width, this.axMap1.Height);
            mem = Graphics.FromImage(bmMem);
            mem = axMap1.CreateGraphics();

            pluma = new Pen(Color.Red, 2);
            plumaTrayectoria = new Pen(Color.Black, 2);
            fuente = new Font("Arial", 8);
            brochaTexto = new SolidBrush(Color.Red);

           // string directorioActual = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
            string directorioActual = System.Environment.CurrentDirectory;
            //string pathFichero = directorioActual + "\\World\\world_wgs84.shp";
            string pathFichero = directorioActual + "\\world_wgs84.shp";
            AddLayerInicial(pathFichero);

            

            //AddLayerInicial(@"\World\world_wgs84.shp");
            //AddLayerInicial(@"C:\Users\ROCA\SimNav\SimNav\World\world_wgs84.shp");

        }

        private void toolStrip1_toolLayers_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            string tag = (string)e.ClickedItem.Tag;
            switch (tag)
            {
                case "Añadir":
                    AddLayer();
                    break;
                case "Remover":
                    legend1.Layers.Remove(legend1.SelectedLayer);
                    legend1.Refresh();
                    
                    //int handleRemove = handleMap.Count - 1;
                    //if (handleRemove >= 0)
                    //{
                    //    axMap1.RemoveLayer(handleMap[handleRemove]);
                    //    handleMap.RemoveAt(handleRemove);
                    //}
                    break;
                case "Limpiar":
                    legend1.Layers.Clear();
                    handleMap.Clear();
                    //axMap1.RemoveAllLayers();
                    break;
                case "ZoomIn":
                    axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
                    refreshMapa();
                    break;
                case "ZoomOut":
                    axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
                    refreshMapa();
                    break;
                case "Pan":
                    axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
                    refreshMapa();
                    break;
                case "FullExtents":
                    axMap1.ZoomToMaxExtents();
                    break;
                
            }
        }

        private void AddLayer()
        {
            MapWinGIS.Shapefile shpfileOpen;
            string[] fileNombres;


            MapWinGIS.Grid grid;
            MapWinGIS.GridColorScheme gridScheme;
            MapWinGIS.Image image;
            MapWinGIS.Utils utils;


            OpenFileDialog openDlg = new OpenFileDialog();
            openDlg.Multiselect = true;

            int handle;
            string ext;


            //initialize dialog
            openDlg.Filter = "Supported Formats|*.shp;*.bgd;*asc;*.jpg|Shapefile (*.shp)|*.shp|Binary Grids (*.bgd)|*.bgd|ASCII Grids (*.asc)|*.asc |World File (*.jpg)|*.jpg";
            openDlg.CheckFileExists = true;

            if (openDlg.ShowDialog(this) == DialogResult.OK)
            {
                fileNombres = openDlg.FileNames;
                int totalNombres = fileNombres.Length;
                for (int j = 0; j < totalNombres; j++)
                {

                    //get the extension of the file
                    ext = System.IO.Path.GetExtension(openDlg.FileNames[j]);

                    if (ext == ".bgd" || ext == ".asc" || ext == ".jpg")
                    {
                        if (ext == ".jpg")
                        {
                            image = new MapWinGIS.Image();

                            // open image world file
                            image.Open(openDlg.FileNames[j], MapWinGIS.ImageType.JPEG_FILE, true, null);
                            handle = legend1.Layers.Add(image, true);
                            legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(image.Filename));
                            //handle = axMap1.AddLayer(image, true);
                            handleMap.Add(handle);

                                                       
                        }
                        else
                        {
                            
                            utils = new MapWinGIS.UtilsClass();
                            gridScheme = new MapWinGIS.GridColorScheme();
                            grid = new MapWinGIS.GridClass();

                            //open the grid
                            grid.Open(openDlg.FileName, MapWinGIS.GridDataType.UnknownDataType, true, MapWinGIS.GridFileType.UseExtension, null);

                            //create a coloring scheme for the image
                            gridScheme.UsePredefined(System.Convert.ToDouble(grid.Minimum), System.Convert.ToDouble(grid.Maximum), MapWinGIS.PredefinedColorScheme.SummerMountains);

                            //convert the grid to a image
                            image = utils.GridToImage(grid, gridScheme, null);

                            //add the image to the legend and map
                            handle = axMap1.AddLayer(image, true);
                            handleMap.Add(handle);

                            grid.Close();

                            //utils = new MapWinGIS.UtilsClass();
                            //gridScheme = new MapWinGIS.GridColorScheme();
                            //grid = new MapWinGIS.GridClass();

                            ////open the grid
                            //grid.Open(openDlg.FileName, MapWinGIS.GridDataType.UnknownDataType, true, MapWinGIS.GridFileType.UseExtension, null);

                            ////create a coloring scheme for the image
                            //gridScheme.UsePredefined(System.Convert.ToDouble(grid.Minimum), System.Convert.ToDouble(grid.Maximum), MapWinGIS.PredefinedColorScheme.SummerMountains);

                            ////convert the grid to a image
                            //image = utils.GridToImage(grid, gridScheme, null);

                            ////add the image to the legend and map
                            //handle = axMap1.AddLayer(image, true);
                            ////handle = legend1.Layers.Add(image, true);

                            //if (legend1.Layers.IsValidHandle(handle))
                            //{
                            //    //set the layer name
                            //    legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(grid.Filename));

                            //    //set's the legend layer type, this displays a default icon in the legend (line shapefile, point shapefile,polygon shapefile,grid,image)
                            //    legend1.Layers.ItemByHandle(handle).Type = MapWindow.Interfaces.eLayerType.Grid;

                            //    //set coloring scheme
                            //    //when applying a coloring scheme to a shapfile use axMap1.ApplyLegendColors(ShapefileColorScheme)
                            //    //when applying a coloring scheme for a grid or image use axMap1.SetImageLayerColorScheme(handle,GridColorScheme);
                            //    axMap1.SetImageLayerColorScheme(legend1.SelectedLayer, gridScheme);
                            //    legend1.Layers.ItemByHandle(legend1.SelectedLayer).Refresh();
                            //}


                            //close the grid
                            //grid.Close();
                        }
                       

                    }
                    else if (ext == ".shp")
                    {
                        shpfileOpen = new MapWinGIS.ShapefileClass();

                        //open the shapefile
                        shpfileOpen.Open(openDlg.FileNames[j], null);


                        //add the shapefile to the map and legend
                        handle = legend1.Layers.Add(shpfileOpen, true);
                        legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(shpfileOpen.Filename));
                        //handle = axMap1.AddLayer(shpfileOpen, true);
                        handleMap.Add(handle);
                        string oldProj = shpfileOpen.Projection;
                        
                        // bool status = MapWinGeoProc.SpatialReference.ProjectShapefile(sourceProj, destProj, inputSF, resultSF)
                        this.flagMapaAbierto = true;

                    }
                }

            }
          
        }


        private void AddLayerInicial(string file)
        {
            MapWinGIS.Shapefile shpfileOpen;
            shpfileOpen = new MapWinGIS.ShapefileClass();

            try
            {
                //open the shapefile
                shpfileOpen.Open(file, null);


                //add the shapefile to the map and legend
                //handle = axMap1.AddLayer(shpfileOpen, true); //sin control legend
                handle = legend1.Layers.Add(shpfileOpen, true);
                legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(shpfileOpen.Filename));
                handleMap.Add(handle);
                string oldProj = shpfileOpen.Projection;

                // bool status = MapWinGeoProc.SpatialReference.ProjectShapefile(sourceProj, destProj, inputSF, resultSF)
                this.flagMapaAbierto = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
             

        }

        private void axMap1_MouseMoveEvent(object sender, AxMapWinGIS._DMapEvents_MouseMoveEvent e)
        {
            if (this.flagMapaAbierto)
            {
                           

                //handle = this.axMap1.get_LayerHandle(0);
                //shpfile = (MapWinGIS.Shapefile)this.axMap1.get_GetObject(handle);

                // Convertimos las coordenadas de pantalla en una proyeccion de coordenadas
                this.axMap1.PixelToProj(e.x, e.y, ref CoordX, ref CoordY);

                if (enSeleccionCoord)
                {
                    refreshMapa();
                    mem.DrawString(CoordY.ToString("0.000"), fuente, brochaTexto, e.x+10, e.y);
                    mem.DrawString(CoordX.ToString("0.000"), fuente, brochaTexto, e.x+10, e.y-10);

                    if (estaSelPos)
                    {
                        double latPixel = 0.0;
                        double longPixel = 0.0;
                        this.axMap1.ProjToPixel(CoordXSel, CoordYSel, ref longPixel, ref latPixel);
                                                
                        brochaTexto.Color = Color.Black;
                        mem.DrawString(CoordYSel.ToString("0.000"), fuente, brochaTexto, (float)longPixel + 10, (float)latPixel);
                        mem.DrawString(CoordXSel.ToString("0.000"), fuente, brochaTexto, (float)longPixel + 10, (float)latPixel - 10);
                        brochaTexto.Color = Color.Red;
                        pluma.Color = Color.Black;
                        mem.DrawEllipse(pluma, (float)longPixel - 5, (float)latPixel - 5, (float)10, (float)10);
                        pluma.Color = Color.Red;

                    }
                }

                this.toolStripStatusLabel1.Text = "LAT: " + CoordY.ToString("0.000");
                this.toolStripStatusLabel2.Text = "LON: " + CoordX.ToString("0.000");

                
            }
        }

        private void axMap1_MouseUpEvent(object sender, AxMapWinGIS._DMapEvents_MouseUpEvent e)
        {
            if (enSeleccionCoord)
            {
                double lat = 0.0;
                double lon = 0.0;
                this.axMap1.PixelToProj(e.x, e.y, ref lon, ref lat);
                mainForm.setCoordenadasCanvas(lat, lon);
                CoordXSel = lon;
                CoordYSel = lat;
       

                //double latPixel = 0.0;
                //double longPixel = 0.0;
                //this.axMap1.ProjToPixel(lon, lat, ref longPixel, ref latPixel);


                //refreshMapa();
                brochaTexto.Color = Color.Black;
                mem.DrawString(lat.ToString("0.000"), fuente, brochaTexto, e.x + 10, e.y);
                mem.DrawString(lon.ToString("0.000"), fuente, brochaTexto, e.x + 10, e.y - 10);
                brochaTexto.Color = Color.Red;
                pluma.Color = Color.Black;
                mem.DrawEllipse(pluma, (float)e.x - 5, (float)e.y - 5, (float)10, (float)10);
                pluma.Color = Color.Red;

                estaSelPos = true;
                ////mem.DrawRectangle(pluma, (float)e.x - 5, (float)e.y - 5, (float)10, (float)10);



            }

                      

        }

        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {
            
            
        }

        public void set_cursorSeleccionCoordenadas()
        {
            enSeleccionCoord = true;
            this.axMap1.CursorMode = MapWinGIS.tkCursorMode.cmSelection;


        }

        public void set_NocursorSeleccionCoordenadas()
        {
            enSeleccionCoord = false;
            estaSelPos = false;
            this.axMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;


        }

        public double get_latitudCanvas()
        {
            return CoordY;
        }
        public double get_longitudCanvas()
        {
            return CoordX;
        }

       
        delegate void graficarBuque(double latitud, double longitud);
        public void graficarBuquePropio(double latitud, double longitud)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (axMap1.InvokeRequired)
            {
                graficarBuque d = new graficarBuque(graficarBuquePropio);
                this.Invoke(d, new object[] { latitud, longitud });
            }
            else
            {
                double latPixel = 0.0;
                double longPixel = 0.0;

                //this.axMap1.Refresh();
                this.axMap1.ProjToPixel(longitud, latitud, ref longPixel, ref latPixel);
                



                mem.DrawRectangle(pluma, (float)longPixel-5, (float)latPixel-5, (float)10, (float)10);
                this.toolStripStatusLabel3.Text = "LAT: " + latitud.ToString("00.00000");
                this.toolStripStatusLabel4.Text = "LON: " + longitud.ToString("000.00000");
                //mem.DrawEllipse(pluma, (float)longPixel, (float)latPixel, (float)10, (float)10);
            }
            
            
        }

        delegate void graficarTrayectoria(List<PuntoGeografico> trayectoria);
        public void graficarTrayecto(List<PuntoGeografico> trayectoria)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (axMap1.InvokeRequired)
            {
                graficarTrayectoria d = new graficarTrayectoria(graficarTrayecto);
                this.Invoke(d, new object[] {trayectoria});
            }
            else
            {
                double latPixel1 = 0.0;
                double longPixel1 = 0.0;

                int cantidad = trayectoria.Count;


                //if (cantidad > 3)
                //{
                    //this.axMap1.Refresh();
                    for (int i = 0; i < cantidad; i++)
                    {
                        this.axMap1.ProjToPixel(trayectoria[i].get_longitud(), trayectoria[i].get_latitud(), ref longPixel1, ref latPixel1);
                        mem.DrawEllipse(plumaTrayectoria, (float)longPixel1, (float)latPixel1, (float)1, (float)1);

                    }
                //}
                
                
            

            }


        }

        delegate void graficarVectorVelocidad(double lat1, double lon1, double lat2, double lon2);
        public void graficarVectorVel(double lat1, double lon1, double lat2, double lon2)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (axMap1.InvokeRequired)
            {
                graficarVectorVelocidad d = new graficarVectorVelocidad(graficarVectorVel);
                this.Invoke(d, new object[] { lat1, lon1, lat2, lon2 });
            }
            else
            {
                double latPixel1 = 0.0;
                double longPixel1 = 0.0;

                double latPixel2 = 0.0;
                double longPixel2 = 0.0;

                //this.axMap1.Refresh();

                this.axMap1.ProjToPixel(lon1, lat1, ref longPixel1, ref latPixel1);
                this.axMap1.ProjToPixel(lon2, lat2, ref longPixel2, ref latPixel2);

                mem.DrawLine(pluma, (float)longPixel1, (float)latPixel1, (float)longPixel2, (float)latPixel2);

            }


        }

        public void redimensionarCanvas(int whith, int height)
        {
            this.Size = new Size(whith, height);
            this.BringToFront();
            this.Visible = true;

            axMap1.Size = new Size(whith -20, height - statusStrip1.Height);
            // Se inicializa la visualizacion del contorl Legend1 del arbol de mapas abierto.
            this.legend1.Size = new Size(legend1.Width, height - (statusStrip1.Height+35));
            refreshMapa();

        }

        delegate void refrescarMapa();
        public void refreshMapa()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (axMap1.InvokeRequired)
            {
                refrescarMapa d = new refrescarMapa(refreshMapa);
                this.Invoke(d, new object[] { });
            }
            else
            {
                 this.axMap1.Refresh();
                 //this.legend1.Refresh();
               
                 
                
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (toolStripButton8.Checked)
            {
                verTrayectoria = true;
            }
            else
            {
                verTrayectoria = false;
            }
        }

       

       

       
        

       

        //delegate void drawMapa();
        //public void pintarMapa()
        //{
        //    // InvokeRequired required compares the thread ID of the
        //    // calling thread to the thread ID of the creating thread.
        //    // If these threads are different, it returns true.
        //    if (axMap1.InvokeRequired)
        //    {
        //        drawMapa d = new drawMapa(pintarMapa);
        //        this.Invoke(d, new object[] { });
        //    }
        //    else
        //    {
        //        this.g.DrawImage(bmMem, 0, 0);

        //    }
        //}


       
    }//fin de clase
}
