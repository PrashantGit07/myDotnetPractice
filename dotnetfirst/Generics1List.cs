//in c# , generics are the collection of objects 
//with the help of generics, we can perform vatious operations on objectss 
//like ->> sort , retreive  , update , delete , store etc...

//they are of three types-
//system.collections.generic
//system.collections.
//system.collections.concurrent

//first we will disucsss about list
//list is a data structure which can store duplicate element

// using System;
// class ListCollection{
//creating list
//     public static void Main(string[] args){

//way 1 to create list

// List<int>li = new List<int>();
// li.Add(5);
// li.Add(5);

// foreach(int i in li){
//     System.Console.WriteLine(i);
// }


//way 2 to create list
//using collection initializer

//         var names = new List<string>(){"hello" , "hello","Radhe Radhe"};
//         foreach(string s in names){
//             System.Console.WriteLine(s);
//         }
//     }
// }