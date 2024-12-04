namespace roadmap_dotnet.SOLID.Liskov
{
    public class AppleWithoutLiskov
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
}
