namespace LinqExamples
{
    public class EmployeeInfo
    {
        public static IEnumerable<Employee> EmployeesWithSalaryGreaterThan100K(IEnumerable<Employee> employees)
        {
            return employees.Where(x => x.Salary > 100000);
        }

        public static double AverageConsultantSalaryInBrisbane(IEnumerable<Employee> employees)
        {
            var result = employees.Where(x => x.Level == "Consultant" && x.City == "Brisbane");
            return result.Count() > 0 ? EmployeeInfoHelper.AverageSalary(result) : 0;
        }
    }
}