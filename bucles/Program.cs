using System;

class Ciclos
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Ejemplo de bucle while
        int contador = 0;
        while (contador < 5)
        {
            Console.WriteLine($"Contador: {contador}");
            contador++;
        }

        // Ejemplo de bucle for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteración: {i}");
        }

        // Ejemplo de bucle do-while
        int numero;
        do
        {
            Console.WriteLine("Ingrese un número (0 para salir): ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Usted ingresó: {numero}");
        } while (numero != 0);
    }
}
