using System;
using System.Data;
using System.Data.Odbc;




namespace Capa_Modelo_Movimientos
{
    public class Modelo
    {
        private Conexion conn;

        public Modelo()
        {
            this.conn = new Conexion();  // Asegúrate de que esta clase esté configurada correctamente
        }

        public DataTable ObtenerMov()
        {
            string query = "SELECT fk_cuenta_id AS CuentaID, movimientobancario_fecha AS fecha, movimientobancario_tipo AS Tipo, movimientobancario_monto AS Monto, movimientobancario_descripcion AS Descripcion, movimientobancario_metodo_pago AS metodo, movimientobancario_estado AS estado FROM tbl_movimientobancario";
            DataTable dataTable = new DataTable();

            using (OdbcConnection connection = conn.connection())  // Asegúrate de que conn.connection() esté devolviendo una conexión válida
            {
                try
                {
                    OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los movimientos bancarios: " + ex.Message);  // Manejo de excepción sin MessageBox
                }
            }
            return dataTable;
        }

        // Método para insertar un nuevo movimiento bancario
        public bool InsertarMovimiento( DateTime fecha, string tipo, decimal monto, string descripcion, string metodoPago, bool estado)
        {
            string query = "INSERT INTO tbl_movimientobancario ( movimientobancario_fecha, movimientobancario_tipo, movimientobancario_monto, movimientobancario_descripcion, movimientobancario_metodo_pago, movimientobancario_estado) " +
                           "VALUES (?, ?, ?, ?, ?, ?, ?)";

            using (OdbcConnection connection = conn.connection())  // Asegúrate de que conn.connection() esté devolviendo una conexión válida
            {
                try
                {
                    OdbcCommand command = new OdbcCommand(query, connection);
                    command.Parameters.AddWithValue("?", fecha);
                    command.Parameters.AddWithValue("?", tipo);
                    command.Parameters.AddWithValue("?", monto);
                    command.Parameters.AddWithValue("?", descripcion);
                    command.Parameters.AddWithValue("?", metodoPago);
                    command.Parameters.AddWithValue("?", estado ? 1 : 0);  // El estado es TINYINT, 1 para activo, 0 para inactivo

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;  // Retorna true si se insertó correctamente
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar el movimiento bancario: " + ex.Message);  // Manejo de excepción sin MessageBox
                }
            }
        }
        public bool ActualizarEstadoMovimiento(int movimientoId, bool estado)
        {
            string query = "UPDATE tbl_movimientobancario SET movimientobancario_estado = ? WHERE pk_movimientobancario_id = ?";

            using (OdbcConnection connection = conn.connection())
            {
                try
                {
                    OdbcCommand command = new OdbcCommand(query, connection);
                    command.Parameters.AddWithValue("?", estado ? 1 : 0);  // El estado se convierte en 1 (activo) o 0 (inactivo)
                    command.Parameters.AddWithValue("?", movimientoId);   // El ID del movimiento

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;  // Retorna true si se actualizó correctamente
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el estado del movimiento: " + ex.Message);
                }
            }
        }

        public string modIndice(string idAyuda)
        {
            string indice = "";
            string query = "SELECT indice FROM ayuda WHERE id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(query, this.conn.connection()))
            {
                command.Parameters.AddWithValue("Id_ayuda", idAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        indice = reader.GetString(0); // Asignamos el valor de la columna Indice
                    }
                }
            }

            return indice;
        }

        public string modRuta(string idAyuda)
        {
            string ruta = "";
            string query = "SELECT Ruta FROM ayuda WHERE Id_ayuda = ?"; // Parámetro seguro

            using (OdbcCommand command = new OdbcCommand(query, this.conn.connection()))
            {
                command.Parameters.AddWithValue("id_ayuda", idAyuda);
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ruta = reader.GetString(0); // Asignamos el valor de la columna Ruta
                    }
                }
            }

            return ruta;
        }




    }
}
