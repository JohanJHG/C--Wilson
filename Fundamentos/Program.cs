using System;

namespace Fundamentos
{
    class Fundamentos
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de datos");
            Console.WriteLine("int: " + 10);
            Console.WriteLine("decimal: " + 10.5);
            Console.WriteLine("string: " + "Hola");
            Console.WriteLine("bool: " + true);
            Console.WriteLine("DateTime: " + DateTime.Now);
            Console.WriteLine("TimeSpan: " + DateTime.Now.TimeOfDay);
            Console.WriteLine("Minuto: " + DateTime.Now.Minute);
            Console.WriteLine("Segundo: " + DateTime.Now.Second);
            Console.WriteLine("Caracter: " + 'A');

            // Arrays, Listas y Diccionarios
            int[] numeros = { 1, 2, 3, 4, 5 };
            List<string> nombres = new List<string> { "Juan", "Maria", "Pedro" };
            Dictionary<string, int> edades = new Dictionary<string, int>
            {
                { "Juan", 30 },
                { "Maria", 25 },
                { "Pedro", 40 }
            };
        }
    }
}