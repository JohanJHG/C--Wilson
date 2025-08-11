using System;

class Monedas
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bienvenido al Conversor de Monedas:");
        const double TasaDolar = 0.00024;
        const double TasaEuro = 0.00022;
        const double TasaYen = 0.00017;
        string continuar;
        do
        {
            Console.WriteLine("Ingrese la cantidad de Pesos COP que quiere convertir.");
            int monedas = int.Parse(Console.ReadLine());
            Console.WriteLine(
                "Seleccione la moneda a la que quiere convertir. (USD), (EUR), (YEN)"
            );
            string conversion = Console.ReadLine();
            switch (conversion)
            {
                case "USD":
                    double resultadoDolares = monedas * TasaDolar;
                    Console.WriteLine(
                        $"La cantidad de {monedas} Pesos COP es igual a {resultadoDolares} USD."
                    );
                    break;
                case "EUR":
                    double resultadoEuros = monedas * TasaEuro;
                    Console.WriteLine(
                        $"La cantidad de {monedas} Pesos COP es igual a {resultadoEuros} EUR."
                    );
                    break;
                case "YEN":
                    double resultadoYen = monedas * TasaYen;
                    Console.WriteLine(
                        $"La cantidad de {monedas} Pesos COP es igual a {resultadoYen} YEN"
                    );
                    break;
                default:
                    Console.WriteLine("Seleccione una moneda a convertir valida.");
                    break;
            }
            Console.WriteLine("¿Desea realizar otra conversión? (si/no)");
            continuar = Console.ReadLine()?.ToLower() ?? "no";
        } while (continuar == "si");
    }
}
