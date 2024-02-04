using System;

namespace aula_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula Prática 4!");
            Console.WriteLine("--------------------");

            Console.WriteLine("--------------------");
            Console.WriteLine("Threads");
            Console.WriteLine("--------------------");

            //ThreadPing exercicio1 = new ThreadPing();
            //exercicio1.StartPing();

            PessoaFinder exercicio3 = new PessoaFinder();
            exercicio3.ExercicioPessoaAsync();
        }
    }
}