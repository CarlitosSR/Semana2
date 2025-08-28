using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class ModaDeLosElementos
    {
        // Devuelve la moda de los elementos de una lista
        public static T? CalcularModa<T>(List<T> lista)
        {
            if (lista == null || lista.Count == 0)
                return default;

            var frecuencias = new Dictionary<T, int>();
            foreach (var item in lista)
            {
                if (frecuencias.ContainsKey(item))
                    frecuencias[item]++;
                else
                    frecuencias[item] = 1;
            }

            int maxFrecuencia = frecuencias.Values.Max();
            // Si hay varias modas, devuelve la primera encontrada
            foreach (var par in frecuencias)
            {
                if (par.Value == maxFrecuencia)
                    return par.Key;
            }

            return default;
        }
    }
}
