using System;

namespace OOPCSharpExercises.DefiningClasses_Exercises._07.SpeedingRacing
{
    public class Car
    {
        private string model;
        private double amountOfFuel;
        private double fuelConsumption;
        private int distance;

        public Car(string model, double amountOfFuel, double fuelConsumption)
        {
            this.Model = model;
            this.AmountOfFuel = amountOfFuel;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public double AmountOfFuel
        {
            get => amountOfFuel;
            set => amountOfFuel = value;
        }

        public double FuelConsumption
        {
            get => fuelConsumption;
            set => fuelConsumption = value;
        }

        public int Distance
        {
            get => distance;
            set => distance = value;
        }

        public void Drive(int distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel<= this.AmountOfFuel)
            {
                this.AmountOfFuel -= neededFuel;
                this.Distance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.AmountOfFuel:F2} {this.Distance}";
        }
    }
}