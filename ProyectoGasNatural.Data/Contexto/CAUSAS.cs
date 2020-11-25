using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class CAUSAS
    {
        public int IdCausa { get; set; }
        public string Causa { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdPersonaCreacion { get; set; }
        public string Observaciones { get; set; }//Merge
    }
}
