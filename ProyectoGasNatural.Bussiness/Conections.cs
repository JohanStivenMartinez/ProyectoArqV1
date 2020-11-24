using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace ProyectoGasNatural.Bussiness
{
    class Conections
    {
        
        private SqlConnection conexion = new SqlConnection(ConfigurationManager.AppSettings["StringConect"]);
        private string respuesta = String.Empty;
        

        public void abrirConexion()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conectado");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Cerrada Conexion");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void revisarConsulta()
        {
            
            try
            {
                abrirConexion();
                cerrarConexion();
            }
            catch(Exception)
            {

            }
        }
        
    }
}
