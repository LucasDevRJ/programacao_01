using aula_1;
using System;
using System.Linq.Expressions;

namespace Aula1
{
    class Program
    {
        char c = 'a';
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World - Aula Prática 1!");
            Console.WriteLine("-----------------------------");

            int inteiro = 10;

            Console.WriteLine($"{inteiro}");

            bool boleano1 = true;
            bool boleano2 = false;

            Console.WriteLine($"{boleano1}");
            Console.WriteLine($"{boleano2}");

            long longo = 33444555443;
            decimal deci = 12.45M;
            float f1 = 3445.23f;

            Console.WriteLine($"{longo}");
            Console.WriteLine($"{deci}");
            Console.WriteLine($"{f1}");

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Tipos references types");

            object objeto1 = new object();
            var objeto2 = new object();

            var objeto3 = objeto2;

            Console.WriteLine("Comparando objetos");
            Console.WriteLine($"{objeto1.GetType().Name} | {objeto2.GetType().Name} " +
                $"| {objeto3.GetType().Name}");
            Console.WriteLine($"{objeto2 == objeto3}");

            Console.WriteLine("-----------------------------");

            var s1 = new string('a', 5);
            string s2 = new string(new char[5] { 'a', 'a', 'a', 'a', 'a' });
            Console.WriteLine($"{s1 == s2}");

            string s3 = string.Concat((new char[5] { 'a', 'a', 'a', 'a', 'a' }).AsEnumerable());
            Console.WriteLine($"{s3}");

            Console.WriteLine("-----------------------------");

            ComparaString texto = new ComparaString()
            {
                compara = "123"
            };

            var texto2 = new ComparaString()
            {
                compara = "123"
            };

            Console.WriteLine($"Comparando com == e com equals");
            Console.WriteLine($"{texto.compara == texto2.compara}");
            Console.WriteLine($"{texto.compara.Equals(texto2)}");

            Console.WriteLine("-----------------------------");

            ClasseComplexa classeComplexa = new ClasseComplexa();
            classeComplexa.PropInterface = 123;

            ImprimirValores interfaceX = classeComplexa;
            Console.WriteLine($"{interfaceX.PropInterface}");
        }
    }
}