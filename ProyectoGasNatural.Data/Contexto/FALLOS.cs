using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class FALLOS
    {
        public int IdFallo { get; set; }
        public string Fallo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdPersonaCreaciones { get; set; }
        public string Observaciones { get; set; }
    }
}
