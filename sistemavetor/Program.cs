using System;

namespace sistemavetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a qtd de posicoes: ");
            int qtdVetor = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int[] vetor = new int[qtdVetor];

            for (int i = 0; i < qtdVetor; i++)
            {
                Console.WriteLine("Informe a Posicao {0} do vetor.", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();

            int indice = 0;
            foreach(int elemento in vetor){
                Console.WriteLine("Posicao: {0} Valor: {1}", indice, elemento);
                indice++;
            }
        }
    }
}
