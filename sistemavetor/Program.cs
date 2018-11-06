using System;

namespace sistemavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < vetor.Length;i++){
                Console.WriteLine("\nPosicao: {0} Valor: {1}", i, vetor[i]);
            }
        }
    }
}
