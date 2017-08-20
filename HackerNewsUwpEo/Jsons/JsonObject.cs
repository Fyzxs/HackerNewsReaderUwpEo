namespace HackerNewsUwpEo.Jsons
{
    public interface JsonObject
    {
        T Value<T>(string key);
    }
}