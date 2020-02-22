using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncapsulationAndAbstraction;
using Inheritance;
using Polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationAndAbstraction.Tests
{
    [TestClass()]
    public class OOPTests
    {
        [TestMethod()]
        public void PersonTest()
        {
            Person person = new Person("Mike", 22, "Male", "Student");
            Assert.AreEqual("Mike", person.getName());
        }

        [TestMethod()]
        public void ChangeJobTest()
        {
            Person person = new Person("Mike", 22, "Male", "Student");
            person.changeJob("Developer");
            Assert.AreEqual("Developer", person.getJob());
        }

        [TestMethod()]
        public void InheritanceTest()
        {
            Teacher teacher = new Teacher("Mike", 22, "Male", "History", "NJIT");
            Assert.AreEqual("Mike", teacher.getName());
        }

        [TestMethod()]
        public void PolyTest()
        {
            Shape s = new Shape();
            Assert.AreEqual(9, s.Perimeter(3,3,3));
            Assert.AreEqual(10, s.Perimeter(1,2,3,4));
        }
    }
}