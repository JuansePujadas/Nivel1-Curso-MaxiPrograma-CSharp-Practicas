// Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

int num, cubo;

Console.WriteLine("Ingrese un número: ");
num = int.Parse(Console.ReadLine());

cubo = num*num*num;

Console.WriteLine("Resultado: " + cubo);