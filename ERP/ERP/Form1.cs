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
using MySqlX.XDevAPI.Common;

namespace ERP
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       private SocieteController controllerSociete;
        public Form1()
        {
            InitializeComponent();
            

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

        private void login_Click(object sender, EventArgs e)
        {
            if (SocieteName.Text != "")
            {
                controllerSociete = new SocieteController(SocieteName.Text);
                controllerSociete.connexion();

            }
        }
        public void connect()
        {
            LoginEmpView empLog = new LoginEmpView();
            this.Close();
            Console.WriteLine("ça fonctionne");
            empLog.Show();
        }
    }
}
