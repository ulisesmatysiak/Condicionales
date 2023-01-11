using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
        //  4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.

        int n1, n2, n3;

        Console.WriteLine("Ingresar el primer número");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el segundo número");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingresar el tercer número");
        n3 = int.Parse(Console.ReadLine());

        if (n1 + n2 > n2*n3 )
         Console.WriteLine("La suma de los dos primeros numeros es mayor al producto del segundo con el tercero");
         
        }
    }
}
