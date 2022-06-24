using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string? Nome;
        public int Idade;

        public string Apresentar()
        {
            if (Nome == null || Idade <= 0)
            {
                return string.Format("Os valor de nome ou idade estão vazios ou nulos.");
            }
            else
            {
                return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
            }
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
