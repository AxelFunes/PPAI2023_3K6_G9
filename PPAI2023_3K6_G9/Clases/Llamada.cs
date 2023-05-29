using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2023_3K6_G9.Clases
{
    internal class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private int duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;

        public string DescripcionOperador
        {
            get { return descripcionOperador; }
            set { descripcionOperador = value; }
        }

        public string DetalleAccionRequerida
        {
            get { return detalleAccionRequerida; }
            set { detalleAccionRequerida = value; }
        }

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public bool EncuestaEnviada
        {
            get { return encuestaEnviada; }
            set { encuestaEnviada = value; }
        }

        public string ObservacionAuditor
        {
            get { return observacionAuditor; }
            set { observacionAuditor = value; }
        }
    }
}
