// first question

// using System;
// class Program
// {
//     static bool PerfectSqaure(int n)
//     {
//         int r = (int)Math.Sqrt(n);
//         return r * r == n;
//     }

//     static bool PerfectCube(int n)
//     {
//         int cb = (int)Math.Round(Math.Pow(n, 1.0 / 3));
//         int cube = cb * cb * cb;
//         return cube == n;
//     }

//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("enter a number between 100 and 500 : ");
//         int count = 0;
//         int sum = 0;
//         int n = Convert.ToInt32(Console.ReadLine());
//         for (int i = 100; i < n; i++)
//         {
//             if (!PerfectSqaure(i))
//             {
//                 sum += i;
//             }

//         }
//         for (int i = 1; i < sum; i++)
//         {
//             if (PerfectCube(i))
//             {
//                 count++;
//             }

//         }
//         System.Console.WriteLine("the result is " + sum);
//         System.Console.WriteLine("number of cubes: " + count);
//         if (count < 20)
//         {
//             System.Console.WriteLine("beginner");
//         }
//         else if (count > 20 && count < 30)
//         {
//             System.Console.WriteLine("intermediate");
//         }
//         else
//         {
//             System.Console.WriteLine("expert");
//         }
//     }
// }



// //third question

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter toys: ");
//         string toys = Console.ReadLine()??" ";

//         char[] t = toys.ToCharArray();
//         int mxt = MaxToys(t);
//         Console.WriteLine($"Maximum number of toys the child can pick: {maxToys}");
//     }

//     static int MaxToys(char[] toys)
//     {
//         if (toys == null || toys.Length == 0)
//             return 0;

//         int[] counts = new int[26];  

//         foreach (char c in toys)
//         {
//             int idx = c - 'a';  
//             counts[idx]++;
// this array's index will store the count of each character
// if input is like "aabbccddd" then the counts array will be like [2,2,2,3]
//         }

//         int mxcnt = 0;
//         int secondmxcnt = 0;

// now in the counts array which is not [2,2,2,3]  , we will perform counting operation
//         foreach (int counter in counts)
//         {
//             if (counter > mxcnt)
//             {
//                 secondmxcnt = mxcnt;
//                 mxcnt = counter;
//             }
//             else if (counter > secondmxcnt && counter != mxcnt)
//             {
// means , the counter is less than the second max count but less than the maximum count
// so second max will be updated accordingly
//                 secondmxcnt = counter;
//             }
//         }

//         return mxcnt + secondmxcnt;
//     }
// }





// third qestion

// using System;
// class Program
// {
//     static bool IsPrime(int n)
//     {
//         if (n <= 1)
//         {
//             return false;
//         }
//         else
//         {
//             for (int i = 2; i * i <= n; i++)
//             {
//                 if (n % i == 0)
//                 {
//                     return false;
//                 }
//             }
//         }

//         return true;
//     }

//     static int Digitprod(int num)
//     {
//         int prod = 1;
//         while (num != 0)
//         {
//             prod *= num % 10;
//             num /= 10;
//         }
//         return prod;
//     }
//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("enter a number between 10 and 100");
//         int n = Convert.ToInt32(Console.ReadLine());
//        int mxP = -1;
//         int mxprime = -1;

//         for (int i = 10; i <= n; i++) {
//             if (IsPrime(i)) {
//                 int prod = Digitprod(i);
//                 if (prod > mxP) {
//                     mxP = prod;
//                     mxprime = i;
//                 }
//             }
//         }

//         if (mxprime != -1) {
//             Console.WriteLine("The prime number with the maximum prod of digits is: " + mxprime);
//             Console.WriteLine("The maximum prod of digits is: " + mxP);
//         } else {
//             Console.WriteLine("There are no prime numbers between 10 and " + n);
//         }
//     }
// }