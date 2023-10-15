using System;
using System.Collections.Generic;
using System.Globalization;

namespace exercicio_02
{
    internal class Produto
    {
        //declarando atributos
        private string nome;
        private double preco;
        private int quantidade;

        //encapuslando atributos
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setPreco(double preco)
        {
            this.preco = preco;
        }
       
        public double valorTotalEmEstoque()
        {
            double valorTotal = this.preco * this.quantidade;
            return valorTotal;
        }

        //método para adicionar produto
        public void adicionarProduto(int quantidadeDesejada)
        {
            //condição para verificar se o valor é menor ou igual a 0
            if (quantidadeDesejada <= 0)
            {
                Console.WriteLine("Digite um valor maior que 0!!\n");
                quantidadeDesejada = Int32.Parse(Console.ReadLine());
            }
            else
            {
                this.quantidade += quantidadeDesejada;
                Console.Write("Foram adicionadas " + quantidadeDesejada + " unidades do " + this.nome);
            }
            exibeInformacoesProduto();
        }

        //método para remover produto
        public void removerProduto(int quantidadeDesejada)
        {
            //condição para verificar se o valor é menor ou igual a 0 e a qauntidade desejada é maior que a do produto
            if (quantidadeDesejada <= 0 && this.quantidade < quantidadeDesejada)
            {
                Console.WriteLine("Adicione um valor maior que 0 e/ou quantidade estocada insuficiente!!\n");
                quantidadeDesejada = Int32.Parse(Console.ReadLine());
            }
            else
            {
                this.quantidade -= quantidadeDesejada;
                Console.Write("Foram removidas " + quantidadeDesejada + " unidades do " + this.nome);
            }
            exibeInformacoesProduto();
        }

        //método para exibir informações do produto
        public void exibeInformacoesProduto()
        {
            Console.WriteLine("\nProduto: " + this.nome);
            Console.WriteLine("Preço: " + this.preco);
            Console.WriteLine("Quantidade: " + this.quantidade);
            Console.WriteLine("Valor Total: R$ " + valorTotalEmEstoque());
        }
    }
}
