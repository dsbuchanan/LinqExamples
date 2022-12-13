using LinqExamples;

namespace LinqExxamplesTests
{
    public class EmployeeInfoTests
    {
        IEnumerable<Employee> employees = new Employee[5]
            {
                new Employee ( firstName: "Alex", city: "Brisbane", salary: 100000, level: "Consultant"),
                new Employee ( firstName: "Khoi", city: "Brisbane", salary: 120000, level: "Consultant"),
                new Employee ( firstName: "Sam",  city: "Brisbane", salary: 80000, level: "Analyst"),
                new Employee ( firstName: "Deepinder", city: "Melbourne", salary: 120000, level: "Consultant"),
                new Employee ( firstName: "Nicky", city: "Sydney", salary: 100000, level: "Analyst")
            };

        [Fact]
        public void TestEmployeesWithSalaryGreaterThan100K()
        {
            var employeesWithSalaryGreaterThan100K = EmployeeInfo.EmployeesWithSalaryGreaterThan100K(employees);
            Assert.Equal(2, employeesWithSalaryGreaterThan100K.Count());
        }

        [Fact]
        public void TestAverageConsultantSalaryInBrisbane()
        {
            var averageConsultantSalaryInBrisbane = EmployeeInfo.AverageConsultantSalaryInBrisbane(employees);
            Assert.Equal(110000, averageConsultantSalaryInBrisbane);
        }

        [Fact]
        public void TestEmployeesWithSalaryGreaterThan100KZero()
        {
            var employeesSubset = employees.Where(x => x.Salary <= 100000);
            var employeesWithSalaryGreaterThan100K = EmployeeInfo.EmployeesWithSalaryGreaterThan100K(employeesSubset);
            Assert.Equal(0, employeesWithSalaryGreaterThan100K.Count());
        }

        [Fact]
        public void TestAverageConsultantSalaryInBrisbaneZeroConsultants()
        {
            var employeesSubset = employees.Where(x => x.Level != "Consultant");
            var averageConsultantSalaryInBrisbane = EmployeeInfo.AverageConsultantSalaryInBrisbane(employeesSubset);
            Assert.Equal(0, averageConsultantSalaryInBrisbane);
        }

        [Fact]
        public void TestAverageConsultantSalaryInBrisbaneZeroBrisbane()
        {
            var employeesSubset = employees.Where(x => x.City != "Brisbane");
            var averageConsultantSalaryInBrisbane = EmployeeInfo.AverageConsultantSalaryInBrisbane(employeesSubset);
            Assert.Equal(0, averageConsultantSalaryInBrisbane);
        }
    }
}