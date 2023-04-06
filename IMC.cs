using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);

           if (IMC < 20)
            {
                Console.WriteLine("\nIMC = " + IMC + " -> " + " Abaixo do Peso! ");
            }

           else if ((IMC >= 20) && (IMC <= 24))
            {
                Console.WriteLine("\nIMC = " + IMC + "-> " + "Normal!");
            }
           else if ((IMC >= 25) && (IMC <= 29))
            {
                Console.WriteLine("\nIMC = " + IMC + "-> " + "A cima do Peso!");
            }
           else if ((IMC >= 30) && (IMC <= 34))
            {
                Console.WriteLine("\nIMC = " + IMC + "-> " + "Obeso!");
            }
           else
            {
                Console.WriteLine("\nIMC = " + IMC + "-> " + "Muito Obeso!");
            }
        }
    }
}
