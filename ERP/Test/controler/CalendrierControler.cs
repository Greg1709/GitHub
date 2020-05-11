using System;
using System.Collections.Generic;
using System.Text;
using Test.model;

namespace Test.controler
{
    class CalendrierControler
    {
        private int id_soc, id_emp;
        private CalendrierModel model;
        public CalendrierControler(int id_soc,int id_emp)
        {
            this.id_soc = id_soc;
            this.id_emp = id_emp;
            model = new CalendrierModel(this.id_soc, this.id_emp);
        }

        public List<string>[] afficherRDV()
        {
            List<string>[] res;
            res = model.displayRdv();
            return res;
        }
        public void inscrirRDV(string nom,DateTime date, int duree, int cli_id)
        {
            model.inscrirRDV(nom,date,duree,cli_id);
        }
        public void deleteRDV(int id_cal)
        {
            model.deleteRDV(id_cal);
        }
    }
}
