//using seaal keyword we can prevent a class from being derived
// using System;

// sealed class Parent{
//     public void Display(){
//         System.Console.WriteLine("From parent class");
//     }
// }
// class Child:Parent{
//     public void Getvalue(){
//         System.Console.WriteLine("from child");
//     }
// }

// class Answer{
//     public static void Main(string[] args){
//         Child ch = new Child();
        // ch.Display();   -->>> now this line will show error as we have sealed the parent class and now it can not be dreived
//         ch.Getvalue();
//     }
// }