using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Clients
{
    public class CacheClient : Client
    {
        private readonly Client _client;
        private Text _text;

        public CacheClient(string url) : this(new GetClient(url)) { }
        public CacheClient(Client client) => _client = client;

        public async Task<Text> Text() => _text ?? (_text = new TextOf(await _client.Text()));
    }
}