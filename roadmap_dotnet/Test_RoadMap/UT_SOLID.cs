using roadmap_dotnet.SOLID.DependencyInversion;
using roadmap_dotnet.SOLID.Liskov;

namespace Test_RoadMap
{
    public class UT_Solid
    {
        [Fact]
        public void testWithoutLiskov()
        {
            AppleWithoutLiskov apple = new OrangeWithoutLiskov();
            var actual = apple.GetColor();

            Assert.Equal("Orange", actual);
        }

        [Fact]
        public void testWithLiskov()
        {
            IFruit fruit = new OrangeWithLiskov();
            var actual = fruit.GetColor();

            Assert.Equal("Orange", actual);

            fruit = new AppleWithLiskov();
            actual = fruit.GetColor();

            Assert.Equal("Red", actual);
        }

        [Fact]
        public void testDIP()
        {
            EmployeeBusinessLogicWithDIP employeeBusinessLogic = new EmployeeBusinessLogicWithDIP();
            Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);

            var actual = emp.Department;
            Assert.Equal("IT", actual);
        }
    }
}