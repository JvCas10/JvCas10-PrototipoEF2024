using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Cambio
{
    public class Modelo
    {
        private Conexion conn; // Clase de conexión

        public Modelo()
        {
            this.conn = new Conexion(); // Inicializando la conexión
        }

        public DataTable ObtenerTipoCambio()
        {
            string query = "SELECT tipoCambio_nombre_moneda AS Moneda, tipoCambio_valorCambio_moneda AS Precio FROM tbl_tipoCambio WHERE tipoCambio_estatus = 1";
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
            string query = "SELECT tipoCambio_nombre_moneda FROM tbl_tipoCambio WHERE tipoCambio_estatus = 1";
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
                                nombresMonedas.Add(reader["tipoCambio_nombre_moneda"].ToString());
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
