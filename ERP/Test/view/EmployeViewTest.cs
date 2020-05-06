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
        [Test]
        public void trouverPrenom()
        {
            string name;
            name = ControlerTest.findFirstName(1);
            Assert.AreEqual("Gregory", name);
        }
        [Test]
        public void trouverNom()
        {
            string name;
            name = ControlerTest.findName(1);
            Assert.AreEqual("Deneuve", name);
        }
        [Test]
        public void trouverRole()
        {
            string role;
            role = ControlerTest.findRole(1);
            Assert.AreEqual("Administrateur", role);
        }
        [Test]
        public void testChangePass()
        {
            ControlerTest.changePass("HelloWorld", 2);
            ControlerTest.connexion("Greg", "HelloWorld");
            Assert.AreEqual("A9-4A-8F-E5-CC-B1-9B-A6-1C-4C-08-73-D3-91-E9-87-98-2F-BB-D3", ControlerTest.getPass());
            
        }
        [Test]
        public void testChangeName()
        {
            string name;
            name = ControlerTest.findName(2);
            ControlerTest.changeName("Deneuve", 2);
            Assert.AreEqual("Deneuve", name);
        }
    }
}
