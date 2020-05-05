using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Model;
using MetroFramework;
using MetroFramework.Forms;
using MySqlX.XDevAPI.Common;

namespace ERP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private string[] test;
        private string result;
        public Form1()
        {
            InitializeComponent();
            test = new string[]{"Hello ","World!","My","Name" };
            Console.WriteLine("'"+string.Join("','",test)+"'");
            // Console.WriteLine(string.Join(",",test(c'est le tableau)));
            string[] tableau, lignes;
            tableau = new string[] { "Soc_nom", "Soc_num_ad", "Soc_rue_ad", "Soc_ville_ad", "Soc_main_oeuvre", "Soc_Phone", "Soc_mail" };
            lignes = new string[] { "Facebook", "14", "rue august", "Paris", "1405", "12654", "@kjhe" };
            dBConnect bdd = new dBConnect();
            bdd.insert("T_societe", tableau, lignes);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(473, 164);
            this.MaximizeBox = false;
            this.ControlBox = false;
           
        }


        private void closure()
        {
            this.Close();
        }

        private void end_Click(object sender, EventArgs e)
        {
            closure();
        }
    }
}
