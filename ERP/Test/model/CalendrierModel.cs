using System;
using System.Collections.Generic;
using System.Text;

namespace Test.model
{
    
    class CalendrierModel
    {
        private dBconnectTest bdd = new dBconnectTest();
        private int id_soc, id_emp;
        
        public CalendrierModel(int id_soc,int emp_id)
        {
            this.id_soc = id_soc;
            this.id_emp = emp_id;
        }
        public List<string>[] displayRdv()
        {
            List<string>[] result;
            string[] attributes = new string[] { "Cal_nom", "Cal_date", "Cal_duree" };
            result = bdd.Select(string.Join(", ", attributes),"t_calendrier",attributes, " Soc_id ="+this.id_soc+" AND Emp_id="+this.id_emp);
            return result;
        }
        public void inscrirRDV(string nom, DateTime date, int duree, int cli_id)
        {
            string table = "t_calendrier";
            string[] nomLigne = new string[] { "Cal_nom","Cal_date","Cal_duree","Soc_id","Emp_id","Cli_id"};
            string[] value = new string[] {nom, date.ToString(),duree.ToString(),this.id_soc.ToString(),this.id_emp.ToString(),cli_id.ToString() };
            bdd.insert(table,nomLigne,value);
        }

        public void deleteRDV(int Cal_id)
        {
            bdd.delete("t_calendrier", "Cal_id=" + Cal_id);
        }
    }
}
