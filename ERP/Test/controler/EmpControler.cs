using NUnit.Framework;
using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using Test.model;

namespace Test.controler
{
    class EmpControler
    {
        private EmpModelTest modelTest;
        public EmpControler(int id_soc)
        {
            modelTest = new EmpModelTest(2);
        }
        
       
        public void connexion(string prenom, string pass)
        {
            modelTest.connection("Gregory", "test");
            if(modelTest.state == true)
            {
                //Code gestion de la winform
            }
        }

       
        public int getEmpId()
        {
            
            return modelTest.getId();
        }
        public string getNom()
        {
            return modelTest.getNom();
        }
        public string getFirstName()
        {
            return modelTest.getFirstName();
        }
        public string getRole()
        {
            return modelTest.getRole();
        }
    }

}
