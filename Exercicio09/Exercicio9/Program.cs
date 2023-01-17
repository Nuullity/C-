namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
                seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
                nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
            
             */

            Console.WriteLine("Digite um valor entre 0 e 100");
            double valor =  double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= 25)       { Console.WriteLine($"O valor {valor} esta entre 0 e 25"); }
            else if (valor > 25 && valor <= 50)  { Console.WriteLine($"O valor {valor} esta entre 25 e 50"); }
            else if (valor > 50 && valor <= 75)  { Console.WriteLine($"O valor {valor} esta entre 50 e 75"); }
            else if (valor > 75 && valor <= 100) { Console.WriteLine($"O valor {valor} esta entre 75 e 100"); }
            else                                 { Console.WriteLine($"O valor {valor} esta fora do intervalo "); }


        }
    }
}