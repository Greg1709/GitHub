using System;
using System.Collections.Generic;
using System.Text;
using Test.model;

namespace Test.controler
{
    class DevisControler
    {
        private int id_soc, cli_id;
        private DevisModel model;
        public DevisControler(int id_soc,int cli_id)
        {
            this.id_soc = id_soc;
            this.cli_id = cli_id;
            model = new DevisModel(this.id_soc,this.cli_id);
        }
        public void creerDevis(string date, int statut, string path)
        {
            model.createDevis(date, statut, path);
        }
        public int getIdProduit(string nom)
        {
            int res;
            res = model.getIdProduit(nom);
            return res;
        }

        public void creerProduit(string nom, int prix)
        {
            model.creerProduit(nom, prix);
        }
        public int getPrixProduit(int id_produit)
        {
            int prix;
            prix = model.getPrixProduit(id_produit);
            return prix;
        }
        public List<string>[] afficherNomProduit()
        {
            List<string>[] res;
            res = model.afficherNomProduit();
            return res;
        }
        public int getIdDevis(string path)
        {
            int result = model.getIdDevis(path);
            return result;
        }
        public void insertLigneDevis(int id_devis, int produit_id)
        {
            model.insertLigneDevis(id_devis, produit_id);
        }
        public List<string>[] afficherLignes(int id_devis)
        {
            List<string>[] res = model.afficherLignes(id_devis);
            return res;
        }
    }
}
