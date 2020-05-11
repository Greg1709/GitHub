namespace ERP
{
    partial class Calendrier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendrier));
            this.rdv = new System.Windows.Forms.ListBox();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.newRDV = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // rdv
            // 
            this.rdv.FormattingEnabled = true;
            this.rdv.ItemHeight = 16;
            this.rdv.Location = new System.Drawing.Point(43, 63);
            this.rdv.Name = "rdv";
            this.rdv.Size = new System.Drawing.Size(484, 324);
            this.rdv.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(464, 401);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(82, 72);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // newRDV
            // 
            this.newRDV.Location = new System.Drawing.Point(23, 401);
            this.newRDV.Name = "newRDV";
            this.newRDV.Size = new System.Drawing.Size(198, 54);
            this.newRDV.TabIndex = 2;
            this.newRDV.Text = "Nouveau Rdv";
            this.newRDV.UseSelectable = true;
            this.newRDV.Click += new System.EventHandler(this.newRDV_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(248, 401);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(175, 53);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Supprimer RDV";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Calendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 496);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.newRDV);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.rdv);
            this.Name = "Calendrier";
            this.Text = "Calendrier";
            this.Load += new System.EventHandler(this.Calendrier_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rdv;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton newRDV;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}