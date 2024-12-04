namespace roadmap_dotnet.SOLID.InterfaceSegregation
{
    public interface IPrinterTasksWithISP
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    public interface IFaxTasksWithISP
    {
        void Fax(string content);
    }
    public interface IPrintDuplexTasksWithISP
    {
        void PrintDuplex(string content);
    }
}
