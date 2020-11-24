using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {

        public Car()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; } = "Vroom";
        public string HonkNoise { get; set; } = "Beep!";
        public bool IsDriveable { get; set; }

        public Car(string Make, string Model, int Year, string engineNoise, string honkNoise, bool isDriveable)
        {
 
        }

        public void MakeEngineNoise()
        {
           Console.WriteLine($"Engine noise is: {EngineNoise}");
        }
        public void MakeHonkNoise()
        {
           Console.WriteLine($"Horn noise is: {HonkNoise}");
        }
        public void CarIsDriveable()
        {
            Console.WriteLine($"Car is driveable? {IsDriveable}");
        }
    }
}
