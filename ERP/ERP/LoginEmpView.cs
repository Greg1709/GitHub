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
    public partial class LoginEmpView : MetroFramework.Forms.MetroForm
    {
        public LoginEmpView()
        {
            InitializeComponent();
        }

        private void LoginEmpView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(467, 249);
            this.MaximizeBox = false;
            this.ControlBox = false;
        }
    }
}
