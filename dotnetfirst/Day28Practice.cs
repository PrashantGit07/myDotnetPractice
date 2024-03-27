// using System;
// using System.Collections.Generic;
// using System.Linq;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         List<double> celc = new List<double> { 20.0, 55.5, 44.7, 58.8, 45.78, 100.5, 65.34 };

//         Converter<double, double> conversion = c => (c * 9 / 5) + 32;

//         List<double> far = celc.ConvertAll<double>(conversion);

//         System.Console.WriteLine("Celcius to farenhite temperatures  :");

//         for (int i = 0; i < celc.Count; i++)
//         {
//             System.Console.WriteLine("Celius temperature : " + celc[i].ToString());
//             System.Console.WriteLine("Farenhite temperature : " + far[i].ToString());
//             System.Console.WriteLine();
//         }
//     }
// }



// using System;
// class Program{
//     public static void Main(string[] args){
//         List<string> names = new List<string>{"Akash" , "Ravi" , "Amit" , "Akaay" , "Ashish" , "Rohan" , "Shashank"};

//         Func<string, bool> res = n=>n.StartsWith("A");

//         List<string> result = names.Where(res).ToList();

//         System.Console.WriteLine("Names starting with A : ");
//         foreach (string name in result)
//         {
//             System.Console.WriteLine(name);
//             System.Console.WriteLine();
//         }
//     }
// }




//Q-10 - Sort a string Alphabetically


 