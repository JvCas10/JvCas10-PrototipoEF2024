using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Control_Polizas_Prod;
using System;
using System.Collections.Generic;

namespace TestPolizaProduccion
{
    [TestClass]
    public class TestPolizaProd
    {
        private Control_Polizas_Prod controlPolizas;

        [TestInitialize]
        public void Setup()
        {
            // Inicializamos la instancia de Control_Polizas_Prod antes de cada prueba
            controlPolizas = new Control_Polizas_Prod();
        }

        [TestMethod]
        public void CrearPolizaEncabezado_DeberiaRetornarIdValido()
        {
            // Arrange
            string fechaPoliza = DateTime.Now.ToString("yyyy-MM-dd");
            string concepto = "Test Concepto";
            int tipoPoliza = 1; // Tipo de póliza de prueba

            // Act
            int idEncabezado = controlPolizas.CrearPolizaEncabezado(fechaPoliza, concepto, tipoPoliza);

            // Assert
            Assert.IsTrue(idEncabezado > 0, "El ID del encabezado de la póliza debería ser mayor a 0.");
        }

        [TestMethod]
        public void ProcesarPolizaCompleta_DeberiaRetornarFalseParaSaldoDesbalanceado()
        {
            // Arrange
            string fechaPoliza = DateTime.Now.ToString("yyyy-MM-dd");
            string concepto = "Póliza Desbalanceada";
            int tipoPoliza = 1;
            List<object[]> detalles = new List<object[]>
            {
                new object[] { 1, 1, 150.00m },  // Cargo de 150
                new object[] { 2, 2, 100.00m }   // Abono de 100
            };

            // Act
            bool resultado = controlPolizas.ProcesarPolizaCompleta(fechaPoliza, concepto, tipoPoliza, detalles);

            // Assert
            Assert.IsFalse(resultado, "La póliza desbalanceada no debería procesarse.");
        }
    }
}
