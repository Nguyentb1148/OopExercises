using System;

namespace OOPCSharpExercises.DefiningClasses_Exercises._01.DefineClassPerson
{
    public class StartUp
    {
        public static void PersonMain()
        {
            Person person = new Person();
            person.Age = 21;
            person.Name = "Ben";
            Console.WriteLine($"{person.Name}  :  {person.Age}");
        }
    }
}