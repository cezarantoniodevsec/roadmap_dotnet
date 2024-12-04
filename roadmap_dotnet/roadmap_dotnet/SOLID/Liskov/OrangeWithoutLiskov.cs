namespace roadmap_dotnet.SOLID.Liskov
{
    public class OrangeWithoutLiskov: AppleWithoutLiskov
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
