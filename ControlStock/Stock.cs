using System;

class ControlStock
{
    static void Main(String[] args)
    {
        string[] productos = new string[10];
        int totalProductos = 0;
        int[] cantidades = new int[10];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" --- Control de Stock --- ");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Listar Productos");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            sbyte opcion = sbyte.Parse(Console.ReadLine() ?? "0");



            switch (opcion)
            {
                case 1:
                    if (totalProductos < productos.Length)
                    {
                        Console.Write("Ingrese el nombre del producto: ");
                        string nombreProducto = Console.ReadLine() ?? "";
                        Console.Write("Ingrese la cantidad del producto: ");
                        int cantidadProductos = int.Parse(Console.ReadLine() ?? "0");
                        productos[totalProductos] = nombreProducto;
                        cantidades[totalProductos] = cantidadProductos;
                        totalProductos++;
                        Console.WriteLine("Producto agregado correctamente.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("No se pueden agregar más productos (máximo 10).");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Lista de Productos ---");
                    if (totalProductos == 0)
                    {
                        Console.WriteLine("No hay productos registrados.");
                    }
                    else
                    {
                        for (int i = 0; i < totalProductos; i++)
                        {
                            Console.Write($"{i + 1}. {productos[i]} \t Cantidad: {cantidades[i]} \n");
                        }
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    return;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
        }
    }
}
