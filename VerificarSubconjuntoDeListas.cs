using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    internal class VerificarSubconjuntoDeListas
    {
        // Verifica si todos los elementos de B están contenidos en A
        public static bool EstaContenida<T>(IEnumerable<T> A, IEnumerable<T> B)
        {
            var conjuntoA = new HashSet<T>(A);
            foreach (var elemento in B)
            {
                if (!conjuntoA.Contains(elemento))
                    return false;
            }
            return true;
        }
    }
}
