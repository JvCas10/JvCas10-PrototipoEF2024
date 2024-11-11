using System;
using System.Data;

namespace Capa_Controlador_Cierre_Produccion
{
    public class Control_Cierre
    {
        private Capa_Modelo_Cierre_Produccion.Sentencia_Cierre_Produccion sentenciaCierre = new Capa_Modelo_Cierre_Produccion.Sentencia_Cierre_Produccion();

        // Método para obtener los datos necesarios para el cierre
        public (decimal saldoAnterior, decimal cargosMes, decimal abonosMes) ObtenerDatosCierre(DateTime fecha)
        {
            decimal saldoAnterior = 0;
            decimal cargosMes = 0;
            decimal abonosMes = 0;

            try
            {
                saldoAnterior = sentenciaCierre.ObtenerSaldoAnterior();
                cargosMes = sentenciaCierre.ObtenerCargosMes(fecha);
                abonosMes = sentenciaCierre.ObtenerAbonosMes(fecha);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los datos del cierre: " + ex.Message);
                // Puedes manejar la excepción según sea necesario, tal vez lanzarla nuevamente o registrar el error
            }

            return (saldoAnterior, cargosMes, abonosMes);
        }

        // Método para calcular el saldo actual con base en el saldo anterior, cargos y abonos
        public decimal CalcularSaldoActual(decimal saldoAnterior, decimal cargosMes, decimal abonosMes)
        {
            // Verificación adicional para evitar errores en el cálculo
            if (saldoAnterior < 0 || cargosMes < 0 || abonosMes < 0)
            {
                throw new ArgumentException("Los valores de saldo o movimientos no pueden ser negativos.");
            }

            return saldoAnterior + cargosMes - abonosMes;
        }

        // Método para guardar el cierre en la base de datos, ahora incluye saldoAnterior, cargosMes y abonosMes
        public bool GuardarCierre(decimal saldoAnterior, decimal cargosMes, decimal abonosMes, decimal saldoActual, decimal cargosAcumulados, decimal abonosAcumulados, DateTime fecha)
        {
            try
            {
                if (saldoActual < 0 || cargosAcumulados < 0 || abonosAcumulados < 0)
                {
                    throw new ArgumentException("No se puede guardar un cierre con valores negativos.");
                }

                return sentenciaCierre.ActualizarSaldo(saldoAnterior, cargosMes, abonosMes, saldoActual, cargosAcumulados, abonosAcumulados, fecha);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el cierre: " + ex.Message);
                return false; // Retornar false en caso de error
            }
        }

        // Método para obtener el historial de cierres
        public DataTable ObtenerHistorialCierres()
        {
            try
            {
                return sentenciaCierre.ObtenerHistorialCierres();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el historial de cierres: " + ex.Message);
                return null; // Retornar null en caso de error
            }
        }

        // Método para obtener los cargos acumulados anuales incluyendo el mes actual
        public decimal ObtenerCargosAcumuladosAnuales(int year, decimal cargosMes)
        {
            try
            {
                return sentenciaCierre.ObtenerCargosAcumuladosAnuales(year, cargosMes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los cargos acumulados anuales: " + ex.Message);
                return 0; // Retornar 0 en caso de error
            }
        }

        // Método para obtener los abonos acumulados anuales incluyendo el mes actual
        public decimal ObtenerAbonosAcumuladosAnuales(int year, decimal abonosMes)
        {
            try
            {
                return sentenciaCierre.ObtenerAbonosAcumuladosAnuales(year, abonosMes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los abonos acumulados anuales: " + ex.Message);
                return 0; // Retornar 0 en caso de error
            }
        }
    }
}
