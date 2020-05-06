namespace ERP
{
    partial class LoginEmpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginEmpView));
            this.nomEmploye = new MetroFramework.Controls.MetroTextBox();
            this.passEmploye = new MetroFramework.Controls.MetroTextBox();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // nomEmploye
            // 
            // 
            // 
            // 
            this.nomEmploye.CustomButton.Image = null;
            this.nomEmploye.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.nomEmploye.CustomButton.Name = "";
            this.nomEmploye.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nomEmploye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nomEmploye.CustomButton.TabIndex = 1;
            this.nomEmploye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nomEmploye.CustomButton.UseSelectable = true;
            this.nomEmploye.CustomButton.Visible = false;
            this.nomEmploye.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nomEmploye.Lines = new string[] {
        "Nom de l\'employé"};
            this.nomEmploye.Location = new System.Drawing.Point(99, 103);
            this.nomEmploye.MaxLength = 32767;
            this.nomEmploye.Name = "nomEmploye";
            this.nomEmploye.PasswordChar = '\0';
            this.nomEmploye.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nomEmploye.SelectedText = "";
            this.nomEmploye.SelectionLength = 0;
            this.nomEmploye.SelectionStart = 0;
            this.nomEmploye.ShortcutsEnabled = true;
            this.nomEmploye.Size = new System.Drawing.Size(392, 23);
            this.nomEmploye.TabIndex = 0;
            this.nomEmploye.Text = "Nom de l\'employé";
            this.nomEmploye.UseSelectable = true;
            this.nomEmploye.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nomEmploye.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passEmploye
            // 
            // 
            // 
            // 
            this.passEmploye.CustomButton.Image = null;
            this.passEmploye.CustomButton.Location = new System.Drawing.Point(370, 1);
            this.passEmploye.CustomButton.Name = "";
            this.passEmploye.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passEmploye.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passEmploye.CustomButton.TabIndex = 1;
            this.passEmploye.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passEmploye.CustomButton.UseSelectable = true;
            this.passEmploye.CustomButton.Visible = false;
            this.passEmploye.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passEmploye.Lines = new string[] {
        "Mot de passe"};
            this.passEmploye.Location = new System.Drawing.Point(99, 172);
            this.passEmploye.MaxLength = 32767;
            this.passEmploye.Name = "passEmploye";
            this.passEmploye.PasswordChar = '\0';
            this.passEmploye.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passEmploye.SelectedText = "";
            this.passEmploye.SelectionLength = 0;
            this.passEmploye.SelectionStart = 0;
            this.passEmploye.ShortcutsEnabled = true;
            this.passEmploye.Size = new System.Drawing.Size(392, 23);
            this.passEmploye.TabIndex = 1;
            this.passEmploye.Text = "Mot de passe";
            this.passEmploye.UseSelectable = true;
            this.passEmploye.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passEmploye.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginBtn
            // 
            this.loginBtn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.loginBtn.Location = new System.Drawing.Point(198, 214);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(183, 71);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Connexion";
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(488, 219);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(74, 65);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // LoginEmpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 308);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passEmploye);
            this.Controls.Add(this.nomEmploye);
            this.Name = "LoginEmpView";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Connexion Employé";
            this.Load += new System.EventHandler(this.LoginEmpView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nomEmploye;
        private MetroFramework.Controls.MetroTextBox passEmploye;
        private MetroFramework.Controls.MetroButton loginBtn;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}