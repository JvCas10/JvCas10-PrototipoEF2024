using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ordenes;
using System.IO;

namespace Capa_Vista_Ordenes
{
    public partial class Frm_Ordenes_De_Produccion : Form
    {
        private readonly Control_Ordenes control;

        public Frm_Ordenes_De_Produccion()
        {
            InitializeComponent();
            control = new Control_Ordenes();
            InicializarFormulario();

            // Inicializa y configura el objeto ToolTip
            ToolTip ToolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 100,
                ReshowDelay = 100,
                ShowAlways = true
            };

            // Configura los tooltips para cada control
            ConfigurarTooltips(ToolTip);
        }
        private void ConfigurarTooltips(ToolTip toolTip)
        {

            // Tooltips para los componentes de datos y botones
            toolTip.SetToolTip(txt_id_orden, "ID de la orden de producción (automático)");
            toolTip.SetToolTip(cbo_producto, "Seleccione un producto para la orden de producción");
            toolTip.SetToolTip(cbo_estado_orden, "Estado de la orden de producción (Activo/Inactivo)");
            toolTip.SetToolTip(dtp_fecha_inicio, "Fecha de inicio de la orden de producción");
            toolTip.SetToolTip(dtp_fecha_fin, "Fecha de fin de la orden de producción");
            toolTip.SetToolTip(dgv_ordenes, "Tabla con las órdenes de producción existentes");
            toolTip.SetToolTip(dgv_detalle_orden, "Detalle de productos incluidos en la orden");

            // Tooltips para botones de acción
            toolTip.SetToolTip(btn_agregar, "Agregar una nueva orden de producción");
            toolTip.SetToolTip(btn_actualizar, "Actualizar la orden de producción seleccionada");
            toolTip.SetToolTip(btn_eliminar, "Desactivar la orden de producción seleccionada");
            toolTip.SetToolTip(btn_buscar, "Buscar órdenes de producción según criterios especificados");
            toolTip.SetToolTip(btn_agregar_producto, "Agregar el producto seleccionado con la cantidad especificada a la orden");
            toolTip.SetToolTip(btn_Salir, "Cerrar el formulario de órdenes de producción");
            toolTip.SetToolTip(btn_Reporte, "Generar un reporte de las órdenes de producción");
            toolTip.SetToolTip(btn_Ayuda, "Abrir el archivo de ayuda para el módulo de órdenes de producción");
            toolTip.SetToolTip(btn_Cancelar, "Restablecer el formulario a su estado original, mostrando todas las órdenes y limpiando los campos.");
        }

