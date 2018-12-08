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

        List<Persona> personas = new List<Persona>();

        public void addPersona(Persona persona)
        {
            personas.Add(persona);
        }
        
        public int amountOfPersonas()
        {
            return personas.Count;
        }

    }
}
