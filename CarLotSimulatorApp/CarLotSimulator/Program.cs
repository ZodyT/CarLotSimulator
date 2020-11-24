using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carLot = new CarLot();

            // Standard Initializer
            var Car1 = new Car(); 
            Car1.Make = "Chevrolet";
            Car1.Model = "Classic";
            Car1.Year = 2004;
            Car1.EngineNoise = "Zoom Zoom";
            Car1.HonkNoise = "Beep Beep";
            Car1.IsDriveable = true;

            // Object Initializer
            var Car2 = new Car() { Make = "Nissan", Model = "Pathfinder", Year = 2001, EngineNoise = "Vroom", HonkNoise = "Beep", IsDriveable = true };

            var Car3 = new Car() { Make = "Toyota", Model = "Camry", Year = 1995, EngineNoise = "Clank Clunk", HonkNoise = "there is no horn noise", IsDriveable = false };

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            carLot.ParkingLot = new List<Car>() { Car1, Car2, Car3 };

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                car.CarIsDriveable();
                Console.WriteLine("---------------------------");
            }

        }
    }
}