namespace roadmap_dotnet.SOLID.DependencyInversion
{
    public class EmployeeBusinessLogicWithDIP
    {
        IEmployeeDataAccessLogic _IEmployeeDataAccessLogic;
        public EmployeeBusinessLogicWithDIP()
        {
            _IEmployeeDataAccessLogic = DataAccessFactoryWithISP.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _IEmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
