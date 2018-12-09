using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Hotel
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        static bool reservaActiva = false;

        public MainPage()
        {
            this.InitializeComponent();
            marco.Navigate(typeof(StartPage));
        }

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            marco.Navigate(typeof(StartPage));
        }

        private void reserva_Click(object sender, RoutedEventArgs e)
        {
            if (reservaActiva)
            {
                marco.Navigate(typeof(DataPage));
            } else
            {
                marco.Navigate(typeof(newCustomer));
            }

        }

        private void AcercaDe_Checked(object sender, RoutedEventArgs e)
        {
            marco.Navigate(typeof(AboutPage));
        }

        public static void cambiarEstadoReserva()
        {

            string contenido = "";
            string tag = "";

            reservaActiva = !reservaActiva;            

            if(reservaActiva)
            {
                contenido = "Ver información de mi reserva";
                tag = "&#xE946;";


            } else if (!reservaActiva)
            {
                contenido = "Reservar";
                tag = "&#xE8D1;";
            }

            aplicaCambiosComponentes(contenido, tag);

        }

        private void aplicaCambiosComponentes (string contenido, string tag)
        {

            reserva.Content = contenido;
            reserva.Tag = tag;

        }
    }
}
