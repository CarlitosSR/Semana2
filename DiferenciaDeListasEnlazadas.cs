using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class DiferenciaDeListasEnlazadas
    {
        // Devuelve la diferencia de dos listas enlazadas: elementos de lista1 que no están en lista2
        public static LinkedList<T> Diferencia<T>(LinkedList<T> lista1, LinkedList<T> lista2)
        {
            var resultado = new LinkedList<T>();
            var conjunto = new HashSet<T>(lista2);

            foreach (var item in lista1)
            {
                if (!conjunto.Contains(item))
                {
                    resultado.AddLast(item);
                }
            }
            return resultado;
        }
    }
}
