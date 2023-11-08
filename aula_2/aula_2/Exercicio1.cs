namespace aula_2
{
    internal class Exercicio1
    {
        public void gerarNumerosInteiros()
        {
            int[] vetorComNumerosInteiros = new int[100000];
            int[,] matrizComNumerosInteiros = new int[100, 100];

            var numeroRandomico = new Random();

            for (int i = 0; i < 100000; i++)
            {
                vetorComNumerosInteiros[i] = i;
            }

            for (int i = 0; i < 100; i++)
            {
                for (int k = 0; k < 100; k++)
                {
                    matrizComNumerosInteiros[i, k] = numeroRandomico.Next(1, 300000);
                }
            }

            int contador = 0;
            for (int i = 0; i < matrizComNumerosInteiros.GetUpperBound(0); i++)
            {
                for (int k = 0; k < matrizComNumerosInteiros.GetUpperBound(1); k++)
                {
                    var valorMatriz = (int) matrizComNumerosInteiros.GetValue(1, k);

                    for (int x = 0; x < vetorComNumerosInteiros.Length; x++)
                    {
                        if (vetorComNumerosInteiros[x] == valorMatriz)
                        {
                            contador++;
                        }
                    }
                }
            }
            Console.WriteLine($"Possui {contador} números rândomicos");
        }
    }
}