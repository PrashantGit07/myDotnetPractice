// // using System;
// //using get and set explicitly
// public class Person
// {
//     private string? greet;

//     public string Name
//     {
//         get
//         {
//             return greet??"";
//         }
//         set
//         {
//             greet = value;
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Person person = new Person();

//         // Set the name using the set accessor
//         person.Name = "Hello";

//         // Get the name using the get accessor
//         Console.WriteLine("Name: " + person.Name);
//     }
// }




// //automatic get and set


// using System;

// public class Car
// {
//     public string? Make { get; set; }
//     public string? Model { get; set; }
//     public int Year { get; set; }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car();

//         // Set properties using the set accessor
//         car.Make = "TATA";
//         car.Model = "Mahindra";
//         car.Year = 2020;

//         // Get properties using the get accessor
//         System.Console.WriteLine("car details :");
//         System.Console.WriteLine(car.Make);
//         System.Console.WriteLine(car.Model);
//         System.Console.WriteLine(car.Year);
//     }
// }
