/*
    Crear un cajero con 3 opciones:
    1. Consultar saldo.
    2. retirar dinero.
    3. Salir del cajero.
    el saldo inicial es de 500000, si se elige retirar, debe solicitar el monto a retirar y verificar que haya suficiente saldo.
    Desontar el retiro del saldo, mostrar el saldo actualizado
    Mostrar un mensaje de despedida, realizar correctamente las validaaciones de errores y mostrar mensajes adecuados al usuario.
*/

class Cajero
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecciona una opcion:");
        Console.WriteLine("1. Consultar saldo.");
        Console.WriteLine("2. Retirar dinero. ");
        Console.WriteLine("3. Salir del cajero. ");

        const int saldoInicial = 500000;
        int saldoActual = saldoInicial;

        while (true)
        {
            Console.Write("Selecciona una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"Tu saldo actual es: {saldoActual}");
                    break;
                case 2:
                    Console.Write("Ingresa el monto a retirar: ");
                    int montoRetiro = int.Parse(Console.ReadLine());

                    if (montoRetiro > saldoActual)
                    {
                        Console.WriteLine("No hay suficiente saldo.");
                    }
                    else
                    {
                        saldoActual -= montoRetiro;
                        Console.WriteLine($"Retiraste: {montoRetiro}");
                        Console.WriteLine($"Saldo actualizado: {saldoActual}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Gracias por usar el cajero.");
                    return;
                default:
                    Console.WriteLine("Selecciona un numero. (1, 2 o 3)");
                    break;
            }
        }
    }
}
