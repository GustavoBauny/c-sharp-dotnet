using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine($"Dia: {dateTime.Day}");
            Console.WriteLine($"\nMês: {dateTime.Month}");
            Console.WriteLine($"\nAno: {dateTime.Year}");

            // Sem horas
            var hoje = DateTime.Today;
            Console.WriteLine($"\nDia de hoje (sem horas): {hoje}");

            // Com horas
            var diaAtual = DateTime.Now;
            Console.WriteLine($"\nDia de hoje (com horas): {diaAtual}");
            Console.WriteLine($"\nHoras: {diaAtual.Hour}");
            Console.WriteLine($"\nMinutos: {diaAtual.Minute}");

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine($"\nHorário de amanhã: {amanha}");

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine($"\nHorário de ontem: {ontem}");

            Console.WriteLine($"\nDia atual: {diaAtual.ToString("dd")}");
            Console.WriteLine($"\nDia atual completo: {diaAtual.ToString("d")}");
            Console.WriteLine($"\nDia atual descritivo: {diaAtual.ToString("D")}");
            Console.WriteLine($"\nDia atual e horário: {diaAtual.ToString("g")}");
            Console.WriteLine($"\nDia atual e horário com segundos: {diaAtual.ToString("G")}");
            Console.WriteLine($"\nDia atual e horário (formatação diferente): {diaAtual.ToString("dd-MM-yyyy HH:mm")}");
        }
    }
}
