using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {   Inicio:
            Console.Clear();
            Console.Write("Digite o primeiro número: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação [+] [-] [X] [/]: ");
            char op = char.Parse(Console.ReadLine());
            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, opção invalida");
                    break;
                case '+' :
                    resultado = numero1 + numero2;
                    Console.WriteLine("A Soma de {0} e {1} é {2}\n", numero1,numero2,resultado);
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    Console.WriteLine("A Subtração entres os números {0} e {1} é {2}\n",numero1,numero2,resultado);
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    Console.WriteLine("A Multiplicação entres os números {0} e {1} é {2}\n", numero1, numero2, resultado);
                    break;
                case '/':
                case ':':
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0\n");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine("A Divisão entre os números {0} e {1} é {2}\n", numero1, numero2, resultado);
                    }
                    break;
                     
            }
            Console.Write("---Digitar novos números---\n\n");
            Console.WriteLine("Sim [S]");
            Console.WriteLine("Não [N]\n");
            Console.WriteLine("Opção: ");
            char dc = char.Parse(Console.ReadLine());

            if (dc == 's')
            {
                goto Inicio;
            }
            else
            {
                Console.WriteLine("FIM!");
            }
            Console.ReadKey();
        }
    }
}
