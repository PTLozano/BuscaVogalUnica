using System.Collections.Generic;
using System.Linq;

namespace BuscaVogalUnica
{
    /// <summary>
    /// Verifica o texto informado e valida os caracteres
    /// </summary>
    public class CheckText
    {
        private static List<char> _vowelsList = new List<char>();

        /// <summary>
        /// Busca a vogal que não se repete e está após uma consoante
        /// </summary>
        /// <param name="input">Informe o manipulador com o texto que deseja verificar</param>
        public static char FirstChar(IStream input)
        {
            char vowel = '\0';
            bool isLastCharConsonant = false;

            while (input.hasNext())
            {
                char current = input.getNext();

                if (IsVowel(current))
                {
                    if (isLastCharConsonant)
                    {
                        if (IsNewChar(current))
                        {
                            vowel = current;
                        }
                    }

                    _vowelsList.Add(current);
                    isLastCharConsonant = false;
                }
                else if (IsConsonant(current))
                {
                    isLastCharConsonant = true;
                }
                else
                {
                    return '\0';
                }
            }

            return vowel;
        }

        private static bool IsConsonant(char letter)
        {
            if ((letter > 65 && letter < 91 ||
                letter > 97 && letter < 123) && !IsVowel(letter)) return true;

            return false;
        }

        private static bool IsVowel(char letter)
        {
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if (letter == vowels[i]) return true;
            }

            return false;
        }

        private static bool IsNewChar(char letter) => _vowelsList.Where(c => c == letter).Count() == 0;
    }
}
