using System;

class EncuestaCurso
{
    static void Main(string[] args)
    {
        string nombre = "";
        int califContenido = 0;
        int califInstructor = 0;
        int califPlataforma = 0;
        bool encuestaRespondida = false;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(" --- Encuesta Curso de C# - SENA --- ");
            Console.WriteLine("1. Responder Encuesta");
            Console.WriteLine("2. Ver Resultados");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");

            sbyte opcion = sbyte.Parse(Console.ReadLine() ?? "0");

            switch (opcion)
            {
                case 1:
                    if (encuestaRespondida)
                    {
                        Console.WriteLine("La encuesta ya fue respondida.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Write("Ingrese su nombre: ");
                        nombre = Console.ReadLine() ?? "";

                        Console.Write("Califique el contenido del curso (1-5): ");
                        califContenido = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Califique al instructor (1-5): ");
                        califInstructor = int.Parse(Console.ReadLine() ?? "0");

                        Console.Write("Califique la plataforma utilizada (1-5): ");
                        califPlataforma = int.Parse(Console.ReadLine() ?? "0");

                        encuestaRespondida = true;
                        Console.WriteLine("Encuesta registrada correctamente.");
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine("\n--- Resultados de la Encuesta ---");
                    if (!encuestaRespondida)
                    {
                        Console.WriteLine("No hay respuestas registradas.");
                    }
                    else
                    {
                        Console.WriteLine($"Nombre: {nombre}");
                        Console.WriteLine($"Contenido: {califContenido}");
                        Console.WriteLine($"Instructor: {califInstructor}");
                        Console.WriteLine($"Plataforma: {califPlataforma}");
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
        }
    }
}
