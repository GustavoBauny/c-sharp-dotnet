using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        protected class Aluno
        {
            public string Nome = null!;
            public int Idade;
            public double Nota;
        }

        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno()
                {
                    Nome = "Pedro",
                    Idade = 24,
                    Nota = 8.0
                },
                new Aluno()
                {
                    Nome = "Andre",
                    Idade = 21,
                    Nota = 4.3
                },
                new Aluno()
                {
                    Nome = "Ana",
                    Idade = 25,
                    Nota = 9.5
                },
                new Aluno()
                {
                    Nome = "Jorge",
                    Idade = 20,
                    Nota = 8.5
                },
                new Aluno()
                {
                    Nome = "Gabriela",
                    Idade = 21,
                    Nota = 7.7
                },
                new Aluno()
                {
                    Nome = "Julia",
                    Idade = 22,
                    Nota = 7.5
                },
                new Aluno()
                {
                    Nome = "Marcio",
                    Idade = 18,
                    Nota = 6.8
                }
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"Nome do aluno: {pedro.Nome}\nNota do aluno: {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("\nPesquisando por Fulano = Aluno Inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"\nNota da Ana: {ana.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("\nPesquisando por Sicrano = Aluno Inexistente!");
            }

            var gabriela = alunos.First(aluno => aluno.Nome.Equals("Gabriela"));
            Console.WriteLine($"\nNota da Gabriela: {gabriela.Nota}");

            Console.WriteLine("\nAlunos no exemplo skip: ");
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine($"\nMaior nota: {maiorNota}");

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine($"\nMenor nota: {menorNota}");

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine($"\nSomatório das notas: {somatorioNotas}");

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine($"\nMédia da turma: {mediaDaTurma.ToString("N2")}");
        }
    }
}
