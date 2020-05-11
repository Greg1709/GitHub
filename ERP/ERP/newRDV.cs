using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using ERP.Controler;
using System.Runtime.CompilerServices;
using IronPdf;

namespace ERP
{
    public partial class newRDV : MetroFramework.Forms.MetroForm
    {
        private int id_soc, id_emp;
        private CalendrierControler controler;
        public newRDV(int id_soc,int id_emp)
        {
            InitializeComponent();
            this.id_soc = id_soc;
            this.id_emp = id_emp;
            controler = new CalendrierControler(this.id_soc, this.id_emp);
        }

        private void newRDV_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(540, 400);
            this.MaximizeBox = false;
            this.ControlBox = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }

        private void addRDV_Click(object sender, EventArgs e)
        {
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "YYYY-MM-dd H:mm:ss";
            MessageBox.Show(date.Value.ToString("yyyy-MM-dd H:mm:ss"));
            controler.inscrirRDV(NomRdv.Text, date.Value.ToString("yyyy-MM-dd H:mm:ss"), Int32.Parse(duree.Text));
        }

        private void pdf_Click(object sender, EventArgs e)
        {
            var Render = new IronPdf.HtmlToPdf();
            Render.RenderHtmlAsPdf("<h1>" + NomRdv.Text + "</h1> <br/> <h2>Le :" + date.Value + "</h2> <br/> <p>Temps : <strong>" + duree.Text + "</strong></p>").SaveAs("Rdv.pdf");
        }

        private void closure()
        {
            this.Close();
        }
    }
}
