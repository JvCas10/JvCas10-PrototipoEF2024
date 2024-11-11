using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_RRHH;
using System.Data;

namespace Capa_Controlador_RRHH
{
    public class Controlador_RRHH
    {
        private Sentencias_RRHH sentencia = new Sentencias_RRHH();

        public int ObtenerUltimoID()
        {
            return sentencia.ObtenerUltimoIdRRHH();
        }

        public DataTable ObtenerEmpleados()
        {
            return sentencia.ObtenerEmpleadosActivos();
        }

        public List<decimal> ObtenerSalarios()
        {
            return sentencia.ObtenerSalarios();
        }

        public List<decimal> ObtenerHorasExtras()
        {
            return sentencia.ObtenerHorasExtras();
        }

        public DataTable ObtenerHoras()
        {
            return sentencia.ObtenerHoras();
        }

        public DataTable ObtenerDias()
        {
            return sentencia.ObtenerDias();
        }



        public void GuardarRegistro(int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
            sentencia.GuardarRegistroRRHH(empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtra, totalHorasExtras, totalManoObra);
        }

      

        public DataTable ObtenerTodosLosRegistros()
        {
            return sentencia.ObtenerTodosLosRegistrosRRHH();
        }


        public void ConsultarRegistroPorId(int idRRHH, int empleadoID, decimal salario, int dias, decimal totalDias, decimal horas, decimal totalHoras, int horasExtra, decimal totalHorasExtras, decimal totalManoObra)
        {
             sentencia.ConsultarRegistroPorId(idRRHH, empleadoID, salario, dias, totalDias, horas, totalHoras, horasExtra, totalHorasExtras, totalManoObra);
        }


    }
}
