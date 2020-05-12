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
            controler = new DevisControler(2);
        }
        [Test]
        public void insert()
        {
            controler.creerDevis("2020-09-17 15:25:00",1,"DE004",1);
        }
        [Test]
        public void afficherIdProduit()
        {
            int res;
            res = controler.getIdProduit("Macbook pro");
            Assert.AreEqual(1, res);
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
        [Test]
        public void RecupIdDevis()
        {
            Assert.AreEqual(1, controler.getIdDevis("DE001"));
        }
        [Test]
        public void InsertLigneDevis()
        {
           
            controler.insertLigneDevis(controler.getIdDevis("DE001"), controler.getIdProduit("Macbook pro"));
        }
        [Test]
        public void afficherLignes()
        {
            List<string>[] result;
            result = controler.afficherLignes(controler.getIdDevis("DE001"));
            Assert.AreEqual("Macbook pro", result[0][0]);
            Assert.AreEqual(1500, Int32.Parse(result[1][0]));
        }
        [Test]
        public void afficherDevisAccepter()
        {
            List<string>[] res;
            res = controler.afficherDevisAccepter(1);
            Assert.AreEqual("DE003", res[0][0]);
        }
        [Test]
        public void afficherDevisAttente()
        {
            List<string>[] res;
            res = controler.afficherDevisAccepter(0);
            Assert.AreEqual("DE001", res[0][0]);
        }
    }
}
