using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c, f, k;

            Console.WriteLine("### Conversor de Temperaturas ###");
            Console.Write("Insira a temperatura em celsius: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");

            // f = (c * 9 /5 ) + 32
            f = (c * 9 / 5) + 32;
            // c + 273,15
            k = c + 273.15;

            Console.WriteLine(c + " Graus Celsius = " + f + " Graus em Fahrenheit");
            Console.WriteLine(c + " Graus Celsius = " + k + " Graus em Kelvin");
            Console.WriteLine("-----------------------------------------------");
            Console.ReadKey();


        }
    }
}
