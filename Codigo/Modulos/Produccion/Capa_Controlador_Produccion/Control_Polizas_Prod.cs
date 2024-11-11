using System;
using System.Collections.Generic;
using System.Data;
using Capa_Modelo_Produccion; // Importar la capa modelo para acceder a Sentencia_Polizas_Prod

namespace Capa_Controlador_Produccion
{
    public class Control_Polizas_Prod
    {
        private Sentencia_Polizas_Prod sentencia = new Sentencia_Polizas_Prod();

        // Método para llenar ComboBox con datos de la base de datos
        public DataTable ObtenerDatosComboBox(string tabla, string campoID, string campoNombre)
        {
            try
            {
                return sentencia.ObtenerDatosComboBox(tabla, campoID, campoNombre);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener datos para ComboBox: " + ex.Message);
                return null;
            }
        }

        // Método para insertar una nueva póliza en el encabezado
        public int CrearPolizaEncabezado(string fechaPoliza, string concepto, int tipoPoliza)
        {
            try
            {
                return sentencia.InsertarPolizaEncabezado(fechaPoliza, concepto, tipoPoliza);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al crear el encabezado de la póliza: " + ex.Message);
                return 0;
            }
        }

        // Método para insertar detalles de la póliza
        public bool CrearPolizaDetalle(int idEncabezado, int idCuenta, int tipoOperacion, decimal valor)
        {
            try
            {
                return sentencia.InsertarPolizaDetalle(idEncabezado, idCuenta, tipoOperacion, valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el detalle de la póliza para la cuenta {idCuenta}: " + ex.Message);
                return false;
            }
        }

        // Método para actualizar los saldos de una cuenta
        public bool ActualizarSaldoCuenta(int idCuenta, string tipoOperacion, decimal valor)
        {
            try
            {
                return sentencia.ActualizarSaldosCuenta(idCuenta, tipoOperacion, valor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al actualizar el saldo de la cuenta {idCuenta}: " + ex.Message);
                return false;
            }
        }

        // Método para procesar una nueva póliza completa (encabezado y detalles)
        public bool ProcesarPolizaCompleta(string fechaPoliza, string concepto, int tipoPoliza, List<object[]> detalles)
        {
            try
            {
                // Insertar el encabezado de la póliza y obtener el ID
                int idEncabezado = CrearPolizaEncabezado(fechaPoliza, concepto, tipoPoliza);

                if (idEncabezado > 0)
                {
                    // Procesar cada detalle de la póliza
                    foreach (var detalle in detalles)
                    {
                        int idCuenta = Convert.ToInt32(detalle[0]);
                        int idOperacion = Convert.ToInt32(detalle[1]);
                        decimal valor = Convert.ToDecimal(detalle[2]);

                        // Insertar el detalle
                        bool detalleExito = CrearPolizaDetalle(idEncabezado, idCuenta, idOperacion, valor);
                        if (!detalleExito)
                        {
                            Console.WriteLine($"Error al insertar detalle para cuenta {idCuenta}");
                            return false;
                        }

                        // Actualizar el saldo de la cuenta
                        bool saldoExito = ActualizarSaldoCuenta(idCuenta, idOperacion == 1 ? "Cargo" : "Abono", valor);
                        if (!saldoExito)
                        {
                            Console.WriteLine($"Error al actualizar saldo para cuenta {idCuenta}");
                            return false;
                        }
                    }
                    return true; // Todo el proceso fue exitoso
                }
                else
                {
                    Console.WriteLine("Error al crear el encabezado de la póliza");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al procesar la póliza completa: " + ex.Message);
                return false;
            }
        }
    }
}
