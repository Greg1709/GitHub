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
using MySql.Data.MySqlClient.Memcached;
using MySqlX.XDevAPI.Common;

namespace ERP
{
    public partial class ClientView : MetroFramework.Forms.MetroForm
    {
        private int id_soc;
        ClientControler controler;
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
            List<string>[] resultats;
            resultats = controler.afficherClients();
            Console.WriteLine(resultats[1][0]);
            for(int i=0; i<resultats.Length; i++)
            {
                clients.Items.Add(resultats[0][i] + resultats[1][i]);
            }
            //MessageBox.Show(this.id_soc.ToString());
            
        }
    }
}
