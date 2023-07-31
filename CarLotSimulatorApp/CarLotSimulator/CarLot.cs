using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> CarsLot { get; set; } = new List<Car>();

        public void MyGarage()
        {
            foreach (Car car in CarsLot)
            {
                car.CarDetails();
            }
        }
    }
}
