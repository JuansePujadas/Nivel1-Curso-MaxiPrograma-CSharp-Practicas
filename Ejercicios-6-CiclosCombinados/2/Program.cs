// Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:

// El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
// Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

namespace _2;
class Program
{
    static void Main(string[] args)
    {
        int n, porcI, totalI = 0, totalN = 0, mayorP = 0, nAnterior, contO = 0, totalO = 0, gMayorP = 0;

        for (int i = 0; i < 5; i++){
            
            Console.WriteLine("Ingrese N°: ");
            n = int.Parse(Console.ReadLine());
            nAnterior = n;
            
            totalN = 0;
            totalI = 0;
            contO = 0;
            porcI = 0;

            while (n != 0){
                totalN++;

                if (n % 2 != 0){
                    totalI++;
                }
                
                if (totalN == 1){
                    nAnterior = n;
                    contO++;
                    }
                else if(n < nAnterior){
                    contO++;
                    }
                Console.WriteLine("Ingrese N° (para siguiente lista '0'): ");
                n = int.Parse(Console.ReadLine());
            }
            
            if (totalI != 0){
            porcI = totalN / (totalI*100);                
            }
            
            if (porcI > mayorP){
                mayorP = porcI;
                gMayorP = i + 1;
            }

            if (contO == totalN){
                totalO++;
            }
        }
        Console.WriteLine("La lista con mayor porcentaje de números impares fue la N° " + gMayorP);
        Console.WriteLine("Hay " + totalO + " listas con números ordenados de mayor a menor.");
    }
}
