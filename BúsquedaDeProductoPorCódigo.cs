using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    // Clase para representar un producto
    internal class Producto
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    internal class BúsquedaDeProductoPorCódigo
    {
        // Ingresa datos de n productos y los almacena en una lista
        public static List<Producto> IngresarProductos(int n)
        {
            var productos = new List<Producto>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Producto {i + 1}:");
                Console.Write("Código: ");
                string codigo = Console.ReadLine() ?? "";
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Precio: ");
                decimal precio = decimal.TryParse(Console.ReadLine(), out var p) ? p : 0;
                Console.Write("Stock: ");
                int stock = int.TryParse(Console.ReadLine(), out var s) ? s : 0;

                productos.Add(new Producto
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Precio = precio,
                    Stock = stock
                });
            }
            return productos;
        }

        // Busca un producto por código y muestra sus datos
        public static void BuscarProductoPorCodigo(List<Producto> productos, string codigo)
        {
            var producto = productos.FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                Console.WriteLine("Producto encontrado:");
                Console.WriteLine($"Código: {producto.Codigo}");
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Precio: {producto.Precio}");
                Console.WriteLine($"Stock: {producto.Stock}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado");
            }
        }
    }
}
