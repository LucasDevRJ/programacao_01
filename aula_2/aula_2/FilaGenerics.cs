using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2
{
    internal class FilaGenerics<T>
    {
        private int _countInterno;
        private int Count
        {
            get { return _countInterno; }
        }

        private T[] arrayInterno;

        public FilaGenerics(int quantidade)
        {
            _countInterno = 0;
            arrayInterno = new T[quantidade];
        }

        public void Enqueue(T elemento) {
            arrayInterno[_countInterno] = elemento;
            _countInterno++;
        }

        public T Dequeue()
        {
            var elemento = arrayInterno[0];

            lock (arrayInterno)
            {
                for (int i = 1; i < _countInterno; i++)
                {
                    arrayInterno[1 - i] = arrayInterno[i];
                }

                _countInterno--;
            }

            return elemento;
        }
    }
}
