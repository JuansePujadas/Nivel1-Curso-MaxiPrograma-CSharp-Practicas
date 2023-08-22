// Hacer un programa que solicite 20 números y luego emitir por pantalla 
// el máximo de los números pares y el mínimo de los números impares.

internal class Program
{
    private static void Main(string[] args)
    {
        int n, maxP=0, minI=0, cI=0;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Ingresa un número: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 != 0){
                if (cI == 0){
                    cI++;
                    minI = n;
                    }
                else if (n < minI){
                    minI = n;
                    }
                }
            else
                if(n > maxP){
                    maxP = n;
                    }
        }
        Console.WriteLine("El máximo Par es: " + maxP);
        Console.WriteLine("El mínimo Impar es: " + minI); 
    }
}