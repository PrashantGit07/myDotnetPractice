// using System;
// class FlightClass
// {
//     public int flightNumber;
//     string? destination { get; set; }
//     DateTime departureTime { get; set; }
//     int availableSeats { get; set; }

//     public void FlightDetails()
//     {
//         availableSeats = 50;
//         System.Console.WriteLine("Number of available seats : " + availableSeats);

//         flightNumber = 21;
//         destination = "Lucknow";
//         departureTime = DateTime.Now;
//         System.Console.WriteLine("Flight Number : " + flightNumber);
//         System.Console.WriteLine("Destination : " + destination);
//         System.Console.WriteLine("Departure Time : " + departureTime);
//     }


//     public void BookSeats(int numberOfSeats)
//     {

//         try
//         {
//             if (availableSeats < numberOfSeats)
//             {
//                 System.Console.WriteLine(numberOfSeats + " seats have been booked");
//                 int remainingSeats = availableSeats - numberOfSeats;
//                 remainingSeats = availableSeats;
//                 System.Console.WriteLine("Number of seats remaining : " + remainingSeats);
//             }
//             else
//             {
//                 throw new Exception("Sorry! insufficient number of seats");
//             }
//         }
//         catch (Exception e)
//         {
//             System.Console.WriteLine(e.Message);
//         }
//     }
// }


// class Program
// {
//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("Welcome to Lucknow Airport ");
//         System.Console.WriteLine("Please cooperate with us to maintian cleanliness ");

//         FlightClass flightClass = new FlightClass();

//         System.Console.WriteLine("Enter your fligh number :");
//         int flightNumber = Convert.ToInt32(Console.ReadLine());

//         try
//         {
//             if (flightNumber != flightClass.flightNumber)
//             {
//                 throw new Exception("Sorry! this flight is not available");
//             }
//             else
//             {
//                 System.Console.WriteLine("1 : Get only fligth details");
//                 System.Console.WriteLine("2 : Book flight tickets");
//                 System.Console.WriteLine("Enter what you want to : ");
//                 int choice = Convert.ToInt32(Console.ReadLine());

//                 switch (choice)
//                 {
//                     case 1:
//                         flightClass.FlightDetails();
//                         break;
//                     case 2:
//                         System.Console.WriteLine("Enter the number of seats you want to book :");
//                         int numberOfSeats = Convert.ToInt32(Console.ReadLine());
//                         flightClass.BookSeats(numberOfSeats);
//                         break;
//                     default:
//                         System.Console.WriteLine("Invalid choice");
//                         break;
//                 }
//             }
//         }
//         catch (Exception e)
//         {
//             System.Console.WriteLine(e.Message);
//         }
//     }
// }