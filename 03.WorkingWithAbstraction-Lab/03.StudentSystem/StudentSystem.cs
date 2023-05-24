using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace OOPCSharpExercises._03.WorkingWithAbstraction_Lab._03.StudentSystem
{
    public class StudentSystem
    {
        private Dictionary<string, Student> _students;

        public StudentSystem()
        {
            this._students = new Dictionary<string, Student>();
        }

        public void ParseCommand(string input)
        {
            string[] inputParts = input.Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
            string command = inputParts[0];
            switch(command)
            {
                case "Create":
                    this.CreateCommand(inputParts);
                    break;
                case "Show":
                    this.ShowCommand(inputParts);
                    break;
            }
        }

        private void ShowCommand(string[] inputParts)
        {
            string name = inputParts[1];
            if (this._students.ContainsKey(name))
            {
                Student student = this._students[name];
                Console.WriteLine(student);
            }
        }
        private void CreateCommand(string[] inputParts)
        {
            string name = inputParts[1];
            int age = int.Parse(inputParts[2]);
            double grade = double.Parse(inputParts[3]);
            if (!this._students.ContainsKey(name))
            {
                Student student = new Student(name, age, grade);
                this._students[name] = student;
            }
        }
    }
}