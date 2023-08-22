// Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
// Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

namespace _2;
class Program
{
    static void Main(string[] args)
    {
        int[] vNum = new int[10];
        int promedio = 0, acumulador = 0;

        for (int i = 0; i < 10; i++){
            Console.WriteLine("Ingrese N°: ");
            vNum[i] = int.Parse(Console.ReadLine());
        }

        for (int x = 0; x < 10; x++){
            acumulador += vNum[x];
        }

        promedio = acumulador / 10;

        Console.WriteLine("Los siguiente valores son mayores al promedio: ");

        for (int y = 0; y < 10; y++){
            if (vNum[y] > promedio){
                Console.Write(vNum[y] + " ");
            }
        }
    }
}
