using NUnit.Framework;
using System.Collections.Generic;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Tests test = new Tests();
            test.RecupDonnee();
        }

        [Test]
        public  void RecupDonnee()
        {
            List<string>[] result;
            dBconnectTest bdd = new dBconnectTest();
            result = bdd.Select();
            Assert.AreEqual("Google", result[1][0]);
            
        }
    }
}