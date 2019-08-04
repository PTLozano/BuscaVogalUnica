using System;

namespace BuscaVogalUnica
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "aAbBABacfe";
            string message;

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);
            if (result == '\0')
                message = "Somente os caracteres entre A-Z e/ou a-z devem estar no texto.";
            else
                message = result.ToString();

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
