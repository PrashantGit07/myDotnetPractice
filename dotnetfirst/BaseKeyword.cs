//base keyword
//using base keyword we can access methids and fields of base class inside dereived class if they have same name
//this is a kind of super keyword in c++



// using System;

// class UsingBase{
    
//     public static void Main(string[]args){
//         Child ch = new Child();
//         ch.DisplayChild();
//         ch.Display();
//     }
//     class Parent{
//         public int id=5;
//         public void Display(){
//             System.Console.WriteLine("from parent class");
//         }
//     }

//     class Child:Parent{
//         public new int id = 10;
//         public void DisplayChild(){
//             System.Console.WriteLine(base.id);
//             System.Console.WriteLine(id);
//             // System.Console.WriteLine(Display());
//         }
//     }
// }