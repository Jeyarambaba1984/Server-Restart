namespace ServerServiceRestart
{
    partial class FrmServerrestart
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
            this.lblserverlist = new System.Windows.Forms.Label();
            this.lstServerList = new System.Windows.Forms.ListBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnViewServices = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblserverlist
            // 
            this.lblserverlist.BackColor = System.Drawing.Color.Transparent;
            this.lblserverlist.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserverlist.Location = new System.Drawing.Point(50, 30);
            this.lblserverlist.Name = "lblserverlist";
            this.lblserverlist.Size = new System.Drawing.Size(129, 28);
            this.lblserverlist.TabIndex = 0;
            this.lblserverlist.Text = "Server List";
            // 
            // lstServerList
            // 
            this.lstServerList.FormattingEnabled = true;
            this.lstServerList.Items.AddRange(new object[] {
            "Server 1",
            "Server 2",
            "Server 3",
            "Server 4",
            "Server 5"});
            this.lstServerList.Location = new System.Drawing.Point(53, 74);
            this.lstServerList.Name = "lstServerList";
            this.lstServerList.Size = new System.Drawing.Size(274, 121);
            this.lstServerList.TabIndex = 1;
            this.lstServerList.Click += new System.EventHandler(this.GetServerStatus);
            this.lstServerList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(53, 235);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(106, 24);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart Server";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnViewServices
            // 
            this.btnViewServices.Location = new System.Drawing.Point(221, 235);
            this.btnViewServices.Name = "btnViewServices";
            this.btnViewServices.Size = new System.Drawing.Size(106, 24);
            this.btnViewServices.TabIndex = 3;
            this.btnViewServices.Text = "View Services";
            this.btnViewServices.UseVisualStyleBackColor = true;
            this.btnViewServices.Click += new System.EventHandler(this.btnGetServices);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(393, 76);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(108, 13);
            this.lblServerStatus.TabIndex = 4;
            this.lblServerStatus.Text = "Server Current Status";
            this.lblServerStatus.Visible = false;
            // 
            // FrmServerrestart
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(840, 328);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.btnViewServices);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lstServerList);
            this.Controls.Add(this.lblserverlist);
            this.Name = "FrmServerrestart";
            this.Text = "Server & Service Restart Utility";
            this.Load += new System.EventHandler(this.MyForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Button GetServerStatus;
        private System.Windows.Forms.ListBox ServerListbox;
        private System.Windows.Forms.Label lblserverlist;
        private System.Windows.Forms.ListBox lstServerList;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnViewServices;
        private System.Windows.Forms.Label lblServerStatus;
    }
}

