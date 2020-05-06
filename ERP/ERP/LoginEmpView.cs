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
        private PanelView panel;
        private int id;
        public LoginEmpView(int id_soc)
        {
            InitializeComponent();
            
            setId(id_soc);
        }
        private void setId(int id_soc)
        {
            this.id = id_soc;
        }
        
        private void LoginEmpView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(467, 249);
            this.MaximizeBox = false;
            this.ControlBox = false;
            controler = new EmpControler(this.id);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(nomEmploye.Text!="" && passEmploye.Text!="")
            {
                panel = new PanelView();
                controler.connexion(nomEmploye.Text, passEmploye.Text);
                this.Close();
                panel.Show();
            }
        }
        public void Connection(int id_soc,int id_emp)
        {
            Console.WriteLine("Id de la société " + id_soc);
            Console.WriteLine("Id de l'employé " + id_emp);
        }
    }
}
