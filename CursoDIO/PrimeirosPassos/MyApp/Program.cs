namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Olá, {name}, estamos no dia {currentDate:d} as {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Aperte qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }
}