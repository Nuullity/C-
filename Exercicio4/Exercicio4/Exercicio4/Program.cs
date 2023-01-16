using System;
using System.Diagnostics;

class URI
{

    static void Main(string[] args)
    {




        Console.WriteLine("Entre com seu nome completo:");
        String nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem sua casa ?");
        int quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o preço pela sua vida ?");
        double preco = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha):");
        String[] vet = Console.ReadLine().Split(' ');

        string ultNome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2]);


        Console.WriteLine("Informarções adquiridas:");
        Console.WriteLine();
        Console.WriteLine("nome: " + nome);
        Console.WriteLine("quartos: " + quartos);
        Console.WriteLine("preço: " + preco.ToString("F2"));
        Console.WriteLine("ultimo nome: " + ultNome);
        Console.WriteLine("Sua idade: " + idade);
        Console.WriteLine("Sua altura : " + altura.ToString("F2"));
        Console.WriteLine("A Organização logo irá atras de voce, prepare-se!!");
        Console.ReadLine();





    }


}