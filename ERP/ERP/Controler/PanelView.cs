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
    public partial class PanelView : MetroFramework.Forms.MetroForm
    {
        private EmpControler controler;
       
        public PanelView(int id_soc,int id_emp)
        {
            InitializeComponent();

        }

        private void PanelView_Load(object sender, EventArgs e)
        {

        }

        public void loadTheme(int rules)
        {
            switch (rules)
            {
                case 1:
                    this.Style = MetroColorStyle.Green;
                    break;
            }
        }
    }
}
