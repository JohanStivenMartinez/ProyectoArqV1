using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoGasNatural.Data.Contexto
{
    public class PERSONA
    {
        public int IdPersona { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Login { get; set; }
        public string Contraseña { get; set; }

    }
}
