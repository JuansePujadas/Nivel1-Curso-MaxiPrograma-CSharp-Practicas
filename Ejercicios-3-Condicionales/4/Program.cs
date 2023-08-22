// Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

using System;

class Program
{
    static void Main(string[] args)
    {
        
        int n, min;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        min = n;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        if(n<min)
            min = n;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        if(n<min)
            min = n;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());
        if(n<min)
            min = n;

        Console.WriteLine("El menor número ingresado fue: " + min);

    }
}