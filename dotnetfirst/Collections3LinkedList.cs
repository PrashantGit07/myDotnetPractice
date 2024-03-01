// using System;
// class LinkedListClass
// {
//     public static void Main(string[] args)
//     {
//         var names = new LinkedList<string>();

//         names.AddLast("Prashant");
//         names.AddLast("Mishra");

//         System.Console.WriteLine("===========================================");

//         foreach (var name in names)
//         {
//             System.Console.WriteLine(name);
//         }

//         System.Console.WriteLine("===========================================");
//         //adding last and before any node
//         names.AddLast("Jai");
//         names.AddLast("shree");
//         names.AddLast("Ram");


//         LinkedListNode<String>? node = names.Find("Ram");

//         names.AddBefore(node, "Siya");
//         names.AddAfter(node, "ji");


//         foreach (var name in names)
//         {
//             System.Console.WriteLine(name);
//         }
//         System.Console.WriteLine("===========================================");

//     }
// }