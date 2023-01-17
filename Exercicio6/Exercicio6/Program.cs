using System.Net.Http.Headers;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Este programa tem como objetivo identificar numeros multiplos entre si.");
            
            Console.WriteLine("Por favor digite o primeiro numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
           
            
            if (n1%n2 == 0 || n2 % n1 == 0 ){

                Console.WriteLine($" {n1} e {n2} são multiplos entre si !");

            }
            else {
                Console.WriteLine($" {n1} e {n2} não são multiplos entre si !");
            }







        }
    }
}