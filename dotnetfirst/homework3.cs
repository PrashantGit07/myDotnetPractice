

// //switch cases and loops

// using System;
// namespace Hello
// {
//     class SwitchPractice
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("enter two numbers : ");
//             int n1 = Convert.ToInt32(Console.ReadLine());
//             int n2 = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Enter the expression you want to calculate : ");
//             string? input = Console.ReadLine();
//             char ch = Convert.ToChar(input ?? "");

//             switch (ch)
//             {
//                 case '+':
//                     Console.WriteLine(n1 + n2);
//                     break;

//                 case '-':
//                     Console.WriteLine(n1 - n2);
//                     break;

//                 case '*':
//                     Console.WriteLine(n1 * n2);
//                     break;

//                 case '/':
//                     Console.WriteLine(n1 / n2);
//                     break;

//                 default:
//                     Console.WriteLine("invalid input");
//                     break;
//             }

//         }
//     }
// }


// using System;

// class InfiniteWhileLoop
// {
//     public static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine("This is an infinite while loop!");
//         }
//     }
// }



// class InfiniteFor
// {
//     public static void Main(string[] args)
//     {
//         for (;;)
//         {
//             Console.WriteLine("This is an infinite for loop!");
//         }
//     }
// }


//goto
//definition of goto statement in c#
//using goto we can directly jump to the labelled statement skipping all the condition lying in the way
// using System;
// class UsingGoto
// {
//     public static void Main(string[] args)
//     {
//         int i = 0;
//         for (i = 0; i < 20; i++)
//         {
//             if (i == 10)
//             {
//                 Console.WriteLine("hii there");
//                 goto down;
//             }
//         }
//         Console.WriteLine("Nice work");
//         Console.WriteLine("Nice work");
//     down:
//         Console.WriteLine("Nice work after down");
//     }
// }





//just testing how can i access functions of a class just by using namespace in which the class is written
// using System;
// namespace Working;
// class Inhertis{
//     public static void Mains(string[] args){
//         TryingSomething t = new TryingSomething(10);
//         t.GetValue();
//     }
//




// using System;
// class RestroManagement
// {public static void Main(string[] args)
//     {

// static void GiveOrder()
//         {Console.WriteLine("order has been given");}
//         static void CancelOrder()
//         {Console.WriteLine("order canceled");}
//         static void ChangeOrder()
//         {Console.WriteLine("order changed");}
//         int i = 0;
//         while (i < 3)
//         {
//     Console.WriteLine("enter an option : ");
//             int option = Convert.ToInt32(Console.ReadLine());

//     switch (option)
//             {
//         case 1:
//             GiveOrder();
//             break;
//         case 2:
//             CancelOrder();
//             break;
//         case 3:
//             ChangeOrder();
//             break;
//         case 4:
//             Console.WriteLine("i want nothing");
//             break;
//             default:
//                 Console.WriteLine("invalid input");
//                 break;

//             }
//             i++;
//         }
//     }
// }



// Let's consider a scenario where you need to handle different types of shapes, such as a square, circle, and triangle, based on user input. Each shape has a specific formula to calculate its area. Here's a C# program that uses a switch statement to determine the shape and calculate its area:


// using System;
// using System.Data;
// class CalculateArea
// {
//     static void CircelArea(double r)
//     {
//         Console.WriteLine("area of circle is : " + Math.PI * r * r);
//     }
//     static void SquareArea(double side)
//     {
//         Console.WriteLine("area of square is : " + side * side);
//     }
//     static void TriangleArea(double h, double b)
//     {
//         Console.WriteLine("area of triangle is : " + (h * b) / 2);
//     }
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("enter the shape you want to find area of : ");
//         string? input = Console.ReadLine();
//         string shape = Convert.ToString(input ?? "");
//         switch (shape)
//         {
//             case "circle":
//                 Console.WriteLine("enter radius of circle : ");
//                 int r = Convert.ToInt32(Console.ReadLine());
//                 CircelArea(r);
//                 break;
//             case "triangle":
//                 Console.WriteLine("enter height and base of triangle : ");
//                 int h = Convert.ToInt32(Console.ReadLine());
//                 int b = Convert.ToInt32(Console.ReadLine());
//                 TriangleArea(h, b);
//                 break;
//             case "square":
//                 Console.WriteLine("enter side of square: ");
//                 int s = Convert.ToInt32(Console.ReadLine());
//                 CircelArea(s);
//                 break;
//             default:
//                 Console.WriteLine("invalid input");
//                 break;
//         }
//     }
// }












// Let's consider a more challenging scenario involving a while loop. 
// Suppose you are building a program that generates a random sequence of numbers until a specific condition is met. The program should continue generating numbers until the sum of the generated numbers exceeds a certain threshold. Write a C# program that uses a while loop to generate random numbers and calculates the sum until the sum exceeds a given threshold.

// using System;
// using System.Text;
// class GenerateSum{
//     public static void Main(string[] args){
//          int sum=0;
//          int threshold = 100;
//          Random r = new Random();


//          while(sum<threshold){
//             int randomNum = r.Next(1 , 10);
//             sum += randomNum;

//             if(sum>threshold){
//                 break;
//             }
//          }

//          Console.WriteLine("the final sum till the threshold is : " + sum);
//     }
// }





//print the pattern
// 1
// 2 3
// 4 5 6
// 7 8 9 10

// using System;
// class PrintingPattern
// {
//     public static void Main(string[] args)
//     {
//         int n = 1;
//         for (int i = 1; i <= 5; i++)
//         {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write(n + " ");
//                 n++;
//             }

//             Console.WriteLine();
//         }
//     }

// }