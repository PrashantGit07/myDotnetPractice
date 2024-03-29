// using System;
// class Program
// {
//         public static List<int> FindPattern(List<string> pattern, string text)
//         {
//             var answers = new List<int>();
//             foreach (string item in pattern)
//             {
//                 var indexs = new List<int>();
//                 int sidx = 0;
//                 while (true)
//                 {
//                     int index = text.IndexOf(item, sidx);
//                     if (index == -1)
//                     {
//                         break;
//                     }
//                     indexs.Add(index);
//                     sidx = index + item.Length;
//                 }
//                 answers.AddRange(indexs);
//                 answers.Sort();
//             }
//             return answers;
//         }

//         public static void Main(string[] args)
//         {
//             string text = "abracadabra";
//             List<string> pattern = new List<string>() { "abra", "ca", "cad", "bra" };

//             List<int> res = FindPattern(pattern, text);
//             System.Console.WriteLine(string.Join(",", res));
//         }

// }


// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         string[] strings = { "/user/local/bin/file1.txt", "/user/local/bin/file2.txt", "/user/local/bin/file3.txt" };
//         string res = Answer(strings);
//         Console.WriteLine("Longest Common Directory Prefix: " + res);
//     }

//     static string Answer(string[] s)
//     {
//         if (s == null || s.Length == 0)
//         {
//             return "";
//         }
//         string[] part = s[0].Split('/');

//         int len = part.Length;

//         foreach (string item in s)
//         {
//             string[] p = item.Split('/');
//             int i = 0;
//             while (i < len && i < part.Length && p[i] == part[i])
//             {
//                 i++;
//             }

//             len = Math.Min(len, i);
//         }

//         return string.Join("/", part, 0, len) + "/";
//     }
// }

