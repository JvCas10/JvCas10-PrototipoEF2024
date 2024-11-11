using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Vista_Banco;  // Vista del formulario de bancos

namespace Bancos_Eje
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string idUsuario = "1";
            Application.Run(new frm_principal_bancos(idUsuario));  // Lanza el formulario sin tabla
        }
    }
}
