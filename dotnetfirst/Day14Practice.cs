// static class can contain only static member and can not be instantiatd 


// using System;
// static class StaticCLass{
//     public static float PI = 3.14f;

//     public static double Add(double a , double b){
//         return a+b;
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         System.Console.WriteLine("the answer is " + StaticCLass.PI);
//         System.Console.WriteLine("the answer is " + StaticCLass.Add(5,4));
//     }
// }






// static members - static members are the class type not object type
// they are declared using static keyword
// we can access static members without creating any object
// static members are shared among all the objects
// there is only one copy of static members created in the mempery and it is shared among all the objects , if value of static members is updated , it is updated for all the objects

// using System;

// public class StaticMethodClass
// {
//     public static int Count { get; set; }

//     public StaticMethodClass()
//     {
//         Count++;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         StaticMethodClass c1 = new StaticMethodClass();
//         StaticMethodClass c2 = new StaticMethodClass();
//         StaticMethodClass c3 = new StaticMethodClass();

//         Console.WriteLine("Number of instances created: " + StaticMethodClass.Count);
//     }
// }




// static methods- they are class methods not instance , they are accessed directly withot creating any object.


// using System;

// public class StaticMethodClass
// {
//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         int result = StaticMethodClass.Add(5, 3);
//         Console.WriteLine("Addition result: " + result);
//     }
// }





// static constructor -->> static constructor is used to intialize static members of the class. it is automautically called before the instance is created


// using System;

// public class StaticConstructor
// {
//     public static int Number { get; set; }
    
//     // Static constructor
//     static StaticConstructor()
//     {
//         Number = 10;
//         Console.WriteLine("Static constructor called.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Number: " + StaticConstructor.Number);
//     }
// }



