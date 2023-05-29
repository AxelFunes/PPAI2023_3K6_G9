using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2023_3K6_G9.Clases
{
    internal class GestorConsultarEncuesta
    {
        private Llamada llamadaSeleccionada;
        private string periodoLlamada;

        public Llamada LlamadaSeleccionada
        {
            get { return llamadaSeleccionada; }
            set { llamadaSeleccionada = value; }
        }

        public string PeriodoLlamada
        {
            get { return periodoLlamada; }
            set { periodoLlamada = value; }
        }
    }
}
