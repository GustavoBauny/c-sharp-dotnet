using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // herança ou mesmo projeto
        protected internal string CorDoOlho = "Verde";

        // mesmo projeto (assembly)
        internal string NumeroCelular = "55 11 999999999";

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias.";

        // mesma class ou herança no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Bla bla";

        // private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Sub Celebridade: ");

            Console.WriteLine($"Informação Pública: {InfoPublica}");
            Console.WriteLine($"Cor dos Olhos: {CorDoOlho}");
            Console.WriteLine($"Número do Celular: {NumeroCelular}");
            Console.WriteLine($"Jeito de Falar: {JeitoDeFalar}");
            Console.WriteLine($"Segredo de Família: {SegredoFamilia}");
            Console.WriteLine($"Usa muito Photoshop? {UsaMuitoPhotoshop}");
        }
    }
}
