using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1
{
    internal class ClasseComplexa : ImprimirValores
    {
        protected int PropInt { get; set; }
        protected bool PropBool { get; set; }
        public decimal MeuDecimal { get; set; }

        protected DateTime dataAtual;
        float floatField;

        public Direcoes Direcao { get; set; }
        public int PropInterface { get; set; }

        public enum Direcoes
        {
            Cima = 1,
            Baixo = 10,
            LadoEsquerdo = 20,
            LadoDireito = 67
        }
    }
}
