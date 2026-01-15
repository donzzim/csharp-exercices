using ReceitaFederal.Entities;
using System.Globalization;

namespace ReceitaFederal
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Pessoa> list = new List<Pessoa>();

            Console.Write("Informe o número de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Pessoa #{i}: ");

                Console.Write("Pessoa Física ou Jurídica?(f/j)");
                char p = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (p == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastos = double.Parse(Console.ReadLine());

                    list.Add(new PessoaFisica(nome, renda, gastos));
                }

                if (p == 'j')
                {
                    Console.Write("Número de funcionários: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, renda, funcionarios));
                }
            }

            Console.WriteLine();

            foreach (Pessoa pessoa in list)
            {
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine();
            }
        }
    }
}