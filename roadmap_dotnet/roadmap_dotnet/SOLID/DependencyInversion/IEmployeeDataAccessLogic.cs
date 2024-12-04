namespace roadmap_dotnet.SOLID.DependencyInversion
{
    public interface IEmployeeDataAccessLogic
    {
        Employee GetEmployeeDetails(int id);
    }
}
