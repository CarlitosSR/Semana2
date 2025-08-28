using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class Intersección_de_Listas_Enlazadas
    {
        // Devuelve la intersección de dos listas enlazadas
        public static LinkedList<T> Interseccion<T>(LinkedList<T> lista1, LinkedList<T> lista2)
        {
            var resultado = new LinkedList<T>();
            var conjunto = new HashSet<T>(lista2);

            foreach (var item in lista1)
            {
                if (conjunto.Contains(item) && !resultado.Contains(item))
                {
                    resultado.AddLast(item);
                }
            }
            return resultado;
        }
    }
}
