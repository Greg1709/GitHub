﻿namespace ERP
{
    partial class Devis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devis));
            this.DevisAttente = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DevisAccept = new System.Windows.Forms.ListBox();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.createDevis = new MetroFramework.Controls.MetroButton();
            this.modifyDevis = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // DevisAttente
            // 
            this.DevisAttente.FormattingEnabled = true;
            this.DevisAttente.ItemHeight = 16;
            this.DevisAttente.Location = new System.Drawing.Point(144, 110);
            this.DevisAttente.Name = "DevisAttente";
            this.DevisAttente.Size = new System.Drawing.Size(496, 228);
            this.DevisAttente.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Devis non accepté";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 351);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Devis  accepté";
            // 
            // DevisAccept
            // 
            this.DevisAccept.FormattingEnabled = true;
            this.DevisAccept.ItemHeight = 16;
            this.DevisAccept.Location = new System.Drawing.Point(144, 379);
            this.DevisAccept.Name = "DevisAccept";
            this.DevisAccept.Size = new System.Drawing.Size(496, 196);
            this.DevisAccept.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(701, 608);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(82, 76);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // createDevis
            // 
            this.createDevis.Location = new System.Drawing.Point(42, 608);
            this.createDevis.Name = "createDevis";
            this.createDevis.Size = new System.Drawing.Size(292, 77);
            this.createDevis.TabIndex = 7;
            this.createDevis.Text = "Créer un nouveau devis";
            this.createDevis.UseSelectable = true;
            this.createDevis.Click += new System.EventHandler(this.createDevis_Click);
            // 
            // modifyDevis
            // 
            this.modifyDevis.Location = new System.Drawing.Point(388, 608);
            this.modifyDevis.Name = "modifyDevis";
            this.modifyDevis.Size = new System.Drawing.Size(213, 77);
            this.modifyDevis.TabIndex = 8;
            this.modifyDevis.Text = "Modifier un devis";
            this.modifyDevis.UseSelectable = true;
            // 
            // Devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 705);
            this.Controls.Add(this.modifyDevis);
            this.Controls.Add(this.createDevis);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.DevisAccept);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.DevisAttente);
            this.Name = "Devis";
            this.Text = "Devis";
            this.Load += new System.EventHandler(this.Devis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DevisAttente;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox DevisAccept;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton createDevis;
        private MetroFramework.Controls.MetroButton modifyDevis;
    }
}