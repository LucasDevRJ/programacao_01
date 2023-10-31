using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1
{
    internal class ClasseComplexa
    {
        public int PropInt { get; set; }
        public bool PropBool { get; set; }
        public decimal MeuDecimal { get; set; }

        DateTime dataAtual;
        float floatField;

        public Direcoes Direcao { get; set; }

        public enum Direcoes
        {
            Cima = 1,
            Baixo = 10,
            LadoEsquerdo = 20,
            LadoDireito = 67
        }
    }
}
