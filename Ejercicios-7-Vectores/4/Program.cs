// Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
// - Número de Artículo (1 a 15)
// - Cantidad Vendida 

// Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.

// Se pide determinar e informar:
// a) El número de artículo que más se vendió en total.
// b) Los números de artículos que no registraron ventas.
// c) Cuantas unidades se vendieron del número de artículo 10.

namespace _4;
class Program
{
    static void Main(string[] args)
    {
        int[] articulo = new int[15];
        int[] artSinVentas = new int[15];
        int artActual, artSelec, venta, ventaMax=0, artMax=0, cont=0;


        Console.WriteLine("Número de Artículo: ");
        artActual = int.Parse(Console.ReadLine());

        while (artActual != 0){
            
            artSelec = artActual;

            while (artActual == artSelec){
                //guardo venta.
                Console.WriteLine("Cantidada Vendida: ");
                venta = int.Parse(Console.ReadLine());
                // acumulo ventas en cada n° de producto
                articulo[artActual - 1] += venta;
                //actualizo, o no, el N° de art.
                Console.WriteLine("Número de Artículo: ");
                artActual = int.Parse(Console.ReadLine());
            }
        }
        // A
        for (int i = 0; i < 15; i++){
            if (articulo[i] > ventaMax){
                artMax = i + 1;
                ventaMax = articulo[i];
            }
        }
        // B
        for (int i = 0; i < 15; i++){
            if (articulo[i] == 0){
                artSinVentas[cont] = i + 1;
                cont++;
            }
        }

        Console.WriteLine("Artículo con más ventas: N°" + artMax);

        Console.WriteLine("Los siguiente artículos no tuvieron ventas:");
        for (int i = 0; i < 15; i++){

            if(artSinVentas[i] != 0){
            Console.Write(artSinVentas[i] + " ");
            }
        }

        Console.WriteLine();
        // C
        Console.WriteLine("Total de ventas del artículo 10: " + articulo[9]);
    }
}
