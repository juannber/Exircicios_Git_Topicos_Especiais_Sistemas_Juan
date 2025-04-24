using System;

namespace Calculo_IMC 
{
    public class IMC
    {
        public int Peso {set; get;}

        public double Altura {set; get;}

        public IMC (int peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public void exibirIMC()
        {
            double imc = CalcularIMC();
            
            if(imc < 18.5)
            {
                Console.WriteLine($"{imc:F2} - Abaixo do Peso");
            }

            else if(imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine($"{imc:F2} - Peso Normal");
            }

            else if(imc > 25 && imc < 29.9)
            {
                Console.WriteLine($"{imc:F2} - Sobrepeso");
            }

            else if(imc > 30)
            {
                Console.WriteLine($"{imc:F2} - Obesidade");
            }
        }

        public double CalcularIMC()
        {
            return Peso / (Altura * Altura);
        }
    }
}