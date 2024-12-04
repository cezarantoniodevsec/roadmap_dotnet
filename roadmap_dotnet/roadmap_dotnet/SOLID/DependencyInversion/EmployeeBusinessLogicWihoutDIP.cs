namespace roadmap_dotnet.SOLID.DependencyInversion
{
    public class EmployeeBusinessLogicWihoutDIP
    {
        EmployeeDataAccessLogicWithoutDIP _EmployeeDataAccessLogic;
        public EmployeeBusinessLogicWihoutDIP()
        {
            _EmployeeDataAccessLogic = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccessLogic.GetEmployeeDetails(id);
        }
    }
}
