using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using Test.model;

namespace Test.controler
{
    class EmpControler
    {
        private EmpModelTest bob;
        public EmpControler(int id_soc)
        {
            bob = new EmpModelTest(id_soc);
        }
        
        public List<string>[] getConnect()
        {
            List<string>[] vs;
            vs = bob.connection("Deneuve", "Gregory","test");
            return vs;
        }
    }

}
