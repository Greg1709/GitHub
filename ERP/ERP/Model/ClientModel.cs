using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Model
{
    class ClientModel
    {
        private string nom, prenom, mail, phone;
        private string[] address;
        private int id_client, id_societe;
        private dBConnect bdd;
        public ClientModel(int id_soc)
        {
            this.bdd = new dBConnect();
            this.id_societe = id_soc;
        }
        public string displayNameClient(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_nom" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe + " AND Cli_id=" + id_client);
            string name = result[1][0];
            return name;
        }
        public string displayFirstNameClient(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_prenom" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe + " AND Cli_id=" + id_client);
            string name = result[1][0];
            return name;
        }
        public string displayMail(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_mail" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe + " AND Cli_id=" + id_client);
            string mail = result[1][0];
            return mail;
        }
        public int displayPhone(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_phone" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe + " AND Cli_id=" + id_client);
            int phone = Int32.Parse(result[1][0]);
            return phone;
        }
        public string[] findAddress(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_num_ad", "Cli_rue_ad", "Cli_ville_ad", "Cli_pays_ad" };
            List<string>[] result;
            string[] address = new string[4];
            result = bdd.Select(string.Join(", ", attributes), "T_client", attributes, " Cli_id= " + id_client + " AND Soc_id=" + this.id_societe);
            address = new string[] { result[1][0], result[2][0], result[3][0], result[4][0] };
            return address;
        }

        public void signIn(string nom, string prenom, int numero, string rue, string ville, string pays, int phone, string mail)
        {
            string table = "t_client";
            string[] nomLigne = new string[] { "Cli_nom", "Cli_prenom", "Cli_num_ad", "Cli_rue_ad", "Cli_ville_ad", "Cli_pays_ad", "Cli_phone", "Cli_mail", "Soc_id" };
            string[] value = new string[] { nom, prenom, numero.ToString(), rue, ville, pays, phone.ToString(), mail, this.id_societe.ToString() };
            bdd.insert(table, nomLigne, value);
        }

        public List<string>[] displayAllClients()
        {
            List<string>[] result;
            string[] attributes = new string[] { "Cli_nom", "Cli_prenom","Cli_id" };
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id=" + this.id_societe);
            return result;
        }
        public void deleteClient(int id_client)
        {
            bdd.delete("t_client", "Soc_id=" + this.id_societe + " AND Cli_id=" + id_client);
        }
    }
}
