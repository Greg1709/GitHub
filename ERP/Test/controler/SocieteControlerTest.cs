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
        
        public string AfficherMail(string name)
        {
            string mail = googleModel.findMail(name);
            return mail;
        }
        public string AfficherPhone(string name)
        {
            string phone = googleModel.findPhone(name);
            return phone;
        }
        public string AfficherPrix(string name)
        {
            string prix = googleModel.findPrice(name);
            return prix;
        }
        public string[] AfficherAdresse(string name)
        {
            string[] adresse = new string[3];
            adresse = googleModel.findAddress(name);
            return adresse;
        }
        public void changeMail(string mail, int id_soc)
        {
            googleModel.updateMail(mail, id_soc);
        }
        public void changePhone(int phone, int id_soc)
        {
            googleModel.updatePhone(phone, id_soc);
        }
        public void changePrix(int prix, int id_soc)
        {
            googleModel.updatePrice(prix, id_soc);
        }
        public void changeAdresse(string numAd, string rueAd, string villeAd, int id_soc)
        {
            googleModel.updateAddress(numAd, rueAd, villeAd, id_soc);
        }
    }
}
