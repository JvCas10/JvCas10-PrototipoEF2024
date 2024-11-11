using Capa_Modelo_Produccion;
using System.Data;

namespace Capa_Controlador_Produccion
{
    public class Control_Implosion_Explosion_Materiales
    {
        private readonly Sentencia_Produccion sentencias;

        public Control_Implosion_Explosion_Materiales()
        {
            sentencias = new Sentencia_Produccion();
        }

        public DataTable ObtenerProductosPorSerie(string serie)
        {
            return sentencias.ObtenerProductosPorSerie(serie);
        }
    }
}

