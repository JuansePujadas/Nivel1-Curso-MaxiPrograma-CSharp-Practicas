// Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros 
// es mayor al producto del segundo con el tercero.

int n1, n2, n3, s, p;

Console.WriteLine("Ingrese un primer número: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un segundo número: ");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un tercer número: ");
n3 = int.Parse(Console.ReadLine());

s = n1 + n2;
p = n2 * n3;

if(s>p)
    Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero.");

Console.WriteLine("Fin del Programa.");