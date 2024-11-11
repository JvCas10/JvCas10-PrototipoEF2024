using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Movimientos;
using System.Data;

namespace Capa_Controlador_Movimientos
{
    public class Controlador
    {
        private Modelo Capa_Modelo_Movimientos = new Modelo();

        public DataTable ObtenerMovi()
        {
            try
            {
                DataTable tiposDeCambio = Capa_Modelo_Movimientos.ObtenerMov();
                return tiposDeCambio;
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error en un log o manejarlo de otra forma
                throw new Exception("Error al obtener los movimientos: " + ex.Message);
            }
        }

        // Método para insertar un nuevo movimiento bancario
        public bool InsertarMovimiento( DateTime fecha, string tipo, decimal monto, string descripcion, string metodoPago, bool estado)
        {
            try
            {
                bool resultado = Capa_Modelo_Movimientos.InsertarMovimiento(fecha, tipo, monto, descripcion, metodoPago, estado);
                return resultado;
            }
            catch (Exception ex)
            {
                // Aquí puedes registrar el error en un log o manejarlo de otra forma
                throw new Exception("Error al insertar el movimiento bancario: " + ex.Message);
            }
        }

        public bool EliminarMovimiento(int movimientoId)
        {
            try
            {
                // Llamamos al método del modelo para actualizar el estado del movimiento
                return Capa_Modelo_Movimientos.ActualizarEstadoMovimiento(movimientoId, false);  // El estado pasa a "Inactivo" (0)
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el movimiento: " + ex.Message);
            }
        }


        public string MIndice(string Indice1)
        {
            string indice = Capa_Modelo_Movimientos.modIndice(Indice1);

            return indice;
        }

        public string MRuta(string Ruta1)
        {
            string ruta = Capa_Modelo_Movimientos.modRuta(Ruta1);

            return ruta;
        }

    }
}
