using System.Data;

namespace aula_3
{
    internal class PraticaComExecucaoTardia
    {
        public void exercicio()
        {
            string[] produtos = new string[] { "Noteboo", "Mouse", "Teclado", "Monitor", "Fonte" };
            var pessoas = new List<Pessoa>(5000);
            var rand = new Random();

            //popula pessoas
            for (int i = 0; i < produtos.Length; i++)
            {
                pessoas.Add(new Pessoa
                {
                    Id = i,
                    Nome = $"Pessoa {i}",
                    Pedidos = new Dictionary<int, Pedido>()
                });
            }

            //gerar pedidos
            var pedidos = new List<Pedido>(5000);
            for (int i = 0; i < produtos.Length; i++)
            {
                var produto = produtos[rand.Next(0, 11)];
                var qtdPagamentos = rand.Next(1, 3);
                var pagador = pessoas[rand.Next(0, 5000)];

                var pedido = new Pedido()
                {
                    Id = i,
                    Data = new DateTime(rand.Next(2019, 2025), rand.Next(1, 13), rand.Next(1, 29)),
                    Produto = produto,
                    Pagamentos = new List<Pagamento>(qtdPagamentos)
                };

                pagador.Pedidos.Add(pedido.Id, pedido);
                pedidos.Add(pedido);

                for (int  j = 0; j < qtdPagamentos; j++)
                {
                    var recebedor = pessoas[rand.Next(0, 5000)];
                    var idTransacao = Guid.NewGuid();

                    var pagamento = new Pagamento
                    {
                        Pagador = pagador,
                        Recebedor = recebedor,
                        idTransacao = idTransacao,
                        Valor = decimal.Parse($"{rand.Next(1, 10000)}, {rand.Next(0, 99)}")
                    };

                    pedido.Pagamentos.Add( pagamento );
                    pedido.ValorPedido += pagamento.Valor;
                }
            }

            //Query 1
            var queryPessoaComMaiorRecebimento = pessoas.GroupBy(p => new
            {
                Pessoa = p,
                Valor = p.Pedidos.Sum(pedido => pedido.Value.ValorPedido),
                QtdPedidos = p.Pedidos.Count()
            })
            .OrderByDescending(x => x.Key.Valor)
            .FirstOrDefault()
            .Key;
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Dictionary<int, Pedido> Pedidos { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (obj is not Pessoa)
            {
                return false;
            }

            return ((Pessoa)obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }

    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Produto { get; set; }
        public decimal ValorPedido { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
    }

    public class Pagamento
    {
        public Guid idTransacao { get; set; }
        public Pessoa Pagador { get; set; }
        public Pessoa Recebedor { get; set; }
        public decimal Valor { get; set; }
    }
}