using NuGet.Frameworks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Test.model;
using Test.view;

namespace Test.controler
{
    class SocieteControlerTest
    {
        private SocieteTest googleModel;
        private SocieteViewTest googleView = new SocieteViewTest();
        [SetUp]
        public void SetUp()
        {
            
        }
        public SocieteControlerTest(string name)
        {
            googleModel = new SocieteTest(name);
        }
        
      
        public string getName()
        {
            return googleModel.getName();
        }

        public int getPrix()
        {
            return googleModel.getPrix();
        }
        public string getAddress()
        {
            return googleModel.getAddress();
        }
        public int getPhoneNumber()
        {
            return googleModel.getPhone();
        }
        public string getMail()
        {
            return googleModel.getMail();
        }
        public void connexion()
        {
            if(googleModel.state == true)
            {
                googleView.Connect();
            }
        }
        public void updateOeuvre(int soc_id, int oeuvre)
        {
            googleModel.updateOeuvre(soc_id, oeuvre);
        }
    }
}
