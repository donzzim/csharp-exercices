using System;
using System.Globalization;
using System.IO;

namespace ExercicioArquivosChatGPT
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\lucas\source\repos\students.csv";

            try
            {
                string sourceFolderPath = Path.GetDirectoryName(sourcePath);
                string targetFolderPath = Path.Combine(sourceFolderPath, "out");
                string targetFilePath = Path.Combine(targetFolderPath, "result.csv");

                Directory.CreateDirectory(targetFolderPath);

                using (StreamReader sr = File.OpenText(sourcePath))
                using (StreamWriter sw = File.CreateText(targetFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] fields = line.Split(',');

                        string name = fields[0];
                        double nota1 = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        double nota2 = double.Parse(fields[2], CultureInfo.InvariantCulture);

                        double media = (nota1 + nota2) / 2;
                        string situacao = media >= 6 ? "Aprovado" : "Reprovado";

                        sw.WriteLine(
                            $"{name},{media.ToString("F2", CultureInfo.InvariantCulture)},{situacao}"
                        );
                    }
                }

                Console.WriteLine("Arquivo result.csv criado com sucesso!");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro ao processar arquivo:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
