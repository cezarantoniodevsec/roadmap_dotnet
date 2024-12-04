namespace roadmap_dotnet.SOLID.InterfaceSegregation
{
    internal class PrintTwoWithoutISP
    {
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException("I don't have this function");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException("I don't have this function");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan");
        }
    }
}
