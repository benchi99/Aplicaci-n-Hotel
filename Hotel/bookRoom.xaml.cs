﻿using Hotel.Controladores;
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
        List<string> listaClientes = new List<string>();

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

            listaClientes.Add("Añadir un nuevo cliente...");
            for (int i = 0; i < GestorReservas.amountOfPersonas(); i++)
            {
                listaClientes.Add(GestorReservas.getListPersonas()[i].nombre);
            }
        }

        private void clientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string seleccion = clientes.SelectedItem.ToString();

            if (seleccion == "Añadir un nuevo cliente...")
            {
                Frame.Navigate(typeof(newCustomer));
            } else
            {
                fechaLlegada.IsEnabled = true;
                fechaSalida.IsEnabled = true;
                numPersonas.IsEnabled = true;
                tipoHabitacion.IsEnabled = true;
                reservarBT.IsEnabled = true;
            }
        }
    }
}
