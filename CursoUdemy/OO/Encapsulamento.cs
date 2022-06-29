using System;
using Encapsulamento;

namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("\nFilho Não Reconhecido: ");

            Console.WriteLine($"Informação Pública: {InfoPublica}");
            Console.WriteLine($"Cor dos Olhos: {CorDoOlho}");
            // Console.WriteLine($"Número do Celular: {NumeroCelular}");
            Console.WriteLine($"Jeito de Falar: {JeitoDeFalar}");
            // Console.WriteLine($"Segredo de Família: {SegredoFamilia}");
            // Console.WriteLine($"Usa muito Photoshop? {UsaMuitoPhotoshop}");
        }
    }

    public class AmigoDistante
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\nAmigo Distante: ");

            Console.WriteLine($"Informação Pública: {amiga.InfoPublica}");
            // Console.WriteLine($"Cor dos Olhos: {amiga.CorDoOlho}");
            // Console.WriteLine($"Número do Celular: {amiga.NumeroCelular}");
            // Console.WriteLine($"Jeito de Falar: {amiga.JeitoDeFalar}");
            // Console.WriteLine($"Segredo de Família: {amiga.SegredoFamilia}");
            // Console.WriteLine($"Usa muito Photoshop? {amiga.UsaMuitoPhotoshop}");
        }
    }

    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
