using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data; 
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Torneo.BIZ;
using Torneo.COMMON.CacharDatosOxi;
using Torneo.COMMON.Entidades;
using Torneo.COMMON.Interfaz;
using Torneo.COMMON.ListasDeEntidades;
using Torneo.DAL;

namespace Torneo.GUI
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        Generadora generadora;
        Random ran = new Random();
        enum accion
        {
            nuevo,
            editar
        }
        
        IManejadorUsuarios manejadorUsuarios;
        IManejadorDeporte manejadorDeporte;
        IManejadorEquipo manejadorEquipo;
        IManejadorTorneo manejadorTorneo;
      
        
        public Menu()
        {
            InitializeComponent();

            manejadorUsuarios = new ManejadorUsuarios(new RepositorioGenerico<Usuarios>());
            manejadorDeporte = new ManejadorDeporte(new RepositorioGenerico<Deportes>());
            manejadorEquipo = new ManejadorEquiposTorneo(new RepositorioGenerico<EquiposTorneos>());
            manejadorTorneo = new ManejadorTorneo(new RepositorioGenerico<Torneos>());
            CargarTablas();

            

            /*Para Estadisticos*/
            btnCalcularEstadisticos.Click += btnCalcularEstadisticos_Click;
            generadora = new Generadora();
            /*Para Estadisticos*/
        }

        private void CargarTablas()
        {
           

            dtgPuntosEquipos.ItemsSource = null;
            dtgPuntosEquipos.ItemsSource = manejadorTorneo.Lista;

            cmbDeportePuntosEquipos.ItemsSource = null;
            cmbDeportePuntosEquipos.ItemsSource = manejadorDeporte.Lista;

            cmbEstadisticosEquipos.ItemsSource = null;
            cmbEstadisticosEquipos.ItemsSource = manejadorDeporte.Lista;
        }
        
        private void PuntosEquiposBuscador_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDeportePuntosEquipos.Text)) {
                MessageBox.Show("Seleccione un Deporte", "Puntos Equipos", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(clcFechaPuntosEquipos.Text))
            {
                MessageBox.Show("Seleccione la fecha de programación del torneo", "Puntos Equipos", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            List<TipoDeporteTemporal> tipo = new List<TipoDeporteTemporal>();
            if (cmbDeportePuntosEquipos.SelectedItem != null)
            {
                foreach (var item in manejadorTorneo.Lista)
                {
                    if (item.Tipo_Deporte== cmbDeportePuntosEquipos.Text && item.FechaProgramada== clcFechaPuntosEquipos.Text) {
                        TipoDeporteTemporal TipoDeporteTemporal = new TipoDeporteTemporal() {
                            Equipo1 = item.Equipo1,
                            Equipo2 = item.Equipo2,
                            Tipo_Deporte = item.Tipo_Deporte,
                            FechaProgramada = item.FechaProgramada,
                            Id = item.Id.ToString(),
                            Marcador_1 = item.Marcador_1,
                            Marcador_2 = item.Marcador_2,                          
                        };
                        tipo.Add(TipoDeporteTemporal);
                    }
                }
                dtgPuntosEquipos.ItemsSource = null;
                dtgPuntosEquipos.ItemsSource = tipo;
            }
            else {
                MessageBox.Show("Algo salio mal :(\nIntentalo de nuevo", "Puntos Equipos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PuntosRegresarTabla_Click(object sender, RoutedEventArgs e)
        {
            dtgPuntosEquipos.ItemsSource = null;
            dtgPuntosEquipos.ItemsSource = manejadorTorneo.Lista;
        }

        private void dtgPuntosEquipos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgPuntosEquipos.SelectedItem != null)
            {                
                Torneos a = dtgPuntosEquipos.SelectedItem as Torneos;
                if (a != null)
                {
                    txtPuntosToneroIdentificador.Text = a.Id.ToString();
                    txtPuntosToneroEquipo1.Text = a.Equipo1;
                    txtPuntosToneroEquipo2.Text = a.Equipo2;
                    txtPuntosMarcador1.Text = a.Marcador_1.ToString();
                    txtPuntosMarcador2.Text = a.Marcador_2.ToString();
                }
                else {
                    TipoDeporteTemporal b = dtgPuntosEquipos.SelectedItem as TipoDeporteTemporal;
                    foreach (var item in manejadorTorneo.Lista)
                    {
                        if (b.Id==item.Id.ToString()) {
                            txtPuntosToneroIdentificador.Text = item.Id.ToString();
                            txtPuntosToneroEquipo1.Text = item.Equipo1;
                            txtPuntosToneroEquipo2.Text = item.Equipo2;
                            txtPuntosMarcador1.Text = item.Marcador_1.ToString();
                            txtPuntosMarcador2.Text = item.Marcador_2.ToString();
                        }
                    }                        
                }
            }
            else {
                MessageBox.Show("No ha seleccionado ningun elemento de la tabla", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }       

        
        private void LimpiarPuntosTorneo()
        {
            txtPuntosToneroEquipo1.Clear();
            txtPuntosToneroEquipo2.Clear();
            txtPuntosMarcador1.Clear();
            txtPuntosMarcador2.Clear();
            txtPuntosToneroIdentificador.Clear();
        }

        private void GenerarEstadisticos(int valor, string Deporte, string Fecha) {
            int contador = 1, contador1=1;
            List<NombreDeportes> nombre = new List<NombreDeportes>();
            foreach (var item in manejadorEquipo.Lista)
            {
                if (item.Tipo_De_Deporte == cmbEstadisticosEquipos.Text)
                {
                    NombreDeportes a = new NombreDeportes();
                    a.Numerador = contador1++;
                    a.Nombre = item.Nombre;
                    nombre.Add(a);
                }
            }
            
               List<TorneoLista> listatorneo = new List<TorneoLista>();          

            foreach (var item in nombre)
            {
                int valores1 = 0;
                foreach (var item2 in manejadorTorneo.Lista)
                {
                    if (item2.FechaProgramada==clcFechaEstadisticos.Text) {
                        if (item.Nombre==item2.Equipo1) {
                            valores1 = valores1 +item2.Marcador_1;
                        }
                        if (item.Nombre == item2.Equipo2) {
                            valores1 = valores1 + item2.Marcador_2;
                        }
                    }
                }
                TorneoLista a = new TorneoLista();
                a.X = contador++;
                a.Equipo = item.Nombre;
                a.Puntaje = valores1;
                listatorneo.Add(a);
            }

          
            int valores = 0;
            valores = listatorneo.Count;
            generadora.GeneradorDatos(listatorneo, 1,valores, 1);
            dtgTablaEstadisticos.ItemsSource = null;
            dtgTablaEstadisticos.ItemsSource = listatorneo;
            PlotModel model = new PlotModel();
            LinearAxis ejeX = new LinearAxis();            
            ejeX.Minimum = 1;
            ejeX.Maximum = valores;
            ejeX.Position = AxisPosition.Bottom;

            LinearAxis ejeY = new LinearAxis();
            ejeY.Minimum = generadora.Puntos.Min(p => p.Y);
            ejeY.Maximum = generadora.Puntos.Max(p => p.Y);
            ejeY.Position = AxisPosition.Left;

            model.Axes.Add(ejeX);
            model.Axes.Add(ejeY);
            model.Title = "Datos generados";
            LineSeries linea = new LineSeries();
            foreach (var item in generadora.Puntos)
            {
                linea.Points.Add(new DataPoint(item.X , item.Y));
            }
            linea.Title = "Valores generados";
            linea.Color = OxyColor.FromRgb(byte.Parse(ran.Next(0, 255).ToString()), byte.Parse(ran.Next(0, 255).ToString()), byte.Parse(ran.Next(0, 255).ToString()));
            model.Series.Add(linea);
            Grafica.Model = model;
        }
        
        private void btnCalcularEstadisticos_Click(object sender, RoutedEventArgs e)
        {
             int valor=0;
             if (string.IsNullOrEmpty(clcFechaEstadisticos.Text)|| string.IsNullOrEmpty(cmbEstadisticosEquipos.Text)) {
                 MessageBox.Show("Favor de llenar datos\n*Fecha\n*Tipo de Deporte", "Estadisticos", MessageBoxButton.OK, MessageBoxImage.Error);
                 return;
             }
             foreach (var item in manejadorTorneo.Lista)
             {
                 if (item.Tipo_Deporte== cmbEstadisticosEquipos.Text && item.FechaProgramada== clcFechaEstadisticos.Text) {
                     valor++;
                 }
             }
            if (valor <= 0) {               
               MessageBox.Show("No se encontro ningun Torneo con esa fecha o Deporte", "Estadisticos", MessageBoxButton.OK, MessageBoxImage.Error); 
               return;                
            }
                    
            GenerarEstadisticos(valor, cmbEstadisticosEquipos.Text, clcFechaEstadisticos.Text);
        }
    }
}
