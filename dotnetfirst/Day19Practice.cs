// // Rerverse a String
// class ReverseString{
//     public static void Main(string[] args){
//         System.Console.WriteLine("Enter the String to reverse"+"\n");
//         string? s = Console.ReadLine();
//         System.Console.WriteLine("the reversed String is");


//         for(int i=s.Length-1;i>=0;i--){
//             System.Console.Write(s[i]);
//         }

//     }
// }


// //(2)---Counting vowels in a string
// class CountVowels
// {
//     public static void Main(string[] args)
//     {
//         string? s = "HelloWorld";
//         int vowel=0;

//         for(int i=0;i<s.Length;i++)
//         {
//             if(s[i]=='a'||s[i]=='e'||s[i]=='o'||s[i]=='u'||s[i]=='A'||s[i]=='E'||s[i]=='O'||s[i]=='I'||s[i]=='U'){
//                 vowel++;
//             }
//         }
//         System.Console.WriteLine("Total number of vowels in this string is : "+vowel);
//     }
// }

// //(3)--- converting first letter in upper case
// class TitalConversion
// {
//     public string ConvertToUpper(string s)
//     {
//         if (s.Length != 0)
//         {
//             int asc = Convert.ToInt32(s[0]);

//             //check if ascii value fall within the range of lowercase
//             if (asc >= 97 && asc <= 122)
//             {
//                 //converting upper case by subtracting 32
//                 asc -= 32;

//                 char firstLetter = Convert.ToChar(asc);

//                 string res = firstLetter + s.Substring(1);

//                 return res;
//             }
//             else
//             {
//                 return s;
//                 //if already upper case
//             }
//         }
//         else
//         {
//             return s;
//         }
//     }


// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         TitalConversion t = new TitalConversion();
//         string? iput = "hello";
//         System.Console.WriteLine(t.ConvertToUpper(iput));
//     }
// }

// //(4)--concatenation of two strings
// class ConcatenateStrings
// {
//     public static void Main(string[] args)
//     {
//         string? s1 = "Hello";
//         string? s2 = "Everyone";

//         //Using inbuilt method
//         // string res = string.Concat(s1 , s2);
//         // System.Console.WriteLine("Concatenated String is : " + res);


//         //using simple concatenation
//         string res = s1 + s2;
//         System.Console.WriteLine("Concatenated String is : " + res);

//     }
// }