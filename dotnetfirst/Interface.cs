// using System;

// interface Program{
//     void Display(){}
// }
// interface Program2{
//     void Display2(){}
// }

// class Answer: Program , Program2  {
//     public void Display(){
//         System.Console.WriteLine("Calling method of interface one");
//     }
//     public void Display2(){
//         System.Console.WriteLine("Calling method of interface two");
//     }
// }
 

// class AnswerMain{
//     public static void Main(string[]args){
//         Answer answer = new Answer();

//         //here we are calling function of first and second interface from one child class , this is how we are implementing the multiple inheritence
//         answer.Display();
//         answer.Display2();
//     }
// }