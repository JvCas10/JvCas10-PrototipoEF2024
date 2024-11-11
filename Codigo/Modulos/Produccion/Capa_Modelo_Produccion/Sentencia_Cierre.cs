using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Produccion
{
    public class Sentencia_Cierre
    {
        private Conexion_Produccion conexion = new Conexion_Produccion();

        // Método para obtener el saldo anterior
        public decimal ObtenerSaldoAnterior()
        {
            decimal saldoAnterior = 0;
            string query = "SELECT saldo_actual FROM tbl_cierre_produccion ORDER BY fecha DESC LIMIT 1";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        saldoAnterior = reader.GetDecimal(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el saldo anterior: " + ex.Message);
            }

            return saldoAnterior;
        }

        // Método para obtener los cargos del mes actual
        public decimal ObtenerCargosMes(DateTime fecha)
        {
            decimal cargosMes = 0;
            string query = "SELECT SUM(monto) FROM tbl_movimientos_produccion WHERE tipo = 'cargo' AND MONTH(fecha) = ? AND YEAR(fecha) = ?";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("fechaMes", fecha.Month);
                    command.Parameters.AddWithValue("fechaYear", fecha.Year);

                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            cargosMes = reader.GetDecimal(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los cargos del mes: " + ex.Message);
            }

            return cargosMes;
        }

        // Método para obtener los abonos del mes actual
        public decimal ObtenerAbonosMes(DateTime fecha)
        {
            decimal abonosMes = 0;
            string query = "SELECT SUM(monto) FROM tbl_movimientos_produccion WHERE tipo = 'abono' AND MONTH(fecha) = ? AND YEAR(fecha) = ?";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("fechaMes", fecha.Month);
                    command.Parameters.AddWithValue("fechaYear", fecha.Year);

                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            abonosMes = reader.GetDecimal(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los abonos del mes: " + ex.Message);
            }

            return abonosMes;
        }

        // Método para obtener el último cargo acumulado y sumar el cargo del mes actual
        public decimal ObtenerCargosAcumuladosAnuales(int year, decimal cargosMes)
        {
            decimal ultimoCargosAcumulados = 0;
            string query = "SELECT cargos_acumulados FROM tbl_cierre_produccion ORDER BY fecha DESC LIMIT 1";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        ultimoCargosAcumulados = reader.GetDecimal(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los cargos acumulados: " + ex.Message);
            }

            return ultimoCargosAcumulados + cargosMes;
        }

        // Método para obtener el último abono acumulado y sumar el abono del mes actual
        public decimal ObtenerAbonosAcumuladosAnuales(int year, decimal abonosMes)
        {
            decimal ultimoAbonosAcumulados = 0;
            string query = "SELECT abonos_acumulados FROM tbl_cierre_produccion ORDER BY fecha DESC LIMIT 1";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        ultimoAbonosAcumulados = reader.GetDecimal(0);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los abonos acumulados: " + ex.Message);
            }

            return ultimoAbonosAcumulados + abonosMes;
        }

        // Método para actualizar el saldo actual y los acumulados, incluyendo saldo anterior, cargos y abonos del mes
        public bool ActualizarSaldo(decimal saldoAnterior, decimal cargosMes, decimal abonosMes, decimal saldoActual, decimal cargosAcumulados, decimal abonosAcumulados, DateTime fecha)
        {
            // Verificar si la fecha ya existe
            if (FechaYaExiste(fecha))
            {
                Console.WriteLine("Error: La fecha ya existe en el sistema.");
                return false;
            }

            string query = "INSERT INTO tbl_cierre_produccion (fecha, saldo_anterior, cargos_mes, abonos_mes, saldo_actual, cargos_acumulados, abonos_acumulados) VALUES (?, ?, ?, ?, ?, ?, ?)";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("fecha", fecha);
                    command.Parameters.AddWithValue("saldo_anterior", saldoAnterior);
                    command.Parameters.AddWithValue("cargos_mes", cargosMes);
                    command.Parameters.AddWithValue("abonos_mes", abonosMes);
                    command.Parameters.AddWithValue("saldo_actual", saldoActual);
                    command.Parameters.AddWithValue("cargos_acumulados", cargosAcumulados);
                    command.Parameters.AddWithValue("abonos_acumulados", abonosAcumulados);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el saldo y acumulados: " + ex.Message);
                return false;
            }
        }

        // Método para verificar si la fecha ya existe en la base de datos
        private bool FechaYaExiste(DateTime fecha)
        {
            string query = "SELECT COUNT(*) FROM tbl_cierre_produccion WHERE fecha = ?";
            int count = 0;

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand command = new OdbcCommand(query, conn))
                {
                    command.Parameters.AddWithValue("fecha", fecha);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar la fecha: " + ex.Message);
            }

            return count > 0;
        }

        // Método para obtener el historial de cierres
        public DataTable ObtenerHistorialCierres()
        {
            DataTable historialCierres = new DataTable();
            string query = "SELECT fecha, saldo_anterior, cargos_mes, abonos_mes, saldo_actual FROM tbl_cierre_produccion ORDER BY fecha DESC";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                {
                    adapter.Fill(historialCierres);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el historial de cierres: " + ex.Message);
            }

            return historialCierres;
        }
    }
}
