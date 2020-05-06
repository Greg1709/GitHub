using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Test.model
{
    class EmpModelTest
    {
        private dBconnectTest bdd = new dBconnectTest();
        private int id,id_societe;
        private string nom, prenom, pass;

        public EmpModelTest(int id_societe)
        {
            this.id_societe = id_societe;
        }
        public int get_id_soc()
        {
            return this.id_societe;
        }
        public List<string>[] connection(string nom, string prenom, string pass)
        {
            string cryptPass = encryptPass(pass);
            List<string>[] result;
            string[] attributes = new string[] { "Emp_id", "Emp_role", "Emp_nom", "Emp_prenom", "Emp_pass"};
            result = bdd.Select(string.Join(", ", attributes), "T_Employe", "T_societe", attributes, "T_Employe.Soc_id = T_Societe.Soc_id", "T_Employe.Emp_nom = '" + nom + "' AND T_Employe.Emp_prenom='" + prenom + "' AND T_Employe.Soc_id=" + this.id + " AND T_Employe.Emp_pass='"+cryptPass+"'");
            return result;
        }
        private string encryptPass(string pass)
        {
            using(var sha1 = new SHA1Managed())
            {
                return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(pass)));
            }
        }
    }
}
