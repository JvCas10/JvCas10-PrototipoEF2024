using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Polizas_Prod
{
    public class Sentencia_Polizas_Prod
    {
        private Capa_Modelo_Cierre_Produccion.Conexion_Cierre_Produccion conexion = new Capa_Modelo_Cierre_Produccion.Conexion_Cierre_Produccion();

        // Método para obtener datos de un ComboBox
        public DataTable ObtenerDatosComboBox(string tabla, string campoID, string campoNombre)
        {
            DataTable datos = new DataTable();
            string consulta = $"SELECT {campoID}, {campoNombre} FROM {tabla} WHERE estado = 1";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                {
                    OdbcDataAdapter adaptador = new OdbcDataAdapter(consulta, conn);
                    adaptador.Fill(datos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos del ComboBox: " + ex.Message);
            }
            return datos;
        }

        // Método para insertar en tbl_polizaencabezado
        public int InsertarPolizaEncabezado(string fechaPoliza, string concepto, int tipoPoliza)
        {
            int idEncabezado = 0;
            string consulta = "INSERT INTO tbl_polizaencabezado (fechaPoliza, concepto, Pk_id_tipopoliza) VALUES (?, ?, ?)";

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@fechaPoliza", fechaPoliza);
                    cmd.Parameters.AddWithValue("@concepto", concepto);
                    cmd.Parameters.AddWithValue("@Pk_id_tipopoliza", tipoPoliza);
                    cmd.ExecuteNonQuery();

                    // Obtener el último ID insertado
                    cmd.CommandText = "SELECT LAST_INSERT_ID()";
                    idEncabezado = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el encabezado de la póliza: " + ex.Message);
            }
            return idEncabezado;
        }

        // Método para insertar en tbl_polizadetalle
        public bool InsertarPolizaDetalle(int idEncabezado, int idCuenta, int tipoOperacion, decimal valor)
        {
            string consulta = "INSERT INTO tbl_polizadetalle (Pk_id_polizaencabezado, Pk_id_cuenta, Pk_id_tipooperacion, valor) VALUES (?, ?, ?, ?)";
            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                {
                    cmd.Parameters.AddWithValue("@Pk_id_polizaencabezado", idEncabezado);
                    cmd.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);
                    cmd.Parameters.AddWithValue("@Pk_id_tipooperacion", tipoOperacion);
                    cmd.Parameters.AddWithValue("@valor", valor);

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar detalle de póliza: " + ex.Message);
                return false;
            }
        }

        // Método para actualizar los saldos de una cuenta en tbl_cuentas
        public bool ActualizarSaldosCuenta(int idCuenta, string tipoOperacion, decimal valor)
        {
            string consultaSelect = "SELECT cargo_mes, abono_mes, saldo_act FROM tbl_cuentas WHERE Pk_id_cuenta = ?";
            string consultaUpdate = "UPDATE tbl_cuentas SET cargo_mes = ?, abono_mes = ?, saldo_act = ? WHERE Pk_id_cuenta = ?";

            decimal cargoMes = 0, abonoMes = 0, saldoActual = 0;

            try
            {
                using (OdbcConnection conn = conexion.Probar_Conexion())
                {
                    // Obtener los valores actuales de la cuenta
                    using (OdbcCommand cmdSelect = new OdbcCommand(consultaSelect, conn))
                    {
                        cmdSelect.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);
                        using (OdbcDataReader reader = cmdSelect.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cargoMes = Convert.ToDecimal(reader["cargo_mes"]);
                                abonoMes = Convert.ToDecimal(reader["abono_mes"]);
                                saldoActual = Convert.ToDecimal(reader["saldo_act"]);
                            }
                        }
                    }

                    // Ajustar el saldo según la operación
                    if (tipoOperacion == "Cargo")
                        cargoMes += valor;
                    else
                        abonoMes += valor;

                    saldoActual = cargoMes - abonoMes;

                    // Actualizar los valores en la base de datos
                    using (OdbcCommand cmdUpdate = new OdbcCommand(consultaUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@cargo_mes", cargoMes);
                        cmdUpdate.Parameters.AddWithValue("@abono_mes", abonoMes);
                        cmdUpdate.Parameters.AddWithValue("@saldo_act", saldoActual);
                        cmdUpdate.Parameters.AddWithValue("@Pk_id_cuenta", idCuenta);

                        cmdUpdate.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los saldos de la cuenta: " + ex.Message);
                return false;
            }
        }
    }
}
