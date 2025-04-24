using System;

namespace Cadastro_de_Produtos
{
    public class Produto {

        public string Nome {set; get;}

        public double Preco {set; get;}

        public int Quantidade {set; get;}

        public Produto (string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void ExibirProdutos()
        {
            double valor = CalcularValor();
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: R$ {valor}");
            Console.WriteLine($"Quantidade: {Quantidade}");
        }

        public double CalcularValor()
        {
            return Preco * Quantidade;
        }
    }
}