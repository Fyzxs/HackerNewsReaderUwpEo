using System;

namespace HackerNewsUwpEo.CactooSharp.Texts
{
    //Understands checking a text for nulls
    public class NotNull : Text
    {
        private readonly Text _origin;

        public NotNull(Text origin) => _origin = origin;

        public string String()
        {
            if (_origin == null) throw new Exception("NULL instead of a valid text");
            if (_origin.String() == null) throw new Exception("NULL instead of a valid result string");
            return _origin.String();
        }
    }
}
