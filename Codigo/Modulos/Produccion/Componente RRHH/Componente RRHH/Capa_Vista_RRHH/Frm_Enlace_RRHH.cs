using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_RRHH;
using System.IO;

namespace Capa_Vista_RRHH
{
    public partial class Frm_Enlace_RRHH : Form
    {
        private Controlador_RRHH controlador = new Controlador_RRHH();
        public Frm_Enlace_RRHH()
        {
            InitializeComponent();
            LlenarComboBoxes();
            LimpiarCampos();
            CargarDatos();

            btn_Guardar.Enabled = false;
            btn_Calcular.Enabled = false;
            Txt_id_RRHH_prod.Enabled = false;

            txt_Total_Dias.KeyPress += txt_Numeros_KeyPress;
            txt_Total_Horas.KeyPress += txt_Numeros_KeyPress;
            txt_Total_Horas_Extras.KeyPress += txt_Numeros_KeyPress;
            txt_Total_Mano_de_Obra.KeyPress += txt_Numeros_KeyPress;
            cbo_Dias.KeyPress += txt_Numeros_KeyPress;
            cbo_Horas.KeyPress += txt_Numeros_KeyPress;
            cbo_Horas_Extras.KeyPress += txt_Numeros_KeyPress;
            cbo_Salario.KeyPress += txt_Numeros_KeyPress;

            cbo_Dias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Empleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Salario.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Horas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Horas_Extras.DropDownStyle = ComboBoxStyle.DropDownList;

            // Agregar tooltips a los botones y campos
            ToolTip toolTip = new ToolTip();

            // Botones
            toolTip.SetToolTip(btn_Guardar, "Guarda los datos de Recursos Humanos.");
            toolTip.SetToolTip(btn_Calcular, "Calcula el total de días, horas y mano de obra.");
            toolTip.SetToolTip(btn_Nuevo, "Inicia un nuevo registro.");
            toolTip.SetToolTip(btn_Consultar, "Consulta los datos del registro seleccionado.");
            toolTip.SetToolTip(btn_Ayuda, "Abre la ayuda del módulo de Recursos Humanos.");
            toolTip.SetToolTip(btn_Salir, "Cierra el formulario de Recursos Humanos.");
            toolTip.SetToolTip(btn_reportes, "Abre el módulo de reportes.");

            // Campos de texto y combos
            toolTip.SetToolTip(Txt_id_RRHH_prod, "ID único para el registro de RRHH (generado automáticamente).");
            toolTip.SetToolTip(txt_Total_Dias, "Días trabajados por el empleado.");
            toolTip.SetToolTip(txt_Total_Horas, "Horas trabajadas por el empleado.");
            toolTip.SetToolTip(txt_Total_Horas_Extras, "Horas extras trabajadas.");
            toolTip.SetToolTip(txt_Total_Mano_de_Obra, "Costo total de la mano de obra.");
            toolTip.SetToolTip(cbo_Empleado, "Selecciona el empleado para el registro.");
            toolTip.SetToolTip(cbo_Dias, "Número de días trabajados.");
            toolTip.SetToolTip(cbo_Horas, "Horas trabajadas en el día.");
            toolTip.SetToolTip(cbo_Horas_Extras, "Cantidad de horas extras trabajadas.");
            toolTip.SetToolTip(cbo_Salario, "Salario del empleado seleccionado.");

            // Mensaje para mostrar que solo se permiten números en ciertos campos
            txt_Total_Dias.KeyPress += txt_Numeros_KeyPress;
            txt_Total_Horas.KeyPress += txt_Numeros_KeyPress;
            txt_Total_Horas_Extras.KeyPress += txt_Numeros_KeyPress;
            txt_Total_Mano_de_Obra.KeyPress += txt_Numeros_KeyPress;
        }

        private void txt_Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LlenarComboBoxes()
        {
            cbo_Salario.DataSource = controlador.ObtenerSalarios();
            cbo_Horas_Extras.DataSource = controlador.ObtenerHorasExtras();
            cbo_Horas.DataSource = controlador.ObtenerHoras();
        }

        private void InicializarFormulario()
        {
            Txt_id_RRHH_prod.Text = controlador.ObtenerUltimoID().ToString();
            Txt_id_RRHH_prod.Enabled = false;
            DeshabilitarCampos();
            CargarEmpleados();
            CargarDias();
            Txt_id_RRHH_prod.Text = controlador.ObtenerUltimoID().ToString();
        }

        private void CargarDatos()
        {
            DataTable dt = controlador.ObtenerTodosLosRegistros();
            dgv_empleados.DataSource = dt;
     
        }

        private void DeshabilitarCampos()
        {
        
            txt_Total_Dias.Enabled = true;
            txt_Total_Horas.Enabled = true;
            txt_Total_Mano_de_Obra.Enabled = true;
            btn_Guardar.Enabled = true;
            cbo_Dias.Enabled = false;
            cbo_Horas.Enabled = false;
            btn_Calcular.Enabled = false;
        }

        private void CargarEmpleados()
        {
            DataTable empleados = controlador.ObtenerEmpleados();
            cbo_Empleado.DataSource = empleados;
            cbo_Empleado.DisplayMember = "empleados_nombre";
            cbo_Empleado.ValueMember = "pk_clave";

             DataTable tblrecetas = controlador.ObtenerHoras();
             cbo_Dias.DataSource = tblrecetas;
             cbo_Empleado.DisplayMember = "horas";
             cbo_Horas.ValueMember = "horas";

        }

