//pass by value -->> here we pass copy of value not actual refrence/address , so if we modify the new value ,it will not affect the original value , only copy will be modified



// using System;
// class FunctionsInCsharp
// {
//     public void Display(int v)
//     {
//         v += v;
//         System.Console.WriteLine("value  : " + v);
//     }

//     static void Main(string[] args)
//     {
//         int v = 50;
//         FunctionsInCsharp obj = new FunctionsInCsharp();
//         System.Console.WriteLine("before calling function : " + v);
//         obj.Display(v);
//         System.Console.WriteLine("After calling function : "+v);
//     }


// }



//pass by reference -->> here we pass the reference / address of the value, so if the new value is modified , the original value is also modified , because we are directly making change on the address of the variable

//to pass the argument by reference C# provieds ref keyword , we put this along with the argument



// using System;
// class FunctionsInCsharp
// {
//     public void Display(ref int v)
//     {
//         v += v;
//         System.Console.WriteLine("value  : " + v);
//     }

//     static void Main(string[] args)
//     {
//         int v = 50;
//         FunctionsInCsharp obj = new FunctionsInCsharp();
//         System.Console.WriteLine("before calling function : " + v);
//         obj.Display(ref v);
//         System.Console.WriteLine("After calling function : "+v);
//     }


// }


