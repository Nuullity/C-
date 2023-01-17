using System.Xml.Schema;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
            seguir, calcule e mostre o valor da conta a pagar

            1    Cachorro quente     4.00  
            2    X-Salada            4.50
            3    X-Bacon             5.00
            4    Torrada simples     2.00
            5    refrigerante        1.50




            */


            Console.WriteLine(" por favor digite o codigo do produto: ");
            int codigo  = int.Parse(Console.ReadLine());
            Console.WriteLine("digite por favor a quantidade do produto: ");
            int quantia = int.Parse(Console.ReadLine());
            double total = 0.0;

            if (codigo == 1) { total = quantia * 4.00; }
            else if (codigo == 2) { total = quantia * 4.50; }
            else if (codigo == 3) { total = quantia * 5.00; }
            else if (codigo == 4) { total = quantia * 2.00; }
            else if (codigo == 5) { total = quantia * 1.50; }
            else if (codigo < 1 || codigo > 5) { Console.WriteLine("O Codigo digitado não existe, reinicie o programa."); }

            Console.WriteLine($"Total : R$ {total:F2}");


        }
    }
}