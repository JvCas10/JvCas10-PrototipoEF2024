using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capa_Vista_Cierre_Produccion
{
    public partial class Frm_Cierre : Form
    {
        private Capa_Controlador_Cierre_Produccion.Control_Cierre controlCierre = new Capa_Controlador_Cierre_Produccion.Control_Cierre();
        private ToolTip toolTip;

        public Frm_Cierre()
        {
            InitializeComponent();
            toolTip = new ToolTip(); // Inicializamos el ToolTip
            ConfigurarToolTips(); // Configuramos los ToolTips
            CargarHistorialCierres(); // Cargar el historial de cierres al abrir el formulario

        }

        // Método para configurar ToolTips en los componentes
        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(btn_Nuevo, "Prepara los campos para ingresar un nuevo cierre.");
            toolTip.SetToolTip(btn_calcular, "Calcula el saldo actual y acumulados con los datos ingresados.");
            toolTip.SetToolTip(btn_guardar, "Guarda el cierre contable ingresado.");
            toolTip.SetToolTip(btn_limpiar, "Limpia todos los campos de entrada.");
            toolTip.SetToolTip(btn_cerrar, "Cerrar el formulario.");
            toolTip.SetToolTip(dtp_fecha_cierre, "Seleccione la fecha del cierre contable.");
            toolTip.SetToolTip(txt_saldo_anterior, "Saldo del cierre anterior.");
            toolTip.SetToolTip(txt_cargos_mes, "Total de cargos realizados en el mes.");
            toolTip.SetToolTip(txt_abonos_mes, "Total de abonos realizados en el mes.");
            toolTip.SetToolTip(txt_saldo_actual, "Saldo actual calculado.");
            toolTip.SetToolTip(txt_cargos_acumulados, "Cargos acumulados para el año en curso.");
            toolTip.SetToolTip(txt_abonos_acumulados, "Abonos acumulados para el año en curso.");
            toolTip.SetToolTip(dgv_historico_cierres, "Historial de cierres contables.");
            toolTip.SetToolTip(btn_Ayuda, "Ayuda sobre el formulario.");
            toolTip.SetToolTip(btn_Reporte, "Muestra el reporte.");
        }

        // Método para cargar el historial de cierres en el DataGridView
        private void CargarHistorialCierres()
        {
            try
            {
                dgv_historico_cierres.DataSource = controlCierre.ObtenerHistorialCierres();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de cierres: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón Nuevo
        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            try
            {
                decimal saldoAnterior = controlCierre.ObtenerDatosCierre(dtp_fecha_cierre.Value).saldoAnterior;
                txt_saldo_anterior.Text = saldoAnterior.ToString("F2");

                // Limpiar los campos para nuevos datos
                txt_cargos_mes.Clear();
                txt_abonos_mes.Clear();
                txt_saldo_actual.Clear();
                txt_cargos_acumulados.Clear();
                txt_abonos_acumulados.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar nuevo registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_saldo_anterior.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargos_mes.Text) ||
                    string.IsNullOrWhiteSpace(txt_abonos_mes.Text))
                {
                    MessageBox.Show("Por favor, ingrese todos los datos necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal saldoAnterior = decimal.Parse(txt_saldo_anterior.Text);
                decimal cargosMes = decimal.Parse(txt_cargos_mes.Text);
                decimal abonosMes = decimal.Parse(txt_abonos_mes.Text);

                decimal saldoActual = controlCierre.CalcularSaldoActual(saldoAnterior, cargosMes, abonosMes);
                txt_saldo_actual.Text = saldoActual.ToString("F2");

                int year = dtp_fecha_cierre.Value.Year;
                decimal cargosAcumulados = controlCierre.ObtenerCargosAcumuladosAnuales(year, cargosMes);
                decimal abonosAcumulados = controlCierre.ObtenerAbonosAcumuladosAnuales(year, abonosMes);

                txt_cargos_acumulados.Text = cargosAcumulados.ToString("F2");
                txt_abonos_acumulados.Text = abonosAcumulados.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular los valores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_saldo_actual.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargos_acumulados.Text) ||
                    string.IsNullOrWhiteSpace(txt_abonos_acumulados.Text) ||
                    string.IsNullOrWhiteSpace(txt_saldo_anterior.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargos_mes.Text) ||
                    string.IsNullOrWhiteSpace(txt_abonos_mes.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal saldoAnterior = decimal.Parse(txt_saldo_anterior.Text);
                decimal cargosMes = decimal.Parse(txt_cargos_mes.Text);
                decimal abonosMes = decimal.Parse(txt_abonos_mes.Text);
                decimal saldoActual = decimal.Parse(txt_saldo_actual.Text);
                decimal cargosAcumulados = decimal.Parse(txt_cargos_acumulados.Text);
                decimal abonosAcumulados = decimal.Parse(txt_abonos_acumulados.Text);
                DateTime fecha = dtp_fecha_cierre.Value;

                bool resultado = controlCierre.GuardarCierre(saldoAnterior, cargosMes, abonosMes, saldoActual, cargosAcumulados, abonosAcumulados, fecha);

                if (resultado)
                {
                    MessageBox.Show("Cierre guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHistorialCierres();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al guardar el cierre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para limpiar todos los campos de entrada
        private void LimpiarCampos()
        {
            txt_saldo_anterior.Clear();
            txt_cargos_mes.Clear();
            txt_abonos_mes.Clear();
            txt_saldo_actual.Clear();
            txt_cargos_acumulados.Clear();
            txt_abonos_acumulados.Clear();
        }

        // Evento para mostrar detalles del cierre seleccionado en el DataGridView
        private void dgv_historico_cierres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgv_historico_cierres.Rows[e.RowIndex];

                txt_saldo_anterior.Text = filaSeleccionada.Cells["saldo_anterior"].Value.ToString();
                txt_cargos_mes.Text = filaSeleccionada.Cells["cargos_mes"].Value.ToString();
                txt_abonos_mes.Text = filaSeleccionada.Cells["abonos_mes"].Value.ToString();
                txt_saldo_actual.Text = filaSeleccionada.Cells["saldo_actual"].Value.ToString();
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Cierre_Reporte reporte = new Frm_Cierre_Reporte();
            reporte.Show();
        }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda_Cierre", "Ayuda_Cierre.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "Ayuda_Cierre.html");

               
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
