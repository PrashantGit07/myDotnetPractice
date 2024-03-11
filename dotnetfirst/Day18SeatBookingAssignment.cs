// using System;
// using System.Collections.Generic;

// class Program
// {
//     static List<int> bookedSeats = new List<int>();

//     static void Main(string[] args)
//     {
//         int choice;

//         do
//         {
//             Console.WriteLine("1 - Check available seats");
//             Console.WriteLine("2 - Book a seat");
//             Console.WriteLine("3 - View booked seats");
//             Console.WriteLine("4 - Exit");
//             Console.Write("Enter your choice: ");
            
//             if (!int.TryParse(Console.ReadLine(), out choice))
//             {
//                 Console.WriteLine("Invalid choice. Please enter a number.");
//                 continue;
//             }

//             switch (choice)
//             {
//                 case 1:
//                     CheckAvailableSeats();
//                     break;
//                 case 2:
//                     BookSeat();
//                     break;
//                 case 3:
//                     ViewBookedSeats();
//                     break;
//                 case 4:
//                     Console.WriteLine("Exiting program...");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
//                     break;
//             }

//         } while (choice != 4);
//     }

//     static void CheckAvailableSeats()
//     {
//         Console.WriteLine("Available seats:");
//         for (int i = 1; i <= 8; i++)
//         {
//             //here i am checkig if the available seats are also present in the list of booked seats then it means that seat is already booked and if not then it is displayed as availabel seats
//             if (!bookedSeats.Contains(i))
//             {
//                 Console.Write(i + " ");
//             }
//         }
//         Console.WriteLine();
//     }

//     static void BookSeat()
//     {
//         Console.Write("Enter seat number to book: ");
//         int seatNumber;
//         if (!int.TryParse(Console.ReadLine(), out seatNumber))
//         {
//             Console.WriteLine("Invalid seat number. Please enter a number.");
//             return;
//         }

//         if (seatNumber < 1 || seatNumber > 8)
//         {
//             Console.WriteLine("Invalid seat number. Please enter a number between 1 and 8.");
//             return;
//         }

//         if (bookedSeats.Contains(seatNumber))
//         {
//             Console.WriteLine("Seat is already booked.");
//         }
//         else
//         {
//             bookedSeats.Add(seatNumber);
//             System.Console.WriteLine(seatNumber + " booked successfully");
//         }
//     }

//     static void ViewBookedSeats()
//     {
//         Console.WriteLine("Booked seats:");
//         foreach (var seat in bookedSeats)
//         {
//             Console.Write(seat + " ");
//         }
//         Console.WriteLine();
//     }
// }
