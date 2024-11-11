using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Controlador_Ordenes;
using System;
using System.Data;


namespace TestOrdenesProduccion
{
    [TestClass]
    public class TestOrden
    {
        private Control_Ordenes controlOrdenes;

        [TestInitialize]
        public void Setup()
        {
            // Inicializamos el objeto Control_Ordenes antes de cada prueba
            controlOrdenes = new Control_Ordenes();
        }

        [TestMethod]
        public void ActualizarOrden_DeberiaRetornarTrueParaDatosValidos()
        {
            // Arrange
            int idOrden = 1; // Suponiendo que existe una orden con ID 1
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFin = DateTime.Now.AddDays(10);
            int estado = 2;

            // Act
            bool resultado = controlOrdenes.ActualizarOrden(idOrden, fechaInicio, fechaFin, estado);

            // Assert
            Assert.IsTrue(resultado, "La orden debería actualizarse correctamente con datos válidos.");
        }

        [TestMethod]
        public void DesactivarOrden_DeberiaRetornarTrueParaIdValido()
        {
            // Arrange
            int idOrden = 1; // Suponiendo que existe una orden con ID 1

            // Act
            bool resultado = controlOrdenes.DesactivarOrden(idOrden);

            // Assert
            Assert.IsTrue(resultado, "La orden debería desactivarse correctamente para un ID válido.");
        }



        [TestMethod]
        public void ObtenerSiguienteIdOrden_DeberiaRetornarIdPositivo()
        {
            // Act
            int siguienteId = controlOrdenes.ObtenerSiguienteIdOrden();

            // Assert
            Assert.IsTrue(siguienteId > 0, "El siguiente ID de orden debería ser un valor positivo.");
        }

    }
}
