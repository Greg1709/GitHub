﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.controler;

namespace Test.view
{
    class ClientViewTest
    {
        private ClientControlerTest1 controler;
        [SetUp]
        public void setup()
        {
            controler = new ClientControlerTest1(2);
        }
        [Test]
        public void afficherNom()
        {
            Assert.AreEqual("Deneuve", controler.afficherNom(1));

        }
        [Test]
        public void afficherPrenom()
        {
            Assert.AreEqual("test", controler.afficherPrenom(1));

        }
        [Test]
        public void afficherMail()
        {
            Assert.AreEqual("@hello", controler.afficherMail(1));

        }
        [Test]
        public void afficherTel()
        {
            Assert.AreEqual(645, controler.afficherTel(1));

        }
        [Test]
        public void AfficherAdresse()
        {
            string[] adresse = controler.afficherAdresse(1);
            Assert.AreEqual("126", adresse[1]);
            Assert.AreEqual("rue jean masset", adresse[2]);
            Assert.AreEqual("paris", adresse[3]);
            Assert.AreEqual("France", adresse[4]);
        }
    }
}
