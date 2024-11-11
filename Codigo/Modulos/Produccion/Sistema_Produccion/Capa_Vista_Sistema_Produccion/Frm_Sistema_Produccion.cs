using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Controlador_Sistema_Produccion;
using System.IO;

namespace Capa_Vista_Sistema_Produccion // Espacio de nombres actualizado
{
    public partial class Frm_Sistema_Produccion : Form
    {
        private Control_Sistema_Produccion control = new Control_Sistema_Produccion();

        public Frm_Sistema_Produccion()
        {
            InitializeComponent();
            this.Load += Frm_Sistema_Produccion_Load;

            // Inicializa el ToolTip en el constructor del formulario o en el evento Load
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(cbo_orden, "Selecciona la orden de producción para ver su detalle.");
            toolTip.SetToolTip(cbo_maquinaria, "Selecciona la maquinaria que se usará en el proceso de producción.");
            toolTip.SetToolTip(cbo_empleado, "Selecciona el empleado asignado para este proceso.");
            toolTip.SetToolTip(txt_idProceso, "Muestra el ID del proceso de producción actual.");
            toolTip.SetToolTip(txt_idProcesoDetalle, "Muestra el ID del detalle del proceso de producción.");
            toolTip.SetToolTip(txt_idProducto, "ID del producto relacionado con la orden seleccionada.");
            toolTip.SetToolTip(txt_idReceta, "ID de la receta asociada al producto seleccionado.");
            toolTip.SetToolTip(txt_cantidad, "Ingresa la cantidad de productos a producir.");
            toolTip.SetToolTip(txt_costo_u, "Costo unitario del producto.");
            toolTip.SetToolTip(txt_costo_t, "Costo total calculado en función de la cantidad y costos adicionales.");
            toolTip.SetToolTip(txt_mano_obra, "Costo de mano de obra involucrado en el proceso.");
            toolTip.SetToolTip(txt_costo_luz, "Costo de la electricidad utilizada en el proceso de producción.");
            toolTip.SetToolTip(txt_costo_agua, "Costo del agua utilizada en el proceso de producción.");
            toolTip.SetToolTip(nud_duracion_horas, "Duración estimada en horas para completar el proceso.");
            toolTip.SetToolTip(btn_asignar, "Asigna el proceso de producción con los datos ingresados.");
            toolTip.SetToolTip(btn_salir, "Cierra el formulario actual.");
            toolTip.SetToolTip(btn_Ayuda, "Abre el manual de ayuda del sistema.");
            toolTip.SetToolTip(btn_Reporte, "Genera un reporte del proceso de producción.");
            toolTip.SetToolTip(btn_actualizar, "Recargar Formulario.");
        }

