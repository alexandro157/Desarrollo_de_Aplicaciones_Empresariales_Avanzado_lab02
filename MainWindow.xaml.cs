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

namespace WPFLaboratorio02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Aquí es donde cambiamos a la nueva vista (ventana o página)
            Window1 nuevaVentana = new Window1(); // O NuevaPagina nuevaPagina = new NuevaPagina();

            // Mostrar la nueva vista
            nuevaVentana.Show(); // O nuevaPagina.Show();

            // Cerrar la ventana actual si es necesario
            Close(); // O Hide() si deseas ocultarla en lugar de cerrarla
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            // Cerrar la ventana actual cuando se hace clic en el botón "Cancelar"
            Close();
        }
    }
}
