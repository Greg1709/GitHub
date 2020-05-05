using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.controler;

namespace Test.view
{
    class SocieteViewTest
    {
       private SocieteControlerTest googleControler = new SocieteControlerTest("Google");
        [Test]
        public void afficher()
        {
            Assert.AreEqual("Google", googleControler.getName());
        }
       [Test]
        public void getPrix()
        {
            Assert.AreEqual(7, googleControler.getPrix());
        }

       [Test]
        public void getAddress()
        {
            Assert.AreEqual("126 rue jean masset a 10 min du tram", googleControler.getAddress());
        }
        [Test]
        public void Numero()
        {
            Assert.AreEqual(70, googleControler.getPhoneNumber());
        }
        [Test]
        public void afficherMail()
        {
            Assert.AreEqual("hello@boys", googleControler.getMail());
        }
        [Test]
        public void Connect()
        {
            Assert.Pass();
        }
    }
}
