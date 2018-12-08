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
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void nuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            marco.Navigate(typeof(newCustomer));
            SplitView.IsPaneOpen = false;
        }

        private void reservaHabitacion_Click(object sender, RoutedEventArgs e)
        {
            marco.Navigate(typeof(bookRoom));
            SplitView.IsPaneOpen = false;
        }

        private void reservaSalon_Click(object sender, RoutedEventArgs e)
        {
            marco.Navigate(typeof(bookSaloon));
            SplitView.IsPaneOpen = false;
        }

        private void botonHamburguesa_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }
    }
}
