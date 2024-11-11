using System;
using System.Data;
using System.Windows.Forms;
using Capa_Controlador_Lotes;
using System.IO;
namespace Capa_Vista_Lotes
{
    public partial class Frm_Lotes : Form
    {
        private Control_Lotes controlLotes;
        private ToolTip toolTip;

        public Frm_Lotes()
        {
            InitializeComponent();
            controlLotes = new Control_Lotes();
            CargarCombos();
            GenerarNuevoIdLote();
            CargarLotes();
            toolTip = new ToolTip();

            // Añadir tooltips a los controles
            toolTip.SetToolTip(Cbo_Producto, "Selecciona el producto para el lote");
            toolTip.SetToolTip(Cbo_Proceso, "Selecciona el proceso para el lote");
            toolTip.SetToolTip(Txt_Id_Lotes, "ID generado automáticamente para el lote");
            toolTip.SetToolTip(Txt_Codigo_Lote, "Código único para identificar el lote");
            toolTip.SetToolTip(Txt_Cantidad, "Cantidad de productos en el lote");
            toolTip.SetToolTip(Cbo_Estado_Lotes, "Estado del lote (Activo/Inactivo)");
            toolTip.SetToolTip(Dtp_Fecha_Produccion, "Selecciona la fecha de producción del lote");
            toolTip.SetToolTip(btn_Nuevo, "Prepara el formulario para un nuevo lote");
            toolTip.SetToolTip(Btn_Agregar, "Añadir un nuevo lote al sistema");
            toolTip.SetToolTip(Btn_Actualizar, "Actualizar los datos del lote seleccionado");
            toolTip.SetToolTip(Btn_Eliminar, "Desactivar el lote seleccionado");
            toolTip.SetToolTip(dgv_Lotes, "Tabla que muestra los lotes existentes");
            toolTip.SetToolTip(btn_Reporte, "Genera un reporte de los lotes");
            toolTip.SetToolTip(btn_Ayuda, "Abre la ayuda para la gestión de lotes");
        }

        // Método para cargar los combos de producto y proceso
        private void CargarCombos()
        {
            try
            {
                // Cargar productos en Cbo_Producto
                Cbo_Producto.DataSource = controlLotes.CargarProductos();
                Cbo_Producto.DisplayMember = "nombreProducto";
                Cbo_Producto.ValueMember = "Pk_id_Producto";
                Cbo_Producto.SelectedIndex = -1;

                // Cargar procesos en Cbo_Proceso
                Cbo_Proceso.DataSource = controlLotes.CargarProcesos();
                Cbo_Proceso.DisplayMember = "Fk_id_orden";
                Cbo_Proceso.ValueMember = "Pk_id_proceso";
                Cbo_Proceso.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los combos: " + ex.Message);
            }
        }

        // Método para cargar los datos en el DataGridView
        private void CargarLotes()
        {
            try
            {
                DataTable lotes = controlLotes.CargarLotes();
                dgv_Lotes.DataSource = lotes;
                Console.WriteLine("Lotes cargados en dgv_Lotes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los lotes: " + ex.Message);
            }
        }

        // Método para generar un nuevo ID de lote automáticamente
        private void GenerarNuevoIdLote()
        {
            int nuevoId = controlLotes.ObtenerUltimoIdLotes() + 1;
            Txt_Id_Lotes.Text = nuevoId.ToString();
        }

        // Evento para limpiar el formulario y preparar para un nuevo lote
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            GenerarNuevoIdLote();
        }

        // Método para limpiar el formulario
        private void LimpiarFormulario()
        {
            Txt_Codigo_Lote.Clear();
            Txt_Cantidad.Clear();
            Cbo_Producto.SelectedIndex = -1;
            Cbo_Proceso.SelectedIndex = -1;
            Cbo_Estado_Lotes.SelectedIndex = 0; // Activo por defecto
        }

