using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Receta
{
    
    public class Sentencias_Recetas
    {
        private Conexion_Recetas conexion = new Conexion_Recetas();

        // Método para obtener el siguiente ID de receta
        public int ObtenerSiguienteIdReceta()
        {
            int id = 1;
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_receta) FROM tbl_recetas";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    id = Convert.ToInt32(result) + 1;
                }
            }
            return id;
        }

        // Método para obtener productos para el ComboBox
        public DataTable ObtenerProductos()
        {
            DataTable productos = new DataTable();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_Producto, nombreProducto FROM tbl_productos";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(productos);
            }
            return productos;
        }

        // Método para guardar una nueva receta
        public void GuardarReceta(int idProducto, string descripcion, int cantidad, string area, string cama, int dias, int horas)
        {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                {

                    // Consulta para insertar en la tabla
                    string query = "INSERT INTO tbl_recetas (fk_id_producto, descripcion, cantidad, area, cama, estado, dias, horas) " +
                                   "VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        // Asignar los valores a los parámetros de la consulta
                        cmd.Parameters.AddWithValue("?", idProducto);       
                        cmd.Parameters.AddWithValue("?", descripcion);     
                        cmd.Parameters.AddWithValue("?", cantidad);         
                        cmd.Parameters.AddWithValue("?", area);             
                        cmd.Parameters.AddWithValue("?", cama);             
                        cmd.Parameters.AddWithValue("?", 1);                
                        cmd.Parameters.AddWithValue("?", dias);             
                        cmd.Parameters.AddWithValue("?", horas);          

                        
                        cmd.ExecuteNonQuery();
                    }
                }
        }

        // Método para actualizar una receta existente
        public void ModificarReceta(int idReceta, int idProducto, string descripcion, int cantidad, string area, string cama, int dias, int horas)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                conn.Open();
                string query = "UPDATE tbl_recetas SET fk_id_producto = ?, descripcion = ?, cantidad = ?, area = ?, cama = ?, dias = ?, horas = ? WHERE pk_id_receta = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("fk_id_producto", idProducto);
                    cmd.Parameters.AddWithValue("descripcion", descripcion);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.Parameters.AddWithValue("area", area);
                    cmd.Parameters.AddWithValue("cama", cama);
                    cmd.Parameters.AddWithValue("area", dias);
                    cmd.Parameters.AddWithValue("dias", horas);
                    cmd.Parameters.AddWithValue("horas", idReceta);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarReceta(int idReceta, int idProducto, string descripcion, int cantidad, string area, string cama, int dias, int horas)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = @"UPDATE tbl_recetas 
                             SET fk_id_producto = ?, descripcion = ?, cantidad = ?, area = ?, cama = ?, dias = ?, horas =?
                             WHERE pk_id_receta = ? AND estado = 1";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", idProducto);
                    cmd.Parameters.AddWithValue("?", descripcion);
                    cmd.Parameters.AddWithValue("?", cantidad);
                    cmd.Parameters.AddWithValue("?", area);
                    cmd.Parameters.AddWithValue("?", cama);
                    cmd.Parameters.AddWithValue("?", dias);
                    cmd.Parameters.AddWithValue("?", horas);
                    cmd.Parameters.AddWithValue("?", idReceta);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo actualizar el registro, puede que el estado esté en 0 o el ID no sea válido.");
                    }
                }
            }
        }

        public DataTable ObtenerRecetas()
        {
            DataTable recetas = new DataTable();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_recetas";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(recetas);
            }
            return recetas;
        }

        public DataTable ObtenerRecetaPorId(int idReceta)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_recetas WHERE pk_id_receta = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", idReceta);
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                    {
                        DataTable receta = new DataTable();
                        adapter.Fill(receta);
                        return receta;
                    }
                }
            }
        }

        public void EliminarReceta(int idReceta)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "UPDATE tbl_recetas SET estado = 0 WHERE pk_id_receta = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", idReceta);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        //----------------------------------------AQUI COMIENZA PARA LAS RECETAS DETALLES----------------------------------------//

        public int ObtenerSiguienteIdDetalle()
        {
            int id = 1;
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_detalle) FROM tbl_receta_detalle";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    id = Convert.ToInt32(result) + 1;
                }
            }
            return id;
        }

        // Método para obtener productos para el ComboBox
        public DataTable ObtenerProductosDetalle()
        {
            DataTable productosdetalles = new DataTable();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_Producto, nombreProducto FROM tbl_productos";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(productosdetalles);
            }
            return productosdetalles;
        }

        public DataTable ObtenerRecetaDetalle()
        {
            DataTable recetas = new DataTable();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT Pk_id_receta, descripcion FROM tbl_recetas";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(recetas);
            }
            return recetas;
        }


        // Método para guardar una nueva receta
        public void GuardarRecetaDetalle(int idReceta, int idProducto, int cantidad)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {

                // Consulta para insertar en la tabla
                string query = "INSERT INTO tbl_receta_detalle (fk_id_receta, fk_id_producto, cantidad )" +
                               "VALUES (?, ?, ?)";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    // Asignar los valores a los parámetros de la consulta
                    cmd.Parameters.AddWithValue("?", idReceta);
                    cmd.Parameters.AddWithValue("?", idProducto);
                    cmd.Parameters.AddWithValue("?", cantidad);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar una receta existente
        public void ModificarRecetaDetalle(int idDetalle, int idReceta, int idProducto, int cantidad)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                conn.Open();
                string query = "UPDATE tbl_receta_detalle SET fk_id_receta = ?, fk_id_producto = ?, cantidad = ? WHERE pk_id_detalle = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("fk_id_producto", idReceta);
                    cmd.Parameters.AddWithValue("descripcion", idProducto);
                    cmd.Parameters.AddWithValue("cantidad", cantidad);
                    cmd.Parameters.AddWithValue("horas", idDetalle);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarRecetaDetalle(int idDetalle, int idReceta, int idProducto, int cantidad)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = @"UPDATE tbl_receta_detalle 
                             SET fk_id_receta = ?, fk_id_producto = ?, cantidad = ?
                             WHERE pk_id_detalle = ?";

                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", idReceta);
                    cmd.Parameters.AddWithValue("?", idProducto);
                    cmd.Parameters.AddWithValue("?", cantidad);
                    cmd.Parameters.AddWithValue("?", idDetalle);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo actualizar el registro, puede que el ID no sea válido.");
                    }
                }
            }
        }

        public DataTable ObtenerRecetasDetalles()
        {
            DataTable recetasdetalles = new DataTable();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_receta_detalle";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                adapter.Fill(recetasdetalles);
            }
            return recetasdetalles;
        }

        public DataTable ObtenerRecetaPorIdDetalle(int idDetalle)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_receta_detalle WHERE pk_id_detalle = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", idDetalle);
                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(cmd))
                    {
                        DataTable receta = new DataTable();
                        adapter.Fill(receta);
                        return receta;
                    }
                }
            }
        }

    }
}
