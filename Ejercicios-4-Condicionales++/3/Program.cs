// Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
// Para ello existe la siguiente escala de precios:

//             i5 (1)	i7 (2)	i9 (3)
// 8 RAM (1)	USD 800	USD 900	USD 1200
// 16 RAM (2)	USD 900	USD 1000 USD 1400
// 32 RAM (3)	USD 1000 USD 1400 USD 2000

// Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede 
// ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa que 
// solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no 
// (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina seleccionada.

int P, R, D, T=0;

Console.WriteLine("Ingrese Opción de procesador (1,2,3): ");
P = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Opción de Memoria RAM (1,2,3): ");
R = int.Parse(Console.ReadLine());
Console.WriteLine("Extiende Disco? (1 si, 0 no): ");
D = int.Parse(Console.ReadLine());

switch (P){
    case 1:
        switch (R){
            case 1:
                T = 800;
                break;
            case 2:
                T = 900;
                break;
            case 3:
                T = 1000;
                break;
            default:
                Console.WriteLine("Se ha ingresado una opción incorrecta.");
                break;
       } 
       break;
    case 2:
        switch (R){
            case 1:
                T = 900;
                break;
            case 2:
                T = 1000;
                break;
            case 3:
                T = 1400;
                break;
            default:
                Console.WriteLine("Se ha ingresado una opción incorrecta.");
                break;
        }
        break;
    case 3:
        switch (R){
            case 1:
                T = 1200;
                break;
            case 2:
                T = 1400;
                break;
            case 3:
                T = 2000;
                break;
            default:
                Console.WriteLine("Se ha ingresado una opción incorrecta.");
                break;
        }
        break;
    default:
        Console.WriteLine("Se ha ingresado una opción incorrecta.");
        break;
}

switch (D){
    case 0:
        break;
    case 1:
        T = T + 300;
        break;
    default:
        Console.WriteLine("Se ha ingresado una opción incorrecta.");
        break;
}

Console.WriteLine("El total es de: USD " + T);