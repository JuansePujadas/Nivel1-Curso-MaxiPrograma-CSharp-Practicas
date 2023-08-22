// Hacer un programa para ingresar un número y luego se emita por pantalla un 
// cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.

internal class Program
{
    private static void Main(string[] args)
    {
        int n;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        if (n > 10)
            Console.WriteLine("Es mayor a 10");
        else if(n == 10)
            Console.WriteLine("Es igual a 10");
        else
            Console.WriteLine("Es menor a 10");
    }
}