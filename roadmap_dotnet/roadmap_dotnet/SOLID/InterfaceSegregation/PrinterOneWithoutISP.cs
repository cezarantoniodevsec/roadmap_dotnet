namespace roadmap_dotnet.SOLID.InterfaceSegregation
{
    internal class PrinterOneWithoutISP : IPrinterTasksWithoutISP
    {
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax");
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine("Print");
        }

        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex");
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan");
        }
    }
}
