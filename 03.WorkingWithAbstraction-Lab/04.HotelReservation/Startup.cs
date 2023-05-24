using System;

namespace OOPCSharpExercises._03.WorkingWithAbstraction_Lab._04.HotelReservation
{
    public class Startup
    {
        public static void HotelReservation()
        {
            string input = Console.ReadLine();
            PriceCalculator calculator = new PriceCalculator();
            calculator.ParseCommand(input);
            calculator.CalcualteTotalPrice();
        }
    }
}