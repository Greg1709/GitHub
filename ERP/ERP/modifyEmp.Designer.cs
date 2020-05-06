namespace ERP
{
    partial class modifyEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyEmp));
            this.nameModify = new MetroFramework.Controls.MetroTextBox();
            this.passModify = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SelectName = new System.Windows.Forms.CheckBox();
            this.SelectPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameModify
            // 
            // 
            // 
            // 
            this.nameModify.CustomButton.Image = null;
            this.nameModify.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.nameModify.CustomButton.Name = "";
            this.nameModify.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameModify.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameModify.CustomButton.TabIndex = 1;
            this.nameModify.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameModify.CustomButton.UseSelectable = true;
            this.nameModify.CustomButton.Visible = false;
            this.nameModify.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.nameModify.Lines = new string[0];
            this.nameModify.Location = new System.Drawing.Point(193, 120);
            this.nameModify.MaxLength = 32767;
            this.nameModify.Name = "nameModify";
            this.nameModify.PasswordChar = '\0';
            this.nameModify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameModify.SelectedText = "";
            this.nameModify.SelectionLength = 0;
            this.nameModify.SelectionStart = 0;
            this.nameModify.ShortcutsEnabled = true;
            this.nameModify.Size = new System.Drawing.Size(338, 23);
            this.nameModify.TabIndex = 0;
            this.nameModify.UseSelectable = true;
            this.nameModify.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameModify.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passModify
            // 
            // 
            // 
            // 
            this.passModify.CustomButton.Image = null;
            this.passModify.CustomButton.Location = new System.Drawing.Point(316, 1);
            this.passModify.CustomButton.Name = "";
            this.passModify.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passModify.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passModify.CustomButton.TabIndex = 1;
            this.passModify.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passModify.CustomButton.UseSelectable = true;
            this.passModify.CustomButton.Visible = false;
            this.passModify.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passModify.Lines = new string[0];
            this.passModify.Location = new System.Drawing.Point(193, 200);
            this.passModify.MaxLength = 32767;
            this.passModify.Name = "passModify";
            this.passModify.PasswordChar = '*';
            this.passModify.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passModify.SelectedText = "";
            this.passModify.SelectionLength = 0;
            this.passModify.SelectionStart = 0;
            this.passModify.ShortcutsEnabled = true;
            this.passModify.Size = new System.Drawing.Size(338, 23);
            this.passModify.TabIndex = 1;
            this.passModify.UseSelectable = true;
            this.passModify.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passModify.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 203);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nouveau mot de passe : ";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Nouveau nom :";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroButton1.Location = new System.Drawing.Point(159, 277);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(258, 77);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Changer ";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.metroButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton2.BackgroundImage")));
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton2.Location = new System.Drawing.Point(477, 277);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(71, 77);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // SelectName
            // 
            this.SelectName.AutoSize = true;
            this.SelectName.Location = new System.Drawing.Point(537, 126);
            this.SelectName.Name = "SelectName";
            this.SelectName.Size = new System.Drawing.Size(18, 17);
            this.SelectName.TabIndex = 6;
            this.SelectName.UseVisualStyleBackColor = true;
            // 
            // SelectPass
            // 
            this.SelectPass.AutoSize = true;
            this.SelectPass.Location = new System.Drawing.Point(537, 203);
            this.SelectPass.Name = "SelectPass";
            this.SelectPass.Size = new System.Drawing.Size(18, 17);
            this.SelectPass.TabIndex = 7;
            this.SelectPass.UseVisualStyleBackColor = true;
            // 
            // modifyEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 392);
            this.Controls.Add(this.SelectPass);
            this.Controls.Add(this.SelectName);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.passModify);
            this.Controls.Add(this.nameModify);
            this.Name = "modifyEmp";
            this.Text = "modifyEmp";
            this.Load += new System.EventHandler(this.modifyEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nameModify;
        private MetroFramework.Controls.MetroTextBox passModify;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.CheckBox SelectName;
        private System.Windows.Forms.CheckBox SelectPass;
    }
}