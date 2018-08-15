using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;





namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        const int lägstaVånig = -2;
        const int högstaVåning = 3;
        private const int tidTillUnderhåll = 6;

        readonly Elevator elevator = new Elevator("Kalle", lägstaVånig, högstaVåning, start: 1, life: 6);

        [TestMethod]
        public void elevator_should_be_at_floor_one_when_thats_its_startfloor()
        {
            Assert.AreEqual(1, elevator.startVåning);
        }
    }
}
