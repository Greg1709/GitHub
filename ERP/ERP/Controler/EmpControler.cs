using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Model;

namespace ERP.Controler
{
    public class EmpControler
    {
        private EmpModel model;
        private PanelView view;
        private LoginEmpView view1;
        public int id_soc;
        public EmpControler(int id_soc)
        {
            this.id_soc = id_soc;
            model = new EmpModel(id_soc);
            view1 = new LoginEmpView(id_soc);
            
        }
        public int getIdSoc()
        {
            return this.id_soc;
        }
        
        public void connexion(string prenom,string pass)
        {
            model.connection(prenom, pass);
            if(model.state == true)
            {
                Console.WriteLine(model.getId());
                MessageBox.Show("L'employé existe");
                view1.Connection(this.getIdSoc(), this.getID());
            }
        }

        public string getRole()
        {
            return model.getRole();
        }
        public string getNom()
        {
            return model.getNom();
        }
        public int getID()
        {
            return model.getId();
        }
        public string getPrenom()
        {
            return model.getPrenom();
        }
        public string getFirstName()
        {
            return model.getFirstName();
        }
        
        public string findFirstName(int Id)
        {
            string name = model.findFirstName(Id);
            return name;
        }
        public string findName(int Id)
        {
            string name = model.findName(Id);
            return name;
        }
        public string findRole(int Id)
        {
            string Role = model.findRole(Id);
            return Role;
        }
        public string getPass()
        {
            return model.getPass();
        }
        public void changePass(string newPass, int id)
        {
            model.changePass(newPass, id);
        }
        public void changeName(string name, int id)
        {
            model.changeName(name, id);
        }


    }
}

