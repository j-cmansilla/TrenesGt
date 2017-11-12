using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    class Asiento
    {
        public Asiento(string valor, Cliente cliente, bool reservadoOComprado)
        {
            Valor = valor;
            Cliente = cliente;
            ReservadoOComprado = reservadoOComprado;
        }

        public string Valor { get; set; }
        public Cliente Cliente { get; set; }
        public bool ReservadoOComprado { get; set; }
    }
}
