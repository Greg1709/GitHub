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
using Org.BouncyCastle.Asn1.Crmf;

namespace ERP
{
    public partial class modifyEmp : MetroFramework.Forms.MetroForm
    {
        private int id_emp,id_soc;
        private EmpControler controler;
        public modifyEmp(int id_soc, int id_emp)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            this.id_emp = id_emp;
            controler = new EmpControler(id_soc);
        }

        private void modifyEmp_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(475, 352);
            this.MaximizeBox = false;
            this.ControlBox = false;
            nameModify.Text = controler.findName(this.id_emp);
            passModify.Text = controler.findPass(this.id_emp);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void closure()
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(nameModify.Text != controler.findName(this.id_emp))
            {
                if(passModify.Text != controler.findPass(this.id_emp))
                {
                    if(passModify.Text != "")
                    {
                        controler.changePass(passModify.Text, this.id_emp);
                    }
                    if(nameModify.Text != "")
                    {
                        controler.changeName(nameModify.Text, this.id_emp);
                    }
                }
            }
            else
            {
                MessageBox.Show("Une erreur c'est produite");
            }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
