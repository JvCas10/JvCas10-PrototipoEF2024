using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Capa_Control_Polizas_Prod; // Importamos el controlador
using System.IO;

namespace Capa_Vista_Polizas_Prod
{
    public partial class Frm_Polizas_Prod : Form
    {
        private Control_Polizas_Prod controlador;
        private List<object[]> detalles;
        private ToolTip toolTip; // ToolTip para mostrar información contextual

        public Frm_Polizas_Prod()
        {
            InitializeComponent();
            controlador = new Control_Polizas_Prod();
            detalles = new List<object[]>();
            toolTip = new ToolTip(); // Inicializamos el ToolTip
            CargarDatosComboBox();
            InicializarComponentes();
            ConfigurarToolTips(); // Configuramos los ToolTips
        }

        // Método para configurar ToolTips en los componentes
        private void ConfigurarToolTips()
        {
            toolTip.SetToolTip(btn_nueva_poliza, "Iniciar una nueva póliza.");
            toolTip.SetToolTip(btn_aceptar, "Añadir un nuevo detalle a la póliza.");
            toolTip.SetToolTip(btnQuitar, "Eliminar el detalle seleccionado.");
            toolTip.SetToolTip(btn_registar_poliza, "Registrar toda la póliza.");
            toolTip.SetToolTip(btnCancelar, "Cancelar y limpiar todos los datos.");
            toolTip.SetToolTip(btnSalir, "Salir del formulario de pólizas.");
            toolTip.SetToolTip(cbCuenta, "Selecciona una cuenta para la póliza.");
            toolTip.SetToolTip(cbtipopoliza, "Selecciona el tipo de póliza.");
            toolTip.SetToolTip(cboperacion, "Selecciona si es cargo o abono.");
            toolTip.SetToolTip(txtConcepto, "Ingrese el concepto de la póliza.");
            toolTip.SetToolTip(txtValor, "Ingrese el valor del detalle.");
            toolTip.SetToolTip(dtpfecha, "Seleccione la fecha de la póliza.");
            toolTip.SetToolTip(dgvPolizas, "Detalles de la póliza actual.");
            toolTip.SetToolTip(lblCargo, "Total de cargos en la póliza.");
            toolTip.SetToolTip(lblAbono, "Total de abonos en la póliza.");
            toolTip.SetToolTip(lbl_saldo, "Diferencia entre cargos y abonos.");
        }

        // Método para cargar datos en los ComboBox al inicio
        private void CargarDatosComboBox()
        {
            try
            {
                cbCuenta.DataSource = controlador.ObtenerDatosComboBox("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta");
                cbCuenta.ValueMember = "Pk_id_cuenta";
                cbCuenta.DisplayMember = "nombre_cuenta";

                cbtipopoliza.DataSource = controlador.ObtenerDatosComboBox("tbl_tipopoliza", "Pk_id_tipopoliza", "tipo");
                cbtipopoliza.ValueMember = "Pk_id_tipopoliza";
                cbtipopoliza.DisplayMember = "tipo";

                cboperacion.DataSource = controlador.ObtenerDatosComboBox("tbl_tipooperacion", "Pk_id_tipooperacion", "nombre");
                cboperacion.ValueMember = "Pk_id_tipooperacion";
                cboperacion.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en los ComboBox: " + ex.Message, "Error");
            }
        }

        // Método para inicializar los componentes en su estado inicial
        private void InicializarComponentes()
        {
            cbCuenta.Enabled = false;
            cboperacion.Enabled = false;
            cbtipopoliza.Enabled = false;
            txtConcepto.Enabled = false;
            txtValor.Enabled = false;
            dtpfecha.Enabled = false;
            btnQuitar.Enabled = false;
            btn_aceptar.Enabled = false;
            btn_registar_poliza.Enabled = false;
            btnCancelar.Enabled = false;
            lblCargo.Text = "00.00";
            lblAbono.Text = "00.00";
            lbl_saldo.Text = "00.00"; // Inicializamos lbl_saldo
        }

        // Botón Nueva Póliza
        private void btn_nueva_poliza_Click(object sender, EventArgs e)
        {
            try
            {
                cbCuenta.Enabled = true;
                cboperacion.Enabled = true;
                cbtipopoliza.Enabled = true;
                txtConcepto.Enabled = true;
                txtValor.Enabled = true;
                dtpfecha.Enabled = true;
                btn_aceptar.Enabled = true;
                btnQuitar.Enabled = true;
                btn_registar_poliza.Enabled = true;
                btnCancelar.Enabled = true;
                MessageBox.Show("Empieza el ingreso de una póliza");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar nueva póliza: " + ex.Message, "Error");
            }
        }

        // Variable para manejar el saldo
        private int iSaldo = 0;

