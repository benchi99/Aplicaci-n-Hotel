using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelos
{
    class Reserva
    {

        public Reserva(Persona valorPersona, Habitacion valorHabitacion)
        {
            persona = valorPersona;
            habitacion = valorHabitacion;
            salon = null;
        }

        public Reserva(Persona valorPersona, Salon valorSalon)
        {
            persona = valorPersona;
            salon = valorSalon;
            habitacion = null;
        }

        private Persona persona { get; set; }
        private Habitacion habitacion { get; set; }
        private Salon salon { get; set; }
        
    }
}
