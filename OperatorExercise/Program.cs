using System;
using System.Collections.Generic;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            CarClass myCar = new CarClass();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            var mazda = new CarClass()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            var chevy = new CarClass("Chevy", "Impala", 2001);

            //var carList = new List<CarClass>() { myCar, mazda, chevy};

            var carList = new List<CarClass>() { myCar, mazda, chevy};
            //var Console.WriteLine(carList.Capacity);

            //Console.WriteLine(carList.Capacity);

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Model} {vehicle.Year}");
            }



        }
    }
}

