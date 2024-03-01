//generics -->>
//generics in c# helps us to use same code for diffrent data types to increase code reusablitiy and maintaining type safety.

//it allows us to define classes, methods , interfaces with placeholders for data types which are specified at runtime by the compiler.

//means we can pass diffrent arguments of diffrent data types in same function at the runtime using generics


// using System;

// class UsingGenerics<T>{

//     public T id{get;set;}

//     public void Display(T id){
//         System.Console.WriteLine("the id is "+ this.id);
//     }
// }

// class Answer{
//     public static void Main(string[] args)
//     {
//         UsingGenerics<int> us = new UsingGenerics<int>();
//         us.Display(10);

//         UsingGenerics<char> uc = new UsingGenerics<char>();
//         uc.Display('A');


//         // UsingGenerics<string> us = new UsingGenerics<string>();
//         // us.Display("hello ji");
//     }
// }