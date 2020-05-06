using ERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP.Controler
{
    class SocieteController
    {
        private Societe societe;
        private Form1 f1 = new Form1();
        public SocieteController(string name)
        {
            societe = new Societe(name);
        }
        public string getName()
        {
            return societe.getName();
        }
        public int getId()
        {
            Console.WriteLine(societe.getId());
            return societe.getId();

        }
        public int getPrix()
        {
            return societe.getPrix();
        }
        public string getAddress()
        {
            return societe.getAddress();
        }
        public int getPhoneNumber()
        {
            return societe.getPhone();
        }
        public string getMail()
        {
            return societe.getMail();
        }
        public void connexion()
        {
            if(societe.state == true)
            {
                MessageBox.Show("La société existe connectez-vous", "Ok");
                f1.connect(societe.getId());
            }
        }
    }
}
