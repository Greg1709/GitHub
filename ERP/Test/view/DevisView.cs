using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.controler;

namespace Test.view
{
    class DevisView
    {
        private DevisControler controler;
        [SetUp]
        public void setup()
        {
            controler = new DevisControler(2, 1);
        }
        [Test]
        public void insert()
        {
            controler.creerDevis("2020-09-17 15:25:00",0,"DE001");
        }
        [Test]
        public void afficherIdProduit()
        {
            List<string>[] res;
            res = controler.getIdProduit("Macbook pro");
            Assert.AreEqual(1, Int32.Parse(res[0][0]));
        }
        [Test]
        public void newProduit()
        {
            controler.creerProduit("iPhone 11 pro", 1500);
        }
        [Test]
        public void getPrix()
        {
            Assert.AreEqual(1500, controler.getPrixProduit(3));
        }
        [Test]
        public void afficherNomProduit()
        {
            List<string>[] res;
            res = controler.afficherNomProduit();
            Assert.AreEqual("Mac mini", res[0][1]);
        }
    }
}
