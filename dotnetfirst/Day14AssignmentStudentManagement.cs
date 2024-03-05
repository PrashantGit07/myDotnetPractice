// using System;
// using System.Runtime.ConstrainedExecution;
// using System.Security.Cryptography.X509Certificates;


// // Define the Student class
// class StudentClass
// { // Properties for student details
//     public int id { get; set; }
//     public string? FirstName { get; set; }
//     public string? LastName { get; set; }
//     public int DateOFBirth { get; set; }
//     public string? email { get; set; }

//     public string? course { get; set; }


//     // Method to display student details
//     public void DisplayStudentDetails()
//     {
//         System.Console.WriteLine("Student id " + id);
//         System.Console.WriteLine("Student First Name " + FirstName);
//         System.Console.WriteLine("Student Last Name " + LastName);
//         System.Console.WriteLine("Student Date of Birth " + DateOFBirth);
//         System.Console.WriteLine("Student Email  " + email);
//         System.Console.WriteLine(("Course  " + course) ?? "Not Enrolled in any course yet");
//     }
//     // Method to display information about the institute
//     public void KnowAboutInstitue()
//     {
//         System.Console.WriteLine("The institute has one of the finedt infrastructure");
//         System.Console.WriteLine("the best educators across india");
//         System.Console.WriteLine("we have a big playground");
//         System.Console.WriteLine("we organise extra curricular acitivities on weekly basis");
//         System.Console.WriteLine("We provide extra classes for weak students");
//         System.Console.WriteLine("We organize perosnality developement classes for students");
//     }
// }



// //class for course details
// class CourseDetails
// {
//     public int courseId { get; set; }
//     public string? courseName { get; set; }
//     public string? instructorName { get; set; }

//     public int CourseFee { get; set; }

//     public void DisplayCourseDetails()
//     {
//         System.Console.WriteLine("The course id " + courseId);
//         System.Console.WriteLine("The course name " + courseName);
//         System.Console.WriteLine("The instructor name " + instructorName);
//     }
// }


// //class to deifne process of enrollement

// class EnrollStudents
// {

//     public required StudentClass student { get; set; }
//     public required CourseDetails courseDetails { get; set; }

//     public void DisplayEnrollmentDetails(StudentClass student, CourseDetails courseDetails)
//     {
//         System.Console.Write("enter the id of the student whose details you want to know -->");
//         int id = Convert.ToInt32(Console.ReadLine());

//         if (id == student.id)
//         {
//             System.Console.WriteLine("the student's personal details :");
//             student.DisplayStudentDetails();

//             System.Console.WriteLine("the Enrollment details of the student : ");
//             courseDetails.DisplayCourseDetails();
//         }
//     }

// }


// //class for instructor -- to be implemented
// class Instructor
// {

//     public int courseId { get; set; }
//     public string? courseName { get; set; }
//     public string? instructorName { get; set; }
//     public int fee { get; set; }

//     public void CreateCourse(int courseId, string courseName, string instructorName, int fee)
//     {
//         this.courseId = courseId;
//         this.courseName = courseName;
//         this.instructorName = instructorName;
//         this.fee = fee;
//         Console.WriteLine("Course created successfully!");
//     }

//     public void DisplayCourseDetails()
//     {
//         Console.WriteLine("\nCourse Details:");
//         Console.WriteLine("Course ID: " + courseId);
//         Console.WriteLine("Course Name: " + courseName);
//         Console.WriteLine("Instructor Name: " + instructorName);
//         Console.WriteLine("Fee: " + fee);
//     }
// }


// class Manager
// {

//     //process of registering students , here i made a list where the students details will be saved
//     private List<StudentClass> listOfStudents = new List<StudentClass>();
//     public void RegisterStudent()
//     {

//         System.Console.WriteLine("enter the details of the student :" + "\n");
//         System.Console.Write("First Name : ");
//         string? FirstName = Console.ReadLine();
//         System.Console.Write("Last Name : ");
//         string? LastName = Console.ReadLine();
//         System.Console.Write("Id : ");
//         int id = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Email : ");
//         string? email = Console.ReadLine();
//         System.Console.WriteLine("enter the Date of birth :");
//         int DateOFBirth = Convert.ToInt32(Console.ReadLine());

//         // System.Console.WriteLine("enter the course of the student : ");
//         // string? courseName = Console.ReadLine();

//         //saving the student data in the student object
//         StudentClass student = new StudentClass
//         {
//             FirstName = FirstName,
//             LastName = LastName,
//             id = id,
//             email = email,
//             DateOFBirth = DateOFBirth,
//             // course = courseName
//         };

//         listOfStudents.Add(student);
//         System.Console.WriteLine("the student   " + student.FirstName + " " + student.LastName + " has been registerd");
//         student.DisplayStudentDetails();
//     }


//     //process of registering or adding a course
//     public void RegisterCourse()
//     {
//         System.Console.Write("Enter course Id :");
//         int id = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Enter course Name :");
//         string? courseName = Convert.ToString(Console.ReadLine());
//         System.Console.Write("Enter Instructor name :");
//         string? instructorName = Convert.ToString(Console.ReadLine());
//         System.Console.Write("Enter Fee of the course :");
//         int fee = Convert.ToInt32(Console.ReadLine());

//         CourseDetails newCourse = new CourseDetails
//         {
//             courseId = id,
//             courseName = courseName,
//             instructorName = instructorName,
//             CourseFee = fee,
//         };

