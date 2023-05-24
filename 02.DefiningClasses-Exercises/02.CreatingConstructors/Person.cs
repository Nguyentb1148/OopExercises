namespace OOPCSharpExercises.DefiningClasses_Exercises._02.CreatingConstructors
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name;}
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age;}
            set { this.age = value; }
        }
        public Person(string name, int age)//Constructor 2 parameters
        {
            this.Name = name;
            this.Age = age;
        }

        public Person() : this("No name", 1)//Constructor 1 parameter
        {
            
        }

        public Person(int age) : this("No name", age)//Constructor without parameter
        {
            
        }
    }
}