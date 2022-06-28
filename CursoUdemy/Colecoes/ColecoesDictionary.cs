using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2006: " + filmes.GetValueOrDefault(2006));
            }

            Console.WriteLine($"Contém o filme Amnésia? {filmes.ContainsValue("Amnésia")}");

            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            filmes.TryGetValue(2000, out string? filme2000);
            Console.WriteLine($"Filme: {filme2000}!");

            Console.WriteLine("\nAs datas de lançamento disponíveis são: ");
            foreach (var chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            Console.WriteLine("\nOs filmes disponíveis são: ");
            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("\nOs filmes e suas datas de lançamento são: ");
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

        }
    }
}
