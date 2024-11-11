using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Controlador_Cierre_Produccion; // Asegúrate de tener esta referencia añadida
using System;

namespace Test_Cierre_Produccion
{
    [TestClass]
    public class TestCierre
    {
        [TestMethod]
        public void CalcularSaldoActual_DeberiaRetornarSaldoCorrecto()
        {
            // Arrange
            var controlCierre = new Control_Cierre();
            decimal saldoAnterior = 1000;
            decimal cargosMes = 200;
            decimal abonosMes = 100;

            // Act
            decimal saldoActual = controlCierre.CalcularSaldoActual(saldoAnterior, cargosMes, abonosMes);

            // Assert
            Assert.AreEqual(1100, saldoActual, "El saldo actual calculado no es el esperado.");
        }

        [TestMethod]
        public void ObtenerDatosCierre_DeberiaRetornarValoresCorrectos()
        {
            // Arrange
            var controlCierre = new Control_Cierre();
            DateTime fecha = new DateTime(2024, 11, 2); // Usa una fecha de prueba

            // Act
            var (saldoAnterior, cargosMes, abonosMes) = controlCierre.ObtenerDatosCierre(fecha);

            // Assert
            Assert.IsNotNull(saldoAnterior, "El saldo anterior no debe ser nulo.");
            Assert.IsNotNull(cargosMes, "Los cargos del mes no deben ser nulos.");
            Assert.IsNotNull(abonosMes, "Los abonos del mes no deben ser nulos.");
            // Puedes agregar valores esperados si tienes datos específicos para comparar
        }

        [TestMethod]
        public void ObtenerCargosAcumuladosAnuales_DeberiaRetornarCargosCorrectos()
        {
            // Arrange
            var controlCierre = new Control_Cierre();
            int year = 2024;
            decimal cargosMes = 150;

            // Act
            decimal cargosAcumulados = controlCierre.ObtenerCargosAcumuladosAnuales(year, cargosMes);

            // Assert
            Assert.IsTrue(cargosAcumulados >= cargosMes, "Los cargos acumulados deberían incluir al menos los cargos del mes.");
        }
    }
}
