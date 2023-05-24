using System;
using OOPCSharpExercises.DefiningClasses_Exercises._01.DefineClassPerson;

namespace OOPCSharpExercises.DefiningClasses_Exercises._02.CreatingConstructors
{
    public class Startup
    {
        public static void PersonConstructor()
        {
            Person person1 = new Person("Ben",21);
            Person person2 = new Person(21);
            Person person3 = new Person();
            Console.WriteLine($"Person 1:{person1.Name} {person1.Age}");
            Console.WriteLine($"Person 2:{person2.Name} {person2.Age}");
            Console.WriteLine($"Person 3:{person3.Name} {person3.Age}");
        }
        
    }
}