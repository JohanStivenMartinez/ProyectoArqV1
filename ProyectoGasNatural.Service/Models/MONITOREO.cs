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
    
    public partial class MONITOREO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONITOREO()
        {
            this.RECORRIDO = new HashSet<RECORRIDO>();
        }
    
        public int IdMonitoreo { get; set; }
        public int IdServicio { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public decimal MetrosRecorridos { get; set; }
    
        public virtual SERVICIOS SERVICIOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECORRIDO> RECORRIDO { get; set; }
    }
}