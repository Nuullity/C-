namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
exemplo.
            */



            int alcool = 0;
            int gas = 0;
            int diesel = 0;

            Console.WriteLine("Informe o código do produto:");
            Console.WriteLine("1. Álcool");
            Console.WriteLine("2. Gasolina");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. Encerrar:");

            int produto = int.Parse(Console.ReadLine());


            while (produto != 4) { 
                if (produto == 1) { alcool++;  }
                else if (produto == 2) { gas++; }
                else if (produto == 3) { diesel++; }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
               
                Console.WriteLine("Informe o código do produto:");
                Console.WriteLine("1. Álcool");
                Console.WriteLine("2. Gasolina");
                Console.WriteLine("3. Diesel");
                Console.WriteLine("4. Encerrar:");
                produto = int.Parse(Console.ReadLine());

            }



            Console.WriteLine("Muito Obrigado");
            Console.WriteLine("Álcool: " + alcool );
            Console.WriteLine("Gasolina " + gas);
            Console.WriteLine("Diesel " + diesel);

        }
    }
}