// using System;
// class BinaryWriterClass{
//     public static void Main(string[] args){
//         string path = "b.txt";
//         string fullpath = Path.GetFullPath(path);

//         FileStream fs = new FileStream(fullpath , FileMode.OpenOrCreate);

//         BinaryWriter writer = new BinaryWriter(fs);

//         using(writer){
//             writer.Write("Proud to be a Bhartiya");
//             writer.Write("Abki baar 400 par");
//         }
//         System.Console.WriteLine("done");
//         writer.Close();
//         fs.Close();
//     }
// }