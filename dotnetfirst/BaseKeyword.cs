// base keyword
// using base keyword we can access methods and fields of base class inside dereived class if they have same name

// we use (base.memberFunction/variable) to access the methods of parent class
// this is a kind of super keyword in c++



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






// using System;
 
// class Animal
// {
//     public virtual void Eat()
//     {
//         Console.WriteLine("Animal is eating.");
//     }
// }
 
// class Dog : Animal
// {
//     public override void Eat()
//     {
//         Console.WriteLine("Dog is eating.");
//         base.Eat(); // Calling the Eat method of the base class
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Dog dog = new Dog();
//         dog.Eat(); // Calling the Eat method of the derived class
//     }
// }

