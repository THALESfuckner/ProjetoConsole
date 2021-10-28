using System;

namespace ListaDeExecicios.Views //serve para que consiga dentro do projeto, posicionar a classe
{
    public class Exe01
    {
        public static void Renderizar(){ // metodo 
            int largura, altura;
            Console.WriteLine("Digite a largura");
            largura = Convert.ToInt32(Console.ReadLine()); //leitura 
            Console.WriteLine("Digite a altura");
            altura = Convert.ToInt32(Console.ReadLine()); //leitura 
          
            Console.WriteLine($"Área: { CalcularAreaDoRetangulo(altura, largura) } "); //interpolação chamando o metodo com o resultado
        }

        public static int CalcularAreaDoRetangulo(int largura, int altura) // o metodo recebe como parametro os valores e entrega toda vez que for chamado 
        {
            return largura * altura;
        }
    }
}