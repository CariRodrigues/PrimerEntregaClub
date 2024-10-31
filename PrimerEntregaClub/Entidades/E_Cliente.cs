using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerEntregaClub.Entidades
{
    public class E_Cliente
    {
        public int idCliente { get ; set ; }
        public string NombreC { get; set ; }
        public string ApellidoC { get; set; }
        public string TDocC { get; set; }
        public string DocC { get; set; }
        public DateTime FechaNacC { get;set; }
        public string TelC { get;set; }
        public string DomicilioC { get; set; }
        public string EmailC { get; set; }
        public bool EsSocio { get; set; }

    }
}
