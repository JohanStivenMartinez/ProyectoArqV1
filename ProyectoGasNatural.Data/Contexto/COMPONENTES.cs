using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class COMPONENTES
    {
        public int IdComponente { get; set; }
        public DateTime FechaComponente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdPersonaCreaciones { get; set; }
    }
}
