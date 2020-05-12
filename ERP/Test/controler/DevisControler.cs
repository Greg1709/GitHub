using System;
using System.Collections.Generic;
using System.Text;
using Test.model;

namespace Test.controler
{
    class DevisControler
    {
        private int id_soc;
        private DevisModel model;
        public DevisControler(int id_soc)
        {
            this.id_soc = id_soc;
            
            model = new DevisModel(this.id_soc);
        }
        public void creerDevis(string date, int statut, string path,int cli_id)
        {
            model.createDevis(date, statut, path,cli_id);
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
        public List<string>[] afficherDevisAccepter(int value)
        {
            List<string>[] result;
            result = model.afficherDevisAccept(value);
            return result;
        }
    }
}
