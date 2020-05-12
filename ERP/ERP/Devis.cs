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

namespace ERP
{
    public partial class Devis : MetroFramework.Forms.MetroForm
    {
        public Devis()
        {
            InitializeComponent();
        }

        private void Devis_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.MaximumSize = new Size(670, 530);
        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void closure()
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
    }
}
