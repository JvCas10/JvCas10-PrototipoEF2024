using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_RRHH
{
    public class Conexion_RRHH
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        public OdbcConnection Probar_Conexion() // Método estandarizado
        {
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria");
            //if (conn.State == ConnectionState.Closed)
            // {
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No conectó");
            }
            // }
            return conn;

        }
    }
}
