using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace Test.model
{
    class ClientModelTest
    {
        private string nom, prenom, mail, phone;
        private string[] address;
        private int id_client, id_societe;
        private dBconnectTest bdd;
        public ClientModelTest (int id_soc)
        {
            this.bdd = new dBconnectTest();
            this.id_societe = id_soc;
        }
        public string displayNameClient(int id_client)
        {
            string[] attributes = new string[] {"Cli_id","Cli_nom"};
            List<string>[] result;
            result = bdd.Select(string.Join(", ",attributes), "t_client",attributes," Soc_id ="+this.id_societe);
            string name = result[1][0];
            return name;
        }
        public string displayFirstNameClient(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_prenom" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe);
            string name = result[1][0];
            return name;
        }
        public string displayMail(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_mail" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe);
            string mail = result[1][0];
            return mail;
        }
        public int displayPhone(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_phone" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "t_client", attributes, " Soc_id =" + this.id_societe);
            int phone = Int32.Parse(result[1][0]);
            return phone;
        }
        public string[] findAddress(int id_client)
        {
            string[] attributes = new string[] { "Cli_id", "Cli_num_ad", "Cli_rue_ad", "Cli_ville_ad","Cli_pays_ad" };
            List<string>[] result;
            string[] address = new string[4];
            result = bdd.Select(string.Join(", ", attributes), "T_employe", attributes, " Cli_id= '" + id_client + "'");
            address = new string[] { result[1][0], result[2][0], result[3][0], result[4][0] };
            return address;
        }
    }
}
