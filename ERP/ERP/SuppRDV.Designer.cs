namespace ERP
{
    partial class SuppRDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppRDV));
            this.listNom = new System.Windows.Forms.ComboBox();
            this.supRDV = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listNom
            // 
            this.listNom.FormattingEnabled = true;
            this.listNom.Location = new System.Drawing.Point(82, 94);
            this.listNom.Name = "listNom";
            this.listNom.Size = new System.Drawing.Size(364, 24);
            this.listNom.TabIndex = 0;
            // 
            // supRDV
            // 
            this.supRDV.Location = new System.Drawing.Point(153, 141);
            this.supRDV.Name = "supRDV";
            this.supRDV.Size = new System.Drawing.Size(219, 59);
            this.supRDV.TabIndex = 1;
            this.supRDV.Text = "Supprimer RDV";
            this.supRDV.UseSelectable = true;
            this.supRDV.Click += new System.EventHandler(this.supRDV_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.Location = new System.Drawing.Point(407, 200);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 77);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // SuppRDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 325);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.supRDV);
            this.Controls.Add(this.listNom);
            this.Name = "SuppRDV";
            this.Text = "SuppRDV";
            this.Load += new System.EventHandler(this.SuppRDV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox listNom;
        private MetroFramework.Controls.MetroButton supRDV;
        private MetroFramework.Controls.MetroButton btn_exit;
    }
}