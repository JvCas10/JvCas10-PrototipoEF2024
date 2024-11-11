using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Receta;
using System.IO;

namespace Capa_Vista_Receta
{
    public partial class Frm_Recetas : Form
    {
        private Controlador_Recetas controlador = new Controlador_Recetas();
        public Frm_Recetas()
        {
            InitializeComponent();
            CargarProductos();
            CargarProductosDetalle();
            CargarRecetaDetalle();
            CargarRecetasDetalles();
            CargarRecetas();

            btn_Guardar.Enabled = false;
            btn_Actualizar.Enabled = false;
            txt_id_recetas.Enabled = false;
            btn_Modificar.Enabled = true;

            txt_id_detalle.Enabled = false;
            btn_Guardar_Detalle.Enabled = false;
            btn_Actualizar_Detalle.Enabled = false;
            btn_Modificar_Detalle.Enabled = true;

            txt_Cantidad.KeyPress += txt_Numeros_KeyPress;
            txt_Dias.KeyPress += txt_Numeros_KeyPress;
            txt_Horas.KeyPress += txt_Numeros_KeyPress;
            txt_Cantidad_Detalle.KeyPress += txt_Numeros_KeyPress;
            cbo_Producto.KeyPress += txt_Numeros_KeyPress;
            cbo_Producto_Detalle.KeyPress += txt_Numeros_KeyPress;
            cbo_Receta_Detalle.KeyPress += txt_Numeros_KeyPress;

            cbo_Producto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Producto_Detalle.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Receta_Detalle.DropDownStyle = ComboBoxStyle.DropDownList;


            // Agregar tooltips a los botones y campos
            ToolTip toolTip = new ToolTip();

            // Botones
            toolTip.SetToolTip(btn_Guardar, "Guarda la receta actual en la base de datos.");
            toolTip.SetToolTip(btn_Actualizar, "Actualiza la información de la receta seleccionada.");
            toolTip.SetToolTip(btn_Modificar, "Permite editar la receta seleccionada.");
            toolTip.SetToolTip(btn_Eliminar, "Elimina o deshabilita la receta seleccionada.");
            toolTip.SetToolTip(btn_Nuevo, "Crea una nueva receta.");
            toolTip.SetToolTip(btn_Guardar_Detalle, "Guarda los detalles de la receta.");
            toolTip.SetToolTip(btn_Actualizar_Detalle, "Actualiza los detalles de la receta seleccionada.");
            toolTip.SetToolTip(btn_Modificar_Detalle, "Permite modificar los detalles de la receta.");
            toolTip.SetToolTip(btn_Nuevo_Detalle, "Crea un nuevo detalle de receta.");
            toolTip.SetToolTip(btn_Salir, "Cierra el formulario de recetas.");
            toolTip.SetToolTip(btn_Reportes, "Muestra el reporte.");

            // Campos de texto y combos
            toolTip.SetToolTip(txt_id_recetas, "ID único de la receta. Generado automáticamente.");
            toolTip.SetToolTip(txt_Descripcion, "Descripción detallada de la receta.");
            toolTip.SetToolTip(txt_Cantidad, "Cantidad necesaria de producto para la receta.");
            toolTip.SetToolTip(txt_Area, "Área de preparación de la receta.");
            toolTip.SetToolTip(txt_Cama, "Cama o lugar de almacenamiento.");
            toolTip.SetToolTip(txt_Dias, "Días necesarios para la preparación.");
            toolTip.SetToolTip(txt_Horas, "Horas requeridas para la preparación.");
            toolTip.SetToolTip(cbo_Producto, "Selecciona el producto principal para la receta.");

            // Detalles de receta
            toolTip.SetToolTip(txt_id_detalle, "ID único para el detalle de la receta.");
            toolTip.SetToolTip(txt_Cantidad_Detalle, "Cantidad de producto en este detalle de la receta.");
            toolTip.SetToolTip(cbo_Producto_Detalle, "Selecciona un producto para agregar al detalle de la receta.");
            toolTip.SetToolTip(cbo_Receta_Detalle, "Selecciona la receta a la que pertenece el detalle.");

            // Ayuda
            toolTip.SetToolTip(btn_Ayuda, "Muestra la ayuda del módulo de recetas.");
        }
        private void txt_Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarProductos()
        {
            DataTable productos = controlador.ObtenerProductos();
            cbo_Producto.DataSource = productos;
            cbo_Producto.DisplayMember = "nombreProducto";
            cbo_Producto.ValueMember = "Pk_id_Producto";
        }

