using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Model;

namespace ERP.Controler
{
    class EmpControler
    {
        private EmpModel bob;
        public EmpControler(int id_soc)
        {
            bob = new EmpModel(id_soc);
        }
        
        public void connexion(string prenom,string pass)
        {
            bob.connection(prenom, pass);
        }
    }
}
