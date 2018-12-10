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

        public Persona persona { get; set; }
        public Habitacion habitacion { get; set; }
        public Salon salon { get; set; }
        
    }
}
