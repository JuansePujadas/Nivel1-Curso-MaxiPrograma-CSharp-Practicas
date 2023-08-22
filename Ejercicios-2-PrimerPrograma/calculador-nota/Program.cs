// Hacer un programa para ingresar por teclado las tres notas de exámenes de un 
// alumno y luego calcule y emita por pantalla el promedio final.

double n1, n2, n3, p;

Console.WriteLine("Nota del 1er Trimestre: ");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Nota del 2do Trimestre: ");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("Nota del 3er Trimestre: ");
n3 = double.Parse(Console.ReadLine());

p = (n1+n2+n3) / 3;

Console.WriteLine("La nota final es de: " + p);