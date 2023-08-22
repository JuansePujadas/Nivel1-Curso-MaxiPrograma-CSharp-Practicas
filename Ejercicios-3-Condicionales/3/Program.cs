// Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

// Si el importe es menor a ARS 1000, no hay descuento.
// Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
// Si el importe es ARS 5000 o más, aplica un descuento del 18%.

// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

internal partial class Program
{
    private static void Main(string[] args)
    {
        double importe;

        Console.WriteLine("Ingrese el importe de la compra: ");
        importe = double.Parse(Console.ReadLine());

        if (importe >= 5000){
            importe = importe - importe * 0.18;
            Console.WriteLine("Con un 18% de descuento el total a pagar es de: $" + importe);
        }else if (importe >= 1000){
            importe = importe - importe * 0.10;
            Console.WriteLine("Con un 10% de descuento el total a pagar es de: $" + importe);
        }else{
            Console.WriteLine("El total a pagar es de: $" + importe);}
    }
}