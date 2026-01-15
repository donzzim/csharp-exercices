using System;
using System.Collections.Generic;
using System.Text;

namespace ReceitaFederal.Entities
{
    internal class PessoaJuridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string nome, double renda, int funcionarios): base(nome, renda)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto(double renda)
        {
            double porcentagem = Funcionarios > 10 ? 0.14 : 0.16;

            return renda * porcentagem;

        }

        public override string ToString() 
        {
            return $"Nome: {Nome} \n Renda Anual: {Renda} \n Funcionários: {Funcionarios} \n Imposto a pagar: {Imposto(Renda)}";
        }
    }
}
