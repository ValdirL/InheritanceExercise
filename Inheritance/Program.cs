using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird instance = new Bird();
            instance.BirdName = "Peacock";
            instance.CanFly = true;
            instance.Color = "Multicolor";
            instance.LaysEggs = false;

            Console.WriteLine($"A {instance.BirdName} is one of the most beautiful bird species. Its tends to be {instance.Color} and it is {instance.CanFly} that it can fly but is {instance.LaysEggs} that it lays eggs.");

            Reptile instance2 = new Reptile();
            instance2.ReptileName = "Lizard";
            instance2.CanCamo = true;
            instance2.IsColdBlooded = true;
            instance2.IsFriendly = false;

            Console.WriteLine($"I love {instance2.ReptileName}s!! They have the coolest characteristics. I'll admit, its {instance2.IsFriendly} that they are always friendly but its {instance2.CanCamo} that they can camoflauge and {instance2.IsColdBlooded} that the are cold blooded animals");
         

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
