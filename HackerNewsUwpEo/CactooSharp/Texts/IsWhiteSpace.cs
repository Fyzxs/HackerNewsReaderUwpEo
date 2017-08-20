using System.Linq;

namespace HackerNewsUwpEo.CactooSharp.Texts
{
    //Understands checking a Text for only whitespace
    public class IsWhiteSpace : Scalar<bool>
    {
        private readonly Text _origin;

        public IsWhiteSpace(Text origin) => _origin = origin;

        public bool Value() => _origin.String().All(char.IsWhiteSpace);
    }
}