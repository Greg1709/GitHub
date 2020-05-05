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
            Societe google = new Societe("Google");

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
