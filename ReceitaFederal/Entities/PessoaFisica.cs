using System;
using System.Collections.Generic;
using System.Text;

namespace ReceitaFederal.Entities
{
    internal class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double renda, double gastosSaude):base(nome, renda)
        {
            GastosSaude = gastosSaude;
        }

        public override double Imposto(double renda)
        {
            double imposto = renda < 20000.00 ? imposto = renda * 0.15 : imposto = renda * 0.25;
            double desconto = GastosSaude != 0 ? GastosSaude/2 : 0;

            imposto -= desconto;

            return imposto;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} \n Renda Anual: {Renda} \n Gastos com saúde: {GastosSaude} \n Imposto a pagar: {Imposto(Renda)}";
        }
    }
}
