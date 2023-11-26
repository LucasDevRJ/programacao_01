using System;

namespace aula_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------|Exercício 1|----------");
            PraticaComLambdas praticaComLambdas = new PraticaComLambdas();
            praticaComLambdas.exercicio1();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("----------|Exercício 2|----------");
            praticaComLambdas.exercicio2();
            Console.WriteLine("---------------------------------");

            //PraticaComLinq praticaComLinq = new PraticaComLinq();
            //praticaComLinq.exercicio1();

            PraticaComExecucaoTardia praticaComExecucaoTardia = new PraticaComExecucaoTardia();
        }
    }
}