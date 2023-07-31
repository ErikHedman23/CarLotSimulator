﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }
        public void MakeEngineNoise()
        {
            Console.WriteLine($"The {Year} {Make} {Model} is revving up! '{EngineNoise}'");
        }
        public void MakeHonkNoise(bool isDriveable)
        {
            if (isDriveable == true)
            {
             Console.WriteLine($"{Year} {Make} {Model} '{HonkNoise}'!");

            }
            else
            {
                Console.WriteLine("Uh oh, this one isn't starting for some reason...");
            }
        }
        public void CarDetails()
        {
            Console.WriteLine($"{Year} {Make} {Model}\nWhat a Hot-Rod!");
        }
       
    }

    
}
