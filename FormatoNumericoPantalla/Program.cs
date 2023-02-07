﻿namespace FormatoNumericoPantalla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double miDoble = 123456.7890123;
            int miInt = 637;

            Console.WriteLine("Impresiones normales");
            Console.WriteLine("El entero {0}", miInt);
            Console.WriteLine("El doble {0}", miDoble);
            Console.WriteLine("-----------");
            Console.WriteLine("Impresiones con formato");
            Console.WriteLine("Moneda {0:C}", miDoble);
            Console.WriteLine($"Moneda {miDoble:C}"); // Como la linea anterior pero con fstring.

            Console.ReadKey();

        }
    }
}