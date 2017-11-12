using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    class Vagon
    {
        public Vagon(bool esDeLujo, int filas, int asientosPorFila)
        {
            FilasYAsientos = new Asiento[filas,asientosPorFila];
            this.esDeLujo = esDeLujo;
            Filas = filas;
            AsientosPorFila = asientosPorFila;
        }

        public int obtenerCantidadDeAsientosDisponibles()
        {
            int count = 0;
            for (int k = 0; k < Filas; k++)
            {
                for (int i = 0; i < AsientosPorFila; i++)
                {
                    if (FilasYAsientos[k, i].Valor != "XX")
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        
        public Asiento[,] FilasYAsientos { get; set; }
        public bool esDeLujo { get; set; }
        public int Filas { get; set; }
        public int AsientosPorFila { get; set; }
        public bool comprar(int fila, int asiento)
        {
            if (FilasYAsientos[fila, asiento].Valor == "XX") return false;
            FilasYAsientos[fila, asiento].Valor = "XX";
            return true;
        }

        public bool cancelarReserva(int fila, int asiento)
        {
            if (FilasYAsientos[fila, asiento].Valor == "XX")
            {
                FilasYAsientos[fila, asiento].Valor = "F"+(fila+1).ToString()+"-"+"A"+(asiento+1).ToString();
            }
            return true;
        }

        public string[,] listaAsientos()
        {
            string[,] asientos = new string[Filas, AsientosPorFila];
            for (int i = 0; i < Filas; i++)
            {
                for (int j  = 0; j < AsientosPorFila; j++)
                {
                    asientos[i, j] = FilasYAsientos[i, j].Valor;
                }
            }
            return asientos;
        }
    }
}
