using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car()
        {
            CarLot.numberOfCars++; //Everytime this class is used to create a new instance of a car, CarLot.numberOfCars++ is called, and it increments the static field numberOfCars by 1 every time a new instance is created. 
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLot.numberOfCars++;
        }
        public void MakeEngineNoise(string engineNoise)
        {
            EngineNoise = engineNoise;
            Console.WriteLine($"The {Year} {Make} {Model} is revving up! '{engineNoise}'");
        }
        public void MakeHonkNoise(bool userInfo)
        {
            
            
            Console.WriteLine("Type true if your car is driveable, and false if it is not.");
            userInfo = IsDriveable; 
            //var checkEngine = bool.TryParse(userInfo, out bool response);
            if(userInfo == false)
            {
                Console.WriteLine("Uh oh, this one isn't wanting to start... strange.");
            }
            else
            {
                Console.WriteLine($"{HonkNoise}!");
            }


            //if (isDriveable == true)
            //{
             //Console.WriteLine($"{Year} {Make} {Model} '{HonkNoise}'!");

            //}
            //else
            //{
            //    Console.WriteLine("Uh oh, this one isn't starting for some reason...");
            //}
        }
        public void CarDetails()
        {
            Console.WriteLine($"{Year} {Make} {Model}\nWhat a Hot-Rod!");
        }
       
    }

    
}
