using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class FilhoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("\nFilho Reconhecido: ");

            Console.WriteLine($"Informação Pública: {InfoPublica}");
            Console.WriteLine($"Cor dos Olhos: {CorDoOlho}");
            Console.WriteLine($"Número do Celular: {NumeroCelular}");
            Console.WriteLine($"Jeito de Falar: {JeitoDeFalar}");
            Console.WriteLine($"Segredo de Família: {SegredoFamilia}");
            // Console.WriteLine($"Usa muito Photoshop? {UsaMuitoPhotoshop}");
        }
    }
}
