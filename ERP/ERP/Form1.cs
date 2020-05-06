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
        private int id_Soc;
        private LoginEmpView empLog;


        public Form1()
        {
            InitializeComponent();
            

    }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(473, 164);
            this.MaximizeBox = false;
            this.ControlBox = false;
            /*List<string>[] vs;
            vs = bobControler.getConnect();
            MessageBox.Show(vs[2][0]);*/

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
                this.id_Soc = controllerSociete.getId();
                
                controllerSociete.connexion();
               

            }
        }
        public void connect(int id_soc)
        {
            Console.WriteLine("test" + id_soc);
             empLog = new LoginEmpView(id_soc);
           
            
            this.Close();
            Console.WriteLine("ça fonctionne");
            empLog.Show();
        }
    }
}
