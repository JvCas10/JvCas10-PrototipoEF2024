using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Receta;
using System.Data;

namespace Capa_Controlador_Receta
{
    public class  Controlador_Recetas
    {
        private Sentencias_Recetas sentencias = new Sentencias_Recetas();

        public int ObtenerNuevoId()
        {
            return sentencias.ObtenerSiguienteIdReceta();
        }

        public DataTable ObtenerProductos()
        {
            return sentencias.ObtenerProductos();
        }

        public void GuardarReceta( int idProducto, string descripcion, int cantidad, string area, string cama, int dias, int horas)
        {
             sentencias.GuardarReceta(idProducto, descripcion, cantidad, area, cama, dias, horas);
        }

        public void ModificarReceta(int idReceta, int idProducto, string descripcion, int cantidad, string area, string cama, int dias, int horas)
        {
             sentencias.ModificarReceta(idReceta, idProducto, descripcion, cantidad, area, cama, dias, horas);
        }

        public void ActualizarReceta(int idReceta, int idProducto, string descripcion, int cantidad, string area, string cama, int dias, int horas)
        {
            sentencias.ActualizarReceta(idReceta, idProducto, descripcion, cantidad, area, cama, dias, horas);
        }

        public DataTable ObtenerRecetas()
        {
            return sentencias.ObtenerRecetas();
        }

        public void EliminarReceta(int idReceta)
        {
            sentencias.EliminarReceta(idReceta);
        }

        public DataTable CargarRecetaPorId(int idReceta)
        {
            return sentencias.ObtenerRecetaPorId(idReceta);
        }


        //-------------------------------------AQUI COMIENZA PARA LAS RECETAS DETALLES----------------------------------//

        public int ObtenerSiguienteIdDetalle()
        {
            return sentencias.ObtenerSiguienteIdDetalle();
        }

        public DataTable ObtenerProductosDetalle()
        {
            return sentencias.ObtenerProductosDetalle();
        }
        public DataTable ObtenerRecetaDetalle()
        {
            return sentencias.ObtenerRecetaDetalle();
        }

        public void GuardarRecetaDetalle(int idReceta, int idProducto, int cantidad)
        {
            sentencias.GuardarRecetaDetalle(idReceta, idProducto, cantidad);
        }

        public void ModificarRecetaDetalle(int idDetalle, int idReceta, int idProducto, int cantidad)
        {
            sentencias.ModificarRecetaDetalle(idDetalle, idReceta, idProducto, cantidad);
        }

        public void ActualizarRecetaDetalle(int idDetalle, int idReceta, int idProducto, int cantidad)
        {
            sentencias.ActualizarRecetaDetalle(idDetalle, idReceta, idProducto, cantidad);
        }

        public DataTable ObtenerRecetasDetalles()
        {
            return sentencias.ObtenerRecetasDetalles();
        }

        public DataTable CargarRecetaPorIdDetalles(int idReceta)
        {
            return sentencias.ObtenerRecetaPorIdDetalle(idReceta);
        }

    }
}
