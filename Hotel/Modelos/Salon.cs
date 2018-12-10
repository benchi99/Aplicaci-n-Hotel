using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelos
{
    class Salon
    {

        public Salon(string valorFechaEvento, string valorTipoEvento, int valorNumeroAsistentes, string valorTipoCocina, bool valorVeganoONo, int valorNumJornadas, bool valorAlojarONo, int valorNumAlojar)
        {

            fechaEvento = valorFechaEvento;
            tipoEvento = valorTipoEvento;
            numeroAsistentes = valorNumeroAsistentes;
            tipoCocina = valorTipoCocina;
            if (valorTipoCocina.Equals("Buffet"))
            {
                veganoONo = valorVeganoONo;
            }
            if (valorTipoEvento.Equals("Congreso"))
            {
                numJornadas = valorNumJornadas;
                alojarONo = valorAlojarONo;
                if (valorAlojarONo == true)
                {
                    numAlojar = valorNumAlojar;
                }
            }            
        }

        public string fechaEvento { get; set; }
        public string tipoEvento { get; set; }
        public int numeroAsistentes { get; set; }
        public string tipoCocina { get; set; }
        public bool veganoONo { get; set; }
        public int numJornadas { get; set; }
        public bool alojarONo { get; set; }
        public int numAlojar { get; set; }

    }
}
