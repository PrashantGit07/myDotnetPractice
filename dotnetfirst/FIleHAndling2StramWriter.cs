//as we know that in filestream class we can perform asynchronous read and write operations
//using StreamWriter class we can perform write operations using specific encoding.
//it inherits TexWriter class.
//it provides overload write() and writeln() methods to peroform write operations


//in fileStream class we get more precise control over file as we work on bytes by bytes
//in streamWriter class we can write on file using specific encoding like string , numbers etc.





// using System;
// class Program{
//     public static void Main(string[] args){
//         string path = "c.txt";
//         string fullpath = Path.GetFullPath(path);
//         FileStream fs = new FileStream(fullpath , FileMode.OpenOrCreate);

//         StreamWriter st = new StreamWriter(fs);

//         st.WriteLine("<<<===----  Jai Shree Ram ----====>>>");
//         st.WriteLine("JAi Shree Ram");
//         st.WriteLine(12344565656);
//         st.Close();
//         fs.Close();

//         System.Console.WriteLine("done");
//     }
// }