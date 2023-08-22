// Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
// Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

namespace _1;
class Program
{
    static void Main(string[] args)
    {
        int[] vNum = new int[10];
        int vMax = 0, p = 0;

        for (int i = 0; i < 10; i++){
            Console.WriteLine("Ingrese N°: ");
            vNum[i] = int.Parse(Console.ReadLine());
        }
        
        for (int i = 0; i < 10; i++){
            if (vNum[i] > vMax){
                vMax = vNum[i];
                p = i + 1;
            }            
        }

        Console.WriteLine("El valor máximo es " + vMax);
        Console.WriteLine("Y se encuentras en la posición: " + p);
    }
}
