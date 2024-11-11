using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo_Produccion; // Espacio de nombres estandarizado con mayúscula por palabra
using System.Data;

namespace Capa_Controlador_Produccion // Espacio de nombres estandarizado con mayúscula por palabra
{
    public class Control_Receta // Clase con el nombre Control_Receta
    {
        private readonly Sentencia_Produccion sentencias; // Variable con nombre estandarizado

        public Control_Receta()
        {
            sentencias = new Sentencia_Produccion(); // Inicialización de la clase del modelo
        }

        // Método para obtener todas las recetas (comentado hasta que se implemente)
        /*public DataTable Mostrar_Recetas()
        {
            //return sentencias.Mostrar_Recetas();
        }*/
    }
}
