using System;
class EmployeeClass
{
    int id { get; set; }
    string? name { get; set; }
    string? department { get; set; }
    double salary { get; set; }


    List<EmployeeClass> employees = new List<EmployeeClass>();


    //Create ===============================



    public void CreateEmployee()
    {
        System.Console.WriteLine("Enter the name of the employee : ");
        string? Ename = Console.ReadLine();



        System.Console.WriteLine("Enter the department of Employee  :");
        string? Edepartment = Console.ReadLine();

        System.Console.WriteLine("Enter the salary of the employee :");
        int Esalary = Convert.ToInt32(Console.ReadLine());


        EmployeeClass employeeClass = new EmployeeClass
        {
            id = employees.Count + 1,
            name = Ename,
            salary = Esalary,
            department = Edepartment
        };
        employees.Add(employeeClass);
        System.Console.WriteLine("Employee created successfully");
    }


    //Read================


    public void DisplayEmployeeDetails()
    {
        if (employees.Count < 0)
        {
            System.Console.WriteLine("No Employee is here");
        }
        else
        {
            foreach (var employee in employees)
            {
                System.Console.WriteLine("Employee id " + employee.id);
                System.Console.WriteLine("Employee name " + employee.name);
                System.Console.WriteLine("Employee department " + employee.department);
                System.Console.WriteLine("Employee salary " + employee.salary);
            }
        }
    }


    //Update======================


    public void UpdateEmployee()
    {
        System.Console.WriteLine("Enter the id of the employee : ");
        int uid = Convert.ToInt32(Console.ReadLine());

        EmployeeClass updatedEmployee = employees.Find(emp => emp.id == uid);
        if (updatedEmployee == null)
        {
            System.Console.WriteLine("Employee not found");
            return;
        }
        System.Console.WriteLine("Enter the updated name of the employee : ");
        string? Uname = Console.ReadLine();

        updatedEmployee.name = Uname;

        System.Console.WriteLine("Enter the updated department of Employee  :");
        string? Udepartment = Console.ReadLine();

        updatedEmployee.department = Udepartment;

        System.Console.WriteLine("Enter the updated salary of the employee :");
        int Usalary = Convert.ToInt32(Console.ReadLine());

        updatedEmployee.salary = Usalary;


        System.Console.WriteLine("Emplyee updated successfully");
        System.Console.WriteLine("Details of new employee : ");

        updatedEmployee.DisplayEmployeeDetails();

    }


    //delet =====================
    public void DeleteEmployee()
    {
        System.Console.WriteLine("Emter the id of the employee :");
        int delId = Convert.ToInt32(Console.ReadLine());

        EmployeeClass deleteEmployee = employees.Find(emp => emp.id == delId);

        if (deleteEmployee == null)
        {
            System.Console.WriteLine("No such employee exist");
            return;
        }

        employees.Remove(deleteEmployee);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        EmployeeClass employeeClass = new EmployeeClass();

        while (true)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View All Employees");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    employeeClass.CreateEmployee();
                    break;
                case 2:
                    employeeClass.DisplayEmployeeDetails();
                    break;
                case 3:
                    employeeClass.UpdateEmployee();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Invalid choice");
                    break;
            }

        }
    }
}