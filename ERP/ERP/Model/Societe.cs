using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Model
{
    public class Societe
    {
        private int phone, id, price;
        private string name, mail, address;
        public bool state;
        private dBConnect bdd = new dBConnect();
        public Societe(string name)
        {
            List<string>[] result;
            string[] attributes = new string[] { "Soc_id", "Soc_nom", "Soc_num_ad", "Soc_rue_ad", "Soc_ville_ad", "Soc_main_oeuvre", "Soc_phone", "Soc_mail" };
            result = bdd.Select(string.Join(", ", attributes), "T_societe", attributes, "Soc_nom = '" + name + "'");
            this.state = getConnexion(result);
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
        private bool getConnexion(List<string>[] result)
        {
            if (result.Count() != 0)
            {
                this.id = Int32.Parse(result[0][0]);
                this.name = result[1][0];
                this.address = result[2][0] + " " + result[3][0] + " " + result[4][0];
                this.price = Int32.Parse(result[5][0]);
                this.phone = Int32.Parse(result[6][0]);
                this.mail = result[7][0];
                return true;
            }else
            {
                MessageBox.Show("Cette société n'existe pas...");
                return false;
            }
        }
        public string findMail(string name)
        {
            string[] attributes = new string[] {"Soc_nom","Soc_mail" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes),"T_societe",attributes, " Soc_nom= '"+name+"'");
            return result[1][0];
        }
        public string findPhone(string name)
        {
            string[] attributes = new string[] { "Soc_nom", "Soc_phone" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "T_societe", attributes, " Soc_nom= '" + name + "'");
            string phone = result[1][0];
            return phone;
        }
        public string findPrice(string name)
        {
            string[] attributes = new string[] { "Soc_nom", "Soc_main_oeuvre" };
            List<string>[] result;
            result = bdd.Select(string.Join(", ", attributes), "T_societe", attributes, " Soc_nom= '" + name + "'");
            string price = result[1][0];
            return price;
        }
        public string[] findAddress(string name)
        {
            string[] attributes = new string[] { "Soc_nom", "Soc_num_ad","Soc_rue_ad","Soc_ville_ad" };
            List<string>[] result;
            string[] address = new string[3];
            result = bdd.Select(string.Join(", ", attributes), "T_societe", attributes, " Soc_nom= '" + name + "'");
             address = new string[] { result[1][0], result[2][0], result[3][0] };
            return address;
        }
        public void updateMail(string mail,int id_soc)
        {
            bdd.update("T_societe", "Soc_mail", mail, "Soc_id =" + id_soc);
        }
        public void updatePhone(int phone, int id_soc)
        {
            bdd.update("T_societe", "Soc_phone", ""+phone, "Soc_id =" + id_soc);
        }
        public void updatePrice(int price, int id_soc)
        {
            bdd.update("T_societe","Soc_main_oeuvre", "" + price, "Soc_id =" + id_soc); 
        }
        public void updateAddress(string numAd, string rueAd, string villeAd, int id_soc)
        {
            bdd.update("T_societe", "Soc_num_ad", "" + numAd, "Soc_id =" + id_soc);
            bdd.update("T_societe", "Soc_rue_ad", rueAd, "Soc_id =" + id_soc);
            bdd.update("T_societe", "Soc_ville_ad",villeAd, "Soc_id =" + id_soc);
        }
    }
}
