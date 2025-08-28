using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class CribadeEratóstenes
    {
        // Genera una lista enlazada con números consecutivos desde 2 hasta n
        public static LinkedList<int> GenerarLista(int n)
        {
            var lista = new LinkedList<int>();
            for (int i = 2; i <= n; i++)
            {
                lista.AddLast(i);
            }
            return lista;
        }

        // Aplica la criba de Eratóstenes sobre la lista enlazada
        public static void CribaEratóstenes(LinkedList<int> lista)
        {
            var nodo = lista.First;
            while (nodo != null)
            {
                int primo = nodo.Value;
                var siguiente = nodo.Next;
                while (siguiente != null)
                {
                    var temp = siguiente.Next;
                    if (siguiente.Value % primo == 0)
                    {
                        lista.Remove(siguiente);
                    }
                    siguiente = temp;
                }
                nodo = nodo.Next;
            }
        }

        // Muestra los números primos de la lista
        public static void MostrarPrimos(LinkedList<int> lista)
        {
            foreach (var num in lista)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
