// using seal keyword we can prevent a class from being derived/inherited
// using System;

// sealed class Parent{
//     public void Display(){
//         System.Console.WriteLine("From parent class");
//     }
// }
// class Child:Parent{   --->> this will show error because we can not inherit sealed class
//     public void Getvalue(){
//         System.Console.WriteLine("from child");
//     }
// }

// class Child{
//         public void Display(){
//                 System.Console.WriteLine("Hello, World!");
//         }
// }
// class Answer{
//     public static void Main(string[] args){
//         Child ch = new Child();

//         ch.Display();    

//         Parent p = new Parent();
//         p.Display();
//     }
// }