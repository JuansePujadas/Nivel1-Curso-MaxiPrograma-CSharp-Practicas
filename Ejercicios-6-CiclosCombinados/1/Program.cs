// Hacer un programa para ingresar 10 números. 
// El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

namespace _1;
class Program
{
    static void Main(string[] args)
    {
        int n, p = 0, cantP = 0;
        
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
            p = 0;
            for (int x = 1; x <= n; x++){
                if(n % x == 0)
                    p++;
            }
            if(p == 2)
                cantP++;
        }
        Console.WriteLine("De los 10 números " + cantP + " son PRIMOS.");
    }
}
