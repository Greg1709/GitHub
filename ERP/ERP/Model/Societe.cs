using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Model
{
    public class Societe
    {
        private int phone;
        private string name, mail, address, id;
        private dBConnect bdd = new dBConnect();
        public Societe(string name)
        {
            List<string>[] result;
            string[] attributes = new string[] { "Soc_id", "Soc_nom", "Soc_num_ad", "Soc_rue_ad", "Soc_ville_ad", "Soc_main_oeuvre", "Soc_phone", "Soc_mail" };
            result = bdd.Select(string.Join(", ", attributes), "T_societe", attributes, "Soc_nom = '" + name + "'");
            Console.WriteLine(this.id = result[0][0]);
        }
    }
}
