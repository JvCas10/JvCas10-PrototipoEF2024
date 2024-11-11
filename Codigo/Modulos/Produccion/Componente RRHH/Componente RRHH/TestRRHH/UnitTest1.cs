using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_RRHH;
using System.Data;

namespace TestRRHH
{
    [TestClass]
    public class TestRRHH
    {
        private Sentencias_RRHH sentenciasRRHH;

        [TestInitialize]
        public void Setup()
        {
            sentenciasRRHH = new Sentencias_RRHH();
        }


        [TestMethod]
        public void GuardarRegistroRRHH_DatosCorrectos_RegistroExitoso()
        {
            // Arrange: Configura los datos de entrada
            int empleadoID = 1; // Debe coincidir con un ID de empleado en la base de datos de prueba
            decimal salario = 1000;
            int dias = 10;
            decimal totalDias = salario / dias;
            decimal horas = 40;
            decimal totalHoras = totalDias / horas;
            int horasExtra = 5;
            decimal totalHorasExtras = horasExtra * 1.5M;
            decimal totalManoObra = totalHoras + totalHorasExtras;

        }
    }
}
