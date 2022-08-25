using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraCSharp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float numero1, numero2, resultado;
            int menu;

            texto();
            Console.WriteLine("\n\n\n                       O que deseja fazer?\n\n");
            Console.WriteLine("                        *******************\n");
            Console.WriteLine("                          1 - Somar");
            Console.WriteLine("                          2 - Subtrair");
            Console.WriteLine("                          3 - Multiplicar");
            Console.WriteLine("                          4 - Dividir");
            Console.WriteLine("                          5 - Sair");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {

                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("       Soma                      \n");
                        Console.WriteLine("       Primeiro número: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("       Segundo número: ");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = numero1 + numero2;
                        Console.WriteLine("O resultado da soma é: " + resultado);

                        break;
                    }


                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("       Subtração                      \n");
                        Console.WriteLine("       Primeiro número: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("       Segundo número: ");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = numero1 - numero2;
                        Console.WriteLine("O resultado da subtração é: " + resultado);

                        break;
                    }


                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("       Multiplicação                      \n");
                        Console.WriteLine("       Primeiro número: ");
                        numero1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("       Segundo número: ");
                        numero2 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = numero1 * numero2;
                        Console.WriteLine("O resultado da multiplicação é: " + resultado);

                        break;
                    }


                case 4:
                    {
                        Console.Clear();
                        Console.WriteLine("       Divisão                      \n");
                        Console.WriteLine("       Primeiro número: ");
                        numero1 = float.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("       Segundo número: ");
                        numero2 = float.Parse(Console.ReadLine());
                        Console.Clear();
                        resultado = numero1 / numero2;
                        Console.WriteLine("O resultado da divisão é: " + resultado.ToString("F1"));

                        break;
                    }


                case 5:
                    {
                        Console.Clear();
                        Console.WriteLine("Saindo...");


                        break;


                    }



                default:

                    Console.WriteLine("    Opção Invalida!!!!     ");

                    break;
            }



            Console.ReadLine();




             void texto()
            {

                Console.WriteLine("\t\t\t*****************");
                Console.WriteLine("\t\t\t***Calculadora***");
                Console.WriteLine("\t\t\t*****************");

            }
        }
    }
}

