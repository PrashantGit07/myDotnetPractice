// using System;

// namespace Zoo
// {
//     // Base class representing basic properties and behaviors of animals
//     class BaseClass
//     {
//         public string? name { get; protected set; }
//         public int age { get; protected set; }

//         //virtual methods for behaviors
//         public virtual void Eat() { }
//         public virtual void Sleep() { }

//         public virtual void Sound()
//         {
//             // Default sound explanation
//             Console.WriteLine("Animals make different sounds, some sniff, some roar, some trumpet, some bark, and many more" + "\n");
//         }
//     }

//     // Derived class for carnivorous animals
//     class Carnivorous : BaseClass
//     {
//         // Override eat method for carnivorous animals
//         public override void Eat()
//         {
//             Console.WriteLine("Carnivorous animals eat flesh" + "\n");
//         }

//         // Override sleep method for carnivorous animals
//         public override void Sleep()
//         {
//             Console.WriteLine("Carnivorous animals sleep during the day and hunt at night" + "\n");
//         }
//     }

//     // Derived class for herbivorous animals
//     class HerbivorousAnimal : BaseClass
//     {
//         // Override eat method for herbivorous animals
//         public override void Eat()
//         {
//             Console.WriteLine("Herbivorous animals eat fruits, grass, plant leaves, etc." + "\n");
//         }

//         // Override sleep method for herbivorous animals
//         public override void Sleep()
//         {
//             Console.WriteLine("Herbivorous animals sleep during the night and during the day they travel searching for food" + "\n");
//         }
//     }

//     // Derived class for lions, a carnivorous animal
//     class LionClass : Carnivorous
//     {
//         // Constructor for Lion class
//         public LionClass(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//         }

//         // Override sound method for Lion class
//         public override void Sound()
//         {
//             base.Sound();
//             // Lion specific sound
//             Console.WriteLine("Lion makes a Roaring Sound" + "\n");
//         }

//         // Override eat method for Lion class
//         public override void Eat()
//         {
//             base.Eat();
//             System.Console.WriteLine("Lion is a carnivorous animal" + "\n");
//         }
//     }

//     // Derived class for elephants, a herbivorous animal
//     class Elephant : HerbivorousAnimal
//     {
//         // Constructor for Elephant class
//         public Elephant(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//         }

//         // Override sound method for Elephant class
//         public override void Sound()
//         {
//             base.Sound();
//             Console.WriteLine("Elephants make the sound of a trumpet" + "\n");
//         }

//         // Override eat method for Elephant class
//         public override void Eat()
//         {
//             base.Eat();
//             System.Console.WriteLine("Elephant is a herbivorous animal" + "\n");
//         }
//     }

//     // Derived class for tigers, a carnivorous animal
//     class Tiger : Carnivorous
//     {
//         // Constructor for Tiger class
//         public Tiger(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//         }

//         // Override sound method for Tiger class
//         public override void Sound()
//         {
//             base.Sound();
//             Console.WriteLine("Tiger makes a Growling Sound" + "\n");
//         }

//         // Override eat method for Tiger class
//         public override void Eat()
//         {
//             base.Eat();
//             System.Console.WriteLine("Tiger is a carnivorous animal" + "\n");
//         }
//     }

//     // Derived class for giraffes, a herbivorous animal
//     class Giraffe : HerbivorousAnimal
//     {
//         // Constructor for Giraffe class
//         public Giraffe(string name, int age)
//         {
//             this.name = name;
//             this.age = age;
//         }

//         // Override sound method for Giraffe class
//         public override void Sound()
//         {
//             base.Sound();
//             Console.WriteLine("Giraffes make a Grunting Sound" + "\n");
//         }

//         // Override eat method for Giraffe class
//         public override void Eat()
//         {
//             base.Eat();
//             System.Console.WriteLine("Giraffe is a herbivorous animal" + "\n");
//         }
//     }

//     // Main class containing the entry point of the program
//     class ZooClass
//     {
//         public static void Main(string[] args)
//         {
//             // Creating a Lion object
//             LionClass lion = new LionClass("Sher", 15);
//             System.Console.WriteLine("-----------------------------------");

//             // Displaying details about the Lion
//             Console.WriteLine("Details about the Lion :" + "\n");
//             Console.WriteLine("The name of the lion is  : " + lion.name + "\n");
//             Console.WriteLine("The age of the Lion is : " + lion.age + "\n");
//             lion.Sound();
//             lion.Eat();
//             lion.Sleep();


//             System.Console.WriteLine("-----------------------------------");

//             // Creating an Elephant object
//             Console.WriteLine("The details about the Elephant is : " + "\n");
//             Elephant elephant = new Elephant("Boxer", 50);
//             Console.WriteLine("the name of elephant : " + elephant.name + "\n");
//             Console.WriteLine("The age of elephant is  : " + elephant.age + "\n");
//             elephant.Sound();
//             elephant.Eat();
//             elephant.Sleep();

//             System.Console.WriteLine("-----------------------------------");

//             // Creating a Tiger object
//             Console.WriteLine("The details about the Tiger is : " + "\n");
//             Tiger tiger = new Tiger("Stripes", 10);
//             Console.WriteLine("the name of tiger : " + tiger.name + "\n");
//             Console.WriteLine("The age of tiger is  : " + tiger.age + "\n");
//             tiger.Sound();
//             tiger.Eat();
//             tiger.Sleep();

//             System.Console.WriteLine("-----------------------------------");

//             // Creating a Giraffe object
//             Console.WriteLine("The details about the Giraffe is : " + "\n");
//             Giraffe giraffe = new Giraffe("Stretch", 7);
//             Console.WriteLine("the name of giraffe : " + giraffe.name + "\n");
//             Console.WriteLine("The age of giraffe is  : " + giraffe.age + "\n");
//             giraffe.Sound();
        
