using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Ordenes;
using System.Data.Odbc;

namespace Capa_Controlador_Ordenes
{
    public class Control_Ordenes // Clase con modificador 'public' para acceso externo
    {
        private readonly Sentencia_Ordenes sentencias;

        public Control_Ordenes()
        {
            sentencias = new Sentencia_Ordenes();
        }

        // Método para crear una nueva orden con sus productos (detalles) en una transacción
        public bool CrearOrdenConDetalles(DateTime fechaInicio, DateTime fechaFin, int estado, DataTable productos)
        {
            if (productos == null || productos.Rows.Count == 0)
            {
                Console.WriteLine("Error: No se proporcionaron productos para la orden.");
                return false;
            }

            using (OdbcConnection conn = sentencias.ObtenerConexionVerificada())
            using (OdbcTransaction transaccion = conn.BeginTransaction())
            {
                try
                {
                    // Obtener el siguiente ID de la orden
                    int nuevoId = ObtenerSiguienteIdOrden();

                    // Insertar la orden en tbl_ordenes_produccion
                    bool exitoOrden = sentencias.AgregarOrden(nuevoId, fechaInicio, fechaFin, estado, conn, transaccion);
                    if (!exitoOrden)
                    {
                        Console.WriteLine("Error al crear la orden.");
                        transaccion.Rollback();
                        return false;
                    }

                    // Insertar detalles de la orden
                    foreach (DataRow producto in productos.Rows)
                    {
                        int idProducto = Convert.ToInt32(producto["idProducto"]);
                        int cantidad = Convert.ToInt32(producto["cantidad"]);

                        // Validación de producto duplicado en los detalles
                        if (ProductoYaAgregado(nuevoId, idProducto, conn, transaccion))
                        {
                            Console.WriteLine($"Advertencia: El producto ID {idProducto} ya está en la orden.");
                            continue;
                        }

                        bool exitoDetalle = sentencias.AgregarDetalleOrden(nuevoId, idProducto, cantidad, conn, transaccion);
                        if (!exitoDetalle)
                        {
                            Console.WriteLine($"Error al agregar el detalle del producto ID {idProducto} en la orden.");
                            transaccion.Rollback();
                            return false;
                        }
                    }

                    // Confirmar transacción
                    transaccion.Commit();
                    Console.WriteLine("Orden y detalles agregados exitosamente.");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error en CrearOrdenConDetalles: {ex.Message}");
                    transaccion.Rollback();
                    return false;
                }
            }
        }

        // Método para verificar si un producto ya está agregado a una orden
        private bool ProductoYaAgregado(int idOrden, int idProducto, OdbcConnection conn, OdbcTransaction transaccion)
        {
            DataTable detalles = sentencias.ObtenerDetallesOrden(idOrden, conn, transaccion);
            foreach (DataRow row in detalles.Rows)
            {
                if (Convert.ToInt32(row["Fk_id_producto"]) == idProducto)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para actualizar una orden existente (sin modificar productos)
        public bool ActualizarOrden(int idOrden, DateTime fechaInicio, DateTime fechaFin, int estado)
        {
            try
            {
                return sentencias.ActualizarOrden(idOrden, fechaInicio, fechaFin, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar la orden: {ex.Message}");
                return false;
            }
        }

        // Método para desactivar una orden (Eliminación lógica)
        public bool DesactivarOrden(int idOrden)
        {
            try
            {
                return sentencias.DesactivarOrden(idOrden);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al desactivar la orden: {ex.Message}");
                return false;
            }
        }

        // Método para buscar órdenes con productos
        public DataTable BuscarOrdenes(string fechaInicio = "", string fechaFin = "", int estado = -1)
        {
            try
            {
                return sentencias.BuscarOrdenes(fechaInicio, fechaFin, estado);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar órdenes: {ex.Message}");
                return null;
            }
        }

        // Método para obtener los productos disponibles
        public DataTable ObtenerProductos()
        {
            try
            {
                return sentencias.ObtenerProductos();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener productos: {ex.Message}");
                return null;
            }
        }

        // Método para obtener el siguiente ID de orden
        public int ObtenerSiguienteIdOrden()
        {
            try
            {
                return sentencias.ObtenerUltimoIdOrden() + 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el siguiente ID de orden: {ex.Message}");
                return 0;
            }
        }

        // Método para obtener los detalles de una orden específica
        public DataTable ObtenerDetallesOrden(int idOrden)
        {
            try
            {
                using (OdbcConnection conn = sentencias.ObtenerConexionVerificada())
                using (OdbcTransaction transaccion = conn.BeginTransaction())
                {
                    return sentencias.ObtenerDetallesOrden(idOrden, conn, transaccion);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener detalles de la orden: {ex.Message}");
                return null;
            }
        }
    }
}
