//a prpgram to take integer input and print absolute value without using math library

using System;
class ProgramAbs{
    public static void Main(string[] args){
        Console.WriteLine("enter the number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int ans = num>0? num:-num;
        Console.WriteLine("absolute value is : " + ans);
    }
}



//even or odd
class EvenOdd{
    public static void Main(string[] args){
        Console.WriteLine("enter an integer : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num%2==0){
            Console.WriteLine("the number is even");
        }
        else{
            Console.WriteLine("Odd");
        }
    }
}


//leap year
class LeapYear{
    public static void Main(string[] args){
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if((year%4==0 && year%100 !=0) || (year%400==0)){
            Console.WriteLine("Leap Year");
        }
        else{
            Console.WriteLine("not a leap year");
        }
    }
}


//max of three numbers

class FindMax{
    public static void Main(string[] args){
        Console.WriteLine("Enter inegers : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());
        int mx = n1;
        if(n2>mx){
            mx = n2;
        }
        if(n3>mx){
            mx = n3;
        }

        Console.WriteLine("maximum number is : " + mx);
    }
}


//grading question
class Grading{
    public static void Main(string[] args){
        Console.Write("Enter score : ");
        int score = Convert.ToInt32(Console.ReadLine());
        char grade;

        if(score >90 && score<=100){
            grade='A';
        }
        else if(score>80 && score<=89){
            grade='B';
        }
        else if(score>70 && score<=79){
            grade='C';
        }
        else if(score>60 && score<=69){
            grade='D';
        }
        else{
            grade='F';
        }

        Console.WriteLine("the grade based on score is : " + grade);
    }
}


//vowel or consonent
class VowelConsonent{
    public static void Main(string[] args){
        Console.WriteLine("enter the character : ");
        char ch = char.Parse(Console.ReadLine());

        if(char.IsLetter(ch)){
            ch = char.ToLower(ch);

            if(ch=='a' || ch=='e'|| ch=='i' || ch=='o' || ch=='u'){
                Console.WriteLine("it is vowel");
            }
            else{
                Console.WriteLine("it is consonent");
            }
        }


    }
}



//largest among four

class LargestInFour{
    public static void Main(string[] args){
        Console.WriteLine("enter four numbers : ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());
        int n4 = Convert.ToInt32(Console.ReadLine());

        int mx = n1;

        if(n2>mx){
            mx = n2;
        }
        if(n3>mx){
            mx = n3;
        }
        if(n4>mx){
            mx = n4;
        }

        Console.WriteLine("the maximum numer is : " + mx);
    }
}



//discount calculator

class CalculateDiscount{
    public static void Main(string[] args){
        Console.WriteLine("enter total amount of purchase : ");
        int am = Convert.ToInt32(Console.ReadLine());

        if(am>10000){
            double disc = am * 10/100;
            double finalAmount = am - disc;

            Console.WriteLine("the discount is : " + finalAmount);
        }
        else{
            Console.WriteLine("no discount applied");
        }
    }
}





//palindromem checker
//using two pointer approach

class CheckPalindrome{
    public static void Main(string[] args){
        Console.WriteLine("enter a string : ");
        string s = Convert.ToString(Console.ReadLine()).ToLower();

        bool isPalindrome = true;
        
        int i = 0;
        int j = s.Length-1;
        while(i<j){
            if(s[i] != s[j]){
                isPalindrome = false;
                break;
            }
            i++;
            j--;
        }
        if(isPalindrome){
            Console.WriteLine("the given string is palindrome");
        }
        else{
            Console.WriteLine("the given string is not palindrome");
        }

    }
}


//sign of product


//checking sign of product

 

class SignOfProduct {
    public static void Main(string[] args) {
        Console.WriteLine("Enter three integers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        int negativeCount = 0;

        if (num1 < 0) {
            negativeCount++;
        }
        if (num2 < 0) {
            negativeCount++;
        }
        if (num3 < 0) {
            negativeCount++;
        }

        if (negativeCount % 2 == 0) {
            Console.WriteLine("positive sign");
        } else {
            Console.WriteLine("negative sign");
        }
    }
}