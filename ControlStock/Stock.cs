using System;

class ControlStock
{
    struct Producto
    {
        public int Id;
        public string Nombre;
        public int Cantidad;
        public decimal Precio;
    }

    static void Main()
    {
        Producto[] inventario = new Producto[100];
        int total = 0;
        int nextId = 1;

        while (true)
        {
            Console.WriteLine("=== Control de Stock ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Listar productos");
            Console.WriteLine("3. Ver producto por Id");
            Console.WriteLine("4. Eliminar producto por Id");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            int.TryParse(Console.ReadLine() ?? "0", out int opcion);

            if (opcion == 1)
            {
                if (total >= inventario.Length)
                {
                    Console.WriteLine("Inventario lleno.");
                    continue;
                }

                Console.Write("Nombre: ");
                string nombre = (Console.ReadLine() ?? "").Trim();
                Console.Write("Cantidad: ");
                int.TryParse(Console.ReadLine() ?? "0", out int cantidad);
                Console.Write("Precio: ");
                decimal.TryParse(Console.ReadLine() ?? "0", out decimal precio);

                inventario[total] = new Producto
                {
                    Id = nextId++,
                    Nombre = nombre,
                    Cantidad = cantidad,
                    Precio = precio,
                };
                total++;
                Console.WriteLine("Producto agregado.");
            }
            else if (opcion == 2)
            {
                if (total == 0)
                {
                    Console.WriteLine("Sin productos.");
                }
                else
                {
                    for (int i = 0; i < total; i++)
                    {
                        var p = inventario[i];
                        Console.WriteLine(
                            $"Id:{p.Id} Nombre:{p.Nombre} Cant:{p.Cantidad} Precio:{p.Precio:0.##}"
                        );
                    }
                }
            }
            else if (opcion == 3)
            {
                Console.Write("Id a ver: ");
                int.TryParse(Console.ReadLine() ?? "0", out int id);
                int idx = -1;
                for (int i = 0; i < total; i++)
                {
                    if (inventario[i].Id == id)
                    {
                        idx = i;
                        break;
                    }
                }
                if (idx == -1)
                {
                    Console.WriteLine("No encontrado.");
                }
                else
                {
                    var p = inventario[idx];
                    Console.WriteLine(
                        $"Id:{p.Id}\nNombre:{p.Nombre}\nCantidad:{p.Cantidad}\nPrecio:{p.Precio:0.##}"
                    );
                }
            }
            else if (opcion == 4)
            {
                Console.Write("Id a eliminar: ");
                int.TryParse(Console.ReadLine() ?? "0", out int idDel);
                int del = -1;
                for (int i = 0; i < total; i++)
                {
                    if (inventario[i].Id == idDel)
                    {
                        del = i;
                        break;
                    }
                }
                if (del == -1)
                {
                    Console.WriteLine("No encontrado.");
                }
                else
                {
                    for (int i = del; i < total - 1; i++)
                    {
                        inventario[i] = inventario[i + 1];
                    }
                    total--;
                    Console.WriteLine("Eliminado.");
                }
            }
            else if (opcion == 5)
            {
                return;
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }

            Console.WriteLine();
        }
    }
}
