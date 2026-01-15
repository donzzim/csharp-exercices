using System;
using System.Collections.Generic;
using System.Text;

namespace ReceitaFederal.Entities
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }
        public double Renda { get; set; }

        public Pessoa(string nome, double renda)
        {
            Nome = nome;
            Renda = renda;
        }

        public abstract double Imposto(double renda);

    }
}
