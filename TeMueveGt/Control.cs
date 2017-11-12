using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    static class Control
    {
        public static bool clienteExiste(string DPI)
        {
            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                if (listaDeClientes[i].DPI == int.Parse(DPI))
                {
                    return true;
                }
            }
            return false;
        }
        public static Cliente obtenerCliente(string DPI)
        {
            for (int i = 0; i < listaDeClientes.Count; i++)
            {
                if (listaDeClientes[i].DPI == int.Parse(DPI))
                {
                    return listaDeClientes[i];
                }
            }
            return null;
        }
        public static int obtenerAsientosDeLujoDisponibles()
        {
            int aDisp = 0;
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (ListAsientos[i][5].ToString().Equals("L"))
                {
                    aDisp++;
                }
            }
            return aDisp;
        }
        public static int obtenerAsientosDeAhorroDisponibles()
        {
            int aDisp = 0;
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (ListAsientos[i][5].ToString().Equals("A"))
                {
                    aDisp++;
                }
            }
            return aDisp;
        }
        public static int obtenerAsientosDisponibles()
        {
            int aDisp = 0;
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (ListAsientos[i][4].ToString().Equals("D"))
                {
                    aDisp++;
                }
            }
            return aDisp;
        }
        public static int obtenerAsientosComprados()
        {
            int aDisp = 0;
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (ListAsientos[i][4].ToString().Equals("C"))
                {
                    aDisp++;
                }
            }
            return aDisp;
        }

        public static void comprar(string original, string nuevo)
        {
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (original.Equals(ListAsientos[i]))
                {
                    ListAsientos[i] = nuevo;
                    return;
                }
            }
        }
        public static void cancelarReservacion(string original, string nuevo)
        {
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (original.Equals(ListAsientos[i]))
                {
                    ListAsientos[i] = nuevo;
                    return;
                }
            }
        }
        public static int obtenerAsientosReservados()
        {
            int aDisp = 0;
            for (int i = 0; i < ListAsientos.Count; i++)
            {
                if (ListAsientos[i][4].ToString().Equals("R"))
                {
                    aDisp++;
                }
            }
            return aDisp;
        }
        public static List<string> ListAsientos { get; set; }
        public static int CantidadDeTrenes { get; set; }
        public static int VagonesPorTren { get; set; }
        public static int Correlativo { get; set; }
        public static List<Cliente> listaDeClientes { get; set; }
        public static int Filas { get; set; }
        public static int Asientos { get; set; }
        public static Tren[] ListaTrenes { get; set; }
        public static int TrenesCreados { get; set; }
    }
}
