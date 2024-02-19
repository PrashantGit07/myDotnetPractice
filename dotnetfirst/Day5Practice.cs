 



// // ****
// // ****
// // ****
// // ****


// using System;

// class Pattern{
//     public static void Main(string[] args)
//     {
//         int r=5;
         
        //   int m = Convert.ToInt32(Console.ReadLine());
//         for(int i=0;i<r;i++){
//             for(int j=0;j<r;j++){
//                 System.Console.Write("*");
//             }
//             System.Console.WriteLine("\r");
//         }
//     }
// }



// // *
// // **
// // ***
// // ****
// // *****


// using System;
// class Pattern{
//     public static void Main(string[] args)
//     {
//         int r = 6;
//         for(int i=1;i<r;i++)
//         {
//             for(int j=1;j<i;j++){
//                 System.Console.Write("*" );
//             }
//             System.Console.WriteLine( );
//         }
//     }
// }




// // ****
// // ***
// // **
// // *

// using System;
// class Pattern{
//     public static void Main(string[] args){
//         int r = 4;
//         for(int i=r;i>=1;i--){
//             for(int j=0;j<i;j++){
//                 System.Console.Write("*");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }




// //  *
// // ***
// //*****

// using System;
// class Pattern{
//     public static void Main(string[] args){
//         int r=5;
//         for(int i=0;i<r;i++){
//             for(int j=0;j<r-i-1;j++){
//                 System.Console.Write(" ");
//             }
//            for(int k=0;k<2*i+1;k++){
//             System.Console.Write("*");
//            }
//            System.Console.WriteLine();
//         }
//     }
// }

// //first loop for rows
// //second for spaces
// //third for printing stars



// //1
// //22
// //333
// //4444


// using System;
// class Pattern{
//     public static void Main(string[] args)
//     {
//         int r=5;
//         for(int i=1;i<r;i++)
//         {
//             for(int j=0;j<i;j++){
//                 Console.Write(i);
//             }
//             System.Console.WriteLine();
//         }
//     }
// }



// //*****
// // ***
// //  *
// // ***
// //*****

// using System;
// class Pattern
// {
//     public static void Main(string[] args)
//     {
//         int r = 5;
//         for (int i = r; i >= 0; i--)
//         {
//              for (int j = 0; j < r - i - 1; j++)
//             {
//                 System.Console.Write(" ");
//             }
//             for (int k = 0; k < 2 * i + 1; k++)
//             {
//                 System.Console.Write("*");
//             }

//             System.Console.WriteLine();
//         }
//         for (int i = 0; i < r; i++)
//         {
//             for (int j = 0; j < r - i - 1; j++)
//             {
//                 System.Console.Write(" ");
//             }
//             for (int k = 0; k < 2 * i + 1; k++)
//             {
//                 System.Console.Write("*");
//             }
//             System.Console.WriteLine();
//         }


//     }
// }



// //A
// //B B
// //C C C

// using System;
// class Pattern{
//     public static void Main(string[] args)
//     {
//         int r=5;
//         char ch = 'A';
//         for(int i=0;i<r;i++)
//         {
//             for(int j=0;j<=i;j++)
//             {
//                 System.Console.Write(ch);
//             }
//             System.Console.WriteLine();
//             ch++;
//         }
//     }
// }



// //  *
// // ***
// //*****
// // ***
// //  *

// using System;
// class Pattern
// {
//     public static void Main(string[] args)
//     {
//         int r = 5;
//         for (int i = 0; i < r; i++)
//         {
//             for (int j = 0; j < r - i - 1; j++)
//             {
//                 System.Console.Write(" ");
//             }
//             for (int k = 0; k < 2 * i + 1; k++)
//             {
//                 System.Console.Write("*");
//             }
//             System.Console.WriteLine();
//         }


//         for (int i = r; i >= 0; i--)
//         {
//             for (int j = 0; j < r - i - 1; j++)
//             {
//                 System.Console.Write(" ");
//             }
//             for (int k = 0; k < 2 * i + 1; k++)
//             {
//                 System.Console.Write("*");
//             }

//             System.Console.WriteLine();
//         }

//     }
// }



// //*****
// //*   *
// //*   *
// //*   *
// //*****


// using System;

// class Pattern
// {
//     public static void Main(string[] args)
//     {
//         int r = 5;
//         for (int i = 0; i < r; i++)
//         {
//             if (i == 0 || i == r - 1)
//             {
//                 // If the row is first or last, then print all stars
//                 for (int j = 0; j < r; j++)
//                 {
//                     Console.Write("*");
//                 }
//             }
//             else
//             {
//                 // Print stars at the start
//                 Console.Write("*");
//                 for (int j = 1; j < r - 1; j++)
//                 {
//                     // Leave space
//                     Console.Write(" ");
//                 }
//                 // Print again
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
//     }
// }



 
// }



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         PrintZigzagPattern(5, 6);
//     }

//     static void PrintZigzagPattern(int n, int m)
//     {
//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < m; j++)
//             {
//                 // if ((i + j) % (n - 1) == 0 || (j - i) == (n - 1) / 2)
//                 //     Console.Write("*");
//                 // else
//                 //     Console.Write(" ");
//                 if ( j==i || j==m-i-1 )
//                     Console.Write("*");
//                 else
//                     Console.Write(" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }












//find first prime palindore greater than 100  , use continue statement to skip non palindormic number , the number should be prime and palindromic as well , use break when the number is found

// using System;

// class Program
// {static bool IsPrime(int n)
//     {
//     if (n <= 1)
//         {
//         return false;
//         }
//     for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// }

// static bool IsPalindrome(int n)
// {
//     int originalnum = n;
//     int reverse = 0;
//     while (n > 0)
//     {
//         int rem = n % 10;
//         reverse = reverse * 10 + rem;
//         n /= 10;
//     }
    // if(n==originalnum){
    //     return true;
    // }
    // else{
    //     return false;
    // }
//     return originalnum == reverse;
    //if by revresing the number is not equal to its original value , then it will returnfalse
// }

// public static void Main(string[] args)
// {
//     Console.WriteLine("Enter the number to find the first prime palindrome greater thanthis: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     for (int i = n+1; ; i++) 
    //we used n+1 here , because we want to find prime palindrome greater than n
//     {
//         if (!IsPrime(i))
//         {
//             continue;
//         }
//         if (!IsPalindrome(i))
//         {
//             continue;
//         }

//         Console.WriteLine("The expected prime palindrome is: " + i);
//         break;
//     }
// }}


//find a factorial of a number but use continue to skip the multiplication by 7. break the loop if the factorial exceeds 1000.


// using System;

// class Program
// {
//     public static int FindFactorial(int n)
//     {
//         int fact = 1;
//         for (int i = 1; i <= n; i++)
//         {
//             if (i == 7)
//             {
//                 continue;
//             }
//             fact *= i;
//             if (fact > 1000)
//             {
//                 break;
//             }

//         }
//         return fact;
//     }

//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Enter a number: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         int result = FindFactorial(n);
//         Console.WriteLine("The result is: " + result);
//     }
// }
