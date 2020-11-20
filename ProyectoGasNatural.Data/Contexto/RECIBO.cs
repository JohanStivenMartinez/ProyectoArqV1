using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class RECIBO
    {
        public int IdRecibo { get; set; }
        public double Monto { get; set; }
        public double Iva { get; set; }
        public byte[] FirmaTecnico { get; set; }
        public byte[] Firmausuario { get; set; }
        public int IdServicio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaImpresion { get; set; }
    }
}
