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
    public partial class PanelView : MetroFramework.Forms.MetroForm
    {
        public int id_employe, id_societe;
        public PanelView(int id_emp,int id_soc)
        {
            InitializeComponent();
            this.id_employe = id_emp;
            this.id_societe = id_soc;
        }

        private void PanelView_Load(object sender, EventArgs e)
        {
            MessageBox.Show("L'id employe est " + this.id_employe + " L'id societe est " + this.id_societe);
            this.MaximumSize = new Size(815, 665);
            this.MaximizeBox = false;
            this.ControlBox = false;
        }
    }
}
