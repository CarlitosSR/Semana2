using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class ListaPorSigno
    {
        // Divide una lista en dos: positivos y negativos
        public static void DividirPorSigno(List<int> numeros, out List<int> positivos, out List<int> negativos)
        {
            positivos = new List<int>();
            negativos = new List<int>();

            foreach (var num in numeros)
            {
                if (num > 0)
                    positivos.Add(num);
                else if (num < 0)
                    negativos.Add(num);
            }
        }
    }
}
