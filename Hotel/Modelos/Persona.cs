using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelos
{
    class Persona
    {

        public Persona(string valorDni, string valorNombre, int valorNumeroTlf, string valorDireccion, string valorLocalidad, string valorProvincia)
        {
            dni = valorDni;
            nombre = valorNombre;
            numeroTlf= valorNumeroTlf;
            direccion = valorDireccion;
            localidad = valorLocalidad;
            provincia = valorProvincia;
        }
    
        public string dni { get; set; }
        public string nombre { get; set; }
        public int numeroTlf { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }

    }
}
