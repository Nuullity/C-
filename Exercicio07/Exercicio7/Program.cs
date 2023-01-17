using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 
            Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
            começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            */


            Console.WriteLine("Olá por favor adicione o horario de inicio do Jogo");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o horario de fim do jogo");
            int fim = int.Parse(Console.ReadLine());



            int tempo = fim - inicio;

            if (tempo < 0)
            {

                tempo = (tempo + 4) * -1;
                Console.WriteLine($"O jogo durou {tempo} horas");
            }
            else if (tempo == 0)
            {

                tempo = 0;
                Console.WriteLine($"O jogo durou {tempo} horas");
            }




            else if (tempo > 0)
            {


                Console.WriteLine($"O jogo durou {tempo} horas");
            }













        }






    }
}
