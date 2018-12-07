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
    public sealed partial class newCustomer : Page
    {
        List<string> provincias = new List<string>();
        List<Persona> listaPersonas = new List<Persona>();

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
            
        }

        private void btAnadir_Click(object sender, RoutedEventArgs e)
        {
            string provinciaEscogida = ((ComboBoxItem)provinciaCBX.SelectedItem).Content.ToString();

            listaPersonas.Add(new Persona(dniTbx.Text, nombreTbx.Text, tlfTbx.Text, direccionTbx.Text, localidadTbx.Text, provinciaEscogida));
            
        }
    }
}
