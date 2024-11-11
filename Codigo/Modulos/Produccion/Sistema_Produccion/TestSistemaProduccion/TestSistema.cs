using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Controlador_Sistema_Produccion;
using System;
using System.Data;

namespace TestSistemaProduccion
{
    [TestClass]
    public class TestSistema
    {
        private Control_Sistema_Produccion controlSistema;

        [TestInitialize]
        public void Setup()
        {
            // Inicializamos el objeto Control_Sistema_Produccion antes de cada prueba
            controlSistema = new Control_Sistema_Produccion();
        }

        [TestMethod]
        public void InsertarEncabezado_DeberiaRetornarTrueParaDatosValidos()
        {
            // Arrange
            int idOrden = 1; // Suponiendo que existe una orden con ID 1
            int idMaquinaria = 1; // Suponiendo que existe una maquinaria con ID 1

            // Act
            bool resultado = controlSistema.InsertarEncabezado(idOrden, idMaquinaria);

            // Assert
            Assert.IsTrue(resultado, "La inserción del encabezado debería ser exitosa para datos válidos.");
        }

        [TestMethod]
        public void InsertarDetalle_DeberiaRetornarTrueParaDatosValidos()
        {
            // Arrange
            int idProducto = 1, idReceta = 1, idEmpleado = 1, idProceso = 1;
            int cantidad = 10;
            decimal costoU = 5.0m, costoT = 50.0m, duracionHoras = 2.5m, manoDeObra = 15.0m, costoLuz = 10.0m, costoAgua = 5.0m;

            // Act
            bool resultado = controlSistema.InsertarDetalle(idProducto, idReceta, idEmpleado, idProceso, cantidad, costoU, costoT, duracionHoras, manoDeObra, costoLuz, costoAgua);

            // Assert
            Assert.IsTrue(resultado, "La inserción del detalle debería ser exitosa para datos válidos.");
        }

        [TestMethod]
        public void ObtenerSiguienteIdProceso_DeberiaRetornarIdPositivo()
        {
            // Act
            int siguienteIdProceso = controlSistema.ObtenerSiguienteIdProceso();

            // Assert
            Assert.IsTrue(siguienteIdProceso > 0, "El siguiente ID de proceso debería ser positivo.");
        }

        [TestMethod]
        public void ObtenerSiguienteIdProcesoDetalle_DeberiaRetornarIdPositivo()
        {
            // Act
            int siguienteIdProcesoDetalle = controlSistema.ObtenerSiguienteIdProcesoDetalle();

            // Assert
            Assert.IsTrue(siguienteIdProcesoDetalle > 0, "El siguiente ID de proceso detalle debería ser positivo.");
        }
    }
}
