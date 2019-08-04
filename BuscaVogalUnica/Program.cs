using System;

namespace BuscaVogalUnica
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "aAbBABacfe";

            IStream stream = new ManipulateText(test);
            char result = CheckText.FirstChar(stream);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
