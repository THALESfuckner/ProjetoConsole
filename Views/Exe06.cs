using System;

namespace ListaDeExecicios.Views
{
    public class Exe06
    {
        const int VALOR_MAX = 10001;
        const int TAMANHO_DO_VETOR = 100;
        public static void Renderizar()
        {

            Random random = new Random();
            int[] numeros = new int[TAMANHO_DO_VETOR];
            // METODO PARA POPULAR O VETOR COM VALORES ALEATÓRIOS 
            for (int i = 0; i < TAMANHO_DO_VETOR; i++)
            {
                numeros[i] = random.Next(VALOR_MAX);
            }
            //imprimir o vetor 
            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }
            Console.WriteLine(" \n");
            // Ordenar o vetor automaticamente 
            // Array.Sort(numeros);

            // Ordenar o Vetor em bubble sort
            bool troca = false;
            do
            {
                troca = false;
                for (int i = 0; i < TAMANHO_DO_VETOR - 1; i++)
                {
                    if (numeros[i] > numeros[i + 1])
                    {
                        int aux = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = aux;
                        troca = true;
                    }
                }
            } while (troca);

            foreach (int numero in numeros)
            {
                Console.Write($"{ numero } ");
            }


        }
    }
}
