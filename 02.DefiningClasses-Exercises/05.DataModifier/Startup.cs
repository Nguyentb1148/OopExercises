using System;

namespace OOPCSharpExercises.DefiningClasses_Exercises._05.DataModifier
{
    public class Startup
    {
        public static void DataModifier()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();

            DateTime firstDate = DateTime.ParseExact(firstInput, "yyyy MM dd",null);
            DateTime secondDate = DateTime.ParseExact(secondInput, "yyyy M dd", null);
            DataModifier dataModifier = new DataModifier();
            Console.WriteLine(dataModifier.CalculateDay(firstDate,secondDate));
        }
    }
}