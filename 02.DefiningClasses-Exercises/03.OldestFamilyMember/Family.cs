using System.Collections.Generic;
using System.Linq;

namespace OOPCSharpExercises.DefiningClasses_Exercises._03.OldestFamilyMember
{
    public class Family
    {
        public List<Person> people =new List<Person>();

        public void Addmenber(Person person)
        {
            this.people.Add(person);
        }

        public Person GetOldestMember()
        {
            Person person = this.people.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;
        }
        
    }
}