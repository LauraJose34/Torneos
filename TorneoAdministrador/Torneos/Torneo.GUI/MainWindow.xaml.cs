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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Torneo.BIZ;
using Torneo.COMMON.Entidades;
using Torneo.COMMON.Interfaz;
using Torneo.DAL;

namespace Torneo.GUI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IManejadorUsuarios manejadorUsuario;
        public MainWindow()
        {
            InitializeComponent();
            manejadorUsuario = new ManejadorUsuarios(new RepositorioGenerico<Usuarios>());

            ActualizarBase();
        }

        private void ActualizarBase()
        {
             cmbUsuario.ItemsSource = null;
             cmbUsuario.ItemsSource = manejadorUsuario.Lista;
        }

        private void btnIniciarAplicacion_Click(object sender, RoutedEventArgs e)
        {
            //Menu a = new Menu();
            //a.Show();
            //this.Close();
            /*Prueba*/
           /*MainWindow s = new MainWindow();
            a.txbTipoInicio.Text = b.Tipo;
            a.txbUsuarioInicio.Text = b.NombreDeUsuario;*/
            if (cmbUsuario.Text=="") {
                MessageBox.Show("No ha colocado el usuario al que corresponde\nSelecciones uno", "Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (string.IsNullOrEmpty(pasword.Password)) {
                MessageBox.Show("No ha ingresado la contraseña", "Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (cmbUsuario.SelectedItem != null)
            {
                Usuarios b = cmbUsuario.SelectedItem as Usuarios;
                if (pasword.Password == b.Contraseña)
                {
                    Menu a = new Menu();
                    a.Show();
                    this.Close();
                    //Prueba
                    MainWindow s = new MainWindow();
                    a.txbTipoInicio.Text = b.Tipo;
                    a.txbUsuarioInicio.Text = b.NombreDeUsuario;

               
                }
                else
                {
                    MessageBox.Show("Contraseña Inconrrecta", "Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            else {
                MessageBox.Show("No ha seleccionado ningun usuario", "Inicio", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancelarAplicacion_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro de cancelar la operación", "Inicio", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {
                this.Close();
            }
        }
    }
}
