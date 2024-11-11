using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Cierre_Produccion // Nuevo espacio de nombres
{
    public class Conexion_Cierre_Produccion // Clase con modificador 'public' y nombre actualizado
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        public OdbcConnection Probar_Conexion() // Método estandarizado
        {
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria"); // Cadena de conexión
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No conectó");
            }
            return conn;
        }
    }
}
