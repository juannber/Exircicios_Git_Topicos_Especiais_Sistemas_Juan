// Cadastro Simples de Produtos

using System;
using System.Globalization;

namespace Cadastro_de_Produtos
{
    class Program
    {
        static void Main (string [] args)
        {
            Console.WriteLine("Digite o nome do primeiro produto: ");
            string nome1 = Console.ReadLine();

            Console.WriteLine("Informe o preco do produto: ");
            double preco1 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a quantidade: ");
            int quantidade1 = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome1, preco1, quantidade1);

            Console.WriteLine("Digite o nome do segundo produto: ");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Informe o preco do produto: ");
            double preco2 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a quantidade: ");
            int quantidade2 = int.Parse(Console.ReadLine());

            Produto p2 = new Produto(nome2, preco2, quantidade2);

            Console.WriteLine("Digite o nome do terceiro produto: ");
            string nome3 = Console.ReadLine();

            Console.WriteLine("Informe o preco do produto: ");
            double preco3 = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a quantidade: ");
            int quantidade3 = int.Parse(Console.ReadLine());

            Produto p3 = new Produto(nome3, preco3, quantidade3);

            p1.ExibirProdutos();
            p2.ExibirProdutos();
            p3.ExibirProdutos();
        }
    }
}