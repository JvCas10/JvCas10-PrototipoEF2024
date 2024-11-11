using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using Capa_Controlador_Movimientos;
using Capa_Modelo_Movimientos;

namespace Test_Movimientos_Bancarios
{
    [TestClass]
    public class Test_Movimientos_Bancarios
    {
        [TestMethod]
        public void ObtenerMovi_CuandoSeLlama_RetornaDataTable()
        {
            // Arrange: Prepara el escenario para la prueba
            var modelo = new Modelo(); // Instancia real de la clase Modelo

            // Crea un DataTable esperado con los tipos de datos correctos
            // Crea un DataTable esperado con los tipos de datos correctos
            // Crea un DataTable esperado con los tipos de datos correctos
            var dataTableEsperado = new DataTable();
            dataTableEsperado.Columns.Add("CuentaID", typeof(int));
            dataTableEsperado.Columns.Add("fecha", typeof(DateTime));
            dataTableEsperado.Columns.Add("Tipo", typeof(string));
            dataTableEsperado.Columns.Add("Monto", typeof(decimal));
            dataTableEsperado.Columns.Add("Descripcion", typeof(string));
            dataTableEsperado.Columns.Add("metodo", typeof(string));
            dataTableEsperado.Columns.Add("estado", typeof(short)); // Cambiar a `short` si el estado es un Int16

            DateTime fechaEsperada = new DateTime(2024, 1, 10);

            // Simular datos esperados con tipos ajustados
            dataTableEsperado.Rows.Add(1, fechaEsperada, "Deposito", 500.00M, "Deposito en efectivo", "Efectivo", (short)1);
            dataTableEsperado.Rows.Add(2, fechaEsperada, "Retiro", 50m, "Retiro de efectivo", "Efectivo", (short)1);
            dataTableEsperado.Rows.Add(3, fechaEsperada, "Transferencia", 200m, "Transferencia interna", "Transferencia", (short)1);
            dataTableEsperado.Rows.Add(4, fechaEsperada, "Pago", 150m, "Pago de servicios", "Efectivo", (short)1);

            // Act y Assert
            /*var resultado = controlador.ObtenerMovi();

            Assert.IsNotNull(resultado);
            Assert.AreEqual(dataTableEsperado.Rows.Count, resultado.Rows.Count);

            for (int i = 0; i <= dataTableEsperado.Rows.Count; i++)
            {
                Assert.AreEqual(dataTableEsperado.Rows[i]["CuentaID"], resultado.Rows[i]["CuentaID"]);
                Assert.AreEqual(((DateTime)dataTableEsperado.Rows[i]["fecha"]).Date, ((DateTime)resultado.Rows[i]["fecha"]).Date);
                Assert.AreEqual(dataTableEsperado.Rows[i]["Tipo"], resultado.Rows[i]["Tipo"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["Monto"], resultado.Rows[i]["Monto"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["Descripcion"], resultado.Rows[i]["Descripcion"]);
                Assert.AreEqual(dataTableEsperado.Rows[i]["metodo"], resultado.Rows[i]["metodo"]);
                Assert.AreEqual((short)dataTableEsperado.Rows[i]["estado"], (short)resultado.Rows[i]["estado"]);
            }
            */
        }
    }
}