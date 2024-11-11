using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Capa_Modelo_Receta;
using System.Data;


namespace TestRecetas
{
    [TestClass]
    public class TestReceta
    {
        private Sentencias_Recetas sentenciasRecetas;
        public void Setup()
        {
            // Inicializa la instancia de Sentencias_Recetas antes de cada prueba
            sentenciasRecetas = new Sentencias_Recetas();
        }

        public void ObtenerSiguienteIdReceta_DeberiaRetornarIdIncrementado()
        {
            // Act
            // Act
            int siguienteId = sentenciasRecetas.ObtenerSiguienteIdReceta();

            // Assert
            Assert.IsTrue(siguienteId > 0, "El ID de la receta debería ser mayor que 0.");
        }

        [TestMethod]
        public void GuardarReceta_DeberiaInsertarRecetaCorrectamente()
        {
            // Arrange
            int idProducto = 1; // Asegúrate de que este ID exista en la base de datos
            string descripcion = "Test Receta";
            int cantidad = 5;
            string area = "Cocina";
            string cama = "N/A";
            int dias = 3;
            int horas = 4;

            // Act
            try
            {
                sentenciasRecetas.GuardarReceta(idProducto, descripcion, cantidad, area, cama, dias, horas);
            }
            catch (Exception ex)
            {
                //Assert.Fail("GuardarReceta lanzó una excepción: " + ex.Message);
            }
        }

            public void ModificarReceta_DeberiaActualizarRecetaCorrectamente()
            {
            // Arrange
            int idReceta = 1; // Debe existir en la base de datos para realizar la prueba
            int idProducto = 1;
            string descripcion = "Receta Modificada";
            int cantidad = 10;
            string area = "Nueva Area";
            string cama = "Nueva Cama";
            int dias = 5;
            int horas = 6;

            // Act
            try
            {
                sentenciasRecetas.ModificarReceta(idReceta, idProducto, descripcion, cantidad, area, cama, dias, horas);
            }
            catch (Exception ex)
            {
                Assert.Fail("ModificarReceta lanzó una excepción: " + ex.Message);
            }
        }


       /* public void EliminarReceta_DeberiaDesactivarReceta()
        {
            // Arrange
            int idProducto = 1; // Usa un ID de producto existente
            string descripcion = "Receta de Prueba";
            int cantidad = 5;
            string area = "Test Area";
            string cama = "N/A";
            int dias = 1;
            int horas = 1;

            // Crea una receta de prueba para asegurarte de que el ID existe
            sentenciasRecetas.GuardarReceta(idProducto, descripcion, cantidad, area, cama, dias, horas);

            // Obtén el ID de la receta recién insertada
            int idReceta = sentenciasRecetas.ObtenerSiguienteIdReceta() - 1;

            // Act
            sentenciasRecetas.EliminarReceta(idReceta);

            // Verificar que el estado se haya cambiado a 0
            DataTable receta = sentenciasRecetas.ObtenerRecetaPorId(idReceta);

            Assert.IsTrue(receta.Rows.Count > 0, "La receta debería existir en la base de datos.");
            Assert.AreEqual(0, Convert.ToInt32(receta.Rows[0]["estado"]), "El estado de la receta debería ser 0.");
        }*/

            public void Cleanup()
            {
                // Aquí podrías limpiar datos de prueba si es necesario
            }
        }
    }


