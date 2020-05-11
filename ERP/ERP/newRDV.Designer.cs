namespace ERP
{
    partial class newRDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newRDV));
            this.NomRdv = new MetroFramework.Controls.MetroTextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.duree = new MetroFramework.Controls.MetroTextBox();
            this.addRDV = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.pdf = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // NomRdv
            // 
            // 
            // 
            // 
            this.NomRdv.CustomButton.Image = null;
            this.NomRdv.CustomButton.Location = new System.Drawing.Point(546, 2);
            this.NomRdv.CustomButton.Name = "";
            this.NomRdv.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.NomRdv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NomRdv.CustomButton.TabIndex = 1;
            this.NomRdv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NomRdv.CustomButton.UseSelectable = true;
            this.NomRdv.CustomButton.Visible = false;
            this.NomRdv.Lines = new string[] {
        "Nom rendez-vous"};
            this.NomRdv.Location = new System.Drawing.Point(50, 100);
            this.NomRdv.MaxLength = 32767;
            this.NomRdv.Name = "NomRdv";
            this.NomRdv.PasswordChar = '\0';
            this.NomRdv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NomRdv.SelectedText = "";
            this.NomRdv.SelectionLength = 0;
            this.NomRdv.SelectionStart = 0;
            this.NomRdv.ShortcutsEnabled = true;
            this.NomRdv.Size = new System.Drawing.Size(582, 38);
            this.NomRdv.TabIndex = 0;
            this.NomRdv.Text = "Nom rendez-vous";
            this.NomRdv.UseSelectable = true;
            this.NomRdv.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NomRdv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(139, 171);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(406, 22);
            this.date.TabIndex = 1;
            // 
            // duree
            // 
            // 
            // 
            // 
            this.duree.CustomButton.Image = null;
            this.duree.CustomButton.Location = new System.Drawing.Point(535, 1);
            this.duree.CustomButton.Name = "";
            this.duree.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.duree.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.duree.CustomButton.TabIndex = 1;
            this.duree.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.duree.CustomButton.UseSelectable = true;
            this.duree.CustomButton.Visible = false;
            this.duree.Lines = new string[] {
        "Durée"};
            this.duree.Location = new System.Drawing.Point(51, 228);
            this.duree.MaxLength = 32767;
            this.duree.Name = "duree";
            this.duree.PasswordChar = '\0';
            this.duree.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.duree.SelectedText = "";
            this.duree.SelectionLength = 0;
            this.duree.SelectionStart = 0;
            this.duree.ShortcutsEnabled = true;
            this.duree.Size = new System.Drawing.Size(581, 47);
            this.duree.TabIndex = 2;
            this.duree.Text = "Durée";
            this.duree.UseSelectable = true;
            this.duree.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.duree.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addRDV
            // 
            this.addRDV.Location = new System.Drawing.Point(154, 310);
            this.addRDV.Name = "addRDV";
            this.addRDV.Size = new System.Drawing.Size(378, 85);
            this.addRDV.TabIndex = 3;
            this.addRDV.Text = "Créer RDV";
            this.addRDV.UseSelectable = true;
            this.addRDV.Click += new System.EventHandler(this.addRDV_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(567, 408);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 70);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pdf
            // 
            this.pdf.Location = new System.Drawing.Point(23, 424);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(199, 52);
            this.pdf.TabIndex = 5;
            this.pdf.Text = "Exporter en pdf";
            this.pdf.UseSelectable = true;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // newRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 499);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.addRDV);
            this.Controls.Add(this.duree);
            this.Controls.Add(this.date);
            this.Controls.Add(this.NomRdv);
            this.Name = "newRDV";
            this.Text = "Nouveau RDV";
            this.Load += new System.EventHandler(this.newRDV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox NomRdv;
        private System.Windows.Forms.DateTimePicker date;
        private MetroFramework.Controls.MetroTextBox duree;
        private MetroFramework.Controls.MetroButton addRDV;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton pdf;
    }
}