using System.Collections.Generic;
using System.Linq;

namespace BuscaVogalUnica
{
    class ValidChar
    {
        /// <summary>
        /// Verifica se o caracter é consoante
        /// </summary>
        /// <param name="letter">Caracter que deseja verificar</param>
        public bool IsConsonant(char letter)
        {
            if ((letter > 65 && letter < 91 ||
                letter > 97 && letter < 123) && !IsVowel(letter)) return true;

            return false;
        }

        /// <summary>
        /// Verifica se o caracter é vogal
        /// </summary>
        /// <param name="letter">Caracter que deseja verificar</param>
        public bool IsVowel(char letter)
        {
            char[] vowels = new char[] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
            {
                if (letter == vowels[i]) return true;
            }

            return false;
        }

        /// <summary>
        /// Verifica se o caracter é novo
        /// </summary>
        /// <param name="letter">Caracter que deseja verificar</param>
        public bool IsNewChar(IEnumerable<char> vowelsList, char letter) => vowelsList.Where(c => c == letter).Count() == 0;
    }
}
