using ERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Controler
{
    class SocieteController
    {
        private Societe societe;
        private Form1 f1 = new Form1();
        public SocieteController(string name)
        {
            societe = new Societe(name);
        }
        public string getName()
        {
            return societe.getName();
        }
        public int getId()
        {
            Console.WriteLine(societe.getId());
            return societe.getId();

        }
        public int getPrix()
        {
            return societe.getPrix();
        }
        public string getAddress()
        {
            return societe.getAddress();
        }
        public int getPhoneNumber()
        {
            return societe.getPhone();
        }
        public string getMail()
        {
            return societe.getMail();
        }
        public void connexion()
        {
            if(societe.state == true)
            {
                MessageBox.Show("La société existe connectez-vous", "Ok");
                f1.connect(societe.getId());
            }
        }
        public string AfficherMail(string name)
        {
            string mail = societe.findMail(name);
            return mail;
        }
        public string AfficherPhone(string name)
        {
            string phone = societe.findPhone(name);
            return phone;
        }
        public string AfficherPrix(string name)
        {
            string prix = societe.findPrice(name);
            return prix;
        }
        public string [] AfficherAdresse(string name)
        {
            string[] adresse = new string[3];
            adresse = societe.findAddress(name);
            return adresse;
        }
        public void changeMail(string mail, int id_soc)
        {
            societe.updateMail(mail, id_soc);
        }
        public void changePhone(int phone,int id_soc)
        {
            societe.updatePhone(phone, id_soc);
        }
        public void changePrix(int prix,int id_soc)
        {
            societe.updatePrice(prix, id_soc);
        }
        public void changeAdresse(string numAd, string rueAd, string villeAd, int id_soc)
        {
            societe.updateAddress(numAd, rueAd, villeAd, id_soc);
        }
    }
}
