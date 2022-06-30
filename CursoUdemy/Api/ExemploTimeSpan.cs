using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api
{
    class ExemploTimeSpan
    {
        public static void Executar()
        {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine($"Intervalo completo: {intervalo}");

            Console.WriteLine($"\nMinutos: {intervalo.Minutes}");
            Console.WriteLine($"\nIntervalo em Minutos: {intervalo.TotalMinutes}");

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine($"\nDuração: {tempo}");

            Console.WriteLine($"\nAumentando 8 minutos no intervalo: {intervalo.Add(TimeSpan.FromMinutes(8))}");
            Console.WriteLine($"\nDiminuindo 8 minutos no intervalo: {intervalo.Subtract(TimeSpan.FromMinutes(8))}");

            Console.WriteLine($"\nToString 1: {intervalo.ToString("g")}");
            Console.WriteLine($"\nToString 2: {intervalo.ToString("G")}");
            Console.WriteLine($"\nToString 3: {intervalo.ToString("c")}");

            Console.WriteLine($"\nParse: {TimeSpan.Parse("01:02:03").TotalMilliseconds}");
        }
    }
}
