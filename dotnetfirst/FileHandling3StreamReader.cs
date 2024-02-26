// using System;  
// using System.IO;  
// public class StreamReaderExample  
// {  
//     public static void Main(string[] args)  
//     {  
//         string path = "c.txt";
//         string fullpath = Path.GetFullPath(path);
//         FileStream fs = new FileStream(fullpath, FileMode.OpenOrCreate);
//         StreamReader s = new StreamReader(fs);  
  
//         string line=s.ReadLine()??" ";  
//         Console.WriteLine(line);  
        
        //this will read only one line of the file , to read full file ,we will use loop

//         s.Close();  
//         fs.Close();  
//     }  
// }  



//reading full file

// using System;
// using System.IO;
// class StreamReaderClass{
//     public static void Main(string[] args){
//         string path = "c.txt";
//         string fullpath = Path.GetFullPath(path);
//         FileStream fs  = new FileStream(fullpath , FileMode.OpenOrCreate);

//         StreamReader s = new StreamReader(fs);

//         string? line="";
//         while((line=s.ReadLine() )!=null){
//             System.Console.WriteLine(line );
//         }

//         s.Close();
//         fs.Close();
//     }
// }