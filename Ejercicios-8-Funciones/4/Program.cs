// Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
// que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida 
// por referencia con:

// a. 1 si el número es positivo.
// b. -1 si el número es negativo.
// c. 0 si el número es cero.

namespace _4;
class Program
{
    static void Main(string[] args)
    {
        int n, x=5646545;

        Console.WriteLine("Ingrese un N°: ");
        n = int.Parse(Console.ReadLine());

        positivoNegativoCero(n, ref x);

        if (x == 0){
            Console.WriteLine("Cero");
        }else if (x == 1){
            Console.WriteLine("Positivo");
        }else{
            Console.WriteLine("Negativo");
        }
    }

    static void positivoNegativoCero(int n, ref int x){
        if (n == 0){
            x = 0;
        }else if (n > 0){
            x = 1;
        }else{
            x = -1;
        }
    }
}
