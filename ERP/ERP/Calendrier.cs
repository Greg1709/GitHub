using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;
using ERP.Controler;

namespace ERP
{
    public partial class Calendrier : MetroFramework.Forms.MetroForm
    {
        private int id_soc, id_emp;
        private CalendrierControler controler;
        private newRDV view1;
        private SuppRDV view2;
        public Calendrier(int id_soc, int id_emp)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            this.id_emp = id_emp;
            controler = new CalendrierControler(this.id_soc, this.id_emp);
        }

        private void Calendrier_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(466, 400);
            this.MaximizeBox = false;
            this.ControlBox = false;
            affichage();
        }
        private void closure()
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }

        private void newRDV_Click(object sender, EventArgs e)
        {
            view1 = new newRDV(this.id_soc, this.id_emp);
            view1.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            view2 = new SuppRDV(this.id_soc, this.id_emp);
            view2.Show();
            this.Hide();
        }

        private void affichage()
        {
            List<string>[] res;
            res = controler.afficherRDV();
            for (int i = 0; i < res.Length; i++)
            {
                rdv.Items.Add(res[0][i] + " " + res[1][i]);

            }
        }
    }
}
