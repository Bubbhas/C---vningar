using Animalsinalist8i3i;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Animaltest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            string animals = "Lion,tiger,Monkey";
            string[] list = animals.Split(",");

            Program.CheckForValidAnimals(list);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string animals = "Lion,tiger,Monkey";

            Program.CheckForValidString(animals);
        }
    }
}
