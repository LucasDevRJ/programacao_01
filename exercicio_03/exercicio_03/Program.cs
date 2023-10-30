namespace exercicio_03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lucas Pereira de Lima - 3658733\n");
            //chamando o método que gera a Thread
            gerarThread();
        }

        public static void gerarThread()
        {
            //instanciando a Thread com o método de listar os números
            Thread thread = new Thread(listarNumeros);
            thread.Start();
        }

        public static void listarNumeros()
        {
            //declaração de variável
            int N;
            do
            {
                //laço de repetição para armazenar valor de N     
                Console.WriteLine("Digite o valor N: ");
                N = Int32.Parse(Console.ReadLine());
            } while (N == 0);
            
            for (int i = 0; i < N; i++)
            {
                //verificando se o número é primo
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}