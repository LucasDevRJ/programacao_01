namespace aula_2
{
    internal class Exercicio2
    {
        public void gerarAlfabeto()
        {
            char[] letra = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] vetorAleatorio = new char[100];
            char[] vetorFinal = new char[100];
            Random randomico = new Random();

            for (int i = 0; i < 100; i++)
            {
                vetorAleatorio[i] = letra[randomico.Next(0, letra.Length)];
            }

            int posicaoInicial = 0;
            int posicaoFinal = 0;

            Console.WriteLine("Informe o valor para recortar o array incial: ");
            posicaoInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor para recortar o array final: ");
            posicaoFinal = int.Parse(Console.ReadLine());

            for (int i = posicaoInicial; i < posicaoFinal; i++)
            {
                vetorFinal[i] = vetorAleatorio[i];
            }

            var stringFinal = new string(vetorFinal);

            Console.WriteLine("A String final ficou assim: ");
            Console.WriteLine(stringFinal);
        }
    }
}