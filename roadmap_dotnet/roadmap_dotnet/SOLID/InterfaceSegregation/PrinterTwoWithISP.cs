namespace roadmap_dotnet.SOLID.InterfaceSegregation
{
    public class PrinterTwoWithISP : IPrinterTasksWithISP
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }

        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
    }
}
