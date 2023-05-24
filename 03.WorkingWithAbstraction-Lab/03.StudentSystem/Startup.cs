using System;

namespace OOPCSharpExercises._03.WorkingWithAbstraction_Lab._03.StudentSystem
{
    public class Startup
    {
        public static void StudentSystem()
        {
            StudentSystem studentSystem = new StudentSystem();
            string input = Console.ReadLine();
            while (input !="Exit")
            {
                studentSystem.ParseCommand(input);
                input = Console.ReadLine();
            }
        }
    }
}