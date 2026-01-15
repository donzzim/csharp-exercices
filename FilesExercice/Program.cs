using System;
using System.Globalization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe o caminho do arquivo CSV: ");
        string sourcePath = Console.ReadLine();

        try
        {
            string sourceFolder = Path.GetDirectoryName(sourcePath);

            string outFolder = Path.Combine(sourceFolder, "out");
            Directory.CreateDirectory(outFolder);

            string targetPath = Path.Combine(outFolder, "summary.csv");

            using (StreamReader sr = new StreamReader(sourcePath))
            using (StreamWriter sw = new StreamWriter(targetPath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] fields = line.Split(',');

                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2]);

                    double total = price * quantity;

                    sw.WriteLine($"{name},{total.ToString("F2", CultureInfo.InvariantCulture)}");
                }
            }

            Console.WriteLine("Arquivo summary.csv criado com sucesso!");
        }
        catch (IOException e)
        {
            Console.WriteLine("Erro ao processar o arquivo:");
            Console.WriteLine(e.Message);
        }
    }
}
