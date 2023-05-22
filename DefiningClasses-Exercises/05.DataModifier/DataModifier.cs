using System;

namespace OOPCSharpExercises.DefiningClasses_Exercises._05.DataModifier
{
    public class DataModifier
    {
        public double CalculateDay(DateTime firstDate, DateTime secondDate)
        {
            return Math.Abs((firstDate - secondDate).TotalDays);
        }
    }
}