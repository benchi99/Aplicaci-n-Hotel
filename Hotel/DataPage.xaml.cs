using Hotel.Controladores;
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
    public sealed partial class DataPage : Page
    {
        public DataPage()
        {
            this.InitializeComponent();

            if (GestorReservas.getListReservas()[0].habitacion == null)
            {
                rellenaUsuario();
                habitacionInfo.Visibility = Visibility.Collapsed;

                fechEvento.Text = GestorReservas.getListReservas()[0].salon.fechaEvento;
                tipoEvento.Text = GestorReservas.getListReservas()[0].salon.tipoEvento;
                numeroAsist.Text = GestorReservas.getListReservas()[0].salon.numeroAsistentes.ToString();
                tipoCocina.Text = GestorReservas.getListReservas()[0].salon.tipoCocina;
                if (tipoCocina.Text.Equals("Buffet"))
                {
                    vegTit.Visibility = Visibility.Visible;
                    vegano.Visibility = Visibility.Visible;
                    if (GestorReservas.getListReservas()[0].salon.veganoONo) {
                        vegano.Text = "Sí";
                    } else
                    {
                        vegano.Text = "No";
                    }
                }
                if (tipoEvento.Text.Equals("Congreso"))
                {
                    jornadNumTit.Visibility = Visibility.Visible;
                    numJornadas.Visibility = Visibility.Visible;
                    numJornadas.Text = GestorReservas.getListReservas()[0].salon.numJornadas.ToString();

                    if (GestorReservas.getListReservas()[0].salon.alojarONo)
                    {
                        numAsistAlojSNTit.Visibility = Visibility.Visible;
                        numAsistAloj.Visibility = Visibility.Visible;
                        numAsistAlojSN.Text = "Sí";

                        numAsistAlojTit.Visibility = Visibility.Visible;
                        numAsistAloj.Visibility = Visibility.Visible;
                        numAsistAloj.Text = GestorReservas.getListReservas()[0].salon.numAlojar.ToString();
                    }
                    else
                    {
                        numAsistAlojSNTit.Visibility = Visibility.Visible;
                        numAsistAloj.Visibility = Visibility.Visible;
                        numAsistAlojSN.Text = "No";
                    }
                }
            }
            else if (GestorReservas.getListReservas()[0].salon == null)
            {
                rellenaUsuario();
                salonInfo.Visibility = Visibility.Collapsed;

                fechaLlegada.Text = GestorReservas.getListReservas()[0].habitacion.fechaLlegada;
                fechaSalida.Text = GestorReservas.getListReservas()[0].habitacion.fechaSalida;
                numPersonas.Text = GestorReservas.getListReservas()[0].habitacion.numPersonas.ToString();
                tipoHab.Text = GestorReservas.getListReservas()[0].habitacion.tipoHabitacion;
            }

        }

        private void rellenaUsuario()
        {
            dniUs.Text = GestorReservas.getListPersonas()[0].dni;
            nombreUs.Text = GestorReservas.getListPersonas()[0].nombre;
            tlfUs.Text = GestorReservas.getListPersonas()[0].numeroTlf.ToString();
            direccionUs.Text = GestorReservas.getListPersonas()[0].direccion;
            localidadUs.Text = GestorReservas.getListPersonas()[0].localidad;
            provinciaUs.Text = GestorReservas.getListPersonas()[0].provincia;

        }

        private void volverInicio_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StartPage));
        }

        private void cancelarReserva_Click(object sender, RoutedEventArgs e)
        {
            mostrarAviso();
        }

        private async void mostrarAviso()
        {
            ContentDialog taSeguroTu = new ContentDialog()
            {
                Title = "Aviso",
                Content = "Estás a punto de cancelar la reserva. ¿Estás seguro?",
                PrimaryButtonText = "Sí",
                SecondaryButtonText = "No"
            };

            ContentDialogResult resultado = await taSeguroTu.ShowAsync();

            if(resultado == ContentDialogResult.Primary)
            {
                GestorReservas.setReservaRealizada(!GestorReservas.getReservaRealizada());
                Frame.Navigate(typeof(StartPage));
            }
        }

    }
}
