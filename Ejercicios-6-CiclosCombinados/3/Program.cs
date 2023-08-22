// Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
// El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

namespace _3;
class Program
{
    static void Main(string[] args)
    {
        int n = 0, cN;

        while (n >= 0){
            
            Console.WriteLine("Ingrese N°: ");
            n = int.Parse(Console.ReadLine());
            cN = 0;

            while (n != 0 && n > 0){
                cN++;
                Console.WriteLine("Ingrese N° ('0' para finalizar lista, 'negativo' para salir): ");
                n = int.Parse(Console.ReadLine());
            }           
            Console.WriteLine("La lista contiene " + cN + " números.");
        }
        Console.WriteLine("Fin del Programa.");
    }
}
