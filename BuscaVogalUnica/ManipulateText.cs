namespace BuscaVogalUnica
{
    /// <summary>
    /// Percorre o texto pelos caracteres
    /// </summary>
    public class ManipulateText : IStream
    {
        private string _text;
        private int _count;
        private int _total;

        /// <summary>
        /// Manipula o texto informado
        /// </summary>
        /// <param name="text">Informe o texto que deseja verificar os caracteres</param>
        public ManipulateText(string text)
        {
            _text = text;
            _count = 0;
            _total = text.Length;
        }

        public char getNext() => _text[_count++];

        public bool hasNext()
        {
            if (string.IsNullOrEmpty(_text)) return false;

            return _count + 1 <= _total;
        }
    }
}
