using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Banco
{
    public class Modelo
    {
        private Conexion conn;

        public Modelo()
        {
            this.conn = new Conexion();
        }

        public DataTable ObtenerTipoCambio()
        {
            string query = "SELECT nombre AS Moneda, valorCambio AS Precio FROM tbl_tipoCambio WHERE estatus = 1";
            DataTable dataTable = new DataTable();

            using (OdbcConnection connection = conn.connection()) // Usando el método connection() de la clase Conexion
            {
                try
                {
                    OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los tipos de cambio: " + ex.Message);
                }
            }
            return dataTable;
        }

        public List<string> ObtenerNombresMonedas()
        {
            string query = "SELECT nombre FROM tbl_tipoCambio WHERE estatus = 1";
            List<string> nombresMonedas = new List<string>();

            using (OdbcConnection connection = conn.connection()) // Usando el método connection() de la clase Conexion
            {
                try
                {
                    using (OdbcCommand command = new OdbcCommand(query, connection))
                    {
                        using (OdbcDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nombresMonedas.Add(reader["nombre"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los nombres de las monedas: " + ex.Message);
                }
            }
            return nombresMonedas;
        }
    }
}