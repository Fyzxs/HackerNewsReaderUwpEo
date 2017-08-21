using FluentAssertions;
using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Jsons;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;
using System.Threading.Tasks;
using HackerNewsUwpEo.Clients.Json;

namespace HackerNewsUwpEo.Tests.Clients.Json
{
    [TestClass]
    public class JsonClientTests
    {
        [TestMethod, TestCategory("unit")]
        public async Task ShouldReturnJsonObject()
        {
            //Arrange
            FakeHttpRequestMessage fakeHttpRequestMessage = new FakeHttpRequestMessage("http://Not.a.real/url");
            FakeHttpResponseMessage fakeHttpResponseMessage = new FakeHttpResponseMessage(new StringContent(@"{""title"":""The Title""}"));
            FakeResponseHandler fakeResponseHandler = new FakeResponseHandler(fakeHttpRequestMessage, fakeHttpResponseMessage);

            JsonClient client = new DefaultJsonClient(new GetClient("http://Not.a.real/url", new HttpClient(fakeResponseHandler)), new NewtonSoftJsonParser());
            JsonObject jobj = await client.JsonObject();

            //Act
            string title = jobj.Value<string>("title");

            //Assert
            title.Should().Be("The Title");
        }

        [TestMethod, TestCategory("unit")]
        public async Task ShouldReturnJsonArray()
        {
            //Arrange
            FakeHttpRequestMessage fakeHttpRequestMessage = new FakeHttpRequestMessage("http://Not.a.real/url");
            FakeHttpResponseMessage fakeHttpResponseMessage = new FakeHttpResponseMessage(new StringContent(@"[123, 456, 789]"));
            FakeResponseHandler fakeResponseHandler = new FakeResponseHandler(fakeHttpRequestMessage, fakeHttpResponseMessage);

            JsonClient client = new DefaultJsonClient(new GetClient("http://Not.a.real/url", new HttpClient(fakeResponseHandler)), new NewtonSoftJsonParser());
            JsonArray jsonArray = await client.JsonArray();

            //Act
            string first = jsonArray.Next<string>();

            //Assert
            first.Should().Be("123");
        }
    }
}