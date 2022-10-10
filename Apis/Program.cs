using System;

namespace Apis
{
    class Program  
    {
        static void Main (string[] args)
        {

        /**bool teste = true;
        short min = 15;
        float primeira = 15.5f;
        decimal primeiraD= 15.5m;
        Console.WriteLine("Hello, World!");
        char primeiraLetra = 'D';
        var segundaLetra = 'O';
        string texto = "É preciso utilizar aspas duplas";
        int? idade = null;**/
        int inteiro = 100;
        Console.WriteLine(inteiro);
        float real = 25.6f;
        Console.WriteLine (real);
        inteiro = (int)real;
        Console.WriteLine(inteiro);
        string valorReal = real.ToString();
        //inteiro = int.Parse(real.ToString()); // ou inteiro = int.Parse(valorReal);
        Console.WriteLine(inteiro);
        Console.WriteLine(valorReal);

        inteiro = Convert.ToInt32(real);
        Console.WriteLine(inteiro);
        }
    }
}

  