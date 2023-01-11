using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            int a, b, c, d;

            Console.WriteLine("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            d = int.Parse(Console.ReadLine());

            if ( a>100)
            Console.WriteLine(a +" es mayor que 100");

            if ( b>100)
            Console.WriteLine(b +" es mayor que 100");

            if ( c>100)
            Console.WriteLine(c + " es mayor que 100");

            if ( d>100)
            Console.WriteLine(d + " es mayor que 100");

            


        }
    }
}
