using System;

namespace OOPCSharpExercises.DefiningClasses_Exercises._03.OldestFamilyMember
{
    public class Startup
    {
        public static void OldestPerson()
        {
            Console.Write("Input numbers of people in family: ");
            int num = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < num; i++)
            {
                string[] inputParts = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputParts[0];
                int age = int.Parse(inputParts[1]);
                Person person = new Person(name, age);
                family.Addmenber(person);
            }

            Person oldestPerson = family.GetOldestMember();
            Console.WriteLine($"Oldest person: {oldestPerson.Name} : {oldestPerson.Age}");
        }
    }
}