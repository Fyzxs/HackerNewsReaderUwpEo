namespace HackerNewsUwpEo.Jsons
{
    public interface Json
    {
        T Value<T>(string key);
    }
}