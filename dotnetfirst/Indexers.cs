// //To access the properties of  a class from another class without inheritence and also access using indexes 
// //we use idnexers , using indexers the class starts behaving like a virtual array
// //Syntax ---->>>  
// //  [<Modifier>] <type> this[index]{
// //[get{<statements>}]      -->> get accessor
// //[set{<statements>}]      -->> set accessor
// //  }

// using System;
// using indexs;
// namespace indexs
// {
//     public class Employee
//     {
//         int no;
//         double salary;
//         string? name, job, location;

//         public Employee(int no, double salary, string name, string? job, string? location)
//         {
//             this.no = no;
//             this.salary = salary;
//             this.name = name;
//             this.job = job;
//             this.location = location;

//         }

//         public object this[int index]
//         {

//             get
//             {
//                 if (index == 0)
//                     return no;
//                 else if (index == 1)
//                     return name ?? "";
//                 else if (index == 2)
//                     return salary;
//                 else if (index == 3)
//                     return location ?? "";
//                 else if (index == 4)
//                     return job ?? "";
//                 return null ?? "";
//             }

//             set
//             {
//                 if (index == 0)
//                     no = (int)value;
//                 else if (index == 1)
//                     name = (string)value;
//                 else if (index == 2)
//                     salary = (double)value;
//                 else if (index == 3)
//                     location = (string)value;
//                 else if (index == 4)
//                     job = (string)value;

//             }
//         }
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Employee employee = new Employee(100, 50035.25, "David", "DevOps", "Lucknow");
//         // System.Console.WriteLine(employee[0]);   -- can not apply indexing with employee type , now by using indexers , we can make it possible
//         PrintDetails(employee);
//         System.Console.WriteLine("-----------------------");
//         employee[0] = 455;
//         employee[1] = "Sohan";
//         employee[2] = 4584.25;
//         employee[3] = "Developer";
//         employee[4] = "Mumbai";
//         PrintDetails(employee);

//     }
//     public static void PrintDetails(Employee employee)
//     {
//         System.Console.WriteLine("Employee number : " + employee[0]);
//         System.Console.WriteLine("Employee name : " + employee[1]);
//         System.Console.WriteLine("Employee salary : " + employee[2]);
//         System.Console.WriteLine("Employee job : " + employee[3]);
//         System.Console.WriteLine("Employee job location : " + employee[4]);
//     }
// }