using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelos
{
    class Habitacion
    {

        public Habitacion(DateTime valorFechaLlegada, DateTime valorFechaSalida, int valorNumPersonas, string valorTipoHabitacion)
        {
            fechaLlegada = valorFechaLlegada;
            fechaSalida = valorFechaSalida;
            numPersonas = valorNumPersonas;
            tipoHabitacion = valorTipoHabitacion;
        }

        private DateTime fechaLlegada { get; set; }
        private DateTime fechaSalida { get; set; }
        private int numPersonas { get; set; }
        private string tipoHabitacion { get; set; }

    }
}
