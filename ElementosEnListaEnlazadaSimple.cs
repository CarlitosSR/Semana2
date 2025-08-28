using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class ElementosEnListaEnlazadaSimple
    {
        // Cuenta cuántas veces aparece un elemento en una lista enlazada simple
        public static int ContarOcurrencias<T>(LinkedList<T> lista, T elemento)
        {
            int contador = 0;
            foreach (var item in lista)
            {
                if (EqualityComparer<T>.Default.Equals(item, elemento))
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
