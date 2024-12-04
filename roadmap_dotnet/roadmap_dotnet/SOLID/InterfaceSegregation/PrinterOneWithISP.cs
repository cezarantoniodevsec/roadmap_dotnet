namespace roadmap_dotnet.SOLID.InterfaceSegregation
{
    internal class PrinterOneWithISP : IPrinterTasksWithISP, IPrintDuplexTasksWithISP, IFaxTasksWithISP
    {
        public void Fax(string content)
        {
            Console.WriteLine(content);
        }

        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
    }
}
