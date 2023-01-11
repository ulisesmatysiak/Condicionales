using System;

namespace acu_com
{
    class Program
    {
        static void Main(string[] args)
        {
            // Acumuladores y contadores

            int contador = 0, e1 = 20, e2 = 13, e3 = 30;
            int acumulador = 0, promedio;

            //contador = contador1
            // suma 1 ++
            // resta 1 --
            // suma al acumulado +=
            // resta al acumulado -=

            if (e1 > 18){ 
                contador++;
                acumulador += e1;
            }

            if (e2 > 18){ 
                contador = contador + 1;
                acumulador = acumulador + e2;
            }

            if (e3 > 18){ 
                contador = contador +1;
                acumulador += e3;
            }

            promedio = acumulador / contador;
            
            Console.WriteLine ("El promedio es: " + promedio);
            
        }
    }
}
