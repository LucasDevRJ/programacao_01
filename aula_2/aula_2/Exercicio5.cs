using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2
{
    public static class Exercicio5
    {
        public static void teste()
        {
            var string1 = "123";
            var string2 = "10,0578";
            var string3 = "9000,87";
            var string4 = "010";

            Console.WriteLine($"string1 to int: {string1.ToInt()}");
            Console.WriteLine($"string2 to decimal: {string1.ToDecimal()}");
            Console.WriteLine($"string3 to decimal: {string1.ToDecimal()}");
            Console.WriteLine($"string4 to int: {string1.ToInt()}");

            var arrayBase = new int[50];
            for (int i = 0; i < arrayBase.Length; i++)
            {
                IEnumerable<int> enumerable = arrayBase;
                IList<int> lista = arrayBase;
                ICollection<int> collection = arrayBase;

                Console.WriteLine($"Quantidade Enumerable: {enumerable.CountCustom()}");
                Console.WriteLine($"Quantidade Lista: {lista.CountCustom()}");
                Console.WriteLine($"Quantidade Collection: {collection.CountCustom()}");
            }
            
        }
        public static int ToInt(this string value) 
        {
            return int.Parse(value);
        }

        public static decimal ToDecimal(this string minhaString)
        {
            return decimal.Parse(minhaString);
        }

        public static int CountCustom<T>(this IEnumerable<T> enumerable)
        {
            int countAux = 0;
            foreach (var item in enumerable)
            {
                countAux++;
            }

            return countAux;
        }
    }
}
