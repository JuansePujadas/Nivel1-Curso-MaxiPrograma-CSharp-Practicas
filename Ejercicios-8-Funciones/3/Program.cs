// Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
// Hacer un programa para ingresar números. 
// El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.

namespace _3;
class Program
{
    static void Main(string[] args)
    {
        int n, p, contP=0, acumP=0;

        Console.WriteLine("Ingrese un N°: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0){
            p = primo(n);
            if (p == 1){
                contP++;
                acumP += n;
            }
            Console.WriteLine("Ingrese un N°: ");
            n = int.Parse(Console.ReadLine());
        }

        p = acumP / contP;

        Console.WriteLine("El promedio dentro de los N° primos es de " + p);

    }

    static int primo(int n){
        int cont=0;
        int p=0;
        for (int i = 1; i <= n; i++){
            if (n % i == 0){
                cont++;
            }
        }
        if (cont == 2){
            p=1;
        }
        return p;
    }
}
