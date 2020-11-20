using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class SERVICIO
    {
        public int IdServicio { get; set; }
        public int IdPersonaTecnico { get; set; }
        public int IdPersonaCreacion { get; set; }
        public int IdPersonaCliente { get; set; }
        public int IdEtapa { get; set; }
        public string Observacion { get; set; }
        public int IdComponente { get; set; }
        public int IdFallo { get; set; }
        public int IdCausa { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaAsignacion { get; set; }

    }
}
