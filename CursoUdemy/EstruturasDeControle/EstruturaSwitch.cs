using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar() {
            Console.Write("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    Console.WriteLine("Obrigado por responder!");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    Console.WriteLine("Obrigado por responder!");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    Console.WriteLine("Obrigado por responder!");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    Console.WriteLine("Obrigado por responder!");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    Console.WriteLine("Obrigado por responder!");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    Console.WriteLine("Favor responder uma nota válida!");
                    break;
            }

        }
    }
}
