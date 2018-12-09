using Hotel.Controladores;
using Hotel.Modelos;
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

        List<string> cocinaList = new List<string>();

        public bookSaloon()
        {
            this.InitializeComponent();

            cocinaList.Add("Buffet");
            cocinaList.Add("Carta");
            cocinaList.Add("Pedir cita con chef");
            cocinaList.Add("Sin especificar");

            cbxCocina.ItemsSource = cocinaList;

            GestorReservas.getListReservas().RemoveAt(0);
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

        private void alojarTrue_Checked(object sender, RoutedEventArgs e)
        {
            numHab.IsEnabled = true;
        }

        private void alojarFalse_Checked(object sender, RoutedEventArgs e)
        {
            numHab.IsEnabled = false;
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StartPage));
        }

        private void btReservar_Click(object sender, RoutedEventArgs e)
        {

            string tipoEvento = "";

            if (rbBanquete.IsChecked == true)
            {
                tipoEvento = "Banquete";
            }
            else if (rbJornada.IsChecked == true)
            {
                tipoEvento = "Jornada";
            }
            else if (Congreso.IsChecked == true)
            {
                tipoEvento = "Congreso";
            }

            DateTime? date;
            var fecha = "";
            if (eventoFecha.Date != null)
            {
                date = eventoFecha.Date.DateTime;
                fecha = date.Value.ToString("dd-MM-yyyy");
            }

            GestorReservas.addReserva(new Reserva(GestorReservas.getListPersonas()[0], new Salon(fecha, tipoEvento, int.Parse(numAsistTbx.Text), cbxCocina.SelectedItem.ToString(), (bool)chkbxVeg.IsChecked, int.Parse(tbxJornadas.Text), (bool)alojarTrue.IsChecked, int.Parse(numHab.Text))));

            GestorReservas.setReservaRealizada(!GestorReservas.getReservaRealizada());

            Frame.Navigate(typeof(StartPage));
        }
    }
}
