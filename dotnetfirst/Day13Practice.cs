// using System;

// public class SampleClass
// {
//     private static int instanceCount = 0;  // Counter to keep track of instances

//     private int[] data = new int[5];

// Declare an indexer
//     public int this[int index]
//     {
//         get
//         {
// Accessor: return value at the specified index
//             return data[index];
//         }
//         set
//         {
// Mutator: set value at the specified index
//             data[index] = value;
//         }
//     }

// Constructor
//     public SampleClass()
//     {
//         instanceCount++;  // Increment the instance count when an object is created
//     }

// Property to get the instance count
//     public static int InstanceCount
//     {
//         get { return instanceCount; }
//     }
// }\










// class Program
// {
//     static void Main()
//     {
//         SampleClass sample = new SampleClass();  // One object created

// Using the indexer to set values
//         sample[0] = 1;
//         sample[1] = 2;
//         sample[2] = 3;

// Using the indexer to get values
//         Console.WriteLine(sample[0]); // Output: 1
//         Console.WriteLine(sample[1]); // Output: 2
//         Console.WriteLine(sample[2]); // Output: 3

// Check the number of instances created
//         Console.WriteLine($"Number of instances created: {SampleClass.InstanceCount}");
//     }
// }








//constructor and destructor practice

// using System;
// class Student
// {
//     public string? name { get; set; }
//     public int age { get; set; }
//     public char grade { get; set; }



//     public Student(string name, char grade, int age)
//     {
//         this.name = name;
//         this.grade = grade;
//         this.age = age;
//     }

//     ~Student()
//     {
//         System.Console.WriteLine("student record is saved and now memory is free");
//     }
// }

// class StudentData
// {
//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("enter details of student -->>");

//         System.Console.Write("name ->>  ");
//         string name = Console.ReadLine() ?? " ";

//         System.Console.Write("Grade ->>  ");

//         char grade = Convert.ToChar(Console.ReadLine());

//         System.Console.Write("Age ->>  ");

//         int age = Convert.ToInt32(Console.ReadLine());


//         Student data = new Student(name, grade, age);


//         System.Console.WriteLine("details of student are ->");
//         System.Console.WriteLine("name of student " + name);
//         System.Console.WriteLine("age of student " + age);
//         System.Console.WriteLine("grade of student " + grade);



//     }
// }




// using System;

// class TemperatureConverter
// {
//     public double Celsius { get; set; }
//     public double Fahrenheit { get; set; }

//     public TemperatureConverter()
//     {
//         Celsius = 0;
//         Fahrenheit = 32;
//         Console.WriteLine("Temperature converter initialized.");
//     }

//     ~TemperatureConverter()
//     {
//         Console.WriteLine("Temperature converter destroyed.");
//     }

//     public double CelsiusToFahrenheit(double celsius)
//     {
//         return (celsius * 9 / 5) + 32;
//     }

//     public double FahrenheitToCelsius(double fahrenheit)
//     {
//         return (fahrenheit - 32) * 5 / 9;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         TemperatureConverter? converter = new TemperatureConverter();

//         // Example usage
//         double celsius = 20;
//         double fahrenheit = converter.CelsiusToFahrenheit(celsius);
//         Console.WriteLine(celsius + "°C is equal to " + fahrenheit + "°F");

//         // Clean up
//         converter = null;
//         GC.Collect();
//         GC.WaitForPendingFinalizers();
//     }
// }






// using System;

// class CustomerAccount
// {
//     private static int AccontN = 12354;  

//     public int AccountNumber { get; }
//     public string? AccountHolderName { get; set; }
//     public int Balance { get; set; }
//     public string? AccountType { get; set; }

//     public CustomerAccount(string? AccountHolderName, int Balance, string? AccountType)
//     {
//         this.AccountHolderName = AccountHolderName;
//         this.AccountNumber = AccontN+5;  //it will generate unique account number every time
//         this.AccountType = AccountType;
//         this.Balance = Balance;
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter account holder name:");
//         string accountHolderName = Console.ReadLine() ?? "";

//         // Console.WriteLine("Enter initial balance:");
//         // int balance = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter account type:");
//         string accountType = Console.ReadLine() ?? "";

//         CustomerAccount Data = new CustomerAccount(accountHolderName, 0, accountType); 

//         System.Console.WriteLine("Account created successfully");
//         System.Console.WriteLine("Account details are following");

//         System.Console.WriteLine("Account type: " + Data.AccountType);
//         System.Console.WriteLine("Account number: " + Data.AccountNumber);
//         System.Console.WriteLine("Account holder name: " + Data.AccountHolderName);
//         System.Console.WriteLine("Current balance: " + Data.Balance);
//     }
// }
