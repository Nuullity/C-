using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;



            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine($"{produto2}, cujo o preço é {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e genero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondamento (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal Invariant Culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }

    }
}