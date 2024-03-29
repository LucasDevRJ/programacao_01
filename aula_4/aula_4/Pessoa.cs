﻿namespace aula_4
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is not Pessoa) 
            {
                return false;
            }

            return ((Pessoa)obj).Id == Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}