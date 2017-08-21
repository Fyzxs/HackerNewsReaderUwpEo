using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.CactooSharp.Texts;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Clients
{
    public class GetClient : Client
    {
        private readonly string _url;
        private readonly HttpClient _client;

        public GetClient(string url) : this(url, new HttpClient()) { }

        public GetClient(string url, HttpClient client)
        {
            _url = url;
            _client = client;
        }

        public async Task<Text> Text() => new TextOf(await _client.GetStringAsync(_url));
    }
}