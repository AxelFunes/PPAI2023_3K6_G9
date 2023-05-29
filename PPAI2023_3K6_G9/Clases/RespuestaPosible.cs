using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2023_3K6_G9.Clases
{
    internal class RespuestaPosible
    {
        private string descripcion;
        private int valor;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
