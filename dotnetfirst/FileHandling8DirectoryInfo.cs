// using System;
// class DirectoryIfnfoClass{
//     public static void Main(string[] args){
//         string DirectoryName = "DirectoryNew";
//         string fullpath = Directory.GetCurrentDirectory();

//         DirectoryInfo info = new DirectoryInfo(fullpath);

//         try{
//             if(info.Exists){
//                 System.Console.WriteLine("already exists");
//             }
//             else{
//                 //creating a directory
//                 info.Create();
//                 System.Console.WriteLine("directory created");
//             }
//         }
//         catch(IOException e){
//             System.Console.WriteLine(e);
//         }
//     }
// }