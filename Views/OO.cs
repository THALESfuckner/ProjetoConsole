using System;
using ListaDeExecicios.Models;
namespace ListaDeExecicios.Views

{
    public class OO
    {
        public static void Renderizar(){
            Produto produto = new Produto();
            produto.Nome = "Poco x3";
            produto.Preco = 1500.00;
            produto.Quantidade = 3;
            double valorFinal = produto.Preco * produto.Quantidade; 
            Console.WriteLine($" Nome do Produto: { produto.Nome}.");
            Console.WriteLine($" Quantidade: { produto.Quantidade}");
            Console.WriteLine($" Valor final: { valorFinal.ToString("C2") }");
        }

    
    }
}