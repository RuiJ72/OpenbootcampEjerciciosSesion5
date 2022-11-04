Console.WriteLine("\n------------Lenguajes de Programación--------------------------------");
Console.WriteLine("\n---Qual es tu lenguaje de programación favorito.Introduce el número: ");
Console.WriteLine("-------------------------1-Javascript----------------------------------");
Console.WriteLine("-------------------------2-C# .NET-------------------------------------");
Console.WriteLine("-------------------------3-Python--------------------------------------");
Console.WriteLine("-------------------------4-Java----------------------------------------");
Console.WriteLine("-------------------------5-TypeScript----------------------------------");
Console.WriteLine("-------------------------6-Pascal--------------------------------------");
Console.WriteLine("-------------------------7-Kotlin--------------------------------------");
Console.WriteLine("-------------------------8-Otra----------------------------------------");

int escojer = Convert.ToInt32(Console.ReadLine());


switch (escojer)
{
    case 1:

        Console.WriteLine("Has elegido el lenguaje de programación: Javascript");
        break;
    case 2:
        Console.WriteLine("Has elegido el lenguaje de programación: C# .NET");
        break;
    case 3:
        Console.WriteLine("Has elegido el lenguaje de programación: Python");
        break;
    case 4:
        Console.WriteLine("Has elegido el lenguaje de programación: Java");
        break;
    case 5:
        Console.WriteLine("Has elegido el lenguaje de programación: TypeScript");
        break;
    case 6:
        Console.WriteLine("Has elegido el lenguaje de programación: Pascal");
        break;
    case 7:
        Console.WriteLine("Has elegido el lenguaje de programación: Kotlin");
        break;
    case 8:
    default:
        Console.WriteLine("Tu elección se basa en un lenguaje de programación que no está en la lista");
        break;
}
