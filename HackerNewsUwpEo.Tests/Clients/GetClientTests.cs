using FluentAssertions;
using HackerNewsUwpEo.CactooSharp;
using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests.Clients
{
    [TestClass]
    public class GetClientTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldReturnText()
        {
            //Arrange
            FakeHttpRequestMessage fakeHttpRequestMessage = new FakeHttpRequestMessage("http://Not.a.real/url");
            FakeHttpResponseMessage fakeHttpResponseMessage = new FakeHttpResponseMessage(new StringContent(@"{""title"":""The Title""}"));
            FakeResponseHandler fakeResponseHandler = new FakeResponseHandler(fakeHttpRequestMessage, fakeHttpResponseMessage);

            Client client = new GetClient("http://Not.a.real/url", new HttpClient(fakeResponseHandler));
            Text text = await client.Text();

            //Act
            string value = text.String();

            //Assert
            value.Should().Be(@"{""title"":""The Title""}");
        }
    }
}