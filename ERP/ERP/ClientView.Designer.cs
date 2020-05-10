namespace ERP
{
    partial class ClientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientView));
            this.clients = new System.Windows.Forms.ListBox();
            this.refresh = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.addClient = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // clients
            // 
            this.clients.FormattingEnabled = true;
            this.clients.ItemHeight = 16;
            this.clients.Location = new System.Drawing.Point(23, 78);
            this.clients.Name = "clients";
            this.clients.Size = new System.Drawing.Size(564, 340);
            this.clients.TabIndex = 0;
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(634, 367);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(54, 51);
            this.refresh.TabIndex = 1;
            this.refresh.UseSelectable = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(723, 367);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(54, 51);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.Location = new System.Drawing.Point(634, 319);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 32);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Exporter en CSV ";
            this.metroButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // addClient
            // 
            this.addClient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addClient.BackgroundImage")));
            this.addClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addClient.Location = new System.Drawing.Point(623, 154);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(154, 144);
            this.addClient.TabIndex = 4;
            this.addClient.UseSelectable = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.clients);
            this.Name = "ClientView";
            this.Text = "ClientView";
            this.Load += new System.EventHandler(this.ClientView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox clients;
        private MetroFramework.Controls.MetroButton refresh;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton addClient;
    }
}