using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class PLANEACION
    {
        public int IdPlaneacion { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdPersonaCreacion { get; set; }
        public int IdPersonaModificacion { get; set; }
        public int IdEtapa { get; set; }
        public DateTime FechaAsignacion { get; set; }

    }
}
