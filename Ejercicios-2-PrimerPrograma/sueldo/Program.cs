﻿// Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 
// 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado 
// por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

double tf, t, sf = 15000.0;

Console.WriteLine("Ingrese el total facturado por el empleado: ");
tf = double.Parse(Console.ReadLine());

t = tf * 0.05 + sf;

Console.WriteLine("El total a pagar es de: $" + t);