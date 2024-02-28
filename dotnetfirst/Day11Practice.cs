
// using System;
// using System.Runtime.CompilerServices;
// class Progra{
//    static bool isPrime(int n){
//         if(n<=1){
//             return false;
//         }
//         else{
//             for(int i=2;i*i<=n;i++){
//                 if(n%i==0){
//                     return false;
//                 }
//             }
//         }
//         return true;
//     }
//     public static void Main(string[] args){
//         int cnt=0;
//         for(int i=1;cnt<10 ;i++){
//              if(isPrime(i)){
//                 System.Console.Write(i+" ");
//                 cnt++;
//              }
//         }
//         System.Console.WriteLine();
//     }
// }




// using System;
// class Program{
//     static bool isPalindrome(int n){
//         int original;
//         int res=0;

//         original=n;
//         while(n>0){
//             int d = n%10;
//             res = res*10+d;
//             n/=10;
//         }

//         return original==res;
//     }
//     public static void Main(string[] args){
//         int n = 1221;
//         if(isPalindrome(n)){
//             System.Console.WriteLine("the number is palindrome");
//         }
//         else{
//             System.Console.WriteLine("the number is not palindrome");
//         }
//     }
// }

// using System;

// class Company
// {
//     public string CompanyLocation { get; set; }

//     public Company(string companyLocation)
//     {
//         CompanyLocation = companyLocation;
//     }

//     public void Display()
//     {
//         Console.WriteLine("Company Location: " + CompanyLocation);
//     }
// }

// class Employee : Company
// {
//     public int Salary { get; set; }
//     public string Post { get; set; }
//     public int Id { get; set; }

//     public Employee(string companyLocation, int id, string post, int salary) : base(companyLocation)
//     {
//         Id = id;
//         Post = post;
//         Salary = salary;
//     }

//     public void DisplayEmployeeDetails()
//     {
//         Console.WriteLine("Employee ID: " + Id);
//         Console.WriteLine("Post: " + Post);
//         Console.WriteLine("Salary: " + Salary);
//         Display();
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Employee emp = new Employee("Lucknow", 101, "Manager", 50000);
//         emp.DisplayEmployeeDetails();
//     }
// }



// function overloading

// using System;
// class Program1
// {

//     public void Display(int a, int b)
//     {
//         int sum = a + b;
//         System.Console.WriteLine("the sum of first function  " + sum);
//     }

//     public void Display(int a, int b, int c)
//     {
//         int sum = a + b + c;
//         System.Console.WriteLine("the sum of second function  " + sum);

//     }

// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         Program1 obj = new Program1();
//         obj.Display(5, 6);
//         obj.Display(5, 6, 7);

//     }
// }




//function overriding
// using System;

// class Program1
// {
//     public virtual void Display(int a, int b)
//     {
//         int sum = a + b;
//         Console.WriteLine("The sum of function in Program1: " + sum);
//     }
// }

// class Program2 : Program1
// {
//     public override void Display(int a, int b)
//     {
//         int product = a * b;  
//         Console.WriteLine("The product of function in Program2: " + product);
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Program1 p1 = new Program1();
//         Program2 p2 = new Program2();

//         p1.Display(10, 5); 
//         p2.Display(10, 5);  
//     }
// }


using System;

public class MyClass
{
    private int myField;

    // Property with a getter and a setter
    public int MyProperty
    {
        get
        {
            return myField; // Getter method
        }
        set
        {
            myField = value; // Setter method
        }
    }

    public MyClass(int value)
    {
        MyProperty = value; // Using the setter method
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass(10);

        // Using the getter method
        int retrievedValue = obj.MyProperty;
        Console.WriteLine("Value retrieved using getter: " + retrievedValue);

        // Using the setter method
        obj.MyProperty = 20;
        Console.WriteLine("Value set using setter: " + obj.MyProperty);
    }
}
