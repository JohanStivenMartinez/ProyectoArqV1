//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoGasNatural.Service.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RECORRIDO
    {
        public int IdRecorrido { get; set; }
        public int IdMonitoreo { get; set; }
        public System.DateTime FechaRecorrido { get; set; }
        public int Longitud { get; set; }
        public int Latitud { get; set; }
        public int Velocidad { get; set; }
        public decimal DistanciaRecorrida { get; set; }
    
        public virtual MONITOREO MONITOREO { get; set; }
    }
}