        // Evento para agregar un nuevo lote
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int idLote = int.Parse(Txt_Id_Lotes.Text);
                string codigoLote = Txt_Codigo_Lote.Text;
                DateTime fechaProduccion = Dtp_Fecha_Produccion.Value;
                int cantidad = int.Parse(Txt_Cantidad.Text);
                int estado = Cbo_Estado_Lotes.SelectedIndex == 0 ? 1 : 0;
                int idProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);

                controlLotes.AgregarLotes(idLote, codigoLote, fechaProduccion, cantidad, estado, idProducto);
                MessageBox.Show("Lote agregado correctamente.");
                btn_Nuevo_Click(sender, e);
                CargarLotes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el lote: " + ex.Message);
            }
        }

        // Evento para actualizar un lote existente con confirmación
        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea actualizar este lote?", "Confirmar actualización", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int idLote = int.Parse(Txt_Id_Lotes.Text);
                    string codigoLote = Txt_Codigo_Lote.Text;
                    DateTime fechaProduccion = Dtp_Fecha_Produccion.Value;
                    int cantidad = int.Parse(Txt_Cantidad.Text);
                    int estado = Cbo_Estado_Lotes.SelectedIndex == 0 ? 1 : 0;
                    int idProducto = Convert.ToInt32(Cbo_Producto.SelectedValue);

                    controlLotes.ActualizarLotes(idLote, codigoLote, fechaProduccion, cantidad, estado, idProducto);
                    MessageBox.Show("Lote actualizado correctamente.");
                    btn_Nuevo_Click(sender, e);
                    CargarLotes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el lote: " + ex.Message);
                }
            }
        }

        // Evento para eliminar (desactivar) un lote con confirmación
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea desactivar este lote?", "Confirmar desactivación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int idLote = int.Parse(Txt_Id_Lotes.Text);
                    controlLotes.DesactivarLotes(idLote); // Llama a desactivar el lote

                    MessageBox.Show("Lote desactivado correctamente.");
                    btn_Nuevo_Click(sender, e); // Limpia el formulario y genera un nuevo ID
                    CargarLotes(); // Recarga los datos en el DataGridView para mostrar el cambio
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al desactivar el lote: " + ex.Message);
                }
            }
        }


        // Método para cargar los datos de un lote seleccionado en los campos
        private void dgv_Lotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = dgv_Lotes.Rows[e.RowIndex];

                    // Asignar los valores a los controles, asegurando que los valores existen antes de asignarlos
                    Txt_Id_Lotes.Text = filaSeleccionada.Cells["Pk_id_lote"].Value?.ToString() ?? string.Empty;
                    Txt_Codigo_Lote.Text = filaSeleccionada.Cells["codigo_lote"].Value?.ToString() ?? string.Empty;

                    // Convertir y asignar fecha de producción
                    if (DateTime.TryParse(filaSeleccionada.Cells["FechaProduccion"].Value?.ToString(), out DateTime fechaProduccion))
                    {
                        Dtp_Fecha_Produccion.Value = fechaProduccion;
                    }
                    else
                    {
                        Dtp_Fecha_Produccion.Value = DateTime.Now; // Valor predeterminado si la conversión falla
                    }

                    // Estado
                    int estado = Convert.ToInt32(filaSeleccionada.Cells["estado"].Value);
                    Cbo_Estado_Lotes.SelectedIndex = estado == 1 ? 0 : 1;

                    // Producto - Verificar que el valor existe en el ComboBox
                    int idProducto = Convert.ToInt32(filaSeleccionada.Cells["Fk_id_producto"].Value);
                    bool productoEncontrado = false;
                    foreach (var item in Cbo_Producto.Items)
                    {
                        if (item is DataRowView rowView && Convert.ToInt32(rowView["Pk_id_Producto"]) == idProducto)
                        {
                            Cbo_Producto.SelectedValue = idProducto;
                            productoEncontrado = true;
                            break;
                        }
                    }

                    if (!productoEncontrado)
                    {
                        Cbo_Producto.SelectedIndex = -1;
                    }

                    // Cantidad
                    Txt_Cantidad.Text = filaSeleccionada.Cells["cantidad"].Value?.ToString() ?? string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del lote: " + ex.Message);
                }
            }
        }




        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte lotes = new Frm_Reporte();
            lotes.Show();
        }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda_Lotes", "Ayuda_Lotes.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
               // MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "Ayuda_Lotes.html");


            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }

        }
    }
}
