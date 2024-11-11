using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Lotes
{
    public class Sentencia_Lotes
    {
        private Conexion_Lotes conexion;

        public Sentencia_Lotes()
        {
            conexion = new Conexion_Lotes();
        }

        // Verifica si la conexión es válida
        private bool EsConexionValida(OdbcConnection conn)
        {
            if (conn.State != ConnectionState.Open)
            {
                Console.WriteLine("La conexión no está abierta.");
                return false;
            }
            return true;
        }

        // Método para insertar un nuevo registro de lote
        public void InsertarLote(int idLote, string codigoLote, DateTime fechaProduccionLote, int cantidadLote, int estado, int idProducto)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return;

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insertar en tbl_lotes_encabezado
                        string queryEncabezado = @"INSERT INTO tbl_lotes_encabezado 
                                                   (Pk_id_lote, codigo_lote, Fecha_Producción, estado) 
                                                   VALUES (?, ?, ?, ?)";

                        using (OdbcCommand cmdEncabezado = new OdbcCommand(queryEncabezado, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", idLote);
                            cmdEncabezado.Parameters.AddWithValue("?", codigoLote);
                            cmdEncabezado.Parameters.AddWithValue("?", fechaProduccionLote.ToString("yyyy-MM-dd"));
                            cmdEncabezado.Parameters.AddWithValue("?", estado);

                            int rowsAffectedEncabezado = cmdEncabezado.ExecuteNonQuery();
                            Console.WriteLine("Filas insertadas en tbl_lotes_encabezado: " + rowsAffectedEncabezado);
                        }

                        // Insertar en tbl_lotes_detalles
                        string queryDetalle = @"INSERT INTO tbl_lotes_detalles 
                                                (Fk_id_lote, Fk_id_producto, cantidad) 
                                                VALUES (?, ?, ?)";

                        using (OdbcCommand cmdDetalle = new OdbcCommand(queryDetalle, conn, transaction))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", idLote);
                            cmdDetalle.Parameters.AddWithValue("?", idProducto);
                            cmdDetalle.Parameters.AddWithValue("?", cantidadLote);

                            int rowsAffectedDetalle = cmdDetalle.ExecuteNonQuery();
                            Console.WriteLine("Filas insertadas en tbl_lotes_detalles: " + rowsAffectedDetalle);
                        }

                        transaction.Commit();
                        Console.WriteLine("Transacción completada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al guardar el lote y los detalles: " + ex.Message);
                    }
                }
            }
        }

        // Método para actualizar un registro de lote
        public void ActualizarLote(int idLote, string codigoLote, DateTime fechaProduccionLote, int cantidadLote, int estado, int idProducto)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return;

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Actualizar tbl_lotes_encabezado
                        string queryEncabezado = @"UPDATE tbl_lotes_encabezado SET 
                                                    codigo_lote = ?, 
                                                    Fecha_Producción = ?, 
                                                    estado = ? 
                                                    WHERE Pk_id_lote = ?";

                        using (OdbcCommand cmdEncabezado = new OdbcCommand(queryEncabezado, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", codigoLote);
                            cmdEncabezado.Parameters.AddWithValue("?", fechaProduccionLote.ToString("yyyy-MM-dd"));
                            cmdEncabezado.Parameters.AddWithValue("?", estado);
                            cmdEncabezado.Parameters.AddWithValue("?", idLote);

                            int rowsAffectedEncabezado = cmdEncabezado.ExecuteNonQuery();
                            Console.WriteLine("Filas actualizadas en tbl_lotes_encabezado: " + rowsAffectedEncabezado);
                        }

                        // Actualizar tbl_lotes_detalles
                        string queryDetalle = @"UPDATE tbl_lotes_detalles SET 
                                                cantidad = ?, 
                                                Fk_id_producto = ?
                                                WHERE Fk_id_lote = ?";

                        using (OdbcCommand cmdDetalle = new OdbcCommand(queryDetalle, conn, transaction))
                        {
                            cmdDetalle.Parameters.AddWithValue("?", cantidadLote);
                            cmdDetalle.Parameters.AddWithValue("?", idProducto);
                            cmdDetalle.Parameters.AddWithValue("?", idLote);

                            int rowsAffectedDetalle = cmdDetalle.ExecuteNonQuery();
                            Console.WriteLine("Filas actualizadas en tbl_lotes_detalles: " + rowsAffectedDetalle);
                        }

                        transaction.Commit();
                        Console.WriteLine("Transacción de actualización completada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al actualizar el lote y los detalles: " + ex.Message);
                    }
                }
            }
        }

        // Método para desactivar un registro de lote
        // Método para desactivar un registro de lote
        public void DesactivarLote(int idLote)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return;

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Actualizar estado en tbl_lotes_encabezado a 0 (inactivo)
                        string queryEncabezado = @"UPDATE tbl_lotes_encabezado SET estado = 0 WHERE Pk_id_lote = ?";

                        using (OdbcCommand cmdEncabezado = new OdbcCommand(queryEncabezado, conn, transaction))
                        {
                            cmdEncabezado.Parameters.AddWithValue("?", idLote);
                            cmdEncabezado.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        Console.WriteLine("Lote desactivado correctamente.");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al desactivar el lote: " + ex.Message);
                    }
                }
            }
        }


        // Método para obtener los registros de la tabla de lotes con INNER JOIN
        public DataTable ObtenerLotes()
        {
            DataTable tablaLotes = new DataTable();

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return tablaLotes;

                try
                {
                    string query = @"SELECT le.Pk_id_lote, le.codigo_lote, le.Fecha_Producción AS FechaProduccion, le.estado, 
                                     ld.Fk_id_producto, ld.cantidad
                                     FROM tbl_lotes_encabezado AS le
                                     INNER JOIN tbl_lotes_detalles AS ld ON le.Pk_id_lote = ld.Fk_id_lote";

                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                    {
                        adapter.Fill(tablaLotes);
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener los lotes: " + ex.Message);
                }
            }

            return tablaLotes;
        }

        // Método para obtener el último ID de la tabla de lotes
        public int ObtenerUltimoIdLote()
        {
            int ultimoId = 0;

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return ultimoId;

                try
                {
                    string query = "SELECT MAX(Pk_id_lote) FROM tbl_lotes_encabezado";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            ultimoId = Convert.ToInt32(resultado);
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener el último ID de lote: " + ex.Message);
                }
            }

            return ultimoId;
        }

        // Método para obtener la lista de productos
        public DataTable ObtenerProductos()
        {
            DataTable tablaProductos = new DataTable();

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return tablaProductos;

                try
                {
                    string query = "SELECT Pk_id_Producto, nombreProducto FROM Tbl_Productos WHERE estado = 1";

                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                    {
                        adapter.Fill(tablaProductos);
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener los productos: " + ex.Message);
                }
            }

            return tablaProductos;
        }

        // Método para obtener la lista de procesos
        public DataTable ObtenerProcesos()
        {
            DataTable tablaProcesos = new DataTable();

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (!EsConexionValida(conn)) return tablaProcesos;

                try
                {
                    string query = "SELECT Pk_id_proceso, Fk_id_orden FROM tbl_proceso_produccion_encabezado";

                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                    {
                        adapter.Fill(tablaProcesos);
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener los procesos: " + ex.Message);
                }
            }

            return tablaProcesos;
        }
    }
}