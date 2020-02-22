using System;

namespace EncapsulationAndAbstraction
{
    public class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Gender { get; set; }
        private string Job { get; set; }

        public Person(string name, int age, string gender, string job)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Job = job;
        }

        public string getName()
        {
            return this.Name;
        }

        public void changeJob(string newJob)
        {
            this.Job = newJob;
        }
    }
}
