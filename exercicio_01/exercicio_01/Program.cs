using System;
using System.IO;

namespace exercicio_01
{
    class Program
    {
        public static void Main()
        {
            //chamando a função de calcular Baskara
            Console.Write("Lucas Pereira de Lima - 3658733\n");
            calcularBaskara();
        }

        public static void calcularBaskara()
        {
            //declaração de variáveis
            double a, b, c, x1, x2, delta;

            //armazenando valores solicitados
            Console.Write("Digite o seu primeiro dígito da sua RU: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o seu segundo dígito da sua RU: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o seu terceiro dígito da sua RU: ");
            c = Convert.ToInt32(Console.ReadLine());

            //calculo do delta
            delta = Math.Pow(b, 2) - 4 * a * c;

            //condição para verificar se A é igual a 0 ou delta é menor que 0
            if (a == 0 || delta < 0)
            {
                Console.Write("Impossível calcular!!");
                Console.Write("\nA igual a 0 ou Delta menor que 0.");
            }
            else
            {
                //calculo do x1 e x2
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                //exibição dos valores das variáveis x1 e x2
                Console.Write(String.Format("\nO valor de X1 é {0}", x1));
                Console.Write(String.Format("\nO valor de X2 é {0}", x2));
            }
        }
    }
}
