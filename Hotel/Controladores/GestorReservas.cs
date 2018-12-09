using Hotel.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Controladores
{
    class GestorReservas
    {

        static List<Reserva> reservas = new List<Reserva>();
        static List<Persona> personas = new List<Persona>();

        public static void addPersona(Persona persona)
        {
            personas.Add(persona);
        }
        
        public static List<Persona> getListPersonas()
        {
            return personas;
        }

        public static int amountOfPersonas()
        {
            return personas.Count;
        }



    }
}
