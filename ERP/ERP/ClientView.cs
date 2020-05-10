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
            //Console.WriteLine(resultats[1][0]);

            //MessageBox.Show(this.id_soc.ToString());

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
            writeFile(controler.afficherClients());
        }
        static void writeFile(List<string>[] resultats)
        {
            /*var data = new[]
            {
                    for (int i = 0; i < resultats.Length; i++)
                {
                //clients.Items.Add(resultats[0][i] + " " + resultats[1][i]);
                new CsvClient { nom = resultats[0][i], prenom = resultats[1][i] };
                }
            };*/
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            viewAdd = new addUser(this.id_soc);
            viewAdd.Show();
            this.Hide();
        }
    }
}

