// using System;
// using System.Collections.Generic;

// class HotelRoom
// {
//     public string? RoomType { get; set; }
//     public int ChargePerDay { get; set; }

//     public virtual double TotalCharge(int numberOfDays)
//     {
//         return ChargePerDay * numberOfDays;
//     }

//     public virtual void DisplayRoomDetails()
//     {
//         Console.WriteLine($"Room Type: {RoomType}");
//         Console.WriteLine($"Charge Per Day: {ChargePerDay}");
//     }
// }

// class StandardRoom : HotelRoom
// {
//     public StandardRoom()
//     {
//         RoomType = "Standard";
//         ChargePerDay = 500;
//     }
// }

// class DeluxeRoom : HotelRoom
// {
//     public bool HasSwimmingPool { get; set; }

//     public DeluxeRoom()
//     {
//         RoomType = "Deluxe Room";
//         ChargePerDay = 700;
//     }

//     public override double TotalCharge(int numberOfDays)
//     {
//         double initialCharge = base.TotalCharge(numberOfDays);
//         if (HasSwimmingPool)
//         {
//             initialCharge += 200;
//         }
//         return initialCharge;
//     }

//     public override void DisplayRoomDetails()
//     {
//         base.DisplayRoomDetails();
//         Console.WriteLine("Has Swimming Pool: " + "Yes");
//     }
// }

// class LuxuryRoom : HotelRoom
// {
//     public bool OceanView { get; set; }

//     public LuxuryRoom()
//     {
//         RoomType = "Luxury Room";
//         ChargePerDay = 900;
//     }

//     public override double TotalCharge(int numberOfDays)
//     {
//         double initialCharge = base.TotalCharge(numberOfDays);
//         if (OceanView)
//         {
//             initialCharge += 250;
//         }
//         return initialCharge;
//     }

//     public override void DisplayRoomDetails()
//     {
//         base.DisplayRoomDetails();
//         Console.WriteLine("Has Ocean View: " + "Yes");
//     }
// }

// class HotelManager
// {
//     LuxuryRoom luxuryRoom1 = new LuxuryRoom();
//     StandardRoom standardRoom1 = new StandardRoom();
//     DeluxeRoom deluxeRoom1 = new DeluxeRoom();
//     public List<HotelRoom> rooms = new List<HotelRoom>();
//     public void AddRoom(HotelRoom room)
//     {
//         rooms.Add(room);
//     }

//     public double CalculateTotalCost(string roomType, int numberOfDays)
//     {
//         if (roomType == "luxury")
//         {
//             return luxuryRoom1.TotalCharge(numberOfDays);
//         }
//         else if (roomType == "standard")
//         {
//             return standardRoom1.TotalCharge(numberOfDays);
//         }
//         else if (roomType == "deluxe")
//         {
//             return deluxeRoom1.TotalCharge(numberOfDays);
//         }
//         else
//         {
//             Console.WriteLine("Invalid input");
//             return 0.0;
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create instances of different room types
//         StandardRoom standardRoom = new StandardRoom();
//         LuxuryRoom luxuryRoom = new LuxuryRoom();
//         DeluxeRoom deluxeRoom = new DeluxeRoom();

//         // Add rooms to hotel manager
//         HotelManager manager = new HotelManager();
//         manager.AddRoom(standardRoom);
//         manager.AddRoom(luxuryRoom);
//         manager.AddRoom(deluxeRoom);

//         // Display room details
//         Console.WriteLine("List of Rooms:");
//         foreach (var room in manager.rooms)
//         {
//             room.DisplayRoomDetails();
//             Console.WriteLine();
//         }

//         // Ask user to choose a room type
//         Console.Write("\nEnter your preferred Room: ");
//         string selectedRoomType = Console.ReadLine()?.ToLowerInvariant() ?? "";

//         Console.Write("Enter how many days you want to stay: ");
//         int numberOfDays = Convert.ToInt32(Console.ReadLine());

//         // Calculate total cost based on user input
//         switch (selectedRoomType)
//         {
//             case "standard":
//                 standardRoom.DisplayRoomDetails();
//                 Console.WriteLine("Total cost: " + manager.CalculateTotalCost(selectedRoomType, numberOfDays));
//                 break;
//             case "luxury":
//                 luxuryRoom.DisplayRoomDetails();
//                 Console.WriteLine("Total cost: " + manager.CalculateTotalCost(selectedRoomType, numberOfDays));
//                 break;
//             case "deluxe":
//                 deluxeRoom.DisplayRoomDetails();
//                 Console.WriteLine("Total cost: " + manager.CalculateTotalCost(selectedRoomType, numberOfDays));
//                 break;
//             default:
//                 Console.WriteLine($"Room type '{selectedRoomType}' not found.");
//                 break;
//         }
//     }
// }
