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
        public int id_soc;
        public EmpControler(int id_soc)
        {
            this.id_soc = id_soc;
            model = new EmpModel(id_soc);
            
        }
        
        public void connexion(string prenom,string pass)
        {
            model.connection(prenom, pass);
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
        public void checkRole()
        {
            view = new PanelView(this.id_soc, getID());
            switch (model.getRole())
            {
                
                case "Administrateur":
                    view.loadTheme(1);
                    break;
                case "Comptable":
                    break;
                case "Ouvrier":
                    break;
                default:
                   MessageBox.Show("Erreur", "No");
                    break;
            }
        }
        
    }
}

