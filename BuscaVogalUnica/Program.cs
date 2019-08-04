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
                message = "Caracter não está entre A-Z e a-z";
            else
                message = result.ToString();

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
