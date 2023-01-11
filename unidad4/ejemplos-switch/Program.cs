using System;

namespace ejemplos_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch
            // switch case (en caso) break
            // default
            // opciones hasta match

            char letra = "A";

            switch (letra)
            { 
                case "M" :
                    // ejecuto
                    Console.WriteLine ("Tu nombre comienza con M");
                    break;

                    case "H":
                    // ejecuto
                    Console.WriteLine ("Tu nombre comienza con H");
                    break;

                    case "R" :
                    // ejecuto
                    Console.WriteLine ("Tu nombre comienza con R");
                    break;

                    default :
                    // no coincide con ninguna
                    break ;

            }


        }
    }
}
