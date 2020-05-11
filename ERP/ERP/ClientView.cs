using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using ERP.Controler;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI.Common;

namespace ERP
{
    public partial class ClientView : MetroFramework.Forms.MetroForm
    {
        private int id_soc;
        ClientControler controler;
        private addUser viewAdd;
        public ClientView(int id_soc)
        {
            this.id_soc = id_soc;
            InitializeComponent();
            controler = new ClientControler(this.id_soc);
        }

        private void ClientView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(640, 360);
            this.MaximizeBox = false;
            this.ControlBox = false;
            affichage();
            

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void closure()
        {
            this.Close();
        }
        private void affichage()
        {
            List<string>[] resultats;
            resultats = controler.afficherClients();


            for (int i = 0; i < resultats.Length; i++)
            {
                clients.Items.Add(resultats[0][i] + " " + resultats[1][i]);

            }
        }
        private void delete()
        {
            clients.Items.Clear();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            delete();
            affichage();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            List<string>[] resultats;
            resultats = controler.afficherClients();
            for(int i=0; i<resultats.Length; i++)
            {
                writeFile(resultats[0][i], resultats[1][i]);
            }
        }
        public static void writeFile(string Nom, string Prenom)
        {
            try
            {
                using(System.IO.StreamWriter file = new System.IO.StreamWriter("client.csv",true))
                {
                    file.WriteLine(Nom + " , " + Prenom);
                }
            } catch(Exception ex)
            {
                throw new ApplicationException("Il y a une erreure :", ex);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            viewAdd = new addUser(this.id_soc);
            viewAdd.Show();
            this.Hide();
        }
    }
}

