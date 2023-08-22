// Hacer un programa que solicite el ingreso de dos números y luego calcular:

// La resta si el primero es mayor que el segundo.
// La suma si son iguales.
// El producto si el primero es menor.

// Se deberá emitir un cartel por pantalla con el resultado correspondiente.

int n1, n2, r;

Console.WriteLine("Ingrese un número: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese otro número: ");
n2 = int.Parse(Console.ReadLine());

if(n1>n2)
    r = n1-n2;
else if(n1==n2)
    r = n1+n2;
else
    r = n1*n2;

Console.WriteLine("Resultado: " + r);