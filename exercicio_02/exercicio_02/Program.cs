namespace exercicio_02
{
    class Program
    {
        public static void Main(String[] args)
        {
            //instanciândo o Objeto Produto e chamando os métodos dele
            Produto produto = new Produto();
            produto.setNome("TV");
            produto.setPreco(900.00);
            produto.adicionarProduto(10);
            produto.adicionarProduto(3);

            Console.WriteLine("\n");
            Produto produto2 = new Produto();
            produto2.setNome("TV");
            produto2.setPreco(900.00);
            produto2.adicionarProduto(15);
            produto2.removerProduto(3);
        }
    }
}
