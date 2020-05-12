namespace ERP
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.metroScrollBar2 = new MetroFramework.Controls.MetroScrollBar();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(144, 110);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(496, 228);
            this.listBox1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Devis non accepté";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 351);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Devis  accepté";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(144, 379);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(496, 196);
            this.listBox2.TabIndex = 3;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(630, 128);
            this.metroScrollBar1.Maximum = 100;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 10;
            this.metroScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.metroScrollBar1.TabIndex = 4;
            this.metroScrollBar1.UseSelectable = true;
            this.metroScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroScrollBar1_Scroll);
            // 
            // metroScrollBar2
            // 
            this.metroScrollBar2.LargeChange = 10;
            this.metroScrollBar2.Location = new System.Drawing.Point(630, 379);
            this.metroScrollBar2.Maximum = 100;
            this.metroScrollBar2.Minimum = 0;
            this.metroScrollBar2.MouseWheelBarPartitions = 10;
            this.metroScrollBar2.Name = "metroScrollBar2";
            this.metroScrollBar2.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar2.ScrollbarSize = 10;
            this.metroScrollBar2.Size = new System.Drawing.Size(10, 200);
            this.metroScrollBar2.TabIndex = 5;
            this.metroScrollBar2.UseSelectable = true;
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
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(42, 608);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(292, 77);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Créer un nouveau devis";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(388, 608);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(213, 77);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Modifier un devis";
            this.metroButton2.UseSelectable = true;
            // 
            // Devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 705);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.metroScrollBar2);
            this.Controls.Add(this.metroScrollBar1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Devis";
            this.Text = "Devis";
            this.Load += new System.EventHandler(this.Devis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox listBox2;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar2;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}