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
    public partial class Devis : MetroFramework.Forms.MetroForm
    {
        private int id_soc;
        private DevisControler controler;
        private AddDevis view1;
        public Devis(int id_soc)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            controler = new DevisControler(this.id_soc);
        }

        private void Devis_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.MaximumSize = new Size(670, 570);
            affichageDevisAttente();
            affichageDevisAccepter();
        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void closure()
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void affichageDevisAttente()
        {
            List<string>[] devis;
            devis = controler.afficherDevis(0);
            for(int i=0; i<devis[0].Count; i++)
            {
                
                DevisAttente.Items.Add(devis[0][i]+" le "+devis[1][i]);
            }
        }
        private void affichageDevisAccepter()
        {
            List<string>[] devis;
            devis = controler.afficherDevis(1);
            for (int i = 0; i < devis[0].Count; i++)
            {

                DevisAccept.Items.Add(devis[0][i] + " le " + devis[1][i]);
            }
        }

        private void createDevis_Click(object sender, EventArgs e)
        {
            view1 = new AddDevis(this.id_soc);
            view1.Show();
            this.Close();
        }
    }
}
