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
using MetroFramework;
using MetroFramework.Forms;

namespace ERP
{
    public partial class ModifySoc : MetroFramework.Forms.MetroForm
    {
        private SocieteController controler;
        public int id_societe;
        public string nomSociete;
        public ModifySoc(int id_societe,string nameSociete)
        {
            InitializeComponent();
            this.id_societe = id_societe;
            this.nomSociete = nameSociete;
            controler = new SocieteController(this.nomSociete);
        }

        private void ModifySoc_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(440, 348);
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = "Modifier " + this.nomSociete;
            string[] adresse = controler.AfficherAdresse(this.nomSociete);
            mail.Text = controler.AfficherMail(this.nomSociete);
            phone.Text = controler.AfficherPhone(this.nomSociete);
            oeuvre.Text = controler.AfficherPrix(this.nomSociete);
            NumAd.Text = adresse[0];
            RueAd.Text = adresse[1];
            VilleAd.Text = adresse[2];
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(selectMail.Checked == true)
            {
                if(mail.Text != "")
                {
                    controler.changeMail(mail.Text, this.id_societe);
                    MessageBox.Show("Votre mail a bien été mis à jour");
                }
            }else if(selectPhone.Checked == true)
            {
                if (phone.Text != "")
                {
                    controler.changePhone(Int32.Parse(phone.Text), this.id_societe);
                    MessageBox.Show("Votre téléphone a bien été mis à jour");
                }
            }else if (selectOeuvre.Checked == true)
            {
                if(oeuvre.Text != "")
                {
                    controler.changePrix(Int32.Parse(oeuvre.Text), this.id_societe);
                    MessageBox.Show("Le prix de votre main d'oeuvre a bien été mis à jour");
                }
                
            }else if (selectAd.Checked == true)
            {
                if(NumAd.Text != "")
                {
                    if(RueAd.Text != "")
                    {
                        if(VilleAd.Text != "")
                        {
                            controler.changeAdresse(NumAd.Text, RueAd.Text, VilleAd.Text, this.id_societe);
                            MessageBox.Show("Votre adresse a bien été mis à jour");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Une erreur c'est produite");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            closure();
        }
        private void closure()
        {
            this.Close();
        }
    }
}
