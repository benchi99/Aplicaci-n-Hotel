using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelos
{
    class Habitacion
    {

        public Habitacion(string valorFechaLlegada, string valorFechaSalida, int valorNumPersonas, string valorTipoHabitacion)
        {
            fechaLlegada = valorFechaLlegada;
            fechaSalida = valorFechaSalida;
            numPersonas = valorNumPersonas;
            tipoHabitacion = valorTipoHabitacion;
        }

        public string fechaLlegada { get; set; }
        public string fechaSalida { get; set; }
        public int numPersonas { get; set; }
        public string tipoHabitacion { get; set; }

    }
}
