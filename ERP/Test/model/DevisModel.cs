using System;
using System.Collections.Generic;
using System.Text;

namespace Test.model
{
    class DevisModel
    {
        private int id_soc, cli_id;
        private dBconnectTest bdd = new dBconnectTest();
        public DevisModel(int id_soc,int cli_id)
        {
            this.id_soc = id_soc;
            this.cli_id = cli_id;
        }
        public void createDevis(string date, int statut, string path)
        {
            string table = "t_devis";
            string[] nomLigne = new string[] { "De_date", "De_statut","De_path","Soc_id","Cli_id" };
            string[] value = new string[] { date, statut.ToString(),path,this.id_soc.ToString(),this.cli_id.ToString()};
            bdd.insert(table, nomLigne, value);
        }

        public List<string>[] getIdProduit(string nom)
        {
            List<string>[] result;
            string table = "t_stock";
            string[] attributes = new string[] {"sto_id" };
            result =bdd.Select(string.Join(", ",attributes), table, attributes, " Sto_nom='"+nom+"'");
            return result;
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
    }
}
