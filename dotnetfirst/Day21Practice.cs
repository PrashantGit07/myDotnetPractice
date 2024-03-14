// using System;
// using System.Collections.Generic;

// public class StudentClass : IComparable<StudentClass>
// {
//     public int score { get; set; }
//     public string? name { get; set; }

//     // Implementing CompareTo method of IComparable interface
//     public int CompareTo(StudentClass student)
//     {
//         // Compare based on score
//         // return this.score.CompareTo(student.score);

//         // // if they have same score, then method will check more ways to compare
//         // // it will compare names

//         // int result = this.score.CompareTo(student.score);
//         // if (result != 0)
//         // {

//         // // when two things are equal,  it will give zero as output
//         // // in this case we will use name to comapre

//         // // return this.name.CompareTo(student.name);
//         // return result;
//         // }

//         // return result;
//         int scoreComparison = this.score.CompareTo(student.score);
//         if (scoreComparison != 0)
//         {
//             // If scores are different, return the comparison result
//             return scoreComparison;
//         }

//         // If scores are equal, compare based on name length
//         int nameLengthComparison = this.name.Length.CompareTo(student.name.Length);
//         if (nameLengthComparison != 0)
//         {
//             // If name lengths are different, return the comparison result
//             return nameLengthComparison;
//         }

//         // If name lengths are equal, compare based on name alphabetically
//         // return this.name.CompareTo(student.name);

//         //Odd-Even Case


//         if (this.score % 2 == 1 && student.score % 2 == 0)
//         {
//             // if current student has odd score and other student has even score

//             return -1;

//             // odd score student will come first
//         }
//         else if (this.score % 2 == 0 && student.score % 2 == 1)
//         {
//             // if current student has even score and other student has odd score

//             return 1;

//             // even score student will come first
//         }
//         else
//         {
//             int result = this.score.CompareTo(student.score);
//             if (result == 0)
//             {
//                 return this.name.CompareTo(student.name);
//             }
//             return result;
//         }


//         //if students have same score parity(both odd and even) , the student will longer name will come before other students


//         int thisStudent = this.score % 2;
//         int otherStudent = this.score % 2;

//         if (thisStudent != otherStudent)
//         {
//             //if scores are different, odd score will come first

//             return thisStudent.CompareTo(otherStudent);
//         }
//         else
//         {
//             //if scores are same , we will sort based on the name length



//             int checkName = this.name.Length.CompareTo(student.name.Length);

//             if (checkName != 0)
//             {
//                 //if names have different lengths

//                 return checkName;

//             }
//             else
//             {
//                 //if name has same lengths , sort based on alphabet

//                 return this.name.CompareTo(student.name);
//             }
//         }
//     }
// }

// class Answer
// {
//     public static void Main(string[] args)
//     {
//         List<StudentClass> studentClasses = new List<StudentClass>
//             {
//                 new StudentClass {name="Rahul" , score=15},
//                 new StudentClass {name="Rohan" , score=55},
//                 new StudentClass {name="Shiva" , score=45},
//                 new StudentClass {name="Kash" , score=45}
//             };

//         studentClasses.Sort();

//         foreach (var item in studentClasses)
//         {
//             Console.WriteLine(item.name);
//             Console.WriteLine(item.score);
//         }
//     }
// }



// //this line is doing the comparison based on the score
// //this.score refers to the current student object on which compareTo method is called

// // .CompareTo(other.Score): This is a method call on the Score property of the current Student object. The CompareTo method is used to compare the score of the current Student object (this.Score) with the score of the other Student object (other.Score).


// // f this.Score is less than other.Score, CompareTo returns a negative integer.
// // If this.Score is equal to other.Score, CompareTo returns zero.
// // If this.Score is greater than other.Score, CompareTo returns a positive integer.









// // When you use the Sort() method on a list of objects in C#, it relies on the IComparable interface to compare the objects and determine their order. If any of the objects in the list do not implement IComparable, the Sort() method won't know how to compare them, leading to the exception you encountered.

// // To resolve this issue, you need to ensure that all objects in the list implement the IComparable interface and provide a CompareTo method to define the sorting logic.

// // In your case, make sure that the StudentClass implements IComparable<StudentClass> and provides a CompareTo method, just like in the previous examples. Once you've done that, you should be able to sort the list without encountering this exception.






// //  Let's break down IComparable and CompareTo in a simple way:

// // 1. Imagine You Have Some Toys:

// // Let's say you have a bunch of different toys, like toy cars, toy robots, and toy dinosaurs.
// // 2. You Want to Arrange Them:

// // Now, let's pretend you want to arrange these toys neatly on a shelf from the smallest to the biggest.
// // 3. Each Toy Knows Its Size:

// // Each toy knows how big it is. For example, a toy car knows its length, a toy robot knows its height, and a toy dinosaur knows its length too.
// // 4. How Do You Compare Them?

// // You might think, "How can I compare these toys to know which one is smaller or bigger?" That's where IComparable comes in!
// // 5. Introducing IComparable:

// // IComparable is like a magic spell that you teach to each toy. This spell helps the toys compare themselves to each other based on their sizes.
// // 6. Let's Learn the Spell:

// // IComparable says, "Hey, toy! You can compare yourself to another toy using a special method called CompareTo."
// // 7. CompareTo Method:

// // The CompareTo method is like a game where toys figure out who's bigger or smaller. It's a simple rule:
// // If you're smaller than the other toy, you say "I'm smaller!" (return a negative number).
// // If you're the same size, you say "We're the same!" (return 0).
// // If you're bigger than the other toy, you say "I'm bigger!" (return a positive number).
// // 8. Putting It All Together:

// // So, you teach each toy how to play this game using IComparable and the CompareTo method. Now, when you ask them to line up on the shelf, they know exactly where to go!
// // 9. Example:

// // Let's say you have two toy cars. One is 5 inches long, and the other is 3 inches long.
// // You can use IComparable and CompareTo to compare their sizes.
// // If you ask the first toy car (5 inches) to compare itself to the second toy car (3 inches), it will say, "I'm bigger!" because 5 is greater than 3.
// // 10. Conclusion:

// // IComparable and CompareTo help objects (like toys) compare themselves to each other. It's like teaching them a fun game to figure out who's bigger or smaller. And when you need to sort them, they already know how to line up correctly!




