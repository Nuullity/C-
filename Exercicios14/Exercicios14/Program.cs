using System.Data;

namespace Exercicios14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
            velha. (utilizando classes)
             
             
             */


            Pessoa n1= new Pessoa();
            Pessoa n2= new Pessoa();




            Console.Write("Digite o nome da primeira pessoa: ");
            n1.nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            n1.idade = double.Parse(Console.ReadLine());

            //segunda pessoa



            Console.Write("Digite o nome da segunda pessoa: ");
            n2.nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            n2.idade = Double.Parse(Console.ReadLine());

            Console.Clear();



            Console.WriteLine("Dados da primeira pessoa:");

            Console.WriteLine($"Nome: {n1.nome}");

            Console.WriteLine($"idade: {n1.idade} anos");

            // segunda pessoa




            Console.WriteLine("Dados da segunda pessoa:");

            Console.WriteLine($"Nome: {n2.nome}");

            Console.WriteLine($"idade: {n2.idade} anos");


            if (n1.idade > n2.idade)
            {
                Console.WriteLine($"A pessoa mais velha é {n1.nome} com {n1.idade} anos");
            }


            else
            {
                Console.WriteLine($"A pessoa mais velha é {n2.nome} com {n2.idade} anos");
            }





        }
    }
}