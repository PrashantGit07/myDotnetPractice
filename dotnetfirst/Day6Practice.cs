//input hello word C#
//output -->> c#  hello world
// using System;
// using System.Collections.Generic;


// Split the input string into words
// Pushing all words into the stack
// Pop all words from the stack and add to the output string
// Trim the trailing space and print the output
// class Program
// {
//     public static void Main(string[] args)
//     {
//       Console.Write("enter the string : ");
//       string s = Console.ReadLine()??" ";
//         string[] words = s.Split(' ');
//         Stack<string> wordStack = new Stack<string>();


//         foreach (string word in words)
//         {
//             wordStack.Push(word);
//         }


//         string output = "";
//         while (wordStack.Count > 0)
//         {
//             output += wordStack.Pop() + " ";
//         }


//         output = output.Trim();
//         Console.WriteLine(output);
//     }
// }



//print the pairs of prime numbers from 1 to n and pairs should be perfect square when we multiply the numbers

// using System;
// using System.Numerics;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("enter a number : ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         PairsOfPrime(n);
//     }
//     public static bool Prime(int n)
//     {
//         if (n <= 1)
//         {
//             return false;
//         }
//         for (int i = 2; i * i <= n; i++)
//         {
//             if (n % i == 0)
//             {
//                 return false;
//             }

//         }
//         return true;
//     }

//     //check perfect square
//     static bool PerfectSquare(int n)
//     {
//         int res = (int)Math.Sqrt(n);
//         return res*res==n;
//     }

//     //find pairs of prime

//     static void PairsOfPrime(int n)
//     {
//       for (int i = 2; i <= n; i++)
//         {
//             for(int j=i+1;j<n;j++)
//             {
//                 if(Prime(i) && Prime(j))
//                 {
//                     if( !PerfectSquare((int)((long)i*j))){
//                         break;
//                     }
//                     Console.WriteLine($"{i} * {j} = {i * j}");
//                 }
//             }

//         }
//     }
// }


// using System;

// class Program
// {
//     static bool IsPrime(int num)
//     {
//         if (num < 2)
//             return false;

//         for (int i = 2; i <= Math.Sqrt(num); i++)
//         {
//             if (num % i == 0)
//                 return false;
//         }

//         return true;
//     }

//     static bool IsPerfectSquare(int num)
//     {
//         int sqrt = (int)Math.Sqrt(num);
//         return sqrt * sqrt == num;
//     }

//     static void FindPrimeSquarePairs()
//     {
//         Console.WriteLine("Pairs of perfect squares that are prime up to 100:");

//         for (int i = 1; i <= 100; i++)
//         {
//             int square1 = i * i;

//             if (IsPerfectSquare(square1) && IsPrime(i))
//             {
//                 for (int j = i + 1; j <= 100; j++)
//                 {
//                     int square2 = j * j;

//                     if (IsPerfectSquare(square2) && IsPrime(j))
//                     {
//                         Console.WriteLine("(" + i + "^2 = " + square1 + ", " + j + "^2 = " + square2 + ")");
//                     }
//                 }
//             }
//         }
//     }
//     static void Main(string[] args)
//     {
//         FindPrimeSquarePairs();
//     }
// }



// using System;

// class FindDays
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the month name: ");
//         string month = Console.ReadLine();  

//         switch (month.ToLower())  
//         {
//             case "january":
//               Console.WriteLine("31 days");
//                 break;
//             case "march":
//               Console.WriteLine("31 days");
//                 break;
//             case "may":
//               Console.WriteLine("31 days");
//                 break;
//             case "july":
//               Console.WriteLine("31 days");
//                 break;
//             case "august":
//               Console.WriteLine("31 days");
//                 break;
//             case "october":
//               Console.WriteLine("31 days");
//                 break;
//             case "december":
//                 Console.WriteLine("31 days");
//                 break;
//             case "february":
//                 Console.WriteLine("Enter the year: ");
//                 int n = Convert.ToInt32(Console.ReadLine());
//                 if (n % 4 == 0 && (n % 100 != 0 || n % 400 == 0))  
//                 {
//                     Console.WriteLine("This is a leap year and has 29 days");
//                 }
//                 else
//                 {
//                     Console.WriteLine("28 days");
//                 }
//                 break;
//             default:
//                 Console.WriteLine("Invalid input");
//                 break;
//         }
//     }
// }
