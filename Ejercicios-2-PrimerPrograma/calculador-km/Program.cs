// Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
// la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que 
// demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

double dist, vel, tiempo;

Console.WriteLine("Distancia a recorrer en km: ");
dist = double.Parse(Console.ReadLine());
Console.WriteLine("Velocidad promedio en km/h: ");
vel = double.Parse(Console.ReadLine());

tiempo = dist / vel;

Console.WriteLine("Se tardarán " + tiempo + "hs en llegar al destino");