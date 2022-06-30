using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine($"Tipo de arquivo: {Path.GetExtension(arquivo)}");
            Console.WriteLine($"\nNome do arquivo: {Path.GetFileName(arquivo)}");
            Console.WriteLine($"\nNome do arquivo sem extensão: {Path.GetFileNameWithoutExtension(arquivo)}");
            Console.WriteLine($"\nNome do diretório: {Path.GetDirectoryName(arquivo)}");
            Console.WriteLine($"\nO arquivo possui extensão? {Path.HasExtension(arquivo)}");

            Console.WriteLine($"\nA pasta possui extensão? {Path.HasExtension(pasta)}");
            Console.WriteLine($"\nCaminho da pasta: {Path.GetFullPath(pasta)}");
            Console.WriteLine($"\nCaminho da root: {Path.GetPathRoot(pasta)}");
        }
    }
}
