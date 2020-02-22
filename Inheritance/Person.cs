using System;

namespace Inheritance
{
    public class Person
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Gender { get; set; }

        public Person()
        {
            Name = "";
            Age = -1;
            Gender = "";
        }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string getName()
        {
            return this.Name;
        }
    }

    public class Teacher : Person
    {
        private string Subject { get; set; }
        private string TeachingAt { get; set; }

        public Teacher(string name, int age, string gender, string subject, string college)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Subject = subject;
            TeachingAt = college;
        }
    }
}
