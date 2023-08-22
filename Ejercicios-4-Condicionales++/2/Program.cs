// Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos 
// según la siguiente escala:

// Si vende menos de 100 litros, no hay descuento.
// Si vende entre 101 y 300 litros, el descuento es del 10%.
// Si vende entre 301 y 500 litros, el descuento es del 15%.
// Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

// Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y 
// calcule y emita el importe con el descuento  aplicado.

double venta, litros, tDesc;

Console.WriteLine("Ingrese el importe: ");
venta = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de litros: ");
litros = double.Parse(Console.ReadLine());

if(litros < 100){
    tDesc = venta;
}else if(litros <= 300){
    tDesc = venta - (venta * 0.10);
}else if(litros <= 500){
    tDesc = venta - (venta * 0.15);
}else{
    tDesc = venta - (venta * 0.25);
}
Console.WriteLine("Total a pagar: $" + tDesc);