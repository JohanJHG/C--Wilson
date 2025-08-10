// Console.WriteLine("Ejemplos estructuras condicionales.");

// // if estructuras.

// sbyte EDAD_PARAMETRO = 18;
// Console.WriteLine("Ingrese su edad: ");
// sbyte edad = sbyte.Parse(Console.ReadLine());

// if (edad >= EDAD_PARAMETRO)
// {
//     Console.WriteLine("Usted es mayor de edad");
// }

// // if compuesto

// int SMLV = 1650000;
// Console.WriteLine("Ingrese su salario");
// int salario = int.Parse(Console.ReadLine());

// if (SMLV == salario)
// {
//     Console.WriteLine("Usted gana el minimo");
// }
// else
// {
//     Console.Write("Su salario es diferente al minimo \n");
// }

// // if anidado

// Random random = new Random();
// int diasAntesExpiracion = random.Next(12);
// int porcentajeDescuento = 0;

// if (diasAntesExpiracion == 0)
// {
//     Console.WriteLine("Tu suscripcion ya expiro.");
// }
// else if (diasAntesExpiracion == 1)
// {
//     Console.WriteLine("Tu suscripcio expira en 1 dia.");
//     porcentajeDescuento = 20;
// }
// else if (diasAntesExpiracion <= 5)
// {
//     Console.WriteLine($" Tu suscricion expira en {diasAntesExpiracion} dias.");
//     porcentajeDescuento = 10;
// }
// else if (diasAntesExpiracion <= 10)
// {
//     Console.WriteLine("Tu suscripcion expira pronto, Renueva ahora.");
// }

// if (porcentajeDescuento > 0)
// {
//     Console.WriteLine($"Renueva ahora, y recibe un descuento de {porcentajeDescuento}%.");
// }

// // if con operadores lógicos - Validaciones con si/no


/*

Console.WriteLine("¿Es soltero? (si/no): ");
bool esSoltero = (Console.ReadLine()?.ToLower() ?? "") == "si";

Console.WriteLine("¿Es responsable? (si/no): ");
bool esResponsable = (Console.ReadLine()?.ToLower() ?? "") == "si";

Console.WriteLine("¿Es mayor de edad? (si/no): ");
bool esMayorEdad = (Console.ReadLine()?.ToLower() ?? "") == "si";

Console.WriteLine("¿Tiene hijos? (si/no): ");
bool tieneHijos = (Console.ReadLine()?.ToLower() ?? "") == "si";

// Validación usando operadores lógicos
if (esSoltero && esResponsable && esMayorEdad && !tieneHijos)
{
    Console.WriteLine("Hombre ideal");
}
else if (!esSoltero)
{
    Console.WriteLine("Hombre no ideal. Porque no es soltero");
}
else if (!esMayorEdad)
{
    Console.WriteLine("Hombre no ideal. Porque es menor de edad");
}
else if (!esResponsable)
{
    Console.WriteLine("Hombre no ideal. Porque es irresponsable");
}
else if (tieneHijos)
{
    Console.WriteLine("Hombre no ideal. Porque tiene hijos");
}


Console.WriteLine("Tipo de producto: ");

string tipoProducto = Console.ReadLine().ToLower();
string PARAMETRO_CELULAR = "celular";
string PARAMETRO_TELEVISOR = "televisor";
string PARAMETRO_COMPUTADOR = "computador";

if (tipoProducto == PARAMETRO_CELULAR)
{
    int precio = 600000;
    Console.WriteLine("Producto: Celular");
    Console.WriteLine($"Precio: {precio} COP");
}
else if (tipoProducto == PARAMETRO_TELEVISOR)
{
    int precio = 1200000;
    Console.WriteLine("Producto: Televisor");
    Console.WriteLine($"Precio: {precio} COP");
}
else if (tipoProducto == PARAMETRO_COMPUTADOR)
{
    int precio = 2000000;
    Console.WriteLine("Producto: Computador");
    Console.WriteLine($"Precio: {precio} COP");
}
else
{
    Console.WriteLine("Producto no reconocido");
}
 */

/* 
    Crear un menu con las siguientes opciones:
    1. Mostrar la fecha actual.
    2. Mostrar su nombre.
    3. Mostrara un mensaje motivador.
    4. Salir del programa.

*/

using System.Globalization;

Console.Clear();
Console.WriteLine("Selecciona una opcion:");
Console.WriteLine("Mostrar la fecha actual:");
Console.WriteLine("Mostrar su nombre:");
Console.WriteLine("Mostrar un mensaje motivador:");
Console.WriteLine("Salir del programa:");

sbyte opcion = sbyte.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine($"Fecha actual: {DateTime.Now}");
        break;
    case 2:
        Console.WriteLine("Tu nombre es: Johan");
        break;
    case 3:
        Console.WriteLine("¡Sigue adelante, cada día es una nueva oportunidad!");
        break;
    case 4:
        Console.WriteLine("Saliendo del programa...");
        break;
    default:
        Console.WriteLine("Opción no válida. Por favor, selecciona una opción del menú.");
        break;
}

// determinar en una aplicacion de consola, donde se definan 4 a 5 rangos con respecto a valgo de rodillas
// y se imprima un mensaje dependiendo del rango en el que se encuentre el valor ingresado por el usuario.

Console.WriteLine("Ingrese el valor de sus rodillas:");
int valorRodillas = int.Parse(Console.ReadLine());
if (valorRodillas < 0)
{
    Console.WriteLine("Valor de rodillas no puede ser negativo.");
}
else if (valorRodillas >= 0 && valorRodillas < 20)
{
    Console.WriteLine("Rango 1: Rodillas en buen estado.");
}
else if (valorRodillas >= 20 && valorRodillas < 40)
{
    Console.WriteLine("Rango 2: Rodillas con ligera inflamación.");
}
else if (valorRodillas >= 40 && valorRodillas < 60)
{
    Console.WriteLine("Rango 3: Rodillas con inflamación moderada.");
}
else
{
    Console.WriteLine("Rango 4: Rodillas con inflamación severa.");
}

