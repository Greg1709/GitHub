using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.controler;
using Test.model;

namespace Test.view
{
    class CalendrierView
    {
        private CalendrierControler controler;

       [SetUp]
       public void setup()
        {
            controler = new CalendrierControler(2,1);
        }
        [Test]
        public void afficherRdv()
        {
            List<string>[] res;
            res = controler.afficherRDV();
            Assert.AreEqual("Rdv important", res[0][0]);
        }
        [Test]
        public void NouveauRDV()
        {
            DateTime date = new DateTime();
            controler.inscrirRDV("Rdv super important", date,2,5 );
        }
        [Test]
        public void SupprimerRDV()
        {
            controler.deleteRDV(2);
        }
    }
}
