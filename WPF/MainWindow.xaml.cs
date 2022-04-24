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
using System.Media;
using WPF.Carro;

namespace WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CARRO carrito;
        public MainWindow()
        {
            carrito = new CARRO("Mercedez Bens", 2022, "rojo", 150);
            InitializeComponent();
        }

        private void buttonencender_Click(object sender, RoutedEventArgs e)
        {
            labelencender.Content = carrito.EncendidoMotor();
        }

        private void buttonacelerador_Click(object sender, RoutedEventArgs e)
        {
            labelacelerador.Content = carrito.acelerar();
        }

        private void buttonbocina_Click(object sender, RoutedEventArgs e)
        {
            labelbocina.Content = carrito.Bocinar();
        }



        private void buttonfrenar_Click(object sender, RoutedEventArgs e)
        {
            labelfrenar.Content = carrito.frenar();
        }

        private void buttonapagado_Click(object sender, RoutedEventArgs e)
        {
            labelapagado.Content = carrito.apagarmotor();
        }

        private void buttonradio_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Tu radio tiene muy buen sonido");
        }

     
    }   
}      