        private void CargarDias()
        {
            DataTable tblrecetas = controlador.ObtenerDias();
            cbo_Dias.DataSource = tblrecetas;
            cbo_Dias.DisplayMember = "dias";
            cbo_Dias.ValueMember = "dias";
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
            HabilitarCampos();
            LimpiarCampos();
            CargarEmpleados();
            CargarDias();

            btn_Guardar.Enabled = true;
            btn_Calcular.Enabled = true;

            //if (cbo_Empleado.Items.Count > 0)
           // {
            //    cbo_Empleado.SelectedIndex = 0;
           // }
        }

        private void LimpiarCampos()
        {
            txt_Total_Dias.Text = string.Empty;
            txt_Total_Horas.Text = string.Empty;
            txt_Total_Mano_de_Obra.Text = string.Empty;
            txt_Total_Horas_Extras.Text = string.Empty;
        }


        private void HabilitarCampos()
        {
            cbo_Horas.Enabled = true;
            cbo_Dias.Enabled = true;
            btn_Calcular.Enabled = true;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {


            try
            {
                // 1. Obtener el salario seleccionado y los días ingresados
                decimal salario = Convert.ToDecimal(cbo_Salario.SelectedItem);

                // Convertir el valor seleccionado de cbo_Dias y cbo_Horas desde DataRowView a tipos numéricos
                int dias = Convert.ToInt32((cbo_Dias.SelectedItem as DataRowView)["dias"]);
                decimal horas = Convert.ToDecimal((cbo_Horas.SelectedItem as DataRowView)["horas"]);

                // 2. Calcular Total Días y colocar el resultado en txt_Total_Dias
                decimal totalDias = salario / dias;
                txt_Total_Dias.Text = totalDias.ToString("0.00");

                // 3. Calcular Total Horas
                decimal totalHoras = totalDias / horas;
                txt_Total_Horas.Text = totalHoras.ToString("0.00");

                // 4. Obtener horas extras seleccionadas y calcular Total Horas Extras
                decimal horasExtras = Convert.ToDecimal(cbo_Horas_Extras.SelectedItem);
                decimal totalHorasExtras = horasExtras * 1.5M;
                txt_Total_Horas_Extras.Text = totalHorasExtras.ToString("0.00");

                // 5. Calcular Total Mano de Obra sumando Total Horas y Total Horas Extras
                decimal totalManoDeObra = totalHoras + totalHorasExtras;
                txt_Total_Mano_de_Obra.Text = totalManoDeObra.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el cálculo: " + ex.Message);
            }

        }


        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            if (cbo_Empleado.SelectedIndex == -1 || cbo_Salario.SelectedIndex == -1 ||
                    cbo_Horas_Extras.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbo_Dias.Text) ||
                    string.IsNullOrWhiteSpace(txt_Total_Dias.Text) || string.IsNullOrWhiteSpace(cbo_Horas.Text) ||
                    string.IsNullOrWhiteSpace(txt_Total_Horas.Text) || string.IsNullOrWhiteSpace(txt_Total_Horas_Extras.Text) ||
                    string.IsNullOrWhiteSpace(txt_Total_Mano_de_Obra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos necesarios antes de guardar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Captura de datos
                int empleadoID = Convert.ToInt32(cbo_Empleado.SelectedValue);
                decimal salario = Convert.ToDecimal(cbo_Salario.SelectedItem);

                // Obtener el valor de dias y horas desde DataRowView en cbo_Dias y cbo_Horas
                int dias = Convert.ToInt32((cbo_Dias.SelectedItem as DataRowView)["dias"]);
                decimal totalDias = decimal.Parse(txt_Total_Dias.Text);
                decimal horas = Convert.ToDecimal((cbo_Horas.SelectedItem as DataRowView)["horas"]);
                decimal totalHoras = decimal.Parse(txt_Total_Horas.Text);

                int horasExtra = Convert.ToInt32(cbo_Horas_Extras.SelectedItem);
                decimal totalHorasExtras = decimal.Parse(txt_Total_Horas_Extras.Text);
                decimal totalManoObra = decimal.Parse(txt_Total_Mano_de_Obra.Text);

                // Llamada al controlador para guardar los datos
                controlador.GuardarRegistro(empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtra, totalHorasExtras, totalManoObra);
                MessageBox.Show("Registro guardado exitosamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualización de la tabla y limpieza de campos
                CargarDatos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void btn_Consultar_Click(object sender, EventArgs e)
        {
           
            try
            {
                // Verifica que un registro esté seleccionado en el DataGridView
                if (dgv_empleados.SelectedRows.Count > 0)
                {
                    var row = dgv_empleados.SelectedRows[0];

                    // Rellenar los campos con los datos del registro seleccionado
                    Txt_id_RRHH_prod.Text = row.Cells["Pk_id_RRHH"].Value.ToString();
                    cbo_Empleado.SelectedValue = row.Cells["id_empleado"].Value;
                    cbo_Dias.SelectedValue = row.Cells["dias"].Value;
                    cbo_Horas.SelectedValue = row.Cells["horas"].Value;
                    txt_Total_Dias.Text = row.Cells["total_dias"].Value.ToString();
                    txt_Total_Horas.Text = row.Cells["total_horas"].Value.ToString();
                    txt_Total_Horas_Extras.Text = row.Cells["total_horas_extras"].Value.ToString();
                    txt_Total_Mano_de_Obra.Text = row.Cells["total_mano_obra"].Value.ToString();
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
        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda_RRHH", "AyudaRRHH.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "Ayuda_RRHH.html");

               
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error en caso de una excepción
                MessageBox.Show("Ocurrió un error al abrir la ayuda: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error al abrir la ayuda: " + ex.ToString());
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //public string sRutaProyectoReportes { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\"));
        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }
    }
}
