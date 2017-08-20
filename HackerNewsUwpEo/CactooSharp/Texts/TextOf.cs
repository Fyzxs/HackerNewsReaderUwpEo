using System.IO;
using System.Text;

namespace HackerNewsUwpEo.CactooSharp.Texts
{
    //Understands transforming input into strings

    public class TextOf : Text
    {
        private readonly Text _origin;

        public TextOf(byte[] origin) : this(new DelayedText(() => Encoding.ASCII.GetString(origin))) { }
        public TextOf(string origin) : this(new DelayedText(() => origin)) { }

        public TextOf(Text origin) => _origin = origin;

        public TextOf(Stream origin) : this(new DelayedText(() => new StreamReader(origin).ReadToEnd())) { }

        public string String() => _origin.String();
    }
}