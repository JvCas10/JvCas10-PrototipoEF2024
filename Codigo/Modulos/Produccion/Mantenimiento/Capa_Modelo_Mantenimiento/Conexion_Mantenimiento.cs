using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Mantenimiento // Espacio de nombres actualizado
{
    internal class Conexion_Mantenimiento // Clase con modificador 'internal' y nombre actualizado
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        internal OdbcConnection Probar_Conexion() // Método con modificador 'internal' y nombre estandarizado
        {
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria");
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
