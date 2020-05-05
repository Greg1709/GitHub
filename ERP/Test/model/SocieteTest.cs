using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Test.model
{
    class SocieteTest
    {
        private int phone, id, price;
        private string name, mail,address;
        
        private dBconnectTest bdd = new dBconnectTest();
        [SetUp]
        public void setup()
        {
            
        }
        public SocieteTest(string name)
        {
            List<string>[] result;
            string[] attributes = new string[] { "Soc_id", "Soc_nom", "Soc_num_ad", "Soc_rue_ad", "Soc_ville_ad", "Soc_main_oeuvre", "Soc_phone", "Soc_mail" };
            result = bdd.Select(string.Join(", ", attributes), "T_societe", attributes, "Soc_nom = '"+name+"'");
            this.id = Int32.Parse(result[0][0]);
            this.name = result[1][0];
            this.address = result[2][0] + " " + result[3][0] + " " + result[4][0];
            this.price = Int32.Parse(result[5][0]);
            this.phone = Int32.Parse(result[6][0]);
            this.mail = result[7][0];
        }
        
        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public int getPrix()
        {
            return this.price;
        }
        public string getAddress()
        {
            return this.address;
        }
        public int getPhone()
        {
            return this.phone;
        }
        public string getMail()
        {
            return this.mail;
        }

    }
}
