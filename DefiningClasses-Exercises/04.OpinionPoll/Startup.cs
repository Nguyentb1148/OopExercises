using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPCSharpExercises.DefiningClasses_Exercises._04.OpinionPoll
{
    public class Startup
    {
        public static void OpinionPoll()
        {
            Console.Write("Input numbers of people: ");
            int number = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] inputParts = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = inputParts[0];
                int age = int.Parse(inputParts[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }
            
            Console.WriteLine();
            
            people.Where(p => p.Age > 20).OrderBy(p => p.Name).ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} {p.Age}"));
        }
    }
}