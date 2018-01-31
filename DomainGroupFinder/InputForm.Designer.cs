namespace Domain_Group_Finder
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.lblInputPrompt = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.gbInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.lblInputPrompt);
            this.gbInput.Controls.Add(this.btnCancel);
            this.gbInput.Controls.Add(this.btnOk);
            this.gbInput.Controls.Add(this.txtInput);
            this.gbInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbInput.Location = new System.Drawing.Point(0, 0);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(300, 116);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            // 
            // lblInputPrompt
            // 
            this.lblInputPrompt.AutoSize = true;
            this.lblInputPrompt.Location = new System.Drawing.Point(29, 20);
            this.lblInputPrompt.Name = "lblInputPrompt";
            this.lblInputPrompt.Size = new System.Drawing.Size(91, 13);
            this.lblInputPrompt.TabIndex = 4;
            this.lblInputPrompt.Text = "Input Prompt Text";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(166, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(61, 74);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(79, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(29, 43);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(239, 20);
            this.txtInput.TabIndex = 1;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(300, 116);
            this.Controls.Add(this.gbInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GetInput";
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInputPrompt;
    }
}