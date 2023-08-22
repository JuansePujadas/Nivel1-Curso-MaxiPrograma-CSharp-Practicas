// Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

internal partial class Program
{
    private static void Main(string[] args)
    {
        int e, c = 0, a = 0, p = 0;

        for (int i = 0; i < 20; i++)
        {

            Console.WriteLine("Ingrese edad: ");
            e = int.Parse(Console.ReadLine());

            if (e >= 18)
            {
                c++;
                a += e;
            }
        }

        p = a / c;

        Console.WriteLine("El promedio de edad de mayores a 18 años es de " + p);
    }
}