using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class RECORRIDO
    {
        public int IdRecorrido { get; set; }
        public int IdMonitoreo { get; set; }
        public DateTime FechaRecorrido { get; set; }
        public int Longitud { get; set; }
        public int Latitud { get; set; }
        public int Velocidad { get; set; }
        public double DistanciaRecorrida { get; set; }
    }
}
