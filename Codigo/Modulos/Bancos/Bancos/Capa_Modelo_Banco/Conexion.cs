using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Modelo_Banco
{
    public class Conexion
    {
        public OdbcConnection connection()
        {
            //Se requiere colocar el nombre del DSN
            //Escoger un DSN para todos, hablar en clase
            OdbcConnection conn = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conn.Open();
            }
            catch (OdbcException e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }


    }
}
