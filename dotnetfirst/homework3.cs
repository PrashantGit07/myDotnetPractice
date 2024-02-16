

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


//goto
//definition of goto statement in c#
//using goto we can directly jump to the labelled statement skipping all the condition lying in the way
using System;
class UsingGoto
{
    public static void Main(string[] args)
    {
        int i = 0;
        for (i = 0; i < 20; i++)
        {
            if (i == 10)
            {
                Console.WriteLine("hii there");
                goto down;
            }
        }
        Console.WriteLine("Nice work");
        Console.WriteLine("Nice work");
    down:
        Console.WriteLine("Nice work after down");
    }
}