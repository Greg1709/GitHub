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
            string[] tableau,lignes;
            tableau = new string[] {"Soc_nom","Soc_num_ad","Soc_rue_ad","Soc_ville_ad","Soc_main_oeuvre","Soc_Phone","Soc_mail" };
            lignes = new string[] { "Facebook", "14", "rue august", "Paris","1405","12654","@kjhe" };
            List<string>[] result;
            dBconnectTest bdd = new dBconnectTest();
            bdd.delete("T_societe","  Soc_id = 5");
            //bdd.insert("T_societe", tableau,lignes);
            result = bdd.Select();
            Assert.AreEqual("Google", result[1][0]);
            
        }
    }
}