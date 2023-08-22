// Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
// El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
// sido reemplazadas por el segundo. Mostrar el resultado en pantalla. 

// Ejemplo:
// CADENA FUENTE: “La mar estaba serena"
// CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
// CADENA RESULTADO: “Li mir estibi sereni"

namespace _3;
class Program
{
    static void Main(string[] args){

        char[] vChar = new char[30];
        char c1, c2, letra;
        int cont = 0;

        Console.WriteLine("Ingese una frase (letra por letra): ");
        letra = char.Parse(Console.ReadLine());

        while (letra != '.'){
            vChar[cont] = letra;
            cont ++;
            Console.WriteLine("Continue ('.' para terminar): ");
            letra = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Elija una letra que esté en su frase para modificar: ");
        c1 = char.Parse(Console.ReadLine());
        Console.WriteLine("Elija la nueva letra a agregar: ");
        c2 = char.Parse(Console.ReadLine());

        for (int i = 0; i < cont; i++){
            if (vChar[i] == c1){
                vChar[i] = c2;
            }
        }

        for (int i = 0; i < cont; i++){
            Console.Write(vChar[i]);
        }
    }
}
