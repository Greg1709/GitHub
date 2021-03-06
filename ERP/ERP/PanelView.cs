﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ERP.Controler;
using MetroFramework;
using MetroFramework.Forms;

namespace ERP
{
    public partial class PanelView : MetroFramework.Forms.MetroForm
    {
        public int id_employe, id_societe;
        private EmpControler controler;
        private modifyEmp view2;
        private ModifySoc view3;
        private ClientView clientView;
        private Calendrier view4;
        private Devis view5;
        public PanelView(int id_emp,int id_soc)
        {
            InitializeComponent();
            this.id_employe = id_emp;
            this.id_societe = id_soc;
            controler = new EmpControler(id_soc); // new
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void closure()
        {
            this.Close();
        }

        private void infoSoc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controler.findNameSociete(this.id_societe));
            view3 = new ModifySoc(this.id_societe,controler.findNameSociete(this.id_societe));
            view3.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            view2 = new modifyEmp(this.id_societe, this.id_employe);
            view2.Show();
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //Bouton Devis
            view5 = new Devis(this.id_societe);
            view5.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            clientView = new ClientView(this.id_societe);
            clientView.Show();
            this.Hide();
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            view4 = new Calendrier(this.id_societe, this.id_employe);
            view4.Show();
            this.Hide();
        }

        private void PanelView_Load(object sender, EventArgs e)
        {
            MessageBox.Show("L'id employe est " + this.id_employe + " L'id societe est " + this.id_societe);
            this.MaximumSize = new Size(815, 665);
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = "Pannel de " + controler.findFirstName(this.id_employe);
            int droit = controler.defineRole(controler.findRole(this.id_employe));
            if(droit == 1)
            {
                infoSoc.Visible = true;
            }else
            {
                infoSoc.Visible = false;
            }
        }
    }
}
