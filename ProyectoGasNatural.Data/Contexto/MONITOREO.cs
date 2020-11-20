using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class MONITOREO
    {
        public int IdMonitoreo { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public double MetrosRecorridos { get; set; }
    }
}
