using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Controler;
using MetroFramework;
using MetroFramework.Forms;
namespace ERP
{
    public partial class LoginEmpView : MetroFramework.Forms.MetroForm
    {
        private EmpControler controler;
        public LoginEmpView(int id_soc)
        {
            InitializeComponent();
            controler = new EmpControler(id_soc);
        }

        private void LoginEmpView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(467, 249);
            this.MaximizeBox = false;
            this.ControlBox = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(nomEmploye.Text!="" && passEmploye.Text!="")
            {
                controler.connexion(nomEmploye.Text, passEmploye.Text);
            }
        }
    }
}
