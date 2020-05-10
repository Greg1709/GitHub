using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace ERP.Controler
{
    public partial class addUser : MetroFramework.Forms.MetroForm
    {
        private int id_soc;
        private ClientControler controler;
        public addUser(int id)
        {
            InitializeComponent();
            this.id_soc = id;
            controler = new ClientControler(id);
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(490,430);
            this.MaximizeBox = false;
            this.ControlBox = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void closure()
        {
            this.Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Nom.Text != "")
                if (Prenom.Text != "")
                    if (Numero.Text != "")
                        if (Rue.Text != "")
                            if (Ville.Text != "")
                                if (Pays.Text != "")
                                    if (Phone.Text != "")
                                        if (Mail.Text != "")
                                            controler.InscrireClient(Nom.Text, Prenom.Text, Int32.Parse(Numero.Text), Rue.Text, Ville.Text, Pays.Text, Int32.Parse(Phone.Text), Mail.Text);
        }
    }
}
