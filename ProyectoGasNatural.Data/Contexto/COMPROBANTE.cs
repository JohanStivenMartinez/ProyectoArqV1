using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ProyectoGasNatural.Data.Contexto
{
    public class COMPROBANTE
    {
        public int IdComprobante { get; set; }
        public double Monto { get; set; }
        public double Iva { get; set; }
        public byte[] FirmaTecnico { get; set; }
        public byte[] FirmaUsuario { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaImpresion { get; set; }

    }
}
