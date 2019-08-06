using System.Collections.Generic;

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
            ValidChar validChar = new ValidChar();

            char vowel = '\0';
            bool isLastCharConsonant = false;

            while (input.HasNext())
            {
                char current = input.GetNext();

                if (validChar.IsVowel(current))
                {
                    if (validChar.IsNewChar(_vowelsList, current))
                    {
                        if (isLastCharConsonant)
                        {
                            vowel = current;
                        }
                    }
                    else if (vowel == current)
                    {
                        vowel = '\0';
                    }

                    _vowelsList.Add(current);
                    isLastCharConsonant = false;
                }
                else if (validChar.IsConsonant(current))
                {
                    isLastCharConsonant = true;
                }
                else
                {
                    // Caracter especial ou número
                    isLastCharConsonant = false;
                }
            }

            return vowel;
        }

    }
}
