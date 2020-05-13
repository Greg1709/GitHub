namespace ERP
{
    partial class AddDevis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDevis));
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.path = new MetroFramework.Controls.MetroTextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.client = new MetroFramework.Controls.MetroComboBox();
            this.createdev = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(548, 195);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(78, 76);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // path
            // 
            // 
            // 
            // 
            this.path.CustomButton.Image = null;
            this.path.CustomButton.Location = new System.Drawing.Point(552, 1);
            this.path.CustomButton.Name = "";
            this.path.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.path.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.path.CustomButton.TabIndex = 1;
            this.path.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.path.CustomButton.UseSelectable = true;
            this.path.CustomButton.Visible = false;
            this.path.Lines = new string[] {
        "Reference devis"};
            this.path.Location = new System.Drawing.Point(34, 81);
            this.path.MaxLength = 32767;
            this.path.Name = "path";
            this.path.PasswordChar = '\0';
            this.path.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.path.SelectedText = "";
            this.path.SelectionLength = 0;
            this.path.SelectionStart = 0;
            this.path.ShortcutsEnabled = true;
            this.path.Size = new System.Drawing.Size(592, 41);
            this.path.TabIndex = 1;
            this.path.Text = "Reference devis";
            this.path.UseSelectable = true;
            this.path.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.path.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(426, 142);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 2;
            // 
            // client
            // 
            this.client.FormattingEnabled = true;
            this.client.ItemHeight = 24;
            this.client.Location = new System.Drawing.Point(34, 134);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(335, 30);
            this.client.TabIndex = 3;
            this.client.UseSelectable = true;
            // 
            // createdev
            // 
            this.createdev.Location = new System.Drawing.Point(232, 195);
            this.createdev.Name = "createdev";
            this.createdev.Size = new System.Drawing.Size(229, 76);
            this.createdev.TabIndex = 4;
            this.createdev.Text = "Créer devis";
            this.createdev.UseSelectable = true;
            this.createdev.Click += new System.EventHandler(this.createdev_Click);
            // 
            // AddDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 284);
            this.Controls.Add(this.createdev);
            this.Controls.Add(this.client);
            this.Controls.Add(this.date);
            this.Controls.Add(this.path);
            this.Controls.Add(this.btn_exit);
            this.Name = "AddDevis";
            this.Text = "AddDevis";
            this.Load += new System.EventHandler(this.AddDevis_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroTextBox path;
        private System.Windows.Forms.DateTimePicker date;
        private MetroFramework.Controls.MetroComboBox client;
        private MetroFramework.Controls.MetroButton createdev;
    }
}