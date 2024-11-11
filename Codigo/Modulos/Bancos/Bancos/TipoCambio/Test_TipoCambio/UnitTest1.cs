using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using Capa_Controlador_Cambio;

namespace Test_TipoCambio
{
    [TestClass]
    public class Test_TipoCambio
    {
        [TestMethod]
        public void ObtenerTipoCambio_CuandoSeLlama_RetornaDataTable()
        {
            // Arrange
            var controlador = new Controlador();
            var dataTableEsperado = new DataTable();
            dataTableEsperado.Columns.Add("pk_id_tipoCambio", typeof(int));
            dataTableEsperado.Columns.Add("tipoCambio_nombre_moneda", typeof(string));
            dataTableEsperado.Columns.Add("tipoCambio_valor_moneda", typeof(decimal));
            dataTableEsperado.Columns.Add("tipoCambio_valorCambio_moneda", typeof(decimal));
            dataTableEsperado.Columns.Add("tipoCambio_estatus", typeof(int));

            // Agrega solo los primeros tres registros para la comparación
            dataTableEsperado.Rows.Add(1, "USD - Dólar Estadounidense", 7.820, 1);
            dataTableEsperado.Rows.Add(2, "EUR - Euro", 8.950, 9.100, 1);
            dataTableEsperado.Rows.Add(3, "JPY - Yen Japonés", 0.065, 0.068, 1);

            // Act
            var resultado = controlador.ObtenerTipoCambio();

            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado.Rows.Count >= 3, "El resultado debe tener al menos 3 filas para realizar la comparación.");

            // Compara solo las primeras 3 filas
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(dataTableEsperado.Rows[i]["pk_id_tipoCambio"], resultado.Rows[i]["pk_id_tipoCambio"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["tipoCambio_nombre_moneda"], resultado.Rows[i]["tipoCambio_nombre_moneda"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["tipoCambio_valor_moneda"], resultado.Rows[i]["tipoCambio_valor_moneda"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["tipoCambio_valorCambio_moneda"], resultado.Rows[i]["tipoCambio_valorCambio_moneda"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["tipoCambio_estatus"], resultado.Rows[i]["tipoCambio_estatus"]);
            }
        }
    }
}
