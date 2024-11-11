using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Modelo_Cambio;

namespace Capa_Controlador_Cambio
{
    public class Controlador
    {
        private Modelo capaModeloCambio = new Modelo();

        public DataTable ObtenerTipoCambio()
        {
            DataTable tiposDeCambio = capaModeloCambio.ObtenerTipoCambio();
            return tiposDeCambio;
        }
        public List<string> ObtenerNombresMonedas()
        {
            List<string> nombresMonedas = capaModeloCambio.ObtenerNombresMonedas();
            return nombresMonedas;
        }
        public int BuscarMoneda(DataTable tiposDeCambio, string nombreMoneda)
        {
            for (int i = 0; i < tiposDeCambio.Rows.Count; i++)
            {
                if (tiposDeCambio.Rows[i]["Moneda"].ToString() == nombreMoneda)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
