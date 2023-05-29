using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2023_3K6_G9.Clases
{
    internal class Encuesta
    {
        private string descripcion;
        private DateTime fechaFinVigencia;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime FechaFinVigencia
        {
            get { return fechaFinVigencia; }
            set { fechaFinVigencia = value; }
        }
    }
}
