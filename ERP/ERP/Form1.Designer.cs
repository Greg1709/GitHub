namespace ERP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login = new MetroFramework.Controls.MetroButton();
            this.SocieteName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.end = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(187, 110);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(220, 72);
            this.login.TabIndex = 0;
            this.login.Text = "Accéder au login employé";
            this.login.UseSelectable = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // SocieteName
            // 
            // 
            // 
            // 
            this.SocieteName.CustomButton.Image = null;
            this.SocieteName.CustomButton.Location = new System.Drawing.Point(374, 1);
            this.SocieteName.CustomButton.Name = "";
            this.SocieteName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.SocieteName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SocieteName.CustomButton.TabIndex = 1;
            this.SocieteName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SocieteName.CustomButton.UseSelectable = true;
            this.SocieteName.CustomButton.Visible = false;
            this.SocieteName.Lines = new string[] {
        "Nom de la société "};
            this.SocieteName.Location = new System.Drawing.Point(187, 63);
            this.SocieteName.MaxLength = 32767;
            this.SocieteName.Name = "SocieteName";
            this.SocieteName.PasswordChar = '\0';
            this.SocieteName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SocieteName.SelectedText = "";
            this.SocieteName.SelectionLength = 0;
            this.SocieteName.SelectionStart = 0;
            this.SocieteName.ShortcutsEnabled = true;
            this.SocieteName.Size = new System.Drawing.Size(396, 23);
            this.SocieteName.TabIndex = 1;
            this.SocieteName.Text = "Nom de la société ";
            this.SocieteName.UseSelectable = true;
            this.SocieteName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SocieteName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nom de la société";
            // 
            // end
            // 
            this.end.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("end.BackgroundImage")));
            this.end.Location = new System.Drawing.Point(521, 128);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(62, 65);
            this.end.TabIndex = 3;
            this.end.UseSelectable = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 205);
            this.Controls.Add(this.end);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SocieteName);
            this.Controls.Add(this.login);
            this.Name = "Form1";
            this.Text = "Entreprise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton login;
        private MetroFramework.Controls.MetroTextBox SocieteName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton end;
    }
}

