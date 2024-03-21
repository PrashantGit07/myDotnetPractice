//generics -->>
//generics in c# helps us to use same code for diffrent data types to increase code reusablitiy and maintaining type safety.

//it allows us to define classes, methods , interfaces with placeholders for data types which are specified at runtime by the compiler.

//means we can pass diffrent arguments of diffrent data types in same function at the runtime using generics

// using System;
// class Hello<TId , TName>
// {
//     public TId Id { get; set; }
//     public TName Name { get; set;}

//     public void Display(TId id, TName name)
//     {
//         this.Name = name;
//         this.Id = id;
//         System.Console.WriteLine("Id is " + id + ", Name is " + name);
//     }
// }
// class MainClasS
// {
//     public static void Main(string[] args)
//     {
//         Hello<int,string> hello = new Hello<int,string>();
//         hello.Display(45 , "Naam");
//     }
// }