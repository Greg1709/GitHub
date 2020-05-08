using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Model;
namespace ERP.Controler
{
    class ClientControler
    {
        private ClientModel model;
        public ClientControler(int id_soc)
        {
            model = new ClientModel(id_soc);
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
        public void InscrireClient(string nom, string prenom, int numero, string rue, string ville, string pays, int phone, string mail)
        {
            model.signIn(nom, prenom, numero, rue, ville, pays, phone, mail);
        }
        public List<string>[] afficherClients()
        {
            List<string>[] result;
            result = model.displayAllClients();
            return result;
        }
        public void supprimerClient(int id_client)
        {
            model.deleteClient(id_client);
        }
    }
}
