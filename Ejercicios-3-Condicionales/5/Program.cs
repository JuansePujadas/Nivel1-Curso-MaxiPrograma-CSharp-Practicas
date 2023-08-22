// Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

using System;

class Program
{
    static void Main(string[] args)
    {

        int n1,n2,n3,n4;

        Console.WriteLine("Ingrese un número: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese un número: ");
        n4 = int.Parse(Console.ReadLine());

        Console.WriteLine("Los siguientes números son mayores a 100:");

        if(n1>100)
            Console.WriteLine(n1);
        if(n2>100)
            Console.WriteLine(n2);
        if(n3>100)
            Console.WriteLine(n3);
        if(n4>100)
            Console.WriteLine(n4);

    }
}