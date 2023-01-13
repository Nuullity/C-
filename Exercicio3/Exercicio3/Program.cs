using System;

namespace Projeto1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            double pi = 3.14159;
            Double r = double.Parse(Console.ReadLine());

            Double a = pi * (r * r);

            Console.WriteLine("A= " + a.ToString("F4"));




        }

    }
}