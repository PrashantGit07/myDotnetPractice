// using System;
// class EmployeeClass
// {
//     public static void Main(string[] args)
//     {
//         List<Employee> employees = new List<Employee>()
//         {
//             new Employee{Id=1,name="Akash",age=20 , DpeartmentId=1},
//             new Employee { Id = 1, name = "Akash", age = 20, DpeartmentId=2 },
//             new Employee { Id = 2, name = "John", age = 25, DpeartmentId=3 },
//             new Employee { Id = 3, name = "Emma", age = 30, DpeartmentId=4 },
//             new Employee { Id = 4, name = "Michael", age = 28, DpeartmentId=5 },
//             new Employee { Id = 5, name = "Sophia", age = 22, DpeartmentId=6 },
//             new Employee { Id = 6, name = "David", age = 35, DpeartmentId=7 }

//         };

//         List<Department> departments = new List<Department>()
//         {
//             new Department{id=1 , name="Computer Science"},
//             new Department{id=2 , name="Engineering Science"},
//             new Department{id=3 , name="Management Science"},
//             new Department{id=4 , name="Arts"},
//             new Department{id=8 , name="Agriculture science"},
//             new Department{id=9 , name="Pharma dept"},
//             new Department{id=10 , name="Sports dept"},
//         };
//         //Filtering using Query Syntax

//         // var result = from s in employees
//         // where s.age > 28
//         // select s;



//         //Filtering using Method sysntax

//         // var result = employees.Where(x => x.age > 25).ToArray();

//         // var result2 = employees.Where(x => x.name.Contains("D")).ToArray();
//         // foreach (var i in result)
//         // {
//         //     System.Console.WriteLine(i.name);
//         //     System.Console.WriteLine();
//         //     System.Console.WriteLine();
//         // }

//         // foreach (var i in result2)
//         // {
//         //     System.Console.WriteLine(i.name);
//         // }



//         //Using Order By clauses

//         //Query Sytnax
//         // var result = from e in employees
//         //              orderby e.age
//         //              select e;

//         // foreach (var i in result)
//         // {
//         //     System.Console.WriteLine(i.name);
//         //     System.Console.WriteLine();
//         //     System.Console.WriteLine(i.age);
//         //     System.Console.WriteLine();
//         // }

//         //Method Syntax
//         // var result2 = employees.OrderBy(x => x.name);
//         // var result2 = employees.OrderBy(x => x.name).ThenBy(x => x.age);

//         // foreach (var i in result2)
//         // {
//         //     System.Console.WriteLine(i.name);
//         // }








//         //Joins in LINQ
//         var result = employees.Join(//outer squence
//             departments,   //Inner Sequence
//             employees => employees.DpeartmentId,    //Inner key selector
//             departments => departments.id,          //Outer key selector
//             (employees, departments) => new
//             {
//                 EmployeeName = employees.name,
//                 DepartmentName = departments.name
//             }
//         );

//         //now we will group them by name

//         var groupedResult = result.GroupBy(x => x.DepartmentName);

//         // foreach (var items in result)
//         // {
//         //     System.Console.WriteLine(items.EmployeeName + " " + items.DepartmentName);
//         // }

//         foreach (var items in groupedResult)
//         {
//             foreach (var item in items)
//             {
//                 System.Console.WriteLine(item.EmployeeName + ": " + item.DepartmentName);
//             }
//         }
//     }
// }

// public class Employee
// {
//     public int Id { get; set; }
//     public string? name { get; set; }
//     public int age { get; set; }
//     public int DpeartmentId { get; set; }

// }

// public class Department
// {
//     public int id { get; set; }
//     public string? name { get; set; }
// }