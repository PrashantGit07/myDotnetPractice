// //fileInfo -- this class deals with the files in c# ,it provides methods to create , read and delete files.
// //it uses StreamWriter class to write data into files and StreamReader class to read data from files. it is part of System.IO namespace

// using System;
// class FileInfoClass
// {
//     public static void Main(string[] args)
//     {
//         try
//         {
//             string path = "d.txt";
//             string fullpath = Path.GetFullPath(path);
//             FileInfo fileInfo = new FileInfo(fullpath);

            // creating an empty file
//             fileInfo.Create();
//             System.Console.WriteLine("file created successfully");

            // writing to a file using StreamWriter class

//             StreamWriter StreamWriter = fileInfo.CreateText();
            // StreamWriter.Write("Radhe Radhe Ji");
//             for(char i='A';i<='Z';i++){
//                 StreamWriter.Write(i);
//             }
//             StreamWriter.Close();
//             System.Console.WriteLine("written successfully");

            // reading from file using StreamReader

//             StreamReader reader = fileInfo.OpenText();
//             string? data = "";

//             while ((data = reader.ReadLine()) != null)
//             {
//                 System.Console.WriteLine(data);
//             }
//         }
//         catch (IOException e)
//         {
//             System.Console.WriteLine("exeption  :" + e);
//         }
//     }
// }







 