        // Botón Aceptar - Añade un detalle de póliza
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposDetalle())
                {
                    int idCuenta = Convert.ToInt32(cbCuenta.SelectedValue);
                    int idOperacion = Convert.ToInt32(cboperacion.SelectedValue);
                    int valor = Convert.ToInt32(txtValor.Text); // Convertimos a entero para manejar en iSaldo

                    // Añadir el detalle en el DataGridView
                    dgvPolizas.Rows.Add(idCuenta, cbCuenta.Text, idOperacion == 1 ? valor : 0, idOperacion == 2 ? valor : 0);
                    detalles.Add(new object[] { idCuenta, idOperacion, valor });

                    // Actualizar el saldo en función de si es Cargo o Abono
                    iSaldo += (idOperacion == 1) ? valor : -valor; // Suma en caso de Cargo, resta en caso de Abono
                    ActualizarTotales();

                    LimpiarCamposDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al añadir detalle de póliza: " + ex.Message, "Error");
            }
        }

        // Botón Quitar - Remueve un detalle seleccionado en el DataGridView
        // Botón Quitar - Remueve un detalle seleccionado en el DataGridView
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPolizas.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPolizas.SelectedRows)
                    {
                        // Determinar si el detalle es cargo o abono y ajustar el saldo en consecuencia
                        int valor = Convert.ToInt32(row.Cells["Cargo"].Value ?? 0) - Convert.ToInt32(row.Cells["Abono"].Value ?? 0);
                        iSaldo -= valor;

                        // Remover la fila seleccionada
                        dgvPolizas.Rows.Remove(row);
                    }
                    ActualizarTotales();
                }
                else
                {
                    MessageBox.Show("Por favor selecciona una fila para quitar.", "Aviso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al quitar el detalle seleccionado: " + ex.Message, "Error");
            }
        }


        // Botón Registrar Póliza - Crea el encabezado y detalles de la póliza
        private void btn_registar_poliza_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPolizas.Rows.Count > 0 && ValidarCamposEncabezado())
                {
                    // Verificar si el saldo es diferente de 0 antes de registrar
                    if (iSaldo > 0)
                    {
                        MessageBox.Show("La póliza está desbalanceada. El total de cargos es mayor que el de abonos.",
                                        "Error de Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else if (iSaldo < 0)
                    {
                        MessageBox.Show("La póliza está desbalanceada. El total de abonos es mayor que el de cargos.",
                                        "Error de Balance", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Continuar con el registro si el saldo es 0
                    string fecha = dtpfecha.Value.ToString("yyyy-MM-dd");
                    string concepto = txtConcepto.Text;
                    int tipoPoliza = Convert.ToInt32(cbtipopoliza.SelectedValue);

                    bool exito = controlador.ProcesarPolizaCompleta(fecha, concepto, tipoPoliza, detalles);

                    if (exito)
                    {
                        MessageBox.Show("Póliza registrada correctamente.");
                        LimpiarCamposEncabezado();
                        InicializarComponentes();
                        dgvPolizas.Rows.Clear();
                        detalles.Clear();
                        iSaldo = 0; // Reiniciar saldo después del registro
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al registrar la póliza.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("El detalle de la póliza está vacío o falta completar información.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la póliza: " + ex.Message, "Error");
            }
        }


        // Botón Cancelar - Restablece los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCamposEncabezado();
                LimpiarCamposDetalle();
                InicializarComponentes();
                dgvPolizas.Rows.Clear();
                detalles.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la creación de la póliza: " + ex.Message, "Error");
            }
        }

        // Botón Salir - Cierra el formulario
        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar el formulario: " + ex.Message, "Error");
            }
        }

        // Método para actualizar totales de cargos y abonos
        private void ActualizarTotales()
        {
            try
            {
                int totalCargo = 0, totalAbono = 0;

                foreach (DataGridViewRow row in dgvPolizas.Rows)
                {
                    totalCargo += Convert.ToInt32(row.Cells["Cargo"].Value ?? 0);
                    totalAbono += Convert.ToInt32(row.Cells["Abono"].Value ?? 0);
                }

                lblCargo.Text = totalCargo.ToString("N2");
                lblAbono.Text = totalAbono.ToString("N2");

                // Mostrar el saldo usando iSaldo
                lbl_saldo.Text = iSaldo.ToString("N2");

                // Cambia el color de lbl_saldo según el balance
                lbl_saldo.ForeColor = iSaldo != 0 ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar totales de cargos y abonos: " + ex.Message, "Error");
            }
        }

        // Validar los campos antes de agregar un detalle
        private bool ValidarCamposDetalle()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValor.Text) || cbCuenta.SelectedIndex < 0 || cboperacion.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor complete todos los campos del detalle.", "Validación");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación de campos del detalle: " + ex.Message, "Error");
                return false;
            }
        }

        // Validar los campos antes de registrar la póliza
        private bool ValidarCamposEncabezado()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtConcepto.Text) || cbtipopoliza.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor complete todos los campos del encabezado.", "Validación");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la validación de campos del encabezado: " + ex.Message, "Error");
                return false;
            }
        }

        // Limpiar campos de detalle después de agregar
        private void LimpiarCamposDetalle()
        {
            try
            {
                cbCuenta.SelectedIndex = 0;
                cboperacion.SelectedIndex = 0;
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar campos de detalle: " + ex.Message, "Error");
            }
        }

        // Limpiar campos de encabezado después de registrar
        private void LimpiarCamposEncabezado()
        {
            try
            {
                cbtipopoliza.SelectedIndex = 0;
                txtConcepto.Clear();
                lblCargo.Text = "00.00";
                lblAbono.Text = "00.00";
                lbl_saldo.Text = "00.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar campos de encabezado: " + ex.Message, "Error");
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Frm_Reporte pr = new Frm_Reporte();
            pr.Show();
        }

        public string sRutaProyectoAyuda { get; private set; } = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\..\..\..\"));

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            try
            {
                //Ruta para que se ejecute desde la ejecucion de Interfac3
                string sAyudaPath = Path.Combine(sRutaProyectoAyuda, "Ayuda", "Modulos", "Produccion", "Ayuda_Polizas", "Ayuda_Polizas.chm");
                //string sIndiceAyuda = Path.Combine(sRutaProyecto, "EstadosFinancieros", "ReportesEstados", "Htmlayuda.hmtl");
                //MessageBox.Show("Ruta del reporte: " + sAyudaPath, "Ruta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Help.ShowHelp(this, sAyudaPath, "Ayuda_Polizas.html");


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
