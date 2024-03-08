// using System;

// namespace TrafficManagement
// {
//     //   interface to represent common behaviors of entities in traffic management
//     interface IBehaviors
//     {
//         void Move();
//         void Stop();
//         void InteractWithTrafficSignals();
//     }

//     //  base class for vehicles implementing the IBehaviors interface
//     class Vehicle : IBehaviors
//     {
//         public void Move()
//         {
//             Console.WriteLine("Vehicle is moving.");
//         }

//         public void Stop()
//         {
//             Console.WriteLine("Vehicle has stopped.");
//         }

//         public void InteractWithTrafficSignals()
//         {
//             Console.WriteLine("Vehicle is interacting with traffic signals.");
//         }
//     }

//     //  subclass for cars inheriting from the Vehicle class
//     class Car : Vehicle
//     {
//         // Additional functionality specific to cars
//         public void BlowHorn()
//         {
//             Console.WriteLine("Car is Giving horn");
//         }
//     }

//     //  subclass for pedestrians implementing the IBehaviors interface
//     class Pedestrian : IBehaviors
//     {
//         public void Move()
//         {
//             Console.WriteLine("Pedestrian is walking.");
//         }

//         public void Stop()
//         {
//             Console.WriteLine("Pedestrian has stopped.");
//         }

//         public void InteractWithTrafficSignals()
//         {
//             Console.WriteLine("Pedestrian is crossing the road at the signal.");
//         }
//     }

//     // class for traffic signals
//     class TrafficSignal
//     {

//         public void ChangeSignal(string color)
//         {
//             Console.WriteLine("Traffic signal changed to " + color);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             TrafficSignal signal = new TrafficSignal();

//             Car myCar = new Car();
//             signal.ChangeSignal("Green");
//             myCar.Move();

//             System.Console.WriteLine();
//             signal.ChangeSignal("Red");
//             myCar.Stop();


//             System.Console.WriteLine();

//             signal.ChangeSignal("Yellow");
//             myCar.InteractWithTrafficSignals();
//             myCar.BlowHorn();

//             System.Console.WriteLine();

//             Pedestrian pedestrian = new Pedestrian();
//             signal.ChangeSignal("Red");
//             pedestrian.Move();

//             System.Console.WriteLine(); 

//             signal.ChangeSignal("Green");
//             System.Console.WriteLine("Now on green signal all the vehicles started moving , so to insure safety");
//             pedestrian.Stop();

//             System.Console.WriteLine();

//             signal.ChangeSignal("Yellow");
//             pedestrian.InteractWithTrafficSignals();



//         }
//     }
// }
