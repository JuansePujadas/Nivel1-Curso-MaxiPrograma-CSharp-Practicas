// Hacer un programa que solicite el ingreso de 10 números y que muestre el 
// mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.



internal partial class Program
{
    private static void Main(string[] args)
    {
        int n, m = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            if (n > m)
                m = n;
        }

        Console.WriteLine("El mayor es: " + m);
    }
}