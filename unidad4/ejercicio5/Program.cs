using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .


            int a, b, c, d;

            Console.WriteLine("Ingresar el primer número");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el segundo número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el tercer número");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar el cuarto número");
            d = int.Parse(Console.ReadLine());

            if (a > b && b > c && c > d)
            
            Console.WriteLine("Los numeros se encuentran ordenados de forma decreciente");
                
        }
    }
}
