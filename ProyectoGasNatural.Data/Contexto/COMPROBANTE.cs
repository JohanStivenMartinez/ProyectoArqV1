using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class COMPROBANTE
    {
        public int IdComprobante { get; set; }
        public double Monto { get; set; }
        public double Iva { get; set; }
        public BadImageFormatException FirmaTecnico { get; set; }  ///             Duda en BadImagenFormatException  ..°°.. lml
        public BadImageFormatException FirmaUsuario { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaImpresion { get; set; }

    }
}
