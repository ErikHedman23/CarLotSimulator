using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            var garage = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property
            Car car_1 = new Car();
            
                car_1.Year = 1999;
                car_1.Make = "Cheverolet";
            car_1.Model = "Trailblazer";
            car_1.EngineNoise = "'rummmmmmmm'";
            car_1.HonkNoise = "Honk";
            car_1.IsDriveable = true;
            car_1.MakeEngineNoise();
            car_1.MakeHonkNoise(true);

            garage.CarsLot.Add(car_1);

            Car car_2 = new Car(2000, "Ford", "F-150", "hummmmmmmm", "Honk Honk", true);

            car_2.MakeEngineNoise();
            car_2.MakeHonkNoise(true);

            garage.CarsLot.Add(car_2);

            var car_3 = new Car(1990, "Volkswagen", "Beetle", "mmmmmmmmmmm", "beee-beeep", false);

            car_3.MakeEngineNoise();
            car_3.MakeHonkNoise(false);

            garage.CarsLot.Add(car_3);
            Console.WriteLine("\nThese are the cars in my garage!");
            garage.MyGarage();

            

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
