﻿using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
            */


            int acesso = 2002;

            Console.Write("Digite sua senha de acesso: ");
            int senha = int.Parse(Console.ReadLine()); 
            
            while (senha != acesso) {
                Console.WriteLine("Senha Invalida !!");
                Console.Write("Digite sua senha de acesso: ");
                senha = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");


        }
    }
}