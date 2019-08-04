namespace BuscaVogalUnica
{
    public class ManipulateText : IStream
    {
        private string _text;
        private int _count;
        private int _total;

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
