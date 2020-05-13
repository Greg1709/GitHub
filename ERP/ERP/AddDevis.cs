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
using ERP.Model;
using MetroFramework;
using MetroFramework.Forms;

namespace ERP
{
    public partial class AddDevis : MetroFramework.Forms.MetroForm
    {
        private int id_soc;
        private DevisControler controler;
        private ClientControler clientControler;
        private AddLigneDevis view;
        public AddDevis(int id_soc)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            controler = new DevisControler(this.id_soc);
            clientControler = new ClientControler(this.id_soc);
        }

        private void AddDevis_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.MaximumSize = new Size(540, 326);
            loadClient();
        }
        private void closure()
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
        private int getIdClient(string ligne)
        {
            string[] decomposition = ligne.Split(',');
            int id = Int32.Parse(decomposition[2]);
            return id; 

        }

        private void loadClient()
        {
            List<string>[] res;
            res = clientControler.afficherClients();
            for(int i=0; i<res[0].Count; i++)
            {
                client.Items.Add(res[0][i] + "," + res[1][i] + "," + res[2][i]);
            }
        }

        private void createdev_Click(object sender, EventArgs e)
        {

            controler.creerDevis(date.Value.ToString("yyyy-MM-dd H:mm:ss"), 0, path.Text, getIdClient(client.Text));
            MessageBox.Show("Devis crée avec succès");
            view = new AddLigneDevis(this.id_soc);
            view.Show();
            this.Close();
        }
    }
}
