using FluentAssertions;
using HackerNewsUwpEo.Clients;
using HackerNewsUwpEo.Jsons;
using HackerNewsUwpEo.Stories;
using HackerNewsUwpEo.Tests.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackerNewsUwpEo.Tests
{
    [TestClass]
    public class HighLevelTests
    {

        [TestMethod, TestCategory("integration")]
        public async Task ShouldGetStoryBack()
        {
            //Arrange
            FakeSetText fakeSet = new FakeSetText();
            FakeHttpRequestMessage fakeHttpRequestMessage = new FakeHttpRequestMessage("http://Not.a.real/url");
            FakeHttpResponseMessage fakeHttpResponseMessage = new FakeHttpResponseMessage(new StringContent(@"{""title"":""The Title""}"));
            FakeResponseHandler fakeResponseHandler = new FakeResponseHandler(fakeHttpRequestMessage, fakeHttpResponseMessage);

            Client client = new GetClient("http://Not.a.real/url", new HttpClient(fakeResponseHandler));

            Story story = new ClientStory(client);

            //Act
            await story.TitleInto(fakeSet);

            //Assert
            fakeSet.Assert(val => val.Should().Be("The Title"));
        }

        [TestMethod, TestCategory("functional")]
        public async Task ShouldMakeNetworkCall()
        {
            //Arrange
            FakeSetText fakeSetText = new FakeSetText();
            Story story = new ClientStory("8863");

            //Act
            await story.TitleInto(fakeSetText);

            //Assert
            fakeSetText.Assert(val => val.Should().Be("My YC app: Dropbox - Throw away your USB drive"));
        }

        [TestMethod, TestCategory("functional")]
        public async Task TopStories()
        {
            string result = new HttpClient().GetStringAsync("https://hacker-news.firebaseio.com/v0/topstories.json").Result;
            JArray jArray = JArray.Parse(result);


            Client client = new GetClient("https://hacker-news.firebaseio.com/v0/topstories.json");

            JsonParser jsonParser = await client.JsonParser();
        }
    }
}
