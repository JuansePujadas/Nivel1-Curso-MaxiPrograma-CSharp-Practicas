// Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es. 
// Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

namespace _2;
class Program
{
    static void Main(string[] args)
    {
        int n, v, cont=0;

        for (int i = 0; i < 5; i++){

            Console.WriteLine("Ingrese un N°: ");
            n = int.Parse(Console.ReadLine());
            v = par(n);
            if (v == 1){
                cont ++;
            }
        }

        Console.WriteLine("Hay "+ cont + " números pares.");
    }

    static int par(int n){
        int v;
        if (n % 2 == 0){
            v = 1;
        }else{
            v = 0;
        }
        return v;
    }
}
