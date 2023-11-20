using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_2
{
    internal class Exercicio4
    {
        public void ExercicioBoxingFilas()
        {
            //iniciando listas
            var filaGenerics = new FilaGenerics<Animal>(10);
            var filaObject = new FilaObject(10);

            //instância das classes filhas
            Cachorro cachorro = new Cachorro();
            Gato gato = new Gato();

            //instância com box para tipo "pai"
            Animal cachorro2 = new Cachorro();
            Animal gato2 = new Gato();

            //instância com box para interface
            IBarulhento cachorro3 = new Cachorro();
            IBarulhento gato3 = new Gato();
        }
    }
}
