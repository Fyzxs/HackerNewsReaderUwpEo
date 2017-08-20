using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Fakes
{

    public class FakeHttpRequestMessage : HttpRequestMessage
    {
        private readonly string _url;

        public FakeHttpRequestMessage(string url)
        {
            _url = url;
        }

        public bool Same(Uri uri) => uri.AbsoluteUri.Equals(_url, StringComparison.OrdinalIgnoreCase);
    }
    public class FakeHttpResponseMessage : HttpResponseMessage
    {
        public FakeHttpResponseMessage(HttpContent httpContent)
        {
            Content = httpContent;
        }
    }

    public class FakeRequestResponsePair
    {
        private readonly FakeHttpRequestMessage _request;
        private readonly FakeHttpResponseMessage _response;

        public FakeRequestResponsePair(FakeHttpRequestMessage request, FakeHttpResponseMessage response)
        {
            _request = request;
            _response = response;
        }

        public bool SameRequest(HttpRequestMessage request)
        {
            return _request.Same(request.RequestUri);
        }

        public Task<HttpResponseMessage> Response() => Task.FromResult(_response as HttpResponseMessage);
    }
    public class FakeResponseHandler : DelegatingHandler
    {
        private readonly List<FakeRequestResponsePair> _pairs;

        public FakeResponseHandler(FakeHttpRequestMessage request, FakeHttpResponseMessage response) :
            this(new List<FakeRequestResponsePair> { new FakeRequestResponsePair(request, response) })
        { }

        public FakeResponseHandler(List<FakeRequestResponsePair> pairs) => _pairs = pairs;

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            System.Threading.CancellationToken cancellationToken)
        {
            foreach (FakeRequestResponsePair pair in _pairs)
            {
                if (pair.SameRequest(request)) return pair.Response();
            }

            throw new Exception($"No Request matched for {RequestToString(request)}");
        }

        private string RequestToString(HttpRequestMessage request) => $"[method={request.Method}][uri={request.RequestUri}]";
    }
}
