// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter a decimal number: ");
//         int input = Convert.ToInt32(Console.ReadLine());

//         string result = Answer(input);
//         Console.WriteLine("Binary number is : " + result);
//     }

//     static string Answer(int input)
//     {
//         if (input == 0)
//             return "0";

//         string result = "";
//         while (input > 0)
//         {
//             int remainder = input % 2;
//             result = remainder + result;
//             input /= 2;
//         }
//         return result;
//     }
// }



class Program
{
    public static int CountDigit(int n)
    {
        int cnt = n.ToString().Length;
        return cnt;
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CountDigit(n);
        string count = ConvertToEnglish(result);
        System.Console.WriteLine("total digits are : " + count);
    }

    static string ConvertToEnglish(int number)
    {
        switch (number)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                throw new ArgumentOutOfRangeException("number", "Number out of range. This method converts only numbers from 1 to 9 to English words.");
        }
    }
}