namespace Lab6GenericCollectionsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employees = new Stack<Employee>();

            Employee employee1
                = new Employee(1, "Max", "Male", 43000m);
            Employee employee2
                = new Employee(1, "Fanny", "Female", 43000m);
            Employee employee3
                = new Employee(1, "Linnea", "Female", 43000m);
            Employee employee4
                = new Employee(1, "Tim", "Male", 43000m);

            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender}, {employee.Salary}");
            }

        }

       
    }
}
