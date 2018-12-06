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
    
        private string dni { get; set; }
        private string nombre { get; set; }
        private int numeroTlf { get; set; }
        private string direccion { get; set; }
        private string localidad { get; set; }
        private string provincia { get; set; }

    }
}
