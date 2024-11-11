using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Cambio;

namespace Capa_Vista_Cambio
{
    public partial class frm_tipoCambio : Form
    {

        public DataTable tiposDeCambio;
        public Controlador capaControlador = new Controlador();
        private ToolTip toolTip;

        public frm_tipoCambio()
        {
            InitializeComponent();
            llenarCombo();
            toolTip = new ToolTip();
            toolTip.SetToolTip(btn_Buscar, "Buscar Moneda");
            toolTip.SetToolTip(btn_Actualizar, "Actualizar Vista");
        }

        private void llenarCombo()
        {
            List<string> nombresMonedas = capaControlador.ObtenerNombresMonedas();
            cbo_Monedas.Items.Clear();
            cbo_Monedas.Items.Add("Seleccionar...");
            foreach (string nombreMoneda in nombresMonedas)
            {
                cbo_Monedas.Items.Add(nombreMoneda);
            }
            if (cbo_Monedas.Items.Count > 0)
            {
                cbo_Monedas.SelectedIndex = 0;
            }
        }

        public void tipoCambio_Load(object sender, EventArgs e)
        {
            tiposDeCambio = capaControlador.ObtenerTipoCambio();
            dgv_TipoCambio.DataSource = tiposDeCambio;
            dgv_TipoCambio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreMonedaSeleccionada = cbo_Monedas.SelectedItem.ToString();
            int filaEncontrada = capaControlador.BuscarMoneda(tiposDeCambio, nombreMonedaSeleccionada);

            if (filaEncontrada != -1)
            {
                dgv_TipoCambio.ClearSelection();
                dgv_TipoCambio.Rows[filaEncontrada].Selected = true;
                dgv_TipoCambio.FirstDisplayedScrollingRowIndex = filaEncontrada;
            }
            else
            {
                MessageBox.Show("Moneda no encontrada.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            llenarCombo();
            dgv_TipoCambio.ClearSelection();
        }
    }
}
