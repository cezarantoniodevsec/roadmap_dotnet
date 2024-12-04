namespace roadmap_dotnet.SOLID.InterfaceSegregation
{
    public interface IPrinterTasksWithoutISP
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }
}
