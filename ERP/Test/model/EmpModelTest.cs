using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Test.model
{
    class EmpModelTest
    {
        private dBconnectTest bdd = new dBconnectTest();
        private int id,id_societe;
        private string nom, prenom, pass,role;
        public bool state; 
        public EmpModelTest(int id_societe)
        {
            this.id_societe = id_societe;
        }
        public int get_id_soc()
        {
            return this.id_societe;
        }
       
        public void connection(string prenom, string pass)
        {
            string cryptPass = encryptPass(pass);
            List<string>[] result;
            string[] attributes = new string[] { "Emp_id", "Emp_role", "Emp_nom", "Emp_prenom" };
            result = bdd.Select(string.Join(", ", attributes), "T_Employe", "T_societe", attributes, "T_Employe.Soc_id = T_Societe.Soc_id", " T_Employe.Emp_prenom='" + prenom + "' AND T_Employe.Soc_id=" + this.get_id_soc() + " AND T_Employe.Emp_pass='" + cryptPass + "'");
            this.state = getConnexion(result);
        }
        
        private string encryptPass(string pass)
        {
            using(var sha1 = new SHA1Managed())
            {
                return BitConverter.ToString(sha1.ComputeHash(Encoding.UTF8.GetBytes(pass)));
            }
        }
        private bool getConnexion(List<string>[] result)
        {
            if(result.Any())
            {
                this.id = Int32.Parse(result[0][0]);
                this.role = result[1][0];
                this.nom = result[2][0];
                this.prenom = result[3][0];
                return true;
            }else
            {
                return false;
            }
        }

        public int getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getFirstName()
        {
            return this.prenom;
        }
        public string getRole()
        {
            return this.role;
        }
        public string findFirstName(int Id)
        {
            string[] attributes = new string[] { "Emp_id", "Emp_role", "Emp_nom", "Emp_prenom" };
            List<string>[] result;

            result =bdd.Select(string.Join(", ", attributes), "T_employe", attributes, " Emp_Id= " + Id+"");
            return result[3][0];
        }
        public string findName(int Id)
        {
            string[] attributes = new string[] { "Emp_id", "Emp_role", "Emp_nom", "Emp_prenom" };
            List<string>[] result;

            result = bdd.Select(string.Join(", ", attributes), "T_employe", attributes, " Emp_Id= " + Id + "");
            return result[2][0];
        }
        public string findRole(int Id)
        {
            string[] attributes = new string[] { "Emp_id", "Emp_role", "Emp_nom", "Emp_prenom" };
            List<string>[] result;

            result = bdd.Select(string.Join(", ", attributes), "T_employe", attributes, " Emp_Id= " + Id + "");
            return result[1][0];
        }
    }
}
