using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            // Si el importe es menor a ARS 1000, no hay descuento.
            // Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            // Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda. 

            float importe;
            float importeFinal;

            Console.WriteLine("Ingrese el importe de su compra");
            importe = float.Parse(Console.ReadLine());

            if (importe >= 5000)
            { importeFinal = importe * 0.82F;
            Console.WriteLine("Su importe final es: " + importeFinal);
            } else if (importe >= 1000)
            { importeFinal = importe *0.9F;
            Console.WriteLine("Su importe final es: " + importeFinal);
            } else
            { importeFinal = importe;
            Console.WriteLine("Su importe final es: " + importeFinal);   
            }
        }
    }
}
