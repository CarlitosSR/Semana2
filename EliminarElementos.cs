using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class EliminarElementos
    {
        // Función recursiva para eliminar todos los elementos de una lista
        public static void EliminarTodosRecursivo<T>(List<T> lista)
        {
            if (lista == null || lista.Count == 0)
                return;

            // Elimina el último elemento
            lista.RemoveAt(lista.Count - 1);

            // Llamada recursiva
            EliminarTodosRecursivo(lista);
        }
    }
}
