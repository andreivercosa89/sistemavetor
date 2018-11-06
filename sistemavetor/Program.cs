using System;

namespace sistemavetor
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = { 1, 2, 3, 4, 5 };
            int[] vetor2 = new int[5];


            vetor2[0] = 7;
            vetor2[1] = 5;
            vetor2[2] = 0;
            vetor2[3] = 2;
            vetor2[4] = 3;


            for (int i = 0; i < vetor.Length;i++){
                Console.WriteLine("\nPosicao: {0} Valor: {1}", i, vetor[i]);
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("\nPosicao: {0} Valor: {1}", i, vetor2[i]);
            }

            Console.WriteLine("Informe a qtd de posicoes: ");
            int qtdVetor = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int[] vetor3 = new int[qtdVetor];

            for (int i = 0; i < qtdVetor; i++)
            {
                Console.WriteLine("Informe a Posicao {0} do vetor.", i);
                vetor3[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            int indice = 0;
            foreach(int elemento in vetor3){
                Console.WriteLine("Posicao: {0} Valor: {1}", elemento, indice);
                indice++;
            }
        }
    }
}
