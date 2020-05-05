using NUnit.Framework;
using System.Collections.Generic;
using System.Globalization;

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
            string[] tableau;
            tableau = new string[] {"Soc_nom","Soc_Phone","Soc_mail" };
            
            List<string>[] result;
            dBconnectTest bdd = new dBconnectTest();

            //bdd.insert("T_societe", tableau,lignes);
            result = bdd.Select(string.Join(", ", tableau), "T_societe", tableau, "Soc_id = 2");
            Assert.AreEqual("Google", result[0][0]);
            
        }
    }
}