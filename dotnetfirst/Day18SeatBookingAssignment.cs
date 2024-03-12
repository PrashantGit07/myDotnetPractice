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

//             try
//             {
//                 if (!int.TryParse(Console.ReadLine(), out choice))
//                 {
//                     throw new FormatException("Invalid choice. Please enter a number.");
//                 }

//                 switch (choice)
//                 {
//                     case 1:
//                         CheckAvailableSeats();
//                         break;
//                     case 2:
//                         BookSeat();
//                         break;
//                     case 3:
//                         ViewBookedSeats();
//                         break;
//                     case 4:
//                         Console.WriteLine("Exiting program...");
//                         break;
//                     default:
//                         Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
//                         break;
//                 }
//             }
//             catch (FormatException ex)
//             {
//                 Console.WriteLine(ex.Message);
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"An error occurred: {ex.Message}");
//             }

//         } while (choice != 4);
//     }

//     static void CheckAvailableSeats()
//     {
//         Console.WriteLine("Available seats:");
//         for (int i = 1; i <= 8; i++)
//         {
//             if (!bookedSeats.Contains(i))
//             {
//                 Console.Write(i + " ");
//             }
//         }
//         Console.WriteLine();
//     }

//     static void BookSeat()
//     {
//         try
//         {
//             Console.Write("Enter seat number to book: ");
//             int seatNumber = Convert.ToInt32(Console.ReadLine());

//             if (seatNumber < 1 || seatNumber > 8)
//             {
//                 throw new ArgumentException("Invalid seat number. Please enter a number between 1 and 8.");
//             }

//             if (bookedSeats.Contains(seatNumber))
//             {
//                 Console.WriteLine("Seat is already booked.");
//             }
//             else
//             {
//                 bookedSeats.Add(seatNumber);
//                 Console.WriteLine(seatNumber + " booked successfully");
//             }
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("Invalid seat number format. Please enter a valid number.");
//         }
//         catch (ArgumentException ex)
//         {
//             Console.WriteLine(ex.Message);
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex.Message}");
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
