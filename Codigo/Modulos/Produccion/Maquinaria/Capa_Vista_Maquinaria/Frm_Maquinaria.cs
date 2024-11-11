using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Maquinaria
{
    public partial class Frm_Maquinaria : Form
    {
        public Frm_Maquinaria()
        {
            InitializeComponent();
            string[] alias = { "Código", "Nombre", "Tipo de máquina", "Capacidad", "Estado"};
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B1CFE6"));
            navegador1.AsignarColorFuente(ColorTranslator.FromHtml("#1669B4"));
            navegador1.ObtenerIdAplicacion("1000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario("admin");
            navegador1.AsignarTabla("tbl_maquinaria");
            //navegador1.AsignarForaneas("marcas_vehiculos", "nombre_marca", "codigo_marca", "codigo_marca");
           // navegador1.AsignarForaneas("tipos_vehiculos", "nombre_tipo", "codigo_tipo", "codigo_tipo");
            navegador1.AsignarNombreForm("Maquinaria");
        }
    }
}