        private void LimpiarCampos()
        {
           
            txt_Descripcion.Clear();
            txt_Cantidad.Clear();
            txt_Area.Clear();
            txt_Cama.Clear();
            txt_Dias.Clear();
            txt_Horas.Clear();
            btn_Guardar.Enabled = true; 
            btn_Modificar.Enabled = true;
        }

        private void CargarRecetas()
        {
            dgv_Recetas.DataSource = controlador.ObtenerRecetas();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            txt_id_recetas.Text = controlador.ObtenerNuevoId().ToString();
            btn_Actualizar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;
            LimpiarCampos();
        }



        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener y convertir los valores de los campos
                int idProducto = Convert.ToInt32(cbo_Producto.SelectedValue);
                string descripcion = txt_Descripcion.Text;
                int cantidad = Convert.ToInt32(txt_Cantidad.Text);
                string area = txt_Area.Text;
                string cama = txt_Cama.Text;
                int dias = Convert.ToInt32(txt_Dias.Text);
                int horas = Convert.ToInt32(txt_Horas.Text);

                // Llamar al método para guardar la receta
                controlador.GuardarReceta(idProducto, descripcion, cantidad, area, cama, dias, horas);

                // Mensaje de éxito
                MessageBox.Show("La receta se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresca el DataGridView y limpia los campos
                CargarRecetas();
                LimpiarCampos();
                btn_Modificar.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos numéricos estén correctamente ingresados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la receta: " + ex.Message);
            }


        }


        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que un registro esté seleccionado en el DataGridView
                if (dgv_Recetas.SelectedRows.Count > 0)
                {
                    var row = dgv_Recetas.SelectedRows[0];

                    // Rellenar los campos con los datos del registro seleccionado
                    txt_id_recetas.Text = row.Cells["pk_id_receta"].Value.ToString();
                    cbo_Producto.SelectedValue = row.Cells["fk_id_producto"].Value;
                    txt_Descripcion.Text = row.Cells["descripcion"].Value.ToString();
                    txt_Cantidad.Text = row.Cells["cantidad"].Value.ToString();
                    txt_Area.Text = row.Cells["area"].Value.ToString();
                    txt_Cama.Text = row.Cells["cama"].Value.ToString();
                    txt_Dias.Text = row.Cells["dias"].Value.ToString();
                    txt_Horas.Text = row.Cells["horas"].Value.ToString();

                    btn_Actualizar.Enabled = true;
                    btn_Guardar.Enabled = false;
                    btn_Eliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro para consultar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Consultar: " + ex.Message);
            }

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se haya seleccionado un registro en el DataGridView
                if (dgv_Recetas.CurrentRow != null)
                {
                    // Obtiene el ID del registro seleccionado
                    int idReceta = Convert.ToInt32(dgv_Recetas.CurrentRow.Cells["Pk_id_receta"].Value);

                    // Obtiene los datos de los campos
                    int idProducto = Convert.ToInt32(cbo_Producto.SelectedValue);
                    string descripcion = txt_Descripcion.Text;
                    int cantidad = Convert.ToInt32(txt_Cantidad.Text);
                    string area = txt_Area.Text;
                    string cama = txt_Cama.Text;
                    int dias = Convert.ToInt32(txt_Dias.Text);
                    int horas = Convert.ToInt32(txt_Horas.Text);

                    // Llama al método para actualizar el registro
                    controlador.ActualizarReceta(idReceta, idProducto, descripcion, cantidad, area, cama, dias, horas);

                    // Recarga los datos en el DataGridView
                    CargarRecetas();

                    // Muestra un mensaje indicando que la actualización fue exitosa
                    MessageBox.Show("Registro de receta se Modifico y se Actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún registro.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos ingresados. Verifique e intente nuevamente.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Algunos campos necesarios no están seleccionados o están vacíos.", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Recetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idReceta = int.Parse(txt_id_recetas.Text);
                controlador.EliminarReceta(idReceta);
                MessageBox.Show("Registro deshabilitado exitosamente.");
                CargarRecetas();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deshabilitar el registro: " + ex.Message);
            }
        }

        //-----------------------------------------AQUI COMIENZA PARA RECETA DETALLES---------------------------------//

        private void btn_Nuevo_Detalle_Click(object sender, EventArgs e)
        {
            txt_id_detalle.Text = controlador.ObtenerSiguienteIdDetalle().ToString();
            btn_Actualizar_Detalle.Enabled = false;
            btn_Modificar_Detalle.Enabled = false;
            btn_Guardar_Detalle.Enabled = true;
            LimpiarCamposDetalle();
        }

