namespace roadmap_dotnet.Linq.Models
{
    public class Clump<T> : List<T>
    {
        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return Enumerable.Where(this, predicate).Take(1);
        }
    }
}
