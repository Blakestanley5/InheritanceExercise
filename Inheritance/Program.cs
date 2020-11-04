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


            var blueBird = new Bird();
            blueBird.HasHair = true;
            blueBird.NumOfLegs = 2;
            blueBird.Tail = true;
            blueBird.Species = "Bird";
            blueBird.CanFly = true;
            blueBird.Color = "Blue";
            blueBird.WingSpanFeet = 1;
            blueBird.FlyDistanceMiles = 5;



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile();
            snake.HasHair = false;
            snake.NumOfLegs = 0;
            snake.Tail = false;
            snake.Species = "Snake";
            snake.IsColdBlooded = true;
            snake.HasLegs = false;
            snake.HasScales = true;
            snake.EatMeat = true;

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
