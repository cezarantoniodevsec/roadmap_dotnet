namespace roadmap_dotnet.SOLID.Liskov
{
    public class AppleWithLiskov : IFruit
    {
        public string GetColor()
        {
            return "Red";
        }
    }
}