        // Evento para cargar datos al abrir el formulario
        private void Frm_Sistema_Produccion_Load(object sender, EventArgs e)
        {
            try
            {
                cbo_orden.DataSource = control.ObtenerOrdenesProduccion();
                cbo_orden.DisplayMember = "Pk_id_orden";
                cbo_orden.ValueMember = "Pk_id_orden";

                cbo_maquinaria.DataSource = control.ObtenerMaquinarias();
                cbo_maquinaria.DisplayMember = "nombre_maquinaria";
                cbo_maquinaria.ValueMember = "Pk_id_maquinaria";

                cbo_empleado.DataSource = control.ObtenerEmpleados();
                cbo_empleado.DisplayMember = "empleados_nombre";
                cbo_empleado.ValueMember = "pk_clave";

                txt_idProceso.Text = control.ObtenerSiguienteIdProceso().ToString();
                txt_idProcesoDetalle.Text = control.ObtenerSiguienteIdProcesoDetalle().ToString();

                cbo_orden.SelectedIndexChanged += Cbo_orden_SelectedIndexChanged;

                txt_costo_u.TextChanged += CalcularCostoTotal;
                txt_cantidad.TextChanged += CalcularCostoTotal;
                txt_mano_obra.TextChanged += CalcularCostoTotal;
                txt_costo_luz.TextChanged += CalcularCostoTotal;
                txt_costo_agua.TextChanged += CalcularCostoTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos iniciales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para cargar el detalle de la orden seleccionada en el DataGridView
        private void Cbo_orden_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_orden.SelectedValue != null && int.TryParse(cbo_orden.SelectedValue.ToString(), out int idOrden))
                {
                    dgv_detalle_orden.DataSource = control.ObtenerDetalleOrden(idOrden);

                    if (dgv_detalle_orden.Rows.Count > 0 && dgv_detalle_orden.Rows[0].Cells["Fk_id_producto"].Value != null)
                    {
                        int idProducto = Convert.ToInt32(dgv_detalle_orden.Rows[0].Cells["Fk_id_producto"].Value);
                        DataTable productoReceta = control.ObtenerProductoYReceta(idProducto);

                        if (productoReceta.Rows.Count > 0)
                        {
                            txt_idProducto.Text = productoReceta.Rows[0]["idProducto"].ToString();
                            txt_idReceta.Text = productoReceta.Rows[0]["idReceta"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle de la orden: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para calcular y actualizar el costo total
        private void CalcularCostoTotal(object sender, EventArgs e)
        {
            try
            {
                decimal costoU = decimal.TryParse(txt_costo_u.Text, out decimal cU) ? cU : 0;
                int cantidad = int.TryParse(txt_cantidad.Text, out int qty) ? qty : 0;
                decimal manoDeObra = decimal.TryParse(txt_mano_obra.Text, out decimal mO) ? mO : 0;
                decimal costoLuz = decimal.TryParse(txt_costo_luz.Text, out decimal cL) ? cL : 0;
                decimal costoAgua = decimal.TryParse(txt_costo_agua.Text, out decimal cA) ? cA : 0;

                decimal totalCost = (costoU * cantidad) + manoDeObra + costoLuz + costoAgua;
                txt_costo_t.Text = totalCost.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el costo total: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón btn_asignar
        private void btn_asignar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProceso = Convert.ToInt32(txt_idProceso.Text);
                int idOrden = Convert.ToInt32(cbo_orden.SelectedValue);
                int idMaquinaria = Convert.ToInt32(cbo_maquinaria.SelectedValue);

                if (string.IsNullOrEmpty(txt_idProceso.Text) || string.IsNullOrEmpty(cbo_orden.Text) || string.IsNullOrEmpty(cbo_maquinaria.Text))
                {
                    MessageBox.Show("Por favor complete todos los campos de encabezado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool resultadoEncabezado = control.InsertarEncabezado(idOrden, idMaquinaria);

                if (resultadoEncabezado)
                {
                    int idProcesoDetalle = Convert.ToInt32(txt_idProcesoDetalle.Text);
                    int idProducto = Convert.ToInt32(txt_idProducto.Text);
                    int idReceta = Convert.ToInt32(txt_idReceta.Text);
                    int idEmpleado = Convert.ToInt32(cbo_empleado.SelectedValue);
                    int cantidad = Convert.ToInt32(txt_cantidad.Text);
                    decimal costoU = Convert.ToDecimal(txt_costo_u.Text);
                    decimal costoT = Convert.ToDecimal(txt_costo_t.Text);
                    decimal duracionHoras = nud_duracion_horas.Value;
                    decimal manoDeObra = Convert.ToDecimal(txt_mano_obra.Text);
                    decimal costoLuz = Convert.ToDecimal(txt_costo_luz.Text);
                    decimal costoAgua = Convert.ToDecimal(txt_costo_agua.Text);

                    if (costoT <= 0)
                    {
                        MessageBox.Show("El costo total debe ser mayor que cero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    bool resultadoDetalle = control.InsertarDetalle(idProducto, idReceta, idEmpleado, idProceso, cantidad, costoU, costoT, duracionHoras, manoDeObra, costoLuz, costoAgua);

                    if (resultadoDetalle)
                    {
                        MessageBox.Show("Registro exitoso en el sistema de producción", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el detalle del proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al registrar el encabezado del proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de los datos ingresados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar el proceso: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón btn_salir
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda_Sistema", "Ayuda_Sistema.chm");
                Help.ShowHelp(this, sAyudaPath, "Ayuda_Sistema.html");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Fmr_Reporte op = new Fmr_Reporte();
            op.Show();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            // Limpia los campos de texto
            txt_cantidad.Text = "";
            txt_costo_u.Text = "";
            txt_costo_t.Text = "";
            txt_mano_obra.Text = "";
            txt_costo_luz.Text = "";
            txt_costo_agua.Text = "";

            // Restaura el valor del NumericUpDown a su valor predeterminado
            nud_duracion_horas.Value = nud_duracion_horas.Minimum;

            // Limpia el ComboBox cbo_maquinaria y cbo_empleado
            cbo_maquinaria.SelectedIndex = -1;
            cbo_empleado.SelectedIndex = -1;
        }
    }
}
