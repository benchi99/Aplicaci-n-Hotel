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
    public sealed partial class bookRoom : Page
    {
        List<string> habitaciones = new List<string>();
        List<string> regimenes = new List<string>();

        public bookRoom()
        {
            this.InitializeComponent();

            habitaciones.Add("Doble de uso individual");
            habitaciones.Add("Doble");
            habitaciones.Add("Junior suite");
            habitaciones.Add("Suite");

            regimenes.Add("Alojamiento y desayuno");
            regimenes.Add("Media pensión");
            regimenes.Add("Pensión completa");

            if (GestorReservas.amountOfReservas() > 0)
            {
                GestorReservas.getListReservas().RemoveAt(0);
            }
        }

        private void cancelarBT_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StartPage));
        }

        private void reservarBT_Click(object sender, RoutedEventArgs e)
        {
            DateTime? fechaLlegadaDT;
            var fechaLlegadaST = "";
            if (fechaLlegada.Date != null)
            {
                fechaLlegadaDT = fechaLlegada.Date.DateTime;
                fechaLlegadaST = fechaLlegadaDT.Value.ToString("dd-MM-yyyy");
            }

            DateTime? fechaSalidaDT;
            var fechaSalidaST = "";
            if (fechaSalida.Date != null)
            {
                fechaSalidaDT = fechaSalida.Date.DateTime;
                fechaSalidaST = fechaSalidaDT.Value.ToString("dd-MM-yyyy");
            }
            GestorReservas.addReserva(new Reserva(GestorReservas.getListPersonas()[0], new Habitacion(fechaLlegadaST, fechaSalidaST, int.Parse(numPersonas.Text), tipoHabitacion.SelectedItem.ToString())));

            GestorReservas.setReservaRealizada(!GestorReservas.getReservaRealizada());

            Frame.Navigate(typeof(DataPage));
            
        }
    }
}
