using System;

namespace BuscaVogalUnica
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aAbBABacfe";
            string message;

            IStream stream = new ManipulateText(text);
            char result = CheckText.FirstChar(stream);
            if (result != '\0')
                message = $"A vogal única encontrada no texto {text} é: {result.ToString()}";
            else
                message = $"Não foi possível encontrar nenhuma vogal que esteja em seguida de uma vogal e que seja única no texto: {text}.";

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
