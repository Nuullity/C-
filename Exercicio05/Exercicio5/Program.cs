namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola meu camarada, lhe farei algumas perguntas, espero que seja honesto.");
            Console.WriteLine("Qual seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos anos voce tem ?");

            string idade = Console.ReadLine();
            Console.WriteLine("Qual seria seu CEP ?");
            string cep = Console.ReadLine();
            Console.WriteLine("Em qual horario sua casa costuma ficar vazia ?");
            string invasion = Console.ReadLine();

            Console.WriteLine("E o mais importante... Você apoia a Organização ? ");

            Console.WriteLine("Sim / Não / Depende de quem pergunta");
            string org = Console.ReadLine();

            if (org == "Sim" || org == "sim")
            {

                Console.WriteLine($"Voce parece ser uma boa pessoa {nome}, juntos iremos conseguir a dominação global");
            }


            else

            {



                if (org == "Não" || org == "não" || org == "nao" || org == "não")
                

                    Console.WriteLine($"{nome} voce tem capacete para .50? pois vai precisar de um em 20 segundos");




                else




                        Console.WriteLine("hmmm... inteligente eu diria, mas não tão dedicado a causa, mas ainda ha esperança em você");

                
                
                }

                   Console.ReadLine();




        }
    }
}