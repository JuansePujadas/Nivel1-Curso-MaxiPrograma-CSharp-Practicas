// Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los 
// mismos se encuentran ordenados de forma decreciente .

int n1, n2, n3, n4;

Console.WriteLine("Primer número:");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Segundo número:");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Tercer número:");
n3 = int.Parse(Console.ReadLine());
Console.WriteLine("Cuarto número:");
n4 = int.Parse(Console.ReadLine());

if(n1>=n2 && n2>=n3 && n3>=n4)
    Console.WriteLine("Los números están ordenados de forma decreciente");
else
    Console.WriteLine("Los números están desordenados");