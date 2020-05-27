namespace XplSimbolicLink
{
    partial class FrmMain
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
            this.LblSource = new System.Windows.Forms.Label();
            this.BtnSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnDestination = new System.Windows.Forms.Button();
            this.lblTotalFolders = new System.Windows.Forms.Label();
            this.chkFolders = new System.Windows.Forms.CheckedListBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.lblFolderSelected = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LblSource
            // 
            this.LblSource.AutoSize = true;
            this.LblSource.Location = new System.Drawing.Point(44, 13);
            this.LblSource.Name = "LblSource";
            this.LblSource.Size = new System.Drawing.Size(44, 13);
            this.LblSource.TabIndex = 0;
            this.LblSource.Text = "Source:";
            this.LblSource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BtnSource
            // 
            this.BtnSource.Location = new System.Drawing.Point(362, 6);
            this.BtnSource.Name = "BtnSource";
            this.BtnSource.Size = new System.Drawing.Size(75, 20);
            this.BtnSource.TabIndex = 1;
            this.BtnSource.Text = "Open";
            this.BtnSource.UseVisualStyleBackColor = true;
            this.BtnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(94, 6);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(262, 20);
            this.txtSource.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destination:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDestination
            // 
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(94, 31);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(262, 20);
            this.txtDestination.TabIndex = 5;
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(362, 32);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(75, 20);
            this.btnDestination.TabIndex = 6;
            this.btnDestination.Text = "Open";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // lblTotalFolders
            // 
            this.lblTotalFolders.AutoSize = true;
            this.lblTotalFolders.Location = new System.Drawing.Point(25, 406);
            this.lblTotalFolders.Name = "lblTotalFolders";
            this.lblTotalFolders.Size = new System.Drawing.Size(74, 13);
            this.lblTotalFolders.TabIndex = 7;
            this.lblTotalFolders.Text = "Total Folders: ";
            this.lblTotalFolders.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkFolders
            // 
            this.chkFolders.CheckOnClick = true;
            this.chkFolders.FormattingEnabled = true;
            this.chkFolders.Location = new System.Drawing.Point(28, 114);
            this.chkFolders.Name = "chkFolders";
            this.chkFolders.Size = new System.Drawing.Size(760, 289);
            this.chkFolders.TabIndex = 8;
            this.chkFolders.SelectedIndexChanged += new System.EventHandler(this.ChkFolders_SelectedIndexChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(28, 91);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(70, 17);
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "Select All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.ChkAll_Click);
            // 
            // lblFolderSelected
            // 
            this.lblFolderSelected.AutoSize = true;
            this.lblFolderSelected.Location = new System.Drawing.Point(131, 406);
            this.lblFolderSelected.Name = "lblFolderSelected";
            this.lblFolderSelected.Size = new System.Drawing.Size(86, 13);
            this.lblFolderSelected.TabIndex = 10;
            this.lblFolderSelected.Text = "Folders Selected";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(489, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(298, 45);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(28, 435);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(759, 23);
            this.progressBar1.TabIndex = 12;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblFolderSelected);
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkFolders);
            this.Controls.Add(this.lblTotalFolders);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.BtnSource);
            this.Controls.Add(this.LblSource);
            this.Name = "FrmMain";
            this.Text = "XplSymbolicLinks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSource;
        private System.Windows.Forms.Button BtnSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Label lblTotalFolders;
        private System.Windows.Forms.CheckedListBox chkFolders;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label lblFolderSelected;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

