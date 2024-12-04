namespace roadmap_dotnet.SOLID.DependencyInversion
{
    public class DataAccessFactory
    {
        public static EmployeeDataAccessLogicWithoutDIP GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogicWithoutDIP();
        }
    }
}
