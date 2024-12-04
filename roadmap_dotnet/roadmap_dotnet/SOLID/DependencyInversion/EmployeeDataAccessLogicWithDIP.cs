namespace roadmap_dotnet.SOLID.DependencyInversion
{
    public class EmployeeDataAccessLogicWithDIP : IEmployeeDataAccessLogic
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}
