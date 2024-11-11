using System;
using System.Data;
using Capa_Modelo_Mantenimiento;

namespace Capa_Control_Mantenimiento
{
    public class Control_Mantenimiento
    {
        private readonly Sentencia_Mantenimiento sentencias;

        // Constructor que inicializa la instancia de Sentencia_Mantenimiento para interactuar con la base de datos
        public Control_Mantenimiento()
        {
            sentencias = new Sentencia_Mantenimiento();
        }

        // Método para obtener los datos de la máquina por su nombre
        public (int idMaquina, string tipoMaquina) ObtenerDatosMaquina(string nombreMaquina)
        {
            return sentencias.ObtenerMaquinaPorNombre(nombreMaquina);
        }

        // Método para agregar un nuevo mantenimiento
        public void AgregarMantenimiento(
            int fkIdMaquina,  // Añadido para pasar el ID de la máquina
            string nombreMaquinaria,
            string tipoMaquina,
            decimal horaOperacion,
            string mantenimientoPeriodico,
            DateTime ultimaMantenimiento,
            DateTime proximoMantenimiento,
            string area,
            decimal desgastePorcentaje,
            int estado)
        {
            try
            {
                sentencias.InsertarMantenimiento(
                    fkIdMaquina,          // Paso de fkIdMaquina
                    nombreMaquinaria,
                    tipoMaquina,
                    horaOperacion,
                    mantenimientoPeriodico,
                    ultimaMantenimiento,
                    proximoMantenimiento,
                    area,
                    desgastePorcentaje,
                    estado
                );
                Console.WriteLine("Mantenimiento agregado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar mantenimiento: " + ex.Message);
            }
        }

        // Método para actualizar un mantenimiento existente
        public void ActualizarMantenimiento(
            int idMaquinaria,
            int fkIdMaquina,  // Añadido para pasar el ID de la máquina
            string nombreMaquinaria,
            string tipoMaquina,
            decimal horaOperacion,
            string mantenimientoPeriodico,
            DateTime ultimaMantenimiento,
            DateTime proximoMantenimiento,
            string area,
            decimal desgastePorcentaje,
            int estado)
        {
            try
            {
                sentencias.ActualizarMantenimiento(
                    idMaquinaria,
                    fkIdMaquina,       // Paso de fkIdMaquina
                    nombreMaquinaria,
                    tipoMaquina,
                    horaOperacion,
                    mantenimientoPeriodico,
                    ultimaMantenimiento,
                    proximoMantenimiento,
                    area,
                    desgastePorcentaje,
                    estado
                );
                Console.WriteLine("Mantenimiento actualizado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar mantenimiento: " + ex.Message);
            }
        }

        // Método para eliminar (desactivar) un mantenimiento por ID
        public void DesactivarMantenimiento(int idMaquinaria)
        {
            try
            {
                sentencias.DesactivarMantenimiento(idMaquinaria);
                Console.WriteLine("Mantenimiento desactivado correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desactivar el mantenimiento: " + ex.Message);
            }
        }

        // Método para obtener todos los mantenimientos en la base de datos
        public DataTable CargarMantenimientos()
        {
            try
            {
                DataTable mantenimientos = sentencias.ObtenerMantenimientos();
                Console.WriteLine("Datos de mantenimientos cargados correctamente. Total de registros: " + mantenimientos.Rows.Count);
                return mantenimientos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los mantenimientos: " + ex.Message);
                return new DataTable(); // Retorna una tabla vacía en caso de error
            }
        }

        // Método para obtener los nombres de las máquinas
        public DataTable ObtenerNombresMaquinas()
        {
            return sentencias.ObtenerNombresMaquinas();
        }

        // Método para obtener el último ID de la tabla de mantenimientos
        public int ObtenerUltimoIdMaquinaria()
        {
            try
            {
                int ultimoId = sentencias.ObtenerUltimoIdMaquinaria();
                Console.WriteLine("Último ID de maquinaria obtenido: " + ultimoId);
                return ultimoId;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el último ID de maquinaria: " + ex.Message);
                return 0; // Retorna 0 en caso de error
            }
        }
    }
}
