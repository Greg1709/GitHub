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
            this.clients = new System.Windows.Forms.ListBox();
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
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clients);
            this.Name = "ClientView";
            this.Text = "ClientView";
            this.Load += new System.EventHandler(this.ClientView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox clients;
    }
}