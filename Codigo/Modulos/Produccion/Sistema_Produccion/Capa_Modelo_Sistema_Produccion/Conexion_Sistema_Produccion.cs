using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace Capa_Modelo_Sistema_Produccion // Espacio de nombres actualizado
{
    public class Conexion_Sistema_Produccion // Clase estandarizada como 'public'
    {
        // Método que prueba la conexión a la base de datos utilizando una DSN específica.
        public OdbcConnection ProbarConexion() // Método sin guion bajo en el nombre para seguir la convención
        {
            OdbcConnection conn = new OdbcConnection("dsn=colchoneria"); // Conexión con la DSN especificada
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo conectar a la base de datos."); // Mensaje de error más descriptivo
            }
            return conn;
        }
    }
}
