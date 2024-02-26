
//using string writer we can write/store the information in a in-memory string buffer
//in-memory ->>menas the RAM
//string -->> sequence of character
//buffer -->> it is a place which stores the data temporarily in memory while its being processed or transferred from one place to another

//it seals with the string data types , it is a derived class of textWriter class , the string data is written by stringWriter class and stored in a StringBuilder



//constructors of StringWriter
//(1)-> StringWriter()-- is used to initialzie new instance of stringWriter class
//(2)-> StringWriter(FormatProvider) -->> to initialize a new instance of stringWriter class in a specific format

//(3)-> stringWriter(stringbuilder) -->> to initialize a new instance of stringWriter class that writes to specific stringbuilder

//(4)-> stringWriter(stringbuilder?formatprovider) -->>to write specific builder with specified format




// using System;
// using System.IO;
// using System.Text;
// class StringWriterClass
// {
//     public static void Main(string[] args)
//     {
//         string text = "Jai shree Ram , Jai Hind \n Hamara pyara bharat \n Jai Shivaji";

        //steps - create a string builder , pass the stringbuilder to a stringwriter , use write method to write the text , flush and close the write and then read it , 

        //to read -  create an instance of stringReader and pass the stringBuilder to it

//         StringBuilder sb = new StringBuilder(); //1

//         StringWriter stringWriter = new StringWriter(sb); //2

//         stringWriter.Write(text);
//         stringWriter.Flush();
//         stringWriter.Close();


        //reading

//         StringReader stringReader = new StringReader(sb.ToString());

//         while (stringReader.Peek() >= 0)
//         {
//             System.Console.WriteLine(stringReader.ReadLine());
//         }
//     }
// }





//creating  a stringbuilder instance
//         StringBuilder sb = new StringBuilder();


//passing the stringbuilder function to stringWriter

//         StringWriter stringWriter = new StringWriter(sb);

//wrinting the data using Writer

//         stringWriter.Write(text);

//         stringWriter.Flush();
//closing writer connection

//         stringWriter.Close();


//creating stringReader instance and passing stringbuilder

//         StringReader stringReader = new StringReader(sb.ToString());

//         while(stringReader.Peek()>1){
//             System.Console.WriteLine(stringReader.ReadLine());
//         }