        private void CargarRecetasDetalles()
        {
            dgv_Recetas_Detalles.DataSource = controlador.ObtenerRecetasDetalles();
        }

        private void CargarProductosDetalle()
        {
            DataTable productosdetalle = controlador.ObtenerProductosDetalle();
            cbo_Producto_Detalle.DataSource = productosdetalle;
            cbo_Producto_Detalle.DisplayMember = "nombreProducto";
            cbo_Producto_Detalle.ValueMember = "Pk_id_Producto";
        }

        private void LimpiarCamposDetalle()
        {
            //txt_id_recetas.Clear();
            
            txt_Cantidad_Detalle.Clear();
            btn_Guardar_Detalle.Enabled = true; // Deshabilita el botón de guardar
            btn_Modificar_Detalle.Enabled = true;
        }
        private void CargarRecetaDetalle()
        {
            DataTable recetadetalle = controlador.ObtenerRecetaDetalle();
            cbo_Receta_Detalle.DataSource = recetadetalle;
            cbo_Receta_Detalle.DisplayMember = "descripcion";
            cbo_Receta_Detalle.ValueMember = "Pk_id_receta";
        }

        private void btn_Guardar_Detalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener y convertir los valores de los campos
                int idReceta = Convert.ToInt32(cbo_Receta_Detalle.SelectedValue);
                int idProducto = Convert.ToInt32(cbo_Producto_Detalle.SelectedValue);
                int cantidad = Convert.ToInt32(txt_Cantidad_Detalle.Text);

                // Llamar al método para guardar la receta
                controlador.GuardarRecetaDetalle(idReceta, idProducto, cantidad);

                // Mensaje de éxito
                MessageBox.Show("La Receta Detalle se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresca el DataGridView y limpia los campos
                CargarRecetasDetalles();
                LimpiarCamposDetalle();
                btn_Modificar_Detalle.Enabled = true;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, asegúrate de que todos los campos estén correctamente ingresados: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar la receta detalle: " + ex.Message);
            }
        }

        private void btn_Modificar_Detalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que un registro esté seleccionado en el DataGridView
                if (dgv_Recetas_Detalles.SelectedRows.Count > 0)
                {
                    var row = dgv_Recetas_Detalles.SelectedRows[0];

                    // Rellenar los campos con los datos del registro seleccionado
                    txt_id_detalle.Text = row.Cells["pk_id_detalle"].Value.ToString();
                    cbo_Receta_Detalle.SelectedValue = row.Cells["fk_id_receta"].Value;
                    cbo_Producto_Detalle.SelectedValue = row.Cells["fk_id_producto"].Value;
                    txt_Cantidad_Detalle.Text = row.Cells["cantidad"].Value.ToString();

                    btn_Actualizar_Detalle.Enabled = true;
                    btn_Guardar_Detalle.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un registro para consultar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Consultar: " + ex.Message);
            }
        }

        private void btn_Actualizar_Detalle_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se haya seleccionado un registro en el DataGridView
                if (dgv_Recetas_Detalles.CurrentRow != null)
                {
                    // Obtiene el ID del registro seleccionado
                    int idDetalle = Convert.ToInt32(dgv_Recetas_Detalles.CurrentRow.Cells["pk_id_detalle"].Value);

                    // Obtiene los datos de los campos
                    int idReceta = Convert.ToInt32(cbo_Receta_Detalle.SelectedValue);
                    int idProducto = Convert.ToInt32(cbo_Producto_Detalle.SelectedValue);
                    int cantidad = Convert.ToInt32(txt_Cantidad_Detalle.Text);

                    // Llama al método para actualizar el registro
                    controlador.ActualizarRecetaDetalle(idDetalle, idReceta, idProducto, cantidad);

                    // Recarga los datos en el DataGridView
                    CargarRecetasDetalles();

                    // Muestra un mensaje indicando que la actualización fue exitosa
                    MessageBox.Show("Registro de receta detalle se Modifico y se Actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún registro.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en el formato de los datos ingresados. Verifique e intente nuevamente.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Algunos campos necesarios no están seleccionados o están vacíos.", "Error de Referencia Nula", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //BOTON DE AYUDA
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "AyudaRecetas", "AyudaRecetas.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "AyudaRecetas.html");


            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            Reportes reporte = new Reportes();
            reporte.Show();
        }
    }
}
