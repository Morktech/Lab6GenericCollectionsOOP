namespace Lab6GenericCollectionsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<Employee> employees = new Stack<Employee>();

            // Five employee objects
            Employee employee1
                = new Employee(101, "Max", "Male", 33000m);
            Employee employee2
                = new Employee(102, "Fanny", "Female", 38000m);
            Employee employee3
                = new Employee(103, "Linnea", "Female", 45000m);
            Employee employee4
                = new Employee(104, "Tim", "Male", 39000m);
            Employee employee5
                = new Employee(105, "Sara", "Female", 40000m);

            // Pushes and stacks the employees 1-5
            employees.Push(employee1);
            employees.Push(employee2);
            employees.Push(employee3);
            employees.Push(employee4);
            employees.Push(employee5);

            // Prints every employee in the Stack
            // Counts the total amount of objects left in the stack,
            // each iteration.
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender}, {employee.Salary}");
                Console.WriteLine($"Employees in stack: {employees.Count}");
            }

            Console.WriteLine("Using Pop Method");

            // Temporary stack to hold the Pop:ed objects
            Stack<Employee> tempStack = new Stack<Employee>();


            // Pops the last added object until the stack reaches zero.
            // Pushes the objects to a temporary Stack
            while (employees.Count > 0)
            {
                Employee employee = employees.Pop();

                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender}, {employee.Salary}");
                Console.WriteLine(employees.Count);

                tempStack.Push(employee);
            }

            // Restores the original employee Stack
            while (tempStack.Count > 0)
            {
                Employee employee = tempStack.Pop();
                employees.Push(employee);
            }


            Console.WriteLine("Using Peek!");

            // Uses the method peek() for two iterations,
            // and prints the employee data.
            for (int i = 0; i < 2; i++)
            {
                Employee employee = employees.Peek();

                Console.WriteLine($"{employee.Id}, {employee.Name}, {employee.Gender}, {employee.Salary}");
                Console.WriteLine($"Left in Stack = {employees.Count}");
            }
            
            // Check if employee3 exists or not by using the method Contains()
            // Returning a boolean value true/false if the element exists.
            if (employees.Contains(employee3))
            {
                Console.WriteLine("Employee 3 is in the stack");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in the stack");
            }

            // A List to hold all employee objects
            List<Employee> employeesList = new List<Employee>();

            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);


            // Check if employee 2 exists
            if (employeesList.Contains(employee2))
            {
                Console.WriteLine("Employee2 exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 does not exist in the list");
            }


            // Finds the first employee with the Gender "Male" using a lambda expression
            Employee? firstMale = employeesList.Find(e => e.Gender == "Male");

            if (firstMale != null)
            {
                Console.WriteLine($"{firstMale.Id} {firstMale.Name} {firstMale.Gender} {firstMale.Salary}");
            }

            Console.WriteLine("All male objects:");

            // Using FindAll() followed by a lambda expression to find all employees whos Gender property is "Male"
            List<Employee> allMales = employeesList.FindAll(e => e.Gender == "Male");

            foreach (Employee employee in allMales)
            {
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.Gender} {employee.Salary}");
            }
        }

       
    }
}
