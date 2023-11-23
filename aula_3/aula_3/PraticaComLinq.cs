using System.Security.Cryptography;

namespace aula_3
{
    internal class PraticaComLinq
    {
        public void exercicio1()
        {
            string[] nomes = { "João", "Silva", "Paulo", "Antonio", "Maria", "Joana", "Matheus", "Alan" };
            string[] materias = { "Programação I", "Algoritmos II", "Redes", "Cálculo II", "Sistemas Operacionais" };
            Random rand = new Random();
            List<Avaliacao> avaliacoes = new List<Avaliacao>();

            foreach (var nomeEstudante in nomes) 
            { 
                foreach (var materia in materias)
                {
                    var avaliacao = new Avaliacao()
                    {
                        Nome = materia,
                        NomeAluno = nomeEstudante,
                        Nota = decimal.Parse($"{rand.Next(0, 100)}, {rand.Next(0, 10)}")
                    };

                    avaliacoes.Add(avaliacao);
                }
            }

            var queryEstudantes = from n in nomes
                                  let avaliacoesEstudante = (from a in avaliacoes
                                                             where a.Nome == n
                                                             select a).ToList()
                                  select new Estudante()
                                  {
                                      avaliacoes = avaliacoesEstudante,
                                      Nome = n,
                                      Media = avaliacoesEstudante.Average(x => x.Nota)
                                  };
        }

        public class Estudante
        {
            public string Nome { get; set; }
            public decimal Media { get; set; }

            public List<Avaliacao> avaliacoes { get; set; }
        }

        public class Avaliacao
        {
            public string Nome { get; set; }
            public string NomeAluno { get; set; }
            public decimal Nota { get; set; }
        }
    }
}