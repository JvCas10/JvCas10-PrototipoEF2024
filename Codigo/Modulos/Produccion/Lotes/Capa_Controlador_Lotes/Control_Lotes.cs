using System;
using System.Data;

namespace Capa_Controlador_Lotes
{
    public class Control_Lotes
    {
        private readonly Capa_Modelo_Lotes.Sentencia_Lotes sentencias;

        // Constructor que inicializa la instancia de Sentencia_Lotes para interactuar con la base de datos
        public Control_Lotes()
        {
            sentencias = new Capa_Modelo_Lotes.Sentencia_Lotes();
        }

        // Método para agregar un nuevo lote
        public void AgregarLotes(int idLote, string codigoLote, DateTime fechaProduccionLote, int cantidadLote, int estado, int idProducto)
        {
            if (cantidadLote <= 0)
            {
                Console.WriteLine("La cantidad del lote debe ser mayor que cero.");
                return;
            }

            try
            {
                sentencias.InsertarLote(idLote, codigoLote, fechaProduccionLote, cantidadLote, estado, idProducto);
                Console.WriteLine("Lote agregado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar un lote: " + ex.Message);
            }
        }

        // Método para actualizar un lote existente
        public void ActualizarLotes(int idLote, string codigoLote, DateTime fechaProduccionLote, int cantidadLote, int estado, int idProducto)
        {
            if (idLote <= 0)
            {
                Console.WriteLine("El ID del lote debe ser mayor que cero.");
                return;
            }

            if (cantidadLote < 0)
            {
                Console.WriteLine("La cantidad del lote no puede ser negativa.");
                return;
            }

            try
            {
                sentencias.ActualizarLote(idLote, codigoLote, fechaProduccionLote, cantidadLote, estado, idProducto);
                Console.WriteLine("Lote actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el lote: " + ex.Message);
            }
        }

        // Método para desactivar un lote
        public void DesactivarLotes(int idLote)
        {
            try
            {
                // Llama al método para desactivar el lote en la base de datos
                sentencias.DesactivarLote(idLote);
                Console.WriteLine("Lote desactivado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desactivar el lote: " + ex.Message);
            }
        }


        // Método para cargar los lotes
        public DataTable CargarLotes()
        {
            try
            {
                DataTable lotes = sentencias.ObtenerLotes();
                Console.WriteLine("Datos de los lotes cargados correctamente. Total de registros: " + lotes.Rows.Count);
                return lotes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los lotes: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para obtener los datos de una fila seleccionada de DataGridView
        public (int idLote, string codigoLote, DateTime fechaProduccion, int cantidad, int estado, int idProducto) ObtenerDatosLoteSeleccionado(DataRow fila)
        {
            int idLote = Convert.ToInt32(fila["Pk_id_lote"]);
            string codigoLote = fila["codigo_lote"].ToString();
            DateTime fechaProduccion = Convert.ToDateTime(fila["FechaProduccion"]); // Usando el alias sin espacios ni caracteres especiales
            int cantidad = Convert.ToInt32(fila["cantidad"]);
            int estado = Convert.ToInt32(fila["estado"]);
            int idProducto = Convert.ToInt32(fila["Fk_id_producto"]);

            return (idLote, codigoLote, fechaProduccion, cantidad, estado, idProducto);
        }

        // Método para obtener el último ID de lote
        public int ObtenerUltimoIdLotes()
        {
            try
            {
                int ultimoId = sentencias.ObtenerUltimoIdLote();
                Console.WriteLine("Último ID del lote obtenido: " + ultimoId);
                return ultimoId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID del lote: " + ex.Message);
                return 0;
            }
        }

        // Método para cargar los productos en un DataTable
        public DataTable CargarProductos()
        {
            try
            {
                DataTable productos = sentencias.ObtenerProductos();
                Console.WriteLine("Productos cargados correctamente. Total de registros: " + productos.Rows.Count);
                return productos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los productos: " + ex.Message);
                return new DataTable();
            }
        }

        // Método para cargar los procesos en un DataTable
        public DataTable CargarProcesos()
        {
            try
            {
                DataTable procesos = sentencias.ObtenerProcesos();
                Console.WriteLine("Procesos cargados correctamente. Total de registros: " + procesos.Rows.Count);
                return procesos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los procesos: " + ex.Message);
                return new DataTable();
            }
        }
    }
}