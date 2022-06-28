using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Gabriel");
            fila.Enqueue("Lucas");
            fila.Enqueue("Felipe");
            fila.Enqueue("Luis");

            Console.Write("Primero da fila: ");
            Console.WriteLine(fila.Peek());
            Console.Write("Pessoas na fila: ");
            Console.WriteLine(fila.Count);

            Console.Write("Pessoa retirada da fila: ");
            Console.WriteLine(fila.Dequeue());
            Console.Write("Pessoas na fila: ");
            Console.WriteLine(fila.Count);

            Console.WriteLine("Pessoas que ainda estão na fila: ");
            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

        }
    }
}