//         courseDetails.Add(newCourse);
//         System.Console.WriteLine("the course " + courseName + "has been created");
//     }

//     //here we have some defeault courses , i added them just to display some courses and make a student convinient to enroll for a course
//     public List<CourseDetails> courseDetails = new List<CourseDetails>{
//         new CourseDetails{courseId = 1 , courseName="Dotnet" , instructorName="Akash" , CourseFee=500},
//         new CourseDetails{courseId = 2 , courseName="MERN" , instructorName="Nitish" , CourseFee=600},
//         new CourseDetails{courseId = 3 , courseName="MEAN" , instructorName="Avinash" , CourseFee=700},
//         new CourseDetails{courseId = 4 , courseName="ML" , instructorName="Ashok" , CourseFee=800}
//     };

//     public void EnrollStudentInCourse(StudentClass student)
//     {
//         System.Console.WriteLine("Available courses ");
//         foreach (var courses in courseDetails)
//         {
//             System.Console.WriteLine(courses.courseName);
//         }

//         System.Console.WriteLine("enter the course you want to enroll in : ");
//         string? courseName = Console.ReadLine();


//         bool isAvailable = false;

//         foreach (var availableCourse in courseDetails)
//         {
//             if (courseName == availableCourse.courseName)
//             {
//                 Console.WriteLine("Enter your Id : ");
//                 int Uid = Convert.ToInt32(Console.ReadLine());

//                 // Check if student with entered ID exists in the list
//                 StudentClass? foundStudent = listOfStudents.Find(student => student.id == Uid);
//                 if (foundStudent == null)
//                 {
//                     Console.WriteLine("Student with ID " + Uid + " is not enrolled in the college!!");
//                     isAvailable = false; // Indicate that enrollment is not available
//                     break; // Exit the loop
//                 }
//                 else
//                 {
//                     // Student found, proceed with enrollment
//                     isAvailable = true;
//                     Console.WriteLine("The student with ID " + Uid + " is enrolled in the course");
//                     // Console.WriteLine("Student id : " + Uid);
//                     StudentClass studen = new StudentClass(){
//                         course = courseName
//                     };
//                     System.Console.WriteLine("Here are the complete detail of the student");
//                     studen.DisplayStudentDetails();
//                     break;
//                 }
//             }
//         }


//         if (!isAvailable)
//         {
//             System.Console.WriteLine("the course is not available");
//         }


//     }


//     // public void EnrollementDetails()
//     // {

//     // }

//     public void AllTheCourses()
//     {
//         foreach (var course in courseDetails)
//         {
//             System.Console.WriteLine("Course ID: " + course.courseId);
//             System.Console.WriteLine("Course Name: " + course.courseName);
//             System.Console.WriteLine("Instructor Name: " + course.instructorName);
//             System.Console.WriteLine("Course Fee: " + course.CourseFee + "\n");
//         }
//     }

//     public void DisplayAllTheStudents()
//     {
//         foreach (var details in listOfStudents)
//         {
//             System.Console.WriteLine("id : " + details.id);
//             System.Console.WriteLine("First Name : " + details.FirstName);
//             System.Console.WriteLine("Last Name : " + details.LastName);
//             System.Console.WriteLine("Email : " + details.email);
//             System.Console.WriteLine("Date of Birth  :" + details.DateOFBirth);
//         }
//     }
// }

// class FinalCLass
// {
//     public static void Main(string[] args)
//     {
//         Manager manager = new Manager();
//         StudentClass student = new StudentClass();
//         System.Console.WriteLine("Are You :");
//         System.Console.WriteLine("1 - Manager");
//         System.Console.WriteLine("2 - Instructor");
//         System.Console.WriteLine("3 - I am a student and I want to know about college.");

//         int n = Convert.ToInt32(Console.ReadLine());
//         char choice;
//         switch (n)
//         {
//             case 1:

//                 do
//                 {
//                     System.Console.WriteLine("chose what you want to do");
//                     System.Console.WriteLine("a - Register Student");
//                     System.Console.WriteLine("b - Register Course");
//                     System.Console.WriteLine("c - Enroll a student in a course");
//                     System.Console.WriteLine("d - Display Student details");
//                     System.Console.WriteLine("e - Display all the courses");
//                     System.Console.WriteLine("f - Just a visitor");

//                     choice = Convert.ToChar(Console.ReadLine());

//                     switch (choice)
//                     {
//                         case 'a':
//                             manager.RegisterStudent();
//                             break;

//                         case 'b':
//                             manager.RegisterCourse();
//                             break;

//                         case 'c':
//                             manager.EnrollStudentInCourse(student);
//                             break;
//                         case 'd':
//                             manager.DisplayAllTheStudents();
//                             break;
//                         case 'e':
//                             manager.AllTheCourses();
//                             break;

//                         case 'f':
//                             System.Console.WriteLine("Ok sir have a nice day!");
//                             break;
//                         default:
//                             System.Console.WriteLine("Invalid choice");
//                             break;
//                     }

//                     if (choice != 'f')
//                     {
//                         System.Console.WriteLine("anything else you want to do??");
//                         string? continueWork = Console.ReadLine();
//                         if (continueWork != "yes")
//                         {
//                             break;
//                         }
//                     }
//                 } while (choice != 'f');
//                 break;

//             case 3:
//                 System.Console.WriteLine("Fine! here are some key specialities about our institute");
//                 student.KnowAboutInstitue();
//                 break;

//             default:
//                 System.Console.WriteLine("invalid choice");
//                 break;

//         }
//     }
// }