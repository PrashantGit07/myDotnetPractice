//filestream class --->> this class provides a stream for file operations. it can be used to perform asynchronous and synchronous operations read and write operations

//writing a byte into the file
// using System;
// class FileStreamClass{
//     public static void Main(string[] args){
//         string path = "d.txt";
//         string fullpath = Path.GetFullPath(path);

//         FileStream f = new FileStream(fullpath , FileMode.OpenOrCreate);
//         f.WriteByte(65);
//         System.Console.WriteLine("file created and written");
//         f.Close();
//     }
// }



//writing multiple bytes into the file
// using System;
// class FileStreamClass{
//     public static void Main(string[] args){
//         string path = "c.txt";
//         string fullpath = Path.Combine(Environment.CurrentDirectory, path);

//         FileStream f = new FileStream(fullpath , FileMode.OpenOrCreate);

//         for(int i=65;i<=90;i++)
//         {
//             f.WriteByte((byte)i);
//         }
//         System.Console.WriteLine("file has been written to " + fullpath);
//         f.Close();
//         System.Console.WriteLine("close the file " + fullpath);
//     }
// }





//reading from the file
// using System;
// class FileStreamClass
// {
//     public static void Main(string[] args)
//     {
//         string path = "c.txt";
//         string fullpath = Path.Combine(Environment.CurrentDirectory, path);

//         using (FileStream f = new FileStream(fullpath, FileMode.OpenOrCreate))
//         {
//             int bytesRead = f.ReadByte();
//             while (bytesRead != 0)
//             {
//                 if (bytesRead >= 0 && bytesRead <= 255)
//                 {
//                     System.Console.WriteLine(Convert.ToChar(bytesRead));
//                 }

//                 bytesRead = f.ReadByte();
//             }
//         }
//         System.Console.WriteLine("done ");
//     }
// }


// using System;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         string path = "c.txt";
//         string fullpath = Path.GetFullPath(path);

//         FileStream fs = new FileStream(fullpath, FileMode.OpenOrCreate);
//         int i = 0;
//         while ((i = fs.ReadByte()) != -1)
//         {
//             System.Console.Write((char)i + " ");
//         }
//         fs.Close();
//     }

// }