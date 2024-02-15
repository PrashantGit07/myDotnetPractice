// using Internal;

//value data types :- they directly store their data , when we are working with value data types, we are working with actual data
//they are --> int , cahr , float , short , double etc
//int - 4 bytes
//char - 1 bytes 
//float - 4 bytes
//double - 8 bytes 
//short - 2 bytes


// using System;
// using System.Runtime.InteropServices;
// namespace datatypes
// {
//     class Answer
//     {
//         static void Main(string[] args)
//         {
//             int t = 5;
//             char c = 'x';
//             float f = 4.5f;
//             double d = 45.758;
//             short s = -325;
//             Console.WriteLine("the size of int x is : " + Marshal.SizeOf(t));
//             Console.WriteLine("the value of integer variable t : " + t);

//             Console.WriteLine("the size of char c is  : " + Marshal.SizeOf(c));
//             Console.WriteLine("the value of character variable c : " + c);
//             Console.WriteLine("the value of float variable f : " + f);

//             Console.WriteLine("the size of double d is  : " + Marshal.SizeOf(d));

//             Console.WriteLine("the value of double variable d : " + d);

//             Console.WriteLine("the size of float f is  : " + Marshal.SizeOf(f));

//             Console.WriteLine("the value of short variable s : " + s);
//         }
//     }
// }







//Reference data types -- they store reference of their data. when we work with reference type variables ,we are working with pointer to data not actual data itself.
//if data is changed by one variable then another variable is automatically changed
//1 - predefined -> objects , string
//2 - user defined -> classes , interface


// using System;
// namespace ReferenceDataTypes
// {
//     class Reference
//     {
//         public string s;
//         public int a;
//if we do not initialize s here , then we may have null reference exceptions that can cause bugs
//by default references in c# are non-nullable , means they can not be assigned null value unless explicitly done
//we will have to initialize s here

//         public Reference()
//         {
//             s = "";
//         }
//so here we initialized string(reference type)  , because c# ensures that a non nullable reference type always have a non null value to prevent null reference exeptions
//     }

//     class Answer
//     {
//         public static void Main(string[] args)
//         {
//             Reference obj = new Reference();
//             obj.s = "Hello";
//             obj.a = 10;
//             Console.WriteLine(obj.s);
//             Console.WriteLine(obj.a);
//         }
//     }
// }




//interface--   an interface is a blueprint or set of rules that a class must follow
//it is like a contract that every class must sign if it is using that blueprint
//suppose we have an interface named calculate which has a method named calculateArea()
//then every class that is implementing that interfce must provide an implementation of the method calculateArea() with same name and return type
// it provides a way of diffrent classes to share a common behaviour
//it allows us to write a code that can work with diffrent object as long as they are using same interface
// it supports the code reusabiltiy and flexibility

// using System;

// interface IAnswer
// {
//     double CalculateArea();
// }

// class ImplmentingINterface : IAnswer{
    //properties
    //properties are way to encapsulate fields within a class and control how they are accessed and modified  , when we use {get;set;} both , then it is called auto implemented property ,  compiler automatically generates a private field behind the scenes to store the value of a property.
//     public double Radius{get; set;}

    //constructor
//    public ImplmentingINterface(double radius){
//         Radius = radius;
//     }

//     public double CalculateArea(){
//         return Math.PI*Radius*Radius;
//     }
// }

// class Answer{
//     public static void Main(string[] args){
//         ImplmentingINterface obj = new(5);

//         Console.WriteLine("the are is : " + obj.CalculateArea());    

//     }
// }