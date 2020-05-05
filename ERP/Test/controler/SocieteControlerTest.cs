using NuGet.Frameworks;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Test.model;

namespace Test.controler
{
    class SocieteControlerTest
    {
        private SocieteTest googleModel;
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
    }
}
