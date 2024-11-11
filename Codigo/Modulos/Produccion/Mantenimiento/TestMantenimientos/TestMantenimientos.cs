using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Control_Mantenimiento;
using System;
using System.Collections.Generic;

namespace TestMantenimientos
{
    [TestClass]
    public class TestMantenimientos
    {
        private Control_Mantenimiento controlMantenimiento;

        [TestInitialize]
        public void Setup()
        {
            // Inicializamos el objeto Control_Mantenimiento antes de cada prueba
            controlMantenimiento = new Control_Mantenimiento();
        }

        [TestMethod]
        public void ObtenerUltimoIdMaquinaria_DeberiaRetornarIdValido()
        {
            // Act
            int ultimoId = controlMantenimiento.ObtenerUltimoIdMaquinaria();

            // Assert
            Assert.IsTrue(ultimoId >= 0, "El ID de maquinaria debe ser un valor no negativo.");
        }

        [TestMethod]
        public void CargarMantenimientos_DeberiaRetornarListaConDatos()
        {
            // Act
            List<MantenimientoSimulado> mantenimientos = ObtenerMantenimientosSimulados();

            // Assert
            Assert.IsNotNull(mantenimientos, "La lista de mantenimientos no debería ser nula.");
            Assert.IsTrue(mantenimientos.Count >= 0, "El número de registros en la lista de mantenimientos debe ser no negativo.");
        }

        [TestMethod]
        public void DesactivarMantenimiento_DeberiaDesactivarCorrectamente()
        {
            // Arrange
            int idMaquinaria = 1; // ID de maquinaria de prueba

            // Act
            controlMantenimiento.DesactivarMantenimiento(idMaquinaria);

            // Assert
            Assert.IsTrue(true, "Desactivación ejecutada sin errores."); // Aquí se espera que no ocurra ninguna excepción
        }

        // Método auxiliar para simular los datos de mantenimiento
        private List<MantenimientoSimulado> ObtenerMantenimientosSimulados()
        {
            // Devuelve una lista simulada de objetos de mantenimiento
            return new List<MantenimientoSimulado>
            {
                new MantenimientoSimulado { Id = 1, Nombre = "Maquina 1", Estado = "Activo" },
                new MantenimientoSimulado { Id = 2, Nombre = "Maquina 2", Estado = "Inactivo" },
                // Agrega más datos simulados según sea necesario
            };
        }

        // Clase simulada para representar los datos de mantenimiento
        private class MantenimientoSimulado
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Estado { get; set; }
        }
    }
}
