using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.model;

namespace Test.controler
{
    class ClientControlerTest1
    {
        private ClientModelTest model;
        public ClientControlerTest1(int id_soc)
        {
            model = new ClientModelTest(id_soc);
        }
        public string afficherNom(int id_client)
        {
            string nom;
            nom = model.displayNameClient(id_client);
            return nom;
        }
        public string afficherPrenom(int id_client)
        {
            string nom;
            nom = model.displayFirstNameClient(id_client);
            return nom;
        }
        public string afficherMail(int id_client)
        {
            string mail;
            mail = model.displayMail(id_client);
            return mail;
        }
        public int afficherTel(int id_client)
        {
            int phone;
            phone = model.displayPhone(id_client);
            return phone;
        }
        public string[] afficherAdresse(int id_client)
        {
            string[] adresse = new string[4];
            adresse = model.findAddress(id_client);
            return adresse;
        }
    }
}
