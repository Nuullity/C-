namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
            cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
            menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
            */



            Console.WriteLine("Digite as cordeandas X e Y de seu plano cartesiano ");
            string[] Vet = Console.ReadLine().Split(' ');
            int X = int.Parse(Vet[0]);
            int y = int.Parse(Vet[1]);

            while (X != 0 & y != 0)
            {

                if (X > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (X < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");

                }
                else if (X < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else if (X > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                }

                Console.WriteLine("Digite as cordeandas X e Y de seu plano cartesiano ");
                 Vet = Console.ReadLine().Split(' ');
                 X = int.Parse(Vet[0]);
                 y = int.Parse(Vet[1]);







            }


        }
    }
}