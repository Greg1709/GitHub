namespace ERP.Model
{
    partial class AddLigneDevis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLigneDevis));
            this.Produit = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Produit
            // 
            this.Produit.FormattingEnabled = true;
            this.Produit.ItemHeight = 24;
            this.Produit.Location = new System.Drawing.Point(88, 89);
            this.Produit.Name = "Produit";
            this.Produit.Size = new System.Drawing.Size(460, 30);
            this.Produit.TabIndex = 0;
            this.Produit.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 158);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(187, 68);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Finir et générer le pdf";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(230, 158);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(236, 68);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Ajouter ligne";
            this.metroButton2.UseSelectable = true;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(527, 158);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(76, 68);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // AddLigneDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 261);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.Produit);
            this.Name = "AddLigneDevis";
            this.Text = "AddLigneDevis";
            this.Load += new System.EventHandler(this.AddLigneDevis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox Produit;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btn_exit;
    }
}