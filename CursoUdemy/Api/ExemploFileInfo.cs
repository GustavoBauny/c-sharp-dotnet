using System;
using System.IO;

namespace CursoCSharp.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.Write("Nome do arquivo: ");
            Console.WriteLine(origem.Name);
            Console.Write("\nO Arquivo é somente leitura? ");
            Console.WriteLine(origem.IsReadOnly);
            Console.Write("\nNome completo do arquivo: ");
            Console.WriteLine(origem.FullName);
            Console.Write("\nQual é o tipo do arquivo? ");
            Console.WriteLine(origem.Extension);
            Console.Write("\nO nome do diretório do arquivo: ");
            Console.WriteLine(origem.DirectoryName);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
