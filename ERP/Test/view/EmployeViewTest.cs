using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.controler;

namespace Test.view
{
    class EmployeViewTest
    {
        private EmpControler ControlerTest = new EmpControler(2);
       
       
        public void test()
        {
            //ControlerTest.connexion("Gregory", "test");
            Assert.AreEqual("1", ControlerTest.getEmpId());
        }
        [Test]
        public void afficherIdEmploye()
        {
            ControlerTest.connexion("Gregory", "test");
            Assert.AreEqual(1, ControlerTest.getEmpId());
        }
        [Test]
        public void afficherNom()
        {
            ControlerTest.connexion("Gregory", "test");
            Assert.AreEqual("Deneuve",ControlerTest.getNom());
        }
        [Test]
        public void afficherPrenom()
        {
            ControlerTest.connexion("Gregory", "test");
            Assert.AreEqual("Gregory", ControlerTest.getFirstName());
        }
        [Test]
        public void afficherRole()
        {
            ControlerTest.connexion("Gregory", "test");
            Assert.AreEqual("Administrateur", ControlerTest.getRole());
        }
    }
}
