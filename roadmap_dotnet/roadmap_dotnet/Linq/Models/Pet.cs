namespace roadmap_dotnet.Linq.Models
{
    internal class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person Owner { get; set; } 
    }
}
