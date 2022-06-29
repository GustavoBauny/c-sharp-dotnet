using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos()
        {
            Console.WriteLine("\n Amigo Próximo: ");

            Console.WriteLine($"Informação Pública: {amiga.InfoPublica}");
            Console.WriteLine($"Cor dos Olhos: {amiga.CorDoOlho}");
            Console.WriteLine($"Número do Celular: {amiga.NumeroCelular}");
            Console.WriteLine($"Jeito de Falar: {amiga.JeitoDeFalar}");
            // Console.WriteLine($"Segredo de Família: {amiga.SegredoFamilia}");
            // Console.WriteLine($"Usa muito Photoshop? {amiga.UsaMuitoPhotoshop}");
        }
    }
}
