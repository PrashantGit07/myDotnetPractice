// // checked exception -->> int this exception when arithmatic overflow happens , an exception is thrown explicitly
// // unchecked expection --> in this exception when arithmatic overflow happends , it is ignored and a garbage value comes as output

// using System;
// class Program{
//     static void Main(string[] args)
//     {
//         checked{
//             int val = int.MaxValue;
//             System.Console.WriteLine(val+2);
//         }
//     }
// }

// // output -->>Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.

// using System;
// class Program{
//     static void Main(string[] args){
//         unchecked{
//             int val = int.MaxValue;
//             System.Console.WriteLine(val+2);
//         }
//     }
// }

// output -->> -2147483647



// // system exception -->>
// // system expections is a predefined exception class in c#. it is used  to handle system exceptions. it works as a base class for system exceptions namespace. it has various child classes like validation exceptions, argument exceptions , stackOverflow exceptions , indexoutOfBounds exceptions like this.
 