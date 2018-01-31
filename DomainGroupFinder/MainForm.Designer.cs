namespace Domain_Group_Finder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstDomainGroups = new System.Windows.Forms.ListBox();
            this.lblEnterAccountName = new System.Windows.Forms.Label();
            this.txtDomainAccountName = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptionsSelectDomain = new System.Windows.Forms.ToolStripMenuItem();
            this.miOptionsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbLookup = new System.Windows.Forms.GroupBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.stsMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu.SuspendLayout();
            this.gbLookup.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDomainGroups
            // 
            this.lstDomainGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDomainGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDomainGroups.Location = new System.Drawing.Point(10, 142);
            this.lstDomainGroups.Name = "lstDomainGroups";
            this.lstDomainGroups.Size = new System.Drawing.Size(269, 392);
            this.lstDomainGroups.TabIndex = 8;
            // 
            // lblEnterAccountName
            // 
            this.lblEnterAccountName.Location = new System.Drawing.Point(20, 16);
            this.lblEnterAccountName.Name = "lblEnterAccountName";
            this.lblEnterAccountName.Size = new System.Drawing.Size(160, 24);
            this.lblEnterAccountName.TabIndex = 7;
            this.lblEnterAccountName.Text = "Enter Domain Account Name:";
            // 
            // txtDomainAccountName
            // 
            this.txtDomainAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDomainAccountName.Location = new System.Drawing.Point(61, 34);
            this.txtDomainAccountName.Name = "txtDomainAccountName";
            this.txtDomainAccountName.Size = new System.Drawing.Size(157, 20);
            this.txtDomainAccountName.TabIndex = 6;
            // 
            // btnLookup
            // 
            this.btnLookup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLookup.Location = new System.Drawing.Point(23, 64);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(214, 28);
            this.btnLookup.TabIndex = 5;
            this.btnLookup.Text = "Lookup User";
            this.btnLookup.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOptions});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(289, 24);
            this.mainMenu.TabIndex = 9;
            this.mainMenu.Text = "menuStrip1";
            // 
            // miOptions
            // 
            this.miOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOptionsSelectDomain,
            this.miOptionsExit});
            this.miOptions.Name = "miOptions";
            this.miOptions.Size = new System.Drawing.Size(61, 20);
            this.miOptions.Text = "&Options";
            // 
            // miOptionsSelectDomain
            // 
            this.miOptionsSelectDomain.Name = "miOptionsSelectDomain";
            this.miOptionsSelectDomain.Size = new System.Drawing.Size(150, 22);
            this.miOptionsSelectDomain.Text = "Select &Domain";
            this.miOptionsSelectDomain.Click += new System.EventHandler(this.miOptionsSelectDomain_Click);
            // 
            // miOptionsExit
            // 
            this.miOptionsExit.Name = "miOptionsExit";
            this.miOptionsExit.Size = new System.Drawing.Size(150, 22);
            this.miOptionsExit.Text = "E&xit";
            this.miOptionsExit.Click += new System.EventHandler(this.miOptionsExit_Click);
            // 
            // gbLookup
            // 
            this.gbLookup.Controls.Add(this.btnLookup);
            this.gbLookup.Controls.Add(this.txtDomainAccountName);
            this.gbLookup.Controls.Add(this.lblEnterAccountName);
            this.gbLookup.Location = new System.Drawing.Point(12, 24);
            this.gbLookup.Name = "gbLookup";
            this.gbLookup.Size = new System.Drawing.Size(265, 107);
            this.gbLookup.TabIndex = 10;
            this.gbLookup.TabStop = false;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsMessage,
            this.stsVersion});
            this.status.Location = new System.Drawing.Point(0, 550);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(289, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 11;
            // 
            // stsMessage
            // 
            this.stsMessage.Name = "stsMessage";
            this.stsMessage.Size = new System.Drawing.Size(53, 17);
            this.stsMessage.Text = "message";
            this.stsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stsVersion
            // 
            this.stsVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stsVersion.Name = "stsVersion";
            this.stsVersion.Size = new System.Drawing.Size(190, 17);
            this.stsVersion.Spring = true;
            this.stsVersion.Text = "Version";
            this.stsVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 572);
            this.Controls.Add(this.status);
            this.Controls.Add(this.gbLookup);
            this.Controls.Add(this.lstDomainGroups);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.gbLookup.ResumeLayout(false);
            this.gbLookup.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstDomainGroups;
        internal System.Windows.Forms.Label lblEnterAccountName;
        internal System.Windows.Forms.TextBox txtDomainAccountName;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem miOptions;
        private System.Windows.Forms.ToolStripMenuItem miOptionsSelectDomain;
        private System.Windows.Forms.ToolStripMenuItem miOptionsExit;
        private System.Windows.Forms.GroupBox gbLookup;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel stsMessage;
        public System.Windows.Forms.ToolStripStatusLabel stsVersion;
    }
}