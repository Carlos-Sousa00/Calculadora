﻿using System;
/////
namespace Calculator
{
    class Program
    {
        static void Main (string [] args)
        {
            Menu();
           
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Opções possíveis");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("---------------------");
            Console.WriteLine("Selecione uma opção: ");
            short result = short.Parse(Console.ReadLine());
            short count = 0;
            while (result > 5 || result<1)
            {   
                Console.WriteLine("Por favor, digite uma opção valida");
                result = short.Parse(Console.ReadLine());
                count++;
                if (count == 5)
                {
                    Console.WriteLine("Número de tentativas excedidas");
                    System.Environment.Exit(0);
                }
            }

            switch (result){
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5: System.Environment.Exit(0);
                    break;
                default: Menu(); break;

            }
        }
        static void Soma(){

            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            //INTERPOLAÇÃO DE STRING           
            Console.WriteLine($"O resultado a soma é {v1 + v2}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor");
            float v1 = float.Parse (Console.ReadLine());

            Console.WriteLine("Segundo valor");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é {v1-v2}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao(){

            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O valor da divisão é {v1/v2}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
