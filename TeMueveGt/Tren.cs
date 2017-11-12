using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    class Tren
    {
        public Tren(int cantidadDeVagones, string nombre, int cantidadVagonesDeLujo, int cantidadVagonesDeAhorro)
        {
            ListaVagones = new Vagon[cantidadDeVagones];
            CantidadDeVagones = cantidadDeVagones;
            Nombre = nombre;
            CantidadVagonesDeLujo = cantidadVagonesDeLujo;
            CantidadVagonesDeAhorro = cantidadVagonesDeAhorro;
        }

        public Vagon[] ListaVagones { get; set; }
        public int CantidadDeVagones { get; set; }
        public string Nombre { get; set; }
        public int CantidadVagonesDeLujo { get; set; }
        public int CantidadVagonesDeAhorro { get; set; }
        

        public int asientosDisponiblesTotales()
        {
            int asientosDisponibles = 0;
            for (int i = 0; i < ListaVagones.Length; i++)
            {
                asientosDisponibles = asientosDisponibles + ListaVagones[i].obtenerCantidadDeAsientosDisponibles();
            }
            return asientosDisponibles;
        }
    }
}
