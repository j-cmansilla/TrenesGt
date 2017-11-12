using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeMueveGt
{
    class Cliente
    {
        

        public Cliente()
        {

        }

        public Cliente(string nombre, int dPI, string tipoDeOperacion)
        {
            Nombre = nombre;
            DPI = dPI;
            TipoDeOperacion = tipoDeOperacion;
            listaAsientos = new List<string>();
        }
        public string FormatoImpresion { get; set; }
        public string Nombre { get; set; }
        public int DPI { get; set; }
        public string TipoDeOperacion { get; set; }
        public List<string> listaAsientos { get; set; }
    }
}