        private void InicializarFormulario()
        {
            try
            {
                CargarProductos();
                CargarOrdenes();
                CargarEstados();
                txt_id_orden.ReadOnly = true;
                ObtenerProximoIdOrden();
                ConfigurarDataGridViewDetalle();
                dgv_ordenes.CellClick += dgv_ordenes_CellClick;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                cbo_producto.DataSource = control.ObtenerProductos();
                cbo_producto.DisplayMember = "nombreProducto";
                cbo_producto.ValueMember = "Pk_id_Producto";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstados()
        {
            cbo_estado_orden.Items.Add("Activo");
            cbo_estado_orden.Items.Add("Inactivo");
        }

        private void ObtenerProximoIdOrden()
        {
            try
            {
                txt_id_orden.Text = control.ObtenerSiguienteIdOrden().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el siguiente ID de orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarOrdenes()
        {
            try
            {
                dgv_ordenes.DataSource = control.BuscarOrdenes();
                AjustarColumnasDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar órdenes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarColumnasDGV()
        {
            dgv_ordenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_ordenes.Columns["Pk_id_orden"].HeaderText = "ID Orden";
            dgv_ordenes.Columns["fecha_inicio"].HeaderText = "Fecha Inicio";
            dgv_ordenes.Columns["fecha_fin"].HeaderText = "Fecha Fin";
            dgv_ordenes.Columns["estado"].HeaderText = "Estado";
        }

        private void ConfigurarDataGridViewDetalle()
        {
            dgv_detalle_orden.Columns.Clear();
            dgv_detalle_orden.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_detalle_orden.Columns.Add("idProducto", "ID Producto");
            dgv_detalle_orden.Columns.Add("nombreProducto", "Producto");
            dgv_detalle_orden.Columns.Add("cantidad", "Cantidad");
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarDatosOrden()) return;

                DataTable productos = CrearTablaProductos();

                bool exito = control.CrearOrdenConDetalles(dtp_fecha_inicio.Value, dtp_fecha_fin.Value, ObtenerEstado(), productos);

                if (exito)
                {
                    MessageBox.Show("Orden agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al agregar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarDatosOrden()
        {
            if (cbo_estado_orden.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dgv_detalle_orden.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private DataTable CrearTablaProductos()
        {
            DataTable productos = new DataTable();
            productos.Columns.Add("idProducto", typeof(int));
            productos.Columns.Add("cantidad", typeof(int));

            foreach (DataGridViewRow row in dgv_detalle_orden.Rows)
            {
                if (row.Cells["idProducto"].Value != null && row.Cells["cantidad"].Value != null)
                {
                    productos.Rows.Add(Convert.ToInt32(row.Cells["idProducto"].Value), Convert.ToInt32(row.Cells["cantidad"].Value));
                }
            }
            return productos;
        }

        private int ObtenerEstado()
        {
            if (cbo_estado_orden.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado para la orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1; // Devuelve un valor que indique un estado no válido
            }
            return cbo_estado_orden.SelectedItem.ToString() == "Activo" ? 1 : 0;
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el campo txt_id_orden tenga un valor válido antes de intentar actualizar
                if (string.IsNullOrEmpty(txt_id_orden.Text) || !int.TryParse(txt_id_orden.Text, out int idOrden))
                {
                    MessageBox.Show("Por favor, seleccione una orden válida para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int estado = ObtenerEstado();
                if (estado == -1)
                {
                    return; // Detiene la ejecución si el estado es inválido
                }

                // Proceder con la actualización si el ID es válido
                bool exito = control.ActualizarOrden(idOrden, dtp_fecha_inicio.Value, dtp_fecha_fin.Value, estado);

                if (exito)
                {
                    MessageBox.Show("Orden actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_id_orden.Text, out int idOrden))
                {
                    if (MessageBox.Show("¿Está seguro de desactivar esta orden?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool exito = control.DesactivarOrden(idOrden);

                        if (exito)
                        {
                            MessageBox.Show("Orden desactivada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefrescarFormulario();
                        }
                        else
                        {
                            MessageBox.Show("Error al desactivar la orden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ID de orden no válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desactivar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_ordenes.DataSource = control.BuscarOrdenes(
                    dtp_buscar_inicio.Value.ToString("yyyy-MM-dd"),
                    dtp_buscar_fin.Value.ToString("yyyy-MM-dd"),
                    cbo_estado_orden.SelectedItem != null ? ObtenerEstado() : -1
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar órdenes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txt_cantidad.Text, out int cantidad) && cantidad > 0)
                {
                    int idProducto = (int)cbo_producto.SelectedValue;
                    string nombreProducto = cbo_producto.Text;

                    foreach (DataGridViewRow row in dgv_detalle_orden.Rows)
                    {
                        if (row.Cells["idProducto"].Value != null && (int)row.Cells["idProducto"].Value == idProducto)
                        {
                            MessageBox.Show("Producto ya agregado a la orden.");
                            return;
                        }
                    }

                    dgv_detalle_orden.Rows.Add(idProducto, nombreProducto, cantidad);
                    txt_cantidad.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_ordenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgv_ordenes.Rows[e.RowIndex].Cells["Pk_id_orden"].Value != null)
                {
                    DataGridViewRow row = dgv_ordenes.Rows[e.RowIndex];
                    txt_id_orden.Text = row.Cells["Pk_id_orden"].Value.ToString();
                    dtp_fecha_inicio.Value = Convert.ToDateTime(row.Cells["fecha_inicio"].Value ?? dtp_fecha_inicio.MinDate);
                    dtp_fecha_fin.Value = Convert.ToDateTime(row.Cells["fecha_fin"].Value ?? dtp_fecha_fin.MinDate);
                    cbo_estado_orden.SelectedItem = (Convert.ToInt32(row.Cells["estado"].Value) == 1) ? "Activo" : "Inactivo";

                    // Cargar detalles de la orden seleccionada
                    int idOrden = Convert.ToInt32(row.Cells["Pk_id_orden"].Value);
                    CargarDetallesOrden(idOrden);
                }
                else
                {
                    MessageBox.Show("Seleccione una fila válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetallesOrden(int idOrden)
        {
            try
            {
                DataTable detalles = control.ObtenerDetallesOrden(idOrden);
                if (detalles == null || detalles.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron detalles para esta orden.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_detalle_orden.Rows.Clear();
                    return;
                }

                dgv_detalle_orden.Rows.Clear();
                foreach (DataRow detalle in detalles.Rows)
                {
                    int idProducto = Convert.ToInt32(detalle["Fk_id_producto"]);
                    string nombreProducto = detalle["nombreProducto"].ToString();
                    int cantidad = Convert.ToInt32(detalle["cantidad"]);

                    dgv_detalle_orden.Rows.Add(idProducto, nombreProducto, cantidad);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles de la orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarFormulario()
        {
            CargarOrdenes();
            ObtenerProximoIdOrden();
            dgv_detalle_orden.Rows.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Ordenes_De_Produccion_Load(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void cbo_estado_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Procedimiento para cambio de estado
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Ordenes_Reporte op = new Frm_Ordenes_Reporte();
            op.Show();
        }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda_Ordenes", "Ayuda_Ordenes.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "Ayuda_Ordenes.html");


            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                // Limpiar todos los TextBox en el formulario excepto txt_id_orden
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox && control.Name != "txt_id_orden")
                    {
                        ((TextBox)control).Clear();
                    }
                }

                // Restablecer los ComboBox
                cbo_estado_orden.SelectedIndex = -1; // Deseleccionar el estado de orden
                cbo_producto.SelectedIndex = -1;     // Deseleccionar el producto

                // Restablecer los DateTimePicker a la fecha actual
                dtp_fecha_inicio.Value = DateTime.Today;
                dtp_fecha_fin.Value = DateTime.Today;
                dtp_buscar_inicio.Value = DateTime.Today;
                dtp_buscar_fin.Value = DateTime.Today;

                // Limpiar los DataGridView
                dgv_ordenes.DataSource = null;
                dgv_ordenes.Rows.Clear();
                dgv_detalle_orden.Rows.Clear();

                // Recargar las órdenes para mostrar todos los datos
                CargarOrdenes();

                // Obtener y mostrar el próximo ID en txt_id_orden
                txt_id_orden.Text = control.ObtenerSiguienteIdOrden().ToString();

                // Mensaje opcional para confirmar la acción
                MessageBox.Show("El formulario ha sido reiniciado.", "Formulario Reiniciado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al reiniciar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
