using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace Capa_Modelo_RRHH
{
    public class Sentencias_RRHH
    {
        private Conexion_RRHH conexion = new Conexion_RRHH();

        public int ObtenerUltimoIdRRHH()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT MAX(Pk_id_RRHH) FROM tbl_rrhh_produccion";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? Convert.ToInt32(result) + 1 : 1;

            }
        }

        public DataTable ObtenerEmpleadosActivos()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT pk_clave, empleados_nombre FROM tbl_empleados WHERE estado = 1";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

         public List<decimal> ObtenerHorasExtras()
         {
             List<decimal> horasExtras = new List<decimal>();
             using (OdbcConnection conn = conexion.Probar_Conexion())
             {
                 string query = "SELECT horas_cantidad_horas FROM tbl_horas_extra";
                 OdbcCommand cmd = new OdbcCommand(query, conn);
                 OdbcDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     horasExtras.Add(reader.GetDecimal(0));
                 }
             }
             return horasExtras;
         }

        public DataTable ObtenerHoras()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT  horas FROM tbl_recetas WHERE estado = 1";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

       public DataTable ObtenerDias()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT  dias FROM tbl_recetas WHERE estado = 1";
                OdbcDataAdapter da = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        public List<decimal> ObtenerSalarios()
        {
            List<decimal> salarios = new List<decimal>();
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT contratos_salario FROM tbl_contratos";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    salarios.Add(reader.GetDecimal(0));
                }
            }
            return salarios;
        }


        public void GuardarRegistroRRHH(int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "INSERT INTO tbl_rrhh_produccion (id_empleado, salario, dias, total_dias, horas, total_horas, horas_extras, total_horas_extras, total_mano_obra, estado) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, 1)";
                OdbcCommand cmd = new OdbcCommand(query, conn);
                cmd.Parameters.AddWithValue("?", empleadoID);
                cmd.Parameters.AddWithValue("?", salario);
                cmd.Parameters.AddWithValue("?", dias);
                cmd.Parameters.AddWithValue("?", totalDias);
                cmd.Parameters.AddWithValue("?", horas);
                cmd.Parameters.AddWithValue("?", totalHoras);
                cmd.Parameters.AddWithValue("?", horasExtra);
                cmd.Parameters.AddWithValue("?", totalHorasExtras);
                cmd.Parameters.AddWithValue("?", totalManoObra);
                
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ObtenerTodosLosRegistrosRRHH()
        {
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                string query = "SELECT * FROM tbl_rrhh_produccion";
                OdbcDataAdapter adapter = new OdbcDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void ConsultarRegistroPorId(int idRRHH, int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
          
            using (OdbcConnection conn = conexion.Probar_Conexion())
            {
                conn.Open();
                string query = "UPDATE tbl_rrhh_produccion SET id_empleado = ?, salario = ?, dias = ?, total_dias = ?, horas = ?, total_horas = ?, horas_extras = ?, total_horas_extras = ?, total_mano_obra = ? WHERE pk_id_RRHH = ?";
                using (var cmd = new OdbcCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id_empleado", empleadoID);
                    cmd.Parameters.AddWithValue("salario", salario);
                    cmd.Parameters.AddWithValue("dias", dias);
                    cmd.Parameters.AddWithValue("total_dias", totalDias);
                    cmd.Parameters.AddWithValue("horas", horas);
                    cmd.Parameters.AddWithValue("total_horas", totalHoras);
                    cmd.Parameters.AddWithValue("horas_extras", horasExtra);
                    cmd.Parameters.AddWithValue("total_horas_extras", totalHorasExtras);
                    cmd.Parameters.AddWithValue("total_mano_obra", totalManoObra);
                    cmd.Parameters.AddWithValue("pk_id_RRHH", idRRHH);

                    cmd.ExecuteNonQuery();
                }
            }

        }


    }


}

