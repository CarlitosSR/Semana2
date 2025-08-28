using System;
using System.Collections.Generic;

namespace Semana2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Eliminar todos los elementos de una lista");
                Console.WriteLine("2. Mostrar números primos con la criba de Eratóstenes");
                Console.WriteLine("3. Dividir lista en positivos y negativos");
                Console.WriteLine("4. Contar ocurrencias de un elemento en una lista enlazada");
                Console.WriteLine("5. Calcular la moda de los elementos de una lista");
                Console.WriteLine("6. Intersección de dos listas enlazadas");
                Console.WriteLine("7. Diferencia de dos listas enlazadas");
                Console.WriteLine("8. Búsqueda de producto por código");
                Console.WriteLine("9. Verificar si una lista es subconjunto de otra");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                string opcion = Console.ReadLine();

                Console.Clear(); // Oculta el menú antes de mostrar el resultado

                switch (opcion)
                {
                    case "1":
                        var lista = new List<int> { 1, 2, 3, 4, 5 };
                        Console.WriteLine("Lista original: " + string.Join(", ", lista));
                        EliminarElementos.EliminarTodosRecursivo(lista);
                        Console.WriteLine("Lista después de eliminar: " + string.Join(", ", lista));
                        break;
                    case "2":
                        Console.Write("Ingrese el valor máximo n: ");
                        if (int.TryParse(Console.ReadLine(), out int n) && n >= 2)
                        {
                            var listaPrimos = CribadeEratóstenes.GenerarLista(n);
                            CribadeEratóstenes.CribaEratóstenes(listaPrimos);
                            Console.WriteLine("Números primos hasta " + n + ":");
                            CribadeEratóstenes.MostrarPrimos(listaPrimos);
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                        }
                        break;
                    case "3":
                        var listaSignos = new List<int> { -5, 3, -2, 7, 0, -1, 4 };
                        ListaPorSigno.DividirPorSigno(listaSignos, out var positivos, out var negativos);
                        Console.WriteLine("Positivos: " + string.Join(", ", positivos));
                        Console.WriteLine("Negativos: " + string.Join(", ", negativos));
                        break;
                    case "4":
                        var listaEnlazada = new LinkedList<int>(new[] { 1, 2, 3, 2, 4, 2, 5 });
                        Console.Write("Elemento a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int elemento))
                        {
                            int ocurrencias = ElementosEnListaEnlazadaSimple.ContarOcurrencias(listaEnlazada, elemento);
                            Console.WriteLine($"El elemento {elemento} aparece {ocurrencias} veces.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        break;
                    case "5":
                        var listaModa = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
                        var moda = ModaDeLosElementos.CalcularModa(listaModa);
                        Console.WriteLine("La moda es: " + moda);
                        break;
                    case "6":
                        var l1 = new LinkedList<int>(new[] { 1, 2, 3, 4 });
                        var l2 = new LinkedList<int>(new[] { 3, 4, 5, 6 });
                        var interseccion = Intersección_de_Listas_Enlazadas.Interseccion(l1, l2);
                        Console.WriteLine("Intersección: " + string.Join(", ", interseccion));
                        break;
                    case "7":
                        var ld1 = new LinkedList<int>(new[] { 1, 2, 3, 4 });
                        var ld2 = new LinkedList<int>(new[] { 3, 4, 5, 6 });
                        var diferencia = DiferenciaDeListasEnlazadas.Diferencia(ld1, ld2);
                        Console.WriteLine("Diferencia: " + string.Join(", ", diferencia));
                        break;
                    case "8":
                        Console.Write("¿Cuántos productos desea ingresar?: ");
                        if (int.TryParse(Console.ReadLine(), out int cantidad) && cantidad > 0)
                        {
                            var productos = BúsquedaDeProductoPorCódigo.IngresarProductos(cantidad);
                            Console.Write("Ingrese el código a buscar: ");
                            string codBuscar = Console.ReadLine() ?? "";
                            BúsquedaDeProductoPorCódigo.BuscarProductoPorCodigo(productos, codBuscar);
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida.");
                        }
                        break;
                    case "9":
                        var listaA = new List<int> { 1, 2, 3, 4, 5 };
                        var listaB = new List<int> { 2, 3, 5 };
                        bool esSubconjunto = VerificarSubconjuntoDeListas.EstaContenida(listaA, listaB);
                        Console.WriteLine(esSubconjunto
                            ? "B está contenida en A."
                            : "B no está contenida en A.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine("\nPresione una tecla para volver al menú...");
                Console.ReadKey();
            }
        }
    }
}
