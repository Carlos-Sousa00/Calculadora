using System;

namespace Calculator
{
    class Program
    {
        static void Main (string [] args)
        {
            Subtracao();
           
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
        }
    }
}
