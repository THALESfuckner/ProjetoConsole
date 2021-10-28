using System;

namespace ListaDeExecicios.Views
{
    public class Exe02
    {
        public static void Renderizar(){
            double real, dolar;
            const double VALOR_DO_DOLAR = 5.17; // CONSTANTE e a nomenclatura dela sempre será em LETRAS MAIUSCULAS
            
            Console.WriteLine("Digite o valor em R$");
            real = Convert.ToDouble(Console.ReadLine());
            dolar = real / VALOR_DO_DOLAR;
            Console.WriteLine($"Dolar : { dolar.ToString("F2") }"); // ToString é usado para formatar o valor, pode ser moeda, data, inteiro, casas dessimais etc
        }
    }
}