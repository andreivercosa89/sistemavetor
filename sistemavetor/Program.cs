using System;

namespace sistemavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de palavras no seu nome: ");

            string[] nome = new string[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i < nome.Length; i++){
                Console.WriteLine("Infome o nome ou sobrenome: ");
                nome[i] = Console.ReadLine();
            }

            for (int i = 0; i < nome.Length; i++)
            {
                Console.Write(nome[i].PadRight(nome[i].Length + 1,' '));

            }
        }
    }
}
