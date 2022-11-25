using System;

namespace Apis
{
    class Program  
    {
        static void Main (string[] args)
        {

        bool teste = true;
        short min = 15;
        float primeira = 15.5f;
        decimal primeiraD= 15.5m;
        Console.WriteLine("Hello, World!");
        char primeiraLetra = 'D';
        var segundaLetra = 'O';
        string texto = "É preciso utilizar aspas duplas";
        int? idade = null;
        int inteiro = 100;
        Console.WriteLine(inteiro);
        float real = 25.5f;
        Console.WriteLine (real);
        inteiro = (int)real;
        Console.WriteLine(inteiro);

        var arr = new string [2];
        arr [0] = "Item 1";
        var arr2 = new string [2];
        arr2= arr;

        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);

        arr2[0] = "Item alterado";
        Console.WriteLine(arr[0]);
        Console.WriteLine(arr2[0]);

        Product mouse = new Product ();
        
        Analistas analista1 = new Analistas();

        analista1.Name=("Yago");
        analista1.Phone = 000000000;
        Console.WriteLine(analista1.Name, " and ", analista1.Phone);
        }
    }

    struct Analistas
    {
        public string Name;
        public int Phone;
    }
    struct Product
    {
        public Product(int id, string name, double price)
        {
            Id=id;
            Name=name;
            Price=price;
        }
        public int Id;
        public string Name;
        public double Price;
        public double PriceInDolar (double dolar)
        {
            return Price * dolar;
        }
    }
}

  