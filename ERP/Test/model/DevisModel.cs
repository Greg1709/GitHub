using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Test.model
{
    class DevisModel
    {
        private int id_soc;
        private dBconnectTest bdd = new dBconnectTest();
        public DevisModel(int id_soc)
        {
            this.id_soc = id_soc;
           
        }
        public void createDevis(string date, int statut, string path,int cli_id)
        {
            string table = "t_devis";
            string[] nomLigne = new string[] { "De_date", "De_statut","De_path","Soc_id","Cli_id" };
            string[] value = new string[] { date, statut.ToString(),path,this.id_soc.ToString(),cli_id.ToString()};
            bdd.insert(table, nomLigne, value);
        }

        public int getIdProduit(string nom)
        {
            List<string>[] result;
            string table = "t_stock";
            string[] attributes = new string[] {"sto_id" };
            result =bdd.Select(string.Join(", ",attributes), table, attributes, " Sto_nom='"+nom+"'");
            int res = Int32.Parse(result[0][0]);
            return res;
        }
        public void creerProduit(string nom, int prix)
        {
            string table = "t_stock";
            string[] nomLigne = new string[] {"Sto_nom","Sto_prix","Soc_id" };
            string[] value = new string[] {nom,prix.ToString(),this.id_soc.ToString() };
            bdd.insert(table, nomLigne,value);
        }

        public int getPrixProduit(int id_produit)
        {
            string table = "t_stock";
            string[] attributes = new string[] { "Sto_prix"};
            List<string>[] res;
            res = bdd.Select(string.Join(" ,",attributes),table,attributes," Sto_id="+id_produit);
            return Int32.Parse(res[0][0]);
        }
        public List<string>[] afficherNomProduit()
        {
            string table = "t_stock";
            string[] attributes = new string[] { "Sto_nom"};
            List<string>[] res;
            res = bdd.Select(string.Join(", ", attributes), table, attributes, " Soc_id=" + this.id_soc);
            return res;
        }
        public int getIdDevis(string path)
        {
            string table = "t_devis";
            string[] attributes = new string[] { "De_id" };
            List<string>[] res;
            res = bdd.Select(string.Join(", ", attributes), table, attributes, " De_path='" + path + "'");
            int id = Int32.Parse(res[0][0]);
            return id;
        }
        public void insertLigneDevis(int id_devis,int produit_id)
        {
            string table = "t_donner";
            string[] nomLigne = new string[] {"De_id","Sto_id" };
            string[] values = new string[] { id_devis.ToString(), produit_id.ToString() };
            bdd.insert(table, nomLigne, values);
        }
        public List<string>[] afficherLignes(int id_devis)
        {
            List<string>[] res;
            string table = "t_stock";
            string table2 = "t_donner";
            string[] attributes= new string[] {"Sto_nom","Sto_prix","De_id" };
            res = bdd.Select(string.Join(", ", attributes), table, table2, attributes, "t_stock.sto_id = t_donner.sto_id", "t_donner.de_id="+id_devis);
            return res;
        }
        public List<string>[] afficherDevisAccept(int value)
        {
            List<string>[] res;
            string table = "t_devis";
            string[] attributes;
            
            if (value == 0)
            {
                attributes = new string[] { "De_path", "De_date" };
                res = bdd.Select(string.Join(", ", attributes), table, attributes, "De_statut=" + value + " AND Soc_id=" + this.id_soc);
                return res;
            }
            else 
            {
                attributes = new string[] { "De_path", "De_date", "De_date_accept" };
                res = bdd.Select(string.Join(", ", attributes), table, attributes, "De_statut=" + value + " AND Soc_id=" + this.id_soc);
                return res;
            }
            
        }

        
    }
}
