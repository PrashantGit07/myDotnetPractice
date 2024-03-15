// using System;
// using System.Collections;
// using System.Collections.Generic;

// class Program
// {
//     static bool IsBalanced(string s)
//     {
//         Stack<char> st = new Stack<char>();
//         foreach (char c in s)
//         {
//             if (c == '(' || c == '[' || c == '{')
//             {
//                 st.Push(c);
//             }
//             else if (c == ')' || c == ']' || c == '}')
//             {
//                 if (st.Count == 0)
//                 {
//                     return false;
//                 }
//                 char top = st.Pop();

//                 if ((c == ')' && top != '(') || (c == ']' && top != '[') || (c == '}' && top != '{'))
//                 {
//                     return false;
//                 }
//             }
//             else
//             {
//                 return false;
//             }
//         }

//         return st.Count == 0;
//     }
//     static void Main(string[] args)
//     {
//         string s = "[{()}]";

//         Console.WriteLine(IsBalanced(s));  
//     }
// }




