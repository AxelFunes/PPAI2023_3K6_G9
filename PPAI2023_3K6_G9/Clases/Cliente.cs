using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI2023_3K6_G9.Clases
{
    internal class Cliente
    {
        private string dni;
        private string nombreCompleto;
        private string nroCelular;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }

        public string NroCelular
        {
            get { return nroCelular; }
            set { nroCelular = value; }
        }
    }
}
