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
    public partial class SuppRDV : MetroFramework.Forms.MetroForm
    {
        private int id_soc, id_emp;
        private CalendrierControler controler;
        public SuppRDV(int id_soc, int id_emp)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            this.id_emp = id_emp;
            controler = new CalendrierControler(this.id_soc, this.id_emp);
        }

        private void SuppRDV_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(435, 265);
            this.MaximizeBox = false;
            this.ControlBox = false;
            loadCombobox();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }

        private void closure()
        {
            this.Close();
        }

        private void supRDV_Click(object sender, EventArgs e)
        {
            controler.deleteRDV(listNom.Text);
            MessageBox.Show("Rendez vous supprimé");
        }

        private void loadCombobox()
        {
            List<string>[] nom;
            nom = controler.trouverNom();
            for(int i=0; i<2; i++)
            {
                listNom.Items.Add(nom[0][i]);
            }
        }
    }
}
