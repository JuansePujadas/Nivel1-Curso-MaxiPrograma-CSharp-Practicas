// Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos. 
// Luego hacer un programa que pida el precio de un artículo y 
// la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

namespace _1;
class Program
{
    static void Main(string[] args)
    {
        int precio, cantidad, total;

        Console.WriteLine("Ingrece el Precio del producto: ");
        precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida: ");
        cantidad = int.Parse(Console.ReadLine());

        total = producto(precio, cantidad);

        Console.WriteLine("El total a pagar es de $ " + total);
    }

    static int producto(int a, int b){
        int r;
        r = a * b;
        return r;
    }
}
