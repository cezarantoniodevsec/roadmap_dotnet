using roadmap_dotnet.DesignPatterns.Factory;

namespace roadmap_dotnet.DesignPatterns.FactoryMethod
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
