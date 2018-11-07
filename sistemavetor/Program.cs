using System;

namespace sistemavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o nome: ");
            string nome = Console.ReadLine();

            string [] partes = nome.Split(" ");

            for (int i = 0; i < partes.Length; i++){
                Console.WriteLine("Posicao {0} Valor {1}", i, partes[i]);
            }
        }
    }
}
