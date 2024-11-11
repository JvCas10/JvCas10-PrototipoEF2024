using System;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Mantenimiento
{
    public class Sentencia_Mantenimiento
    {
        private Conexion_Mantenimiento conexion;

        public Sentencia_Mantenimiento()
        {
            conexion = new Conexion_Mantenimiento();
        }

        // Método para insertar un nuevo registro de mantenimiento
        public void InsertarMantenimiento(
            int fkIdMaquina,
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
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return;
                }

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"INSERT INTO tbl_mantenimientos 
                            (fk_id_maquina, nombre_maquinaria, tipo_maquina, hora_operacion, mantenimiento_periodico, 
                            ultima_mantenimiento, proximo_mantenimiento, area, desgaste_porcentaje, estado) 
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                        using (OdbcCommand cmd = new OdbcCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("?", fkIdMaquina); // fk_id_maquina
                            cmd.Parameters.AddWithValue("?", nombreMaquinaria);
                            cmd.Parameters.AddWithValue("?", tipoMaquina);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(horaOperacion));
                            cmd.Parameters.AddWithValue("?", mantenimientoPeriodico);
                            cmd.Parameters.AddWithValue("?", ultimaMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", proximoMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", area);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(desgastePorcentaje));
                            cmd.Parameters.AddWithValue("?", estado);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine("Filas insertadas: " + rowsAffected);

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al guardar el mantenimiento: " + ex.Message);
                        throw;
                    }
                }
            }
        }

        // Método para obtener nombres de las máquinas
        public DataTable ObtenerNombresMaquinas()
        {
            DataTable nombresMaquinas = new DataTable();

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return nombresMaquinas;
                }

                try
                {
                    string query = "SELECT nombre_maquina FROM tbl_maquinaria";

                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                    {
                        adapter.Fill(nombresMaquinas);
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener los nombres de las máquinas: " + ex.Message);
                }
            }

            return nombresMaquinas;
        }

        // Método para obtener ID y tipo de una máquina por su nombre
        public (int idMaquina, string tipoMaquina) ObtenerMaquinaPorNombre(string nombreMaquina)
        {
            int idMaquina = 0;
            string tipoMaquina = string.Empty;

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return (idMaquina, tipoMaquina);
                }

                try
                {
                    string query = "SELECT pk_id_maquina, tipo_maquina FROM tbl_maquinaria WHERE nombre_maquina = ?";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("?", nombreMaquina);
                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idMaquina = reader.GetInt32(0); // pk_id_maquina
                                tipoMaquina = reader.GetString(1); // tipo_maquina
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener la máquina por nombre: " + ex.Message);
                }
            }

            return (idMaquina, tipoMaquina);
        }

        // Método para actualizar un registro de mantenimiento existente
        public void ActualizarMantenimiento(
            int idMaquinaria,
            int fkIdMaquina,
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
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return;
                }

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"UPDATE tbl_mantenimientos SET 
                            fk_id_maquina = ?, 
                            nombre_maquinaria = ?, 
                            tipo_maquina = ?, 
                            hora_operacion = ?, 
                            mantenimiento_periodico = ?, 
                            ultima_mantenimiento = ?, 
                            proximo_mantenimiento = ?, 
                            area = ?, 
                            desgaste_porcentaje = ?, 
                            estado = ? 
                            WHERE Pk_id_maquinaria = ?";

                        using (OdbcCommand cmd = new OdbcCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("?", fkIdMaquina);
                            cmd.Parameters.AddWithValue("?", nombreMaquinaria);
                            cmd.Parameters.AddWithValue("?", tipoMaquina);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(horaOperacion));
                            cmd.Parameters.AddWithValue("?", mantenimientoPeriodico);
                            cmd.Parameters.AddWithValue("?", ultimaMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", proximoMantenimiento.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("?", area);
                            cmd.Parameters.AddWithValue("?", Convert.ToDouble(desgastePorcentaje));
                            cmd.Parameters.AddWithValue("?", estado);
                            cmd.Parameters.AddWithValue("?", idMaquinaria);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine("Filas actualizadas: " + rowsAffected);

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al actualizar el mantenimiento: " + ex.Message);
                    }
                }
            }
        }

        // Método para eliminar (desactivar) un registro de mantenimiento por ID
        public void DesactivarMantenimiento(int idMaquinaria)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return;
                }

                using (OdbcTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string query = @"UPDATE tbl_mantenimientos SET estado = 0 WHERE Pk_id_maquinaria = ?";

                        using (OdbcCommand cmd = new OdbcCommand(query, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("?", idMaquinaria);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            Console.WriteLine("Filas actualizadas (desactivadas): " + rowsAffected);

                            transaction.Commit();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine("Error al desactivar el mantenimiento: " + ex.Message);
                        throw;
                    }
                }
            }
        }

        // Método para obtener todos los registros de mantenimiento
        public DataTable ObtenerMantenimientos()
        {
            DataTable tablaMantenimientos = new DataTable();

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return tablaMantenimientos;
                }

                try
                {
                    string query = "SELECT * FROM tbl_mantenimientos";

                    using (OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn))
                    {
                        adapter.Fill(tablaMantenimientos);
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener los mantenimientos: " + ex.Message);
                }
            }

            return tablaMantenimientos;
        }

        // Método para obtener el último ID de maquinaria
        public int ObtenerUltimoIdMaquinaria()
        {
            int ultimoId = 0;

            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                if (conn.State != ConnectionState.Open)
                {
                    Console.WriteLine("La conexión no está abierta.");
                    return ultimoId;
                }

                try
                {
                    string query = "SELECT MAX(Pk_id_maquinaria) FROM tbl_mantenimientos";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        object resultado = cmd.ExecuteScalar();
                        if (resultado != DBNull.Value && resultado != null)
                        {
                            ultimoId = Convert.ToInt32(resultado);
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al obtener el último ID de maquinaria: " + ex.Message);
                }
            }

            return ultimoId;
        }
    }
}
