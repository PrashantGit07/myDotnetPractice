// using System;
// class BinaryReaderClass
// {
//     public static void Main(string[] args){
//         string path = "b.txt";
//         string fullpath  = Path.GetFullPath(path);
//         FileStream fs = new FileStream(fullpath , FileMode.OpenOrCreate);
//         BinaryReader w= new BinaryReader(fs);

//         string? line=" ";
//         while((line = w.ReadString()) != null){
//             System.Console.WriteLine(line+" ");
//         }

//         w.Close();
//         fs.Close();
//     }
// }