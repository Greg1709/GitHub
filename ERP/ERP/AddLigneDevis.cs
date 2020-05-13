using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Controler;
using MetroFramework;
using MetroFramework.Forms;

namespace ERP.Model
{
    public partial class AddLigneDevis : MetroFramework.Forms.MetroForm
    {
        private int id_soc;
        private DevisControler controler;
        public AddLigneDevis(int id_soc)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            controler = new DevisControler(this.id_soc);
        }

        private void AddLigneDevis_Load(object sender, EventArgs e)
        {
            loadProduit();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void closure()
        {
            this.Close();
        }
        private void loadProduit()
        {
            List<string>[] res;
            res = controler.afficherNomProduit();
            for(int i=0; i<res[0].Count; i++)
            {
                Produit.Items.Add(res[0][i]);
            }
        }
    }
}
