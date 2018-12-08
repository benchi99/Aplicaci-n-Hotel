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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Hotel
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class bookSaloon : Page
    {

        List<string> listaClientes = new List<string>();
        List<string> cocinaList = new List<string>();

        public bookSaloon()
        {
            this.InitializeComponent();

            cocinaList.Add("Buffet");
            cocinaList.Add("Carta");
            cocinaList.Add("Pedir cita con chef");
            cocinaList.Add("Sin especificar");

            listaClientes.Add("Añadir un nuevo cliente...");

            clientes.ItemsSource = listaClientes;
            cbxCocina.ItemsSource = cocinaList;
        }

        private void Congreso_Checked(object sender, RoutedEventArgs e)
        {
            seccionCongreso.Visibility = Visibility.Visible;
        }

        private void rbJornada_Checked(object sender, RoutedEventArgs e)
        {
            seccionCongreso.Visibility = Visibility.Collapsed;
        }

        private void rbBanquete_Checked(object sender, RoutedEventArgs e)
        {
            seccionCongreso.Visibility = Visibility.Collapsed;
        }

        private void cbxCocina_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            string seleccion = cbxCocina.SelectedItem.ToString();

            if (seleccion.Equals("Buffet"))
            {
                chkbxVeg.IsEnabled = true;
            } else
            {
                chkbxVeg.IsEnabled = false;
            }

        }

        private void clientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string seleccion = clientes.SelectedItem.ToString();

            if (seleccion == "Añadir un nuevo cliente...")
            {
                Frame.Navigate(typeof(newCustomer));
            }
            else
            {

            }

        }

        private void alojarTrue_Checked(object sender, RoutedEventArgs e)
        {
            numHab.IsEnabled = true;
        }

        private void alojarFalse_Checked(object sender, RoutedEventArgs e)
        {
            numHab.IsEnabled = false;
        }
    }
}
