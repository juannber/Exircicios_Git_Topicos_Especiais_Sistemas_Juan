// Cálculo de IMC com Classificação

using System;
using System.Globalization;

namespace Calculo_IMC
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Informe seu peso: ");
            int peso = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse (Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            IMC i1 = new IMC(peso, altura);

            i1.exibirIMC();
        }
    }
}