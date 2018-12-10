using Hotel.Controladores;
using Hotel.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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
    public sealed partial class newCustomer : Page
    {
        List<string> provincias = new List<string>();
        //List<string> errores;
        private string provinciaEscogida;

        public newCustomer()
        {
            this.InitializeComponent();

            provincias.Add("Huelva");
            provincias.Add("Sevilla");
            provincias.Add("Cádiz");
            provincias.Add("Córdoba");
            provincias.Add("Granada");
            provincias.Add("Málaga");
            provincias.Add("Almería");
            provincias.Add("Jaén");

            if (GestorReservas.amountOfPersonas() > 0)
            {
                GestorReservas.getListPersonas().RemoveAt(0);
            }
        }

        private void btAnadir_Click(object sender, RoutedEventArgs e)
        {
            /*
            errores = new List<string>();

            bool erroneo = false;
            
            if (dniTbx.Text == null)
            {
                errores.Add("Cumplimente el campo DNI.");
                erroneo = true;
            }

            if (nombreTbx.Text == null)
            {
                erroneo = true;
                errores.Add("Cumplimente el campo Nombre del cliente");
            }

            if (tlfTbx.Text == null)
            {
                erroneo = true;
                errores.Add("Cumplimente el campo Número de teléfono");
            }
            else if (!tlfTbx.Text.All(char.IsDigit))
            {
                erroneo = true;
                errores.Add("Introduzca SOLO números en el campo Número de teléfono");
            }

            if (direccionTbx.Text == null)
            {
                erroneo = true;
                errores.Add("Cumplimente el campo de Dirección");
            }

            if (localidadTbx.Text == null)
            {
                erroneo = true;
                errores.Add("Cumplimente el campo de Localidad");
            }

            if (provinciaCBX.SelectedItem != null)
            {
                provinciaEscogida = provinciaCBX.SelectedItem.ToString();
            }
            else
            {
                errores.Add("Seleccione una provincia.");
                erroneo = true;
            }
            
            if (!erroneo)
            {
            */

            provinciaEscogida = provinciaCBX.SelectedItem.ToString();

            GestorReservas.addPersona(new Persona(dniTbx.Text, nombreTbx.Text, int.Parse(tlfTbx.Text), direccionTbx.Text, localidadTbx.Text, provinciaEscogida));

            if (rbSalon.IsChecked == true)
            {
                Frame.Navigate(typeof(bookSaloon));
            }
            else if (rbHabitacion.IsChecked == true)
            {
                Frame.Navigate(typeof(bookRoom));
            }
            /*
        }
        else
        {
            MostrarErrores();
            errores.Clear();
        }
    }

    private async void MostrarErrores()
    {

        StringBuilder construyeError = new StringBuilder("Se han encontrado errores. ");

        for (int i = 0; i < errores.Count; i++)
        {
            construyeError.Append("\n" + errores[i]);
        }

        ContentDialog error = new ContentDialog()
        {
            Title = "Error",
            Content = construyeError,
            PrimaryButtonText = "Aceptar"
        };

        error.Margin = new Thickness(0, 0, 0, 0);
        await error.ShowAsync();
    }
    */
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(StartPage));
        }
    }
}
