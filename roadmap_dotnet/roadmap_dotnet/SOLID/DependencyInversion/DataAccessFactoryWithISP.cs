namespace roadmap_dotnet.SOLID.DependencyInversion
{
    public class DataAccessFactoryWithISP
    {
        public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogicWithDIP();
        }
    }
}
