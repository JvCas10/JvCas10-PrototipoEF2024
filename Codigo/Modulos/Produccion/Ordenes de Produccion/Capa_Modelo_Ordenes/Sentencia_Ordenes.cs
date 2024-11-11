using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Ordenes
{
    public class Sentencia_Ordenes // Clase con nombre estandarizado y modificador 'public'
    {
        private readonly Conexion_Ordenes conexion; // Cambiado a Conexion_Ordenes
        private readonly int maxRetries = 3; // Para reintentos de conexión

        public Sentencia_Ordenes()
        {
            conexion = new Conexion_Ordenes(); // Cambiado a Conexion_Ordenes
        }

        // Método para verificar conexión antes de ejecutar una consulta, con reintento si falla
        public OdbcConnection ObtenerConexionVerificada()
        {
            int intentos = 0;
            OdbcConnection conn = null;
            while (intentos < maxRetries)
            {
                try
                {
                    conn = conexion.Probar_Conexion();
                    if (conn != null && conn.State == ConnectionState.Open)
                        return conn;
                    throw new Exception("Conexión fallida.");
                }
                catch (Exception ex)
                {
                    intentos++;
                    Console.WriteLine($"Error de conexión, intento {intentos}: {ex.Message}");
                    if (intentos >= maxRetries)
                    {
                        throw new Exception("No se pudo establecer conexión después de varios intentos.");
                    }
                }
            }
            return conn;
        }

        // Método para insertar el encabezado de la orden
        public bool AgregarOrden(int idOrden, DateTime fechaInicio, DateTime fechaFin, int estado, OdbcConnection conn, OdbcTransaction transaccion)
        {
            string query = "INSERT INTO tbl_ordenes_produccion (Pk_id_orden, fecha_inicio, fecha_fin, estado) VALUES (?, ?, ?, ?)";
            try
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn, transaccion))
                {
                    cmd.Parameters.AddWithValue("Pk_id_orden", idOrden);
                    cmd.Parameters.AddWithValue("fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fecha_fin", fechaFin);
                    cmd.Parameters.AddWithValue("estado", estado);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                LogError("AgregarOrden", ex);
                return false;
            }
        }

        // Método para insertar productos en detalle de orden
        public bool AgregarDetalleOrden(int idOrden, int idProducto, int cantidad, OdbcConnection conn, OdbcTransaction transaccion)
        {
            string query = "INSERT INTO tbl_ordenes_produccion_detalle (Fk_id_orden, Fk_id_producto, cantidad) VALUES (?, ?, ?)";
            try
            {
                using (OdbcCommand cmd = new OdbcCommand(query, conn, transaccion))
                {
                    cmd.Parameters.AddWithValue("Fk_id_orden", idOrden);
                    cmd.Parameters.AddWithValue("Fk_id_producto", idProducto);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                LogError("AgregarDetalleOrden", ex);
                return false;
            }
        }

        // Obtener el último ID de orden
        public int ObtenerUltimoIdOrden()
        {
            string query = "SELECT MAX(Pk_id_orden) FROM tbl_ordenes_produccion";
            try
            {
                using (OdbcConnection conn = ObtenerConexionVerificada())
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
            }
            catch (Exception ex)
            {
                LogError("ObtenerUltimoIdOrden", ex);
                return 0;
            }
        }

        // Método para buscar órdenes con filtros opcionales
        public DataTable BuscarOrdenes(string fechaInicio = "", string fechaFin = "", int estado = -1)
        {
            string query = "SELECT Pk_id_orden, fecha_inicio, fecha_fin, estado FROM tbl_ordenes_produccion WHERE 1=1";
            if (!string.IsNullOrEmpty(fechaInicio)) query += " AND fecha_inicio >= ?";
            if (!string.IsNullOrEmpty(fechaFin)) query += " AND fecha_fin <= ?";
            if (estado != -1) query += " AND estado = ?";

            try
            {
                DataTable tabla = new DataTable();
                using (OdbcConnection conn = ObtenerConexionVerificada())
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, conn))
                {
                    if (!string.IsNullOrEmpty(fechaInicio)) da.SelectCommand.Parameters.AddWithValue("fecha_inicio", fechaInicio);
                    if (!string.IsNullOrEmpty(fechaFin)) da.SelectCommand.Parameters.AddWithValue("fecha_fin", fechaFin);
                    if (estado != -1) da.SelectCommand.Parameters.AddWithValue("estado", estado);

                    da.Fill(tabla);
                }
                return tabla;
            }
            catch (Exception ex)
            {
                LogError("BuscarOrdenes", ex);
                return null;
            }
        }

        // Método para obtener los productos disponibles
        public DataTable ObtenerProductos()
        {
            string query = "SELECT Pk_id_Producto, nombreProducto FROM tbl_productos";
            try
            {
                DataTable tabla = new DataTable();
                using (OdbcConnection conn = ObtenerConexionVerificada())
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, conn))
                {
                    da.Fill(tabla);
                }
                return tabla;
            }
            catch (Exception ex)
            {
                LogError("ObtenerProductos", ex);
                return null;
            }
        }

        // Desactivar una orden (eliminación lógica)
        public bool DesactivarOrden(int idOrden)
        {
            string query = "UPDATE tbl_ordenes_produccion SET estado = 0 WHERE Pk_id_orden = ?";
            try
            {
                using (OdbcConnection conn = ObtenerConexionVerificada())
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("Pk_id_orden", idOrden);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                LogError("DesactivarOrden", ex);
                return false;
            }
        }

        // Actualizar una orden existente
        public bool ActualizarOrden(int idOrden, DateTime fechaInicio, DateTime fechaFin, int estado)
        {
            string query = "UPDATE tbl_ordenes_produccion SET fecha_inicio = ?, fecha_fin = ?, estado = ? WHERE Pk_id_orden = ?";
            try
            {
                using (OdbcConnection conn = ObtenerConexionVerificada())
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("fecha_inicio", fechaInicio);
                    cmd.Parameters.AddWithValue("fecha_fin", fechaFin);
                    cmd.Parameters.AddWithValue("estado", estado);
                    cmd.Parameters.AddWithValue("Pk_id_orden", idOrden);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                LogError("ActualizarOrden", ex);
                return false;
            }
        }

        // Obtener detalles de productos de una orden, incluyendo el nombre del producto
        public DataTable ObtenerDetallesOrden(int idOrden, OdbcConnection conn, OdbcTransaction transaccion)
        {
            string query = @"
            SELECT d.Fk_id_producto, p.nombreProducto, d.cantidad 
            FROM tbl_ordenes_produccion_detalle d
            JOIN tbl_productos p ON d.Fk_id_producto = p.Pk_id_Producto
            WHERE d.Fk_id_orden = ?";

            try
            {
                DataTable tabla = new DataTable();
                using (OdbcCommand cmd = new OdbcCommand(query, conn, transaccion))
                {
                    cmd.Parameters.AddWithValue("Fk_id_orden", idOrden);
                    using (OdbcDataAdapter da = new OdbcDataAdapter(cmd))
                    {
                        da.Fill(tabla);
                    }
                }
                return tabla;
            }
            catch (Exception ex)
            {
                LogError("ObtenerDetallesOrden", ex);
                return null;
            }
        }

        // Método para registrar errores en un archivo o sistema de logs
        private void LogError(string metodo, Exception ex)
        {
            Console.WriteLine($"[{DateTime.Now}] Error en {metodo}: {ex.Message}");
        }

        // Iniciar transacción
        public OdbcTransaction IniciarTransaccion(OdbcConnection conn)
        {
            try
            {
                return conn.BeginTransaction();
            }
            catch (Exception ex)
            {
                LogError("IniciarTransaccion", ex);
                throw;
            }
        }

        // Confirmar transacción
        public void ConfirmarTransaccion(OdbcTransaction transaccion)
        {
            try
            {
                transaccion?.Commit();
            }
            catch (Exception ex)
            {
                LogError("ConfirmarTransaccion", ex);
                throw;
            }
        }

        // Revertir transacción
        public void RevertirTransaccion(OdbcTransaction transaccion)
        {
            try
            {
                transaccion?.Rollback();
            }
            catch (Exception ex)
            {
                LogError("RevertirTransaccion", ex);
                throw;
            }
        }
    }
}
