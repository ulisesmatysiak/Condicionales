using System;

namespace ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND Y OR ...... NOT 
            // AND (y) OPERADOR: &&
            // OR (o) OPERADOR: ||
            // v OP v OR v OP v
            // if (edad > 10 && edad < 30) rango

            int edad = 20;
            char inicial = "J";

            // AND &&

            //true && true = true

            if(edad > 20 && inicial == "H");{
                Console.WriteLine ("21% off");
            }

            // true && false = false
            // false && true = false
            // false && false = false

            // OR ||

            //true || true = true

            if(edad > 20 || inicial == "H");{
                Console.WriteLine ("21% off");
            }

            // true || false = true
            // false || true = true
            // false || false = false

            









        }
    }
}
