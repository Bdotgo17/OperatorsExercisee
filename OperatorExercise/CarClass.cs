using System;
namespace OperatorExercise
{
    public class CarClass
    {
        public CarClass()
        {

        }

        public CarClass(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }


    }
}

