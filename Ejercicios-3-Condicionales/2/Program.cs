// Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número 
// es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

internal partial class Program
{
    private static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        if (n == 0)
            Console.WriteLine("Cero");
        else if (n > 0)
            Console.WriteLine("Positivo");
        else
            Console.WriteLine("Negativo");
    }
}