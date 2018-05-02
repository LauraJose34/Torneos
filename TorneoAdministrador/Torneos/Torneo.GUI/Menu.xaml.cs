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
using Microsoft.Reporting.WinForms;
using Torneo.COMMON.Modelos;

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
        
        accion operacion;
        IManejadorUsuarios manejadorUsuarios;
        IManejadorDeporte manejadorDeporte;
        IManejadorEquipo manejadorEquipo;
        IManejadorTorneo manejadorTorneo;
        List<Integrantes> integrantes;

        List<VistaDeDeporteEspecifico> vista = new List<VistaDeDeporteEspecifico>();
        List<Aleatorios> lista = new List<Aleatorios>();
        List<Aleatorios> lista2 = new List<Aleatorios>();
        List<Torneos> torne = new List<Torneos>();
        List<VistaDeDeporteEspecifico> nueva = new List<VistaDeDeporteEspecifico>();
        List<TorneoLista> listatorneo;
       
        string equipo1;
        string equipo2;
        public Menu()
        {
            InitializeComponent();

            manejadorUsuarios = new ManejadorUsuarios(new RepositorioGenerico<Usuarios>());
            manejadorDeporte = new ManejadorDeporte(new RepositorioGenerico<Deportes>());
            manejadorEquipo = new ManejadorEquiposTorneo(new RepositorioGenerico<EquiposTorneos>());
            manejadorTorneo = new ManejadorTorneo(new RepositorioGenerico<Torneos>());
            integrantes = new List<Integrantes>();
            listatorneo = new List<TorneoLista>();
            CargarTablas();

            HabilitarBotones(false);
            LimpiarEditarTablasDeporte(false);
            LimpiarEditarTablasEquipo(false);
            LimpiarEditarTorneo(false);

            /*Para Estadisticos*/
            btnCalcularEstadisticos.Click += btnCalcularEstadisticos_Click;
            generadora = new Generadora();
            /*Para Estadisticos*/
        }

        private void CargarTablas()
        {
            dtgUsuarios.ItemsSource = null;
            dtgUsuarios.ItemsSource = manejadorUsuarios.Lista;
            dtgDeporte.ItemsSource = null;
            dtgDeporte.ItemsSource = manejadorDeporte.Lista;
            txtDeporteUsuario.ItemsSource = null;
            txtDeporteUsuario.ItemsSource = manejadorDeporte.Lista;
            dtgEquipo.ItemsSource = null;
            dtgEquipo.ItemsSource = manejadorEquipo.Lista;

            txtTipoDeporteEquipo.ItemsSource = null;
            txtTipoDeporteEquipo.ItemsSource = manejadorDeporte.Lista;

            cmbTipoDeporteTorneo.ItemsSource = null;
            cmbTipoDeporteTorneo.ItemsSource = manejadorDeporte.Lista;

            dtgPrueba.ItemsSource = null;
            dtgPrueba.ItemsSource = manejadorTorneo.Lista;

            dtgDatosDeporte2.ItemsSource = null;
            dtgDatosDeporte2.ItemsSource = vista;

            dtgDatosDeporte.ItemsSource = null;
            dtgDatosDeporte.ItemsSource = nueva;

            dtgPuntosEquipos.ItemsSource = null;
            dtgPuntosEquipos.ItemsSource = manejadorTorneo.Lista;

            cmbDeportePuntosEquipos.ItemsSource = null;
            cmbDeportePuntosEquipos.ItemsSource = manejadorDeporte.Lista;

            cmbEstadisticosEquipos.ItemsSource = null;
            cmbEstadisticosEquipos.ItemsSource = manejadorDeporte.Lista;
        }

        private void LimpiarEditarTablasDeporte(bool a)
        {
            txtDeportesDeportes.Clear();
            txtDeportesDeportes.IsEnabled = a;

            btnAgregarDeporte.IsEnabled = a;
            btnCancelarDeporte.IsEnabled = a;
            btnEditarDeporte.IsEnabled = !a;
            btnEliminarDeporte.IsEnabled = !a;
            btnNuevoDeporte.IsEnabled = !a;

        }

        private void LimpiarCamposTablasUsuario()
        {
            txtTipoUsuario.Clear();
            txtTelefono.Clear();
            txtNombreUsuario.Clear();
            txtDomicilioUsuario.Clear();
            txtContrasenaUsuario.Clear();
            txtApellidoPaternoUsuario.Clear();
            txtApellidoMaterno.Clear();
            clcFechaUsuario.Text = "";
            // txtDeporteUsuario.ItemsSource="";
            txtNombreDeUsuario.Clear();
        }

        private void LimpiarEditarTablasEquipo(bool a) {
            txtDirectorEquipo.Clear();
            txtNombreEquipo.Clear();
            txtTipoDeporteEquipo.IsEnabled = a;
            txtNombreEquipo.IsEnabled = a;
            txtDirectorEquipo.IsEnabled = a;
            btnCancelarEquipo.IsEnabled = a;
            btnAgregarEquipo.IsEnabled = a;
            btnEditarEquipo.IsEnabled = !a;
            btnEliminarEquipo.IsEnabled = !a;
            btnNuevoEquipo.IsEnabled = !a;

        }

        private void LimpiarEditarTorneo(bool a) {
            cmbTipoDeporteTorneo.ItemsSource = "";
            clFechaTorneo.Text = "";

            cmbTipoDeporteTorneo.IsEnabled = a;
            clFechaTorneo.IsEnabled = a;
            CargarTablas();

            btnOrdenarTorneo.IsEnabled = a;
            btnBuscadorTorneo.IsEnabled = a;
            EliminacionDeTorneoCompleto.IsEnabled = a;
            //btnAgregarTorneo.IsEnabled = a;
            btnCancelarTorneo.IsEnabled = a;
            //btnEditarTorneo.IsEnabled = !a;
            btnEliminarTorneo.IsEnabled = !a;
            btnNuevoTorneo.IsEnabled = !a;

        }

        private void LimpiarTorneo(bool a) {
            cmbTipoDeporteTorneo.ItemsSource = "";
            clFechaTorneo.Text = "";
            cmbTipoDeporteTorneo.IsEnabled = a;
            clFechaTorneo.IsEnabled = a;           
            btnOrdenarTorneo.IsEnabled = a;
            btnCancelarTorneo.IsEnabled = a;
            btnEliminarTorneo.IsEnabled = !a;
            btnNuevoTorneo.IsEnabled = !a;
            btnOrdenarTorneo.IsEnabled = a;
            btnBuscadorTorneo.IsEnabled = a;
            EliminacionDeTorneoCompleto.IsEnabled = a;
            btnCancelarTorneo.IsEnabled = a;
            btnEliminarTorneo.IsEnabled = !a;
            btnNuevoTorneo.IsEnabled = !a;
        }

        private void HabilitarBotones(bool a)
        {
            txtApellidoMaterno.IsEnabled = a;
            txtApellidoPaternoUsuario.IsEnabled = a;
            txtContrasenaUsuario.IsEnabled = a;
            txtDomicilioUsuario.IsEnabled = a;
            txtNombreUsuario.IsEnabled = a;
            txtTelefono.IsEnabled = a;
            txtTipoUsuario.IsEnabled = a;
            clcFechaUsuario.IsEnabled = a;
            txtDeporteUsuario.IsEnabled = a;
            txtNombreDeUsuario.IsEnabled = a;

            btnNuevoUsuario.IsEnabled = !a;
            btnEliminarUusraios.IsEnabled = !a;
            btnAgregar.IsEnabled = a;
            btnCancelarUsuario.IsEnabled = a;
            btnEditarUsuario.IsEnabled = !a;
        }

        private void btnNuevoUsuario_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCamposTablasUsuario();
            HabilitarBotones(true);
            operacion = accion.nuevo;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoMaterno.Text) || string.IsNullOrEmpty(txtApellidoPaternoUsuario.Text) || string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                MessageBox.Show("No ha ingresado los datos del nombre completo de Usuario", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDomicilioUsuario.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(clcFechaUsuario.Text))
            {
                MessageBox.Show("No ha ingresado todos los datos personales del Usuario\n*Domicilio\n*Telefono\n*Fecha de nacimiento", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtDeporteUsuario.Text) || string.IsNullOrEmpty(txtNombreDeUsuario.Text) || string.IsNullOrEmpty(txtTipoUsuario.Text) || string.IsNullOrEmpty(txtContrasenaUsuario.Password))
            {
                MessageBox.Show("No ha ingresado todos los datos del Usuario\n*Nombre de usuario\n*Deporte\n*Tipo de usuario\n*Contraseña", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (manejadorUsuarios.VerificarSiEsNumero(txtTelefono.Text) == true)
            {
                MessageBox.Show("El valor ingresado en Telefono no es valido\nSolo valores númericos", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if ((manejadorUsuarios.ContarNumeroTelefonico(txtTelefono.Text)) == false)
            {
                MessageBox.Show("Numero telefonico no valido\n10 Caracteres debe de contener", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int contrasena = txtContrasenaUsuario.Password.Count();
            if (contrasena <= 8)
            {
                MessageBox.Show("La contraseña debe de ser mayor o igual a 8 caracteres para mayor seguridad", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            if (operacion == accion.nuevo)
            {
                Usuarios a = new Usuarios()
                {
                    ApellidoMaterno = txtApellidoMaterno.Text.ToUpper(),
                    ApellidoPaterno = txtApellidoMaterno.Text.ToUpper(),
                    Contraseña = txtContrasenaUsuario.Password,
                    Deporte = txtDeporteUsuario.Text.ToUpper(),
                    Domicilio = txtDomicilioUsuario.Text.ToUpper(),
                    Nombre = txtNombreUsuario.Text.ToUpper(),
                    NombreDeUsuario = txtNombreDeUsuario.Text,
                    Telefono = txtTelefono.Text,
                    Tipo = txtTipoUsuario.Text.ToUpper(),
                    FechaNacimiento = DateTime.Parse(clcFechaUsuario.Text),
                };
                manejadorUsuarios.Agregar(a);
                CargarTablas();
                LimpiarCamposTablasUsuario();
                HabilitarBotones(false);
            }
            else
            {
                Usuarios usuario = dtgUsuarios.SelectedItem as Usuarios;
                usuario.ApellidoMaterno = txtApellidoMaterno.Text.ToUpper();
                usuario.ApellidoPaterno = txtApellidoMaterno.Text.ToUpper();
                usuario.Contraseña = txtContrasenaUsuario.Password;
                usuario.Deporte = txtDeporteUsuario.Text;
                usuario.Domicilio = txtDomicilioUsuario.Text.ToUpper();
                usuario.Nombre = txtNombreUsuario.Text.ToUpper();
                usuario.NombreDeUsuario = txtNombreDeUsuario.Text;
                usuario.Telefono = txtTelefono.Text;
                usuario.Tipo = txtTipoUsuario.Text.ToUpper();
                usuario.FechaNacimiento = DateTime.Parse(clcFechaUsuario.Text);
                if (manejadorUsuarios.Modificar(usuario))
                {
                    CargarTablas();
                    LimpiarCamposTablasUsuario();
                    HabilitarBotones(false);
                    MessageBox.Show("Usuario editado correctamente", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("No se puedo editar correctamente el usuario", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void btnEliminarUusraios_Click(object sender, RoutedEventArgs e)
        {
            Usuarios a = dtgUsuarios.SelectedItem as Usuarios;
            if (a != null)
            {
                if (MessageBox.Show("Realmente esta seguro de eliminar el usuario: " + a.Nombre, "Eliminación Usuario", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    manejadorUsuarios.Eliminar(a.Id);
                    CargarTablas();
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun elemento de la tabla Usuarios", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEditarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if (dtgUsuarios.SelectedItem != null)
            {
                Usuarios a = dtgUsuarios.SelectedItem as Usuarios;
                txtApellidoMaterno.Text = a.ApellidoMaterno;
                txtApellidoPaternoUsuario.Text = a.ApellidoPaterno;
                txtContrasenaUsuario.Password = a.Contraseña;
                txtDeporteUsuario.Text = a.Deporte;
                txtDomicilioUsuario.Text = a.Domicilio;
                txtNombreDeUsuario.Text = a.NombreDeUsuario;
                txtNombreUsuario.Text = a.Nombre;
                txtTelefono.Text = a.Telefono;
                txtTipoUsuario.Text = a.Tipo;
                clcFechaUsuario.Text = a.FechaNacimiento.ToString();

                operacion = accion.editar;
                HabilitarBotones(true);

            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun elemento de la tabla Usuarios", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarUsuario_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Esta realmente seguro de cancelar la operación", "Usuarios", MessageBoxButton.YesNo, MessageBoxImage.Question)) == MessageBoxResult.Yes)
            {
                HabilitarBotones(false);
                LimpiarCamposTablasUsuario();
            }
        }

        private void btnNuevoDeporte_Click(object sender, RoutedEventArgs e)
        {
            LimpiarEditarTablasDeporte(true);
            operacion = accion.nuevo;
        }

        private void btnAgregarDeporte_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDeportesDeportes.Text))
            {
                MessageBox.Show("Error!!!...No ha ingresado el Deporte", "Deportes", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (operacion == accion.nuevo) {
                Deportes a = new Deportes();
                a.Tipo_Deporte = txtDeportesDeportes.Text.ToUpper();

                if (manejadorDeporte.Agregar(a))
                {
                    MessageBox.Show("Deporte ingresado correctamente", "Deportes", MessageBoxButton.OK, MessageBoxImage.Information);
                    CargarTablas();
                    LimpiarEditarTablasDeporte(false);
                }
                else {
                    MessageBox.Show("No se pudo ingresar los datos correctamente", "Deportes", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            } else {
                Deportes a = dtgDeporte.SelectedItem as Deportes;
                a.Tipo_Deporte = txtDeportesDeportes.Text.ToUpper();
                if (manejadorDeporte.Modificar(a))
                {
                    MessageBox.Show("Deporte Actualizado correctamente", "Deportes", MessageBoxButton.OK, MessageBoxImage.Information);
                    CargarTablas();
                    LimpiarEditarTablasDeporte(false);
                }
                else {
                    MessageBox.Show("No se pudo ingresar Editar correctamente el Deporte", "Deportes", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void btnEditarDeporte_Click(object sender, RoutedEventArgs e)
        {
            if (dtgDeporte.SelectedItem != null)
            {
                operacion = accion.editar;
                LimpiarEditarTablasDeporte(true);
                Deportes a = dtgDeporte.SelectedItem as Deportes;
                txtDeportesDeportes.Text = a.Tipo_Deporte;
            }
            else {
                MessageBox.Show("No ha seleccionado ningun campo de la tabla", "Deportes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarDeporte_Click(object sender, RoutedEventArgs e)
        {
            if (dtgDeporte.SelectedItem != null)
            {
                Deportes a = dtgDeporte.SelectedItem as Deportes;
                if (MessageBox.Show("Realmente esta seguro de eliminar a " + a.Tipo_Deporte, "Deportes", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    manejadorDeporte.Eliminar(a.Id);
                    CargarTablas();
                }
            }
            else {
                MessageBox.Show("No ha seleccionado ningun campo de la tabla", "Deportes", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarDeporte_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Realmente esta seguro de cancelar la operación", "Deporte", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {
                LimpiarEditarTablasDeporte(false);
            }
        }

        private void btnNuevoEquipo_Click(object sender, RoutedEventArgs e)
        {
            LimpiarEditarTablasEquipo(true);
            operacion = accion.nuevo;
        }

        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(txtTipoDeporteEquipo.Text) || string.IsNullOrEmpty(txtNombreEquipo.Text) || string.IsNullOrEmpty(txtDirectorEquipo.Text))
            {
                MessageBox.Show("No ha llenado la información básica del equipo", "Equipos", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            if (operacion == accion.nuevo)
            {

                EquiposTorneos a = new EquiposTorneos();
                a.Director = txtDirectorEquipo.Text.ToUpper();
                a.Tipo_De_Deporte = txtTipoDeporteEquipo.Text.ToUpper();
                a.Nombre = txtNombreEquipo.Text.ToUpper();

                if (manejadorEquipo.Agregar(a))
                {
                    MessageBox.Show("Equipo ingresado correctamente", "Equipo", MessageBoxButton.OK, MessageBoxImage.Information);
                    CargarTablas();
                    LimpiarEditarTablasEquipo(false);
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar correctamente el equipo", "Equipo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                EquiposTorneos a = dtgEquipo.SelectedItem as EquiposTorneos;
                a.Director = txtDirectorEquipo.Text.ToUpper();
                a.Nombre = txtNombreEquipo.Text.ToUpper();
                a.Tipo_De_Deporte = txtTipoDeporteEquipo.Text.ToUpper();
                if (manejadorEquipo.Modificar(a))
                {
                    MessageBox.Show("Equipo Editado Correctamente", "Equipo", MessageBoxButton.OK, MessageBoxImage.Information);

                    CargarTablas();
                    LimpiarEditarTablasEquipo(false);
                }

                else
                {
                    MessageBox.Show("Equipo Editado Inorrectamente", "Equipo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEditarEquipo_Click(object sender, RoutedEventArgs e)
        {
            EquiposTorneos a = dtgEquipo.SelectedItem as EquiposTorneos;
            if (a != null)
            {
                LimpiarEditarTablasEquipo(true);
                txtDirectorEquipo.Text = a.Director;
                txtTipoDeporteEquipo.Text = a.Tipo_De_Deporte;
                txtNombreEquipo.Text = a.Nombre;
                operacion = accion.editar;
            }
            else
            {
                MessageBox.Show("No ha seleccionado la tabla de Equipo\nSeleccione un elemento para editarlo", "Equipos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnEliminarEquipo_Click(object sender, RoutedEventArgs e)
        {
            if (dtgEquipo.SelectedItem != null)
            {
                EquiposTorneos a = dtgEquipo.SelectedItem as EquiposTorneos;
                if (MessageBox.Show("Realmente esta seguro de eliminar a " + a.Nombre, "Equipos", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    if (manejadorEquipo.Eliminar(a.Id))
                    {
                        MessageBox.Show("Equipo eliminado sadisfactoriamente", "Equipos", MessageBoxButton.OK, MessageBoxImage.Information);
                        CargarTablas();
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun campo de la tabla", "Equipos", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarEquipo_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Realmente esta seguro de cancelar la operación", "Equipo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                LimpiarEditarTablasEquipo(false);

            }
        }

        private void btnNuevoTorneo_Click(object sender, RoutedEventArgs e)
        {
            LimpiarEditarTorneo(true);
            torne = new List<Torneos>();
            dtgDatosDeporte.ItemsSource = null;
            dtgDatosDeporte.ItemsSource = torne;
        }

        public void PrimerEquipoTorneo() {
            int contador = 0;
            Aleatorios a = new Aleatorios();
            foreach (var item in lista)
            {
                contador++;
                if (contador == 1)
                {
                    equipo1 = item.Datos;
                    a.Datos = item.Datos;
                    lista.Remove(item);
                    lista2.Add(a);
                    break;
                }
            }
           
        }

        private void SegundoEquipotorneoImpar()
        {
            if (lista.Count>=1) {
                Random r = new Random();
                int val = r.Next(1, lista.Count);
                int contador = 0;
              
                foreach (var item2 in lista)
                {
                    contador++;

                    if (contador == val)
                    {
                        equipo2 = item2.Datos;
                        lista.Remove(item2);
                        break;
                    }
                }
            }            
        }

        private void AgregarListaNumerosImpares(string palabra) {
            PrimerEquipoTorneo();
            SegundoEquipotorneoImpar();
            Torneos a = new Torneos()
            {
                Equipo1 = equipo1,
                Equipo2 = equipo2,
                Marcador_1 = 0,
                Marcador_2=0,
                Tipo_Deporte = palabra.ToUpper(),
                FechaProgramada = clFechaTorneo.Text,
            };
            torne.Add(a);
            manejadorTorneo.Agregar(a);
            dtgPrueba.ItemsSource = null;
            dtgPrueba.ItemsSource = manejadorTorneo.Lista;
            dtgDatosDeporte.ItemsSource = null;
            dtgDatosDeporte.ItemsSource = torne;
        }

        private void CargarEquipos(string palabra) {
            foreach (var item in manejadorEquipo.Lista)
            {
                List<VistaDeDeporteEspecifico> nueva = new List<VistaDeDeporteEspecifico>();
                if (item.Tipo_De_Deporte == palabra)
                {
                    VistaDeDeporteEspecifico equipos = new VistaDeDeporteEspecifico();
                    equipos.Nombre = item.Nombre;
                    equipos.Tipo_De_Deporte = palabra;
                    equipos.Director = item.Director;
                    nueva.Add(equipos);
                }
            }
            dtgDatosDeporte.ItemsSource = null;
            dtgDatosDeporte.ItemsSource = nueva;
        }

        private void btnOrdenarTorneo_Click(object sender, RoutedEventArgs e)
        {
            if (cmbTipoDeporteTorneo.SelectedItem==null) {
                MessageBox.Show("Error...No ha seleccionado ningun deporte!!!", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
           
            string palabra = cmbTipoDeporteTorneo.Text;
            if (manejadorEquipo.ContadorDeBuscarEquipo(palabra)<=1) {
                MessageBox.Show("No se puede realizar los torneos con un solo equipo\nAgregue más equipos", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrEmpty(clFechaTorneo.Text)) {
                MessageBox.Show("Agregue la fecha programada del torneo", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            foreach (var item in manejadorEquipo.Lista)
            {
                if (item.Tipo_De_Deporte == palabra)
                {
                    Aleatorios equipos = new Aleatorios();
                    equipos.Datos = item.Nombre;
                    lista.Add(equipos);                    
                }
            }
            /*Cargar datos en la segunda tabla*/
     //    CargarEquipos(palabra);

            if (lista.Count % 2 == 0)
            {
                while (((lista.Count) / 2) > 0)
                {
                    AgregarListaNumerosImpares(palabra);
                }
            }
            else {
                while (((lista.Count)/ 2) > 0)
                {
                    AgregarListaNumerosImpares(palabra);
                }
                 UltimoElemntoRestante(palabra);
            }

            /**/
            LimpiarTorneo(false);
          //  LimpiarEditarTorneo(false);
        }

        private void UltimoElemntoRestante(string palabra)
        {
            PrimerEquipoTorneo();
            if (lista.Count >= 1)
            {
                Random r = new Random();
                int val = r.Next(2, lista2.Count);
                int contador = 0;

                foreach (var item2 in lista2)
                {
                    contador++;

                    if (contador == val)
                    {
                        equipo2 = item2.Datos;
                        break;
                    }
                }
            }
            Torneos a = new Torneos()
            {
                Equipo1 = equipo1,
                Equipo2 = equipo2,
                Tipo_Deporte = palabra.ToUpper(),
                Marcador_1 = 0,
                Marcador_2 = 0,
                FechaProgramada = clFechaTorneo.Text,
            };
            torne.Add(a);
            manejadorTorneo.Agregar(a);
            dtgPrueba.ItemsSource = null;
            dtgPrueba.ItemsSource = manejadorTorneo.Lista;
            // dtgPrueba.ItemsSource = torne;
            dtgDatosDeporte.ItemsSource = null;
            dtgDatosDeporte.ItemsSource = torne;
        }

        private void btnBuscadorTorneo_Click(object sender, RoutedEventArgs e)
        {
            if (cmbTipoDeporteTorneo.SelectedItem != null)
            {
                List<VistaDeDeporteEspecifico> vista = new List<VistaDeDeporteEspecifico>();
                foreach (var item in manejadorEquipo.Lista)
                {
                    if (item.Tipo_De_Deporte == cmbTipoDeporteTorneo.Text)
                    {
                        VistaDeDeporteEspecifico s = new VistaDeDeporteEspecifico()
                        {
                            Director = item.Director,
                            Nombre = item.Nombre,
                            Tipo_De_Deporte = cmbTipoDeporteTorneo.Text
                        };
                        vista.Add(s);
                    }
                }
                dtgDatosDeporte2.ItemsSource = null;
                dtgDatosDeporte2.ItemsSource = vista;
            }
            else {
                MessageBox.Show("Debe primero seleccionar un Deporte", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
        }

        private void btnEliminarTorneo_Click(object sender, RoutedEventArgs e)
        {
            if (dtgPrueba.SelectedItem != null)
            {
                Torneos a= dtgPrueba.SelectedItem as Torneos;
                if (MessageBox.Show("Esta realmente seguro de eliminar los equipos: "+ a.Equipo1+" & "+ a.Equipo2, "Torneo", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes) {
                    if (manejadorTorneo.Eliminar(a.Id))
                    {
                        MessageBox.Show("Equipos eliminados", "Torneo", MessageBoxButton.OK, MessageBoxImage.Information);
                        CargarTablas();
                    }
                    else {
                        MessageBox.Show("No se puedo eliminar el los quipos", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else {
                MessageBox.Show("No ha seleccionado ningun elemento de la tabla para eliminar\nSeleccione uno", "Torneo Eliminación", MessageBoxButton.OK, MessageBoxImage.Error);
            }
          
        }

        private void btnCancelarTorneo_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Esta realmente seguro de cancelar la operación?", "Torneo", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.Yes){
                CargarTablas();
                LimpiarEditarTorneo(false);
            }
       }

        private void EliminacionDeTorneoCompleto_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(clFechaTorneo.Text)) {
                MessageBox.Show("Seleccione la fecha del torneo para su eliminación", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(cmbTipoDeporteTorneo.Text))
            {
                MessageBox.Show("Seleccione el Deporte para su eliminación", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cmbTipoDeporteTorneo.SelectedItem != null)
            {
                if (MessageBox.Show("Realmente esta seguro de eliminar el torneo", "Torneo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {
                    foreach (var item in manejadorTorneo.Lista)
                    {
                        if (item.FechaProgramada == clFechaTorneo.Text && item.Tipo_Deporte == cmbTipoDeporteTorneo.Text)
                        {
                             manejadorTorneo.Eliminar(item.Id);
                        }
                    }
                    MessageBox.Show("Eliminación del Torneo Correctamente", "Torneo", MessageBoxButton.OK, MessageBoxImage.Information);
                    CargarTablas();
                    LimpiarEditarTorneo(true);
                    LimpiarTorneo(false);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado el Deporte para su eliminación", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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

        private void btnEditarPuntosEquipos_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPuntosToneroIdentificador.Text)) {
                MessageBox.Show("No ha seleccionado ningun campo de la tabla para actualizar", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (manejadorTorneo.VerificarSiEsNumero(txtPuntosMarcador1.Text) == 1) {
                MessageBox.Show("No se aceptan letras, solo numeros en Marcador 1 ", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (manejadorTorneo.VerificarSiEsNumero(txtPuntosMarcador2.Text) == 1)
            {
                MessageBox.Show("No se aceptan letras, solo numeros en Marcador 2", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int eq1=0;
            int eq2=0;
            if (int.Parse(txtPuntosMarcador1.Text)> int.Parse(txtPuntosMarcador2.Text)) {
                eq1 = 3;
                eq2 = 1;
            }
            if (int.Parse(txtPuntosMarcador1.Text) < int.Parse(txtPuntosMarcador2.Text))
            {
                eq1 = 1;
                eq2 = 3;
            }
            if (int.Parse(txtPuntosMarcador1.Text) == int.Parse(txtPuntosMarcador2.Text))
            {
                eq1 = 2;
                eq2 = 2;
            }

            foreach (var item in manejadorTorneo.Lista)
            {
                if (item.Id.ToString() == txtPuntosToneroIdentificador.Text)
                {
                    item.Equipo1 = txtPuntosToneroEquipo1.Text;
                    item.Equipo2 = txtPuntosToneroEquipo2.Text;
                    item.Marcador_1 = eq1;
                    item.Marcador_2 = eq2;
                    if (manejadorTorneo.Modificar(item))
                    {
                        CargarTablas();
                        LimpiarPuntosTorneo();
                        MessageBox.Show("Torneo editado correctamente", "Torneo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se puedo editar correctamente el Torneo", "Torneo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
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

        private void btnEliminarPuntosEquipos_Click(object sender, RoutedEventArgs e)
        {
            if (dtgPuntosEquipos.SelectedItem != null)
            {
                Torneos a = dtgPuntosEquipos.SelectedItem as Torneos;
                if (a != null)
                {
                   if (MessageBox.Show("Esta realmente seguro de eliminar los equipos: " + a.Equipo1 + " & " + a.Equipo2, "Torneo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        if (manejadorTorneo.Eliminar(a.Id))
                        {
                            MessageBox.Show("Equipos eliminados", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Information);
                            CargarTablas();
                            LimpiarPuntosTorneo();
                        }
                        else
                        {
                            MessageBox.Show("No se puedo eliminar el los quipos", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
                else
                {
                    TipoDeporteTemporal b = dtgPuntosEquipos.SelectedItem as TipoDeporteTemporal;
                    foreach (var item in manejadorTorneo.Lista)
                    {
                        if (b.Id == item.Id.ToString())
                        {
                            if (MessageBox.Show("Esta realmente seguro de eliminar los equipos: " + item.Equipo1 + " & " + item.Equipo2, "Torneo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                if (manejadorTorneo.Eliminar(item.Id))
                                {
                                    MessageBox.Show("Equipos eliminados", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Information);
                                    CargarTablas();
                                    LimpiarPuntosTorneo();
                                }
                                else
                                {
                                    MessageBox.Show("No se puedo eliminar el los quipos", "Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun elemento de la tabla", "Puntos Torneo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarPuntosEquipos_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro de cancelar la operación?", "Puntos Torneo", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                CargarTablas();
                LimpiarPuntosTorneo();
            }
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

        private void BuscarDeportes() {
            int valor = 0;
            if (string.IsNullOrEmpty(cmbEstadisticosEquipos.Text))
            {
                MessageBox.Show("Seleccione un deporte para observar su Historial", "Impresión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            foreach (var item in manejadorTorneo.Lista)
            {
                if (item.Tipo_Deporte == cmbEstadisticosEquipos.Text)
                {
                    valor++;
                }
            }
            if (valor <= 0)
            {
                MessageBox.Show("No se encontro ningun Torneo con ese Deporte", "Impresión", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            List<ReportDataSource> datos = new List<ReportDataSource>();
            ReportDataSource vales = new ReportDataSource();
            List<ModelTorneoParaReporte> datosTorneo = new List<ModelTorneoParaReporte>();
            foreach (var item in manejadorTorneo.Lista)
            {
                if (item.Tipo_Deporte == cmbEstadisticosEquipos.Text )
                {
                    datosTorneo.Add(new ModelTorneoParaReporte(item));
                }
            }
            vales.Value = datosTorneo;
            vales.Name = "DataSet1";
            datos.Add(vales);
            Reporteador ventana = new Reporteador("Torneo.GUI.Reporte.ReporteSinParametros.rdlc", datos);
            ventana.ShowDialog();  
        }

        private void btnImprimirEstadisticos_Click(object sender, RoutedEventArgs e)
        {
            BuscarDeportes();
        }
    }
}
