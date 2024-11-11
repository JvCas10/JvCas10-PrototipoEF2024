using System.Data;
using System.Data.Odbc;
using Capa_Modelo_Produccion; // Asegúrate de que este using esté presente

namespace Capa_Modelo_Produccion
{
    public class Sentencia_Produccion
    {
        private Conexion_Produccion conexion = new Conexion_Produccion(); // Asegúrate de que esta instancia esté correctamente declarada

        // Aquí van los métodos que interactúan con la base de datos, por ejemplo:
        public DataTable ObtenerProductosPorSerie(string serie)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT id_producto, Nombre FROM producto WHERE Serie = ?";

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State == ConnectionState.Open)
                {
                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("Serie", serie);
                        using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                        {
                            da.Fill(tabla);
                        }
                    }
                }
            }

            return tabla;
        }

        // Métodos para Agregar, Modificar y Eliminar recetas y cualquier otra operación
    }
}
