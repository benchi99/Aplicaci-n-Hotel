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

        private string fechaEvento { get; set; }
        private string tipoEvento { get; set; }
        private int numeroAsistentes { get; set; }
        private string tipoCocina { get; set; }
        private bool veganoONo { get; set; }
        private int numJornadas { get; set; }
        private bool alojarONo { get; set; }
        private int numAlojar { get; set; }

    }
}
