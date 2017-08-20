namespace HackerNewsUwpEo.Jsons
{
    public interface JsonArray
    {
        T Next<T>();
        int Count();
    }
}