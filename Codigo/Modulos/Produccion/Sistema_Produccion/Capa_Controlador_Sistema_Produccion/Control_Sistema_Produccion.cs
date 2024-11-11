using System;
using System.Data;
using System.Data.Odbc; // Para manejar errores de ODBC
using Capa_Modelo_Sistema_Produccion;

namespace Capa_Controlador_Sistema_Produccion
{
    public class Control_Sistema_Produccion // Clase pública con métodos completos
    {
        private Sentencia_Sistema_Produccion sentencia = new Sentencia_Sistema_Produccion();

        // Método para insertar en tbl_proceso_produccion_encabezado
        public bool InsertarEncabezado(int idOrden, int idMaquinaria)
        {
            try
            {
                int idProceso = ObtenerSiguienteIdProceso();
                return sentencia.InsertarEncabezado(idProceso, idOrden, idMaquinaria);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error ODBC al insertar en encabezado: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en encabezado: " + ex.Message);
                return false;
            }
        }

        // Método para insertar en tbl_proceso_produccion_detalle
        public bool InsertarDetalle(int idProducto, int idReceta, int idEmpleado, int idProceso, int cantidad, decimal costoU, decimal costoT, decimal duracionHoras, decimal manoDeObra, decimal costoLuz, decimal costoAgua)
        {
            try
            {
                int idProcesoDetalle = ObtenerSiguienteIdProcesoDetalle();
                return sentencia.InsertarDetalle(idProcesoDetalle, idProducto, idReceta, idEmpleado, idProceso, cantidad, costoU, costoT, duracionHoras, manoDeObra, costoLuz, costoAgua);
            }
            catch (OdbcException ex)
            {
                Console.WriteLine("Error ODBC al insertar en detalle: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar en detalle: " + ex.Message);
                return false;
            }
        }

        // Método para obtener el siguiente ID de proceso
        public int ObtenerSiguienteIdProceso()
        {
            try
            {
                int lastId = sentencia.ObtenerUltimoIdProceso();
                return lastId + 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el siguiente ID de proceso: " + ex.Message);
                return -1; // Retorna -1 en caso de error
            }
        }

        // Método para obtener el siguiente ID de proceso detalle
        public int ObtenerSiguienteIdProcesoDetalle()
        {
            try
            {
                int lastId = sentencia.ObtenerUltimoIdProcesoDetalle();
                return lastId + 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el siguiente ID de proceso detalle: " + ex.Message);
                return -1;
            }
        }

        // Método para obtener órdenes de producción
        public DataTable ObtenerOrdenesProduccion()
        {
            try
            {
                return sentencia.ObtenerOrdenesProduccion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener órdenes de producción: " + ex.Message);
                return new DataTable(); // Retorna una tabla vacía en caso de error
            }
        }

        // Método para obtener maquinarias
        public DataTable ObtenerMaquinarias()
        {
            try
            {
                return sentencia.ObtenerMaquinarias();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener maquinarias: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener empleados
        public DataTable ObtenerEmpleados()
        {
            try
            {
                return sentencia.ObtenerEmpleados();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleados: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener el detalle de una orden específica
        public DataTable ObtenerDetalleOrden(int idOrden)
        {
            try
            {
                return sentencia.ObtenerDetalleOrden(idOrden);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalle de la orden: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener producto y receta asociados a un producto específico
        public DataTable ObtenerProductoYReceta(int idProducto)
        {
            try
            {
                return sentencia.ObtenerProductoYReceta(idProducto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener producto y receta: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener detalles de una receta específica
        public DataTable ObtenerRecetaDetalle(int idReceta)
        {
            try
            {
                return sentencia.ObtenerRecetaDetalle(idReceta);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener detalles de la receta: " + ex.Message);
                return new DataTable();
            }
        }
    }
}
