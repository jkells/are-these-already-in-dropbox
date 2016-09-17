namespace AreTheseFoldersInDropbox
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
            this.goBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dropboxFolderTxt = new System.Windows.Forms.TextBox();
            this.folderTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowseBtn = new System.Windows.Forms.Button();
            this.dropboxFolderBrowseBtn = new System.Windows.Forms.Button();
            this.resultsTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.folderRecurse = new System.Windows.Forms.CheckBox();
            this.dropboxFolderRecurse = new System.Windows.Forms.CheckBox();
            this.searchPattern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.copyMissing = new System.Windows.Forms.CheckBox();
            this.moveMissing = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(312, 575);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(132, 35);
            this.goBtn.TabIndex = 0;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder";
            // 
            // dropboxFolderTxt
            // 
            this.dropboxFolderTxt.Location = new System.Drawing.Point(98, 67);
            this.dropboxFolderTxt.Name = "dropboxFolderTxt";
            this.dropboxFolderTxt.Size = new System.Drawing.Size(265, 20);
            this.dropboxFolderTxt.TabIndex = 2;
            // 
            // folderTxt
            // 
            this.folderTxt.Location = new System.Drawing.Point(98, 17);
            this.folderTxt.Name = "folderTxt";
            this.folderTxt.Size = new System.Drawing.Size(265, 20);
            this.folderTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DropBox Folder";
            // 
            // folderBrowseBtn
            // 
            this.folderBrowseBtn.Location = new System.Drawing.Point(369, 15);
            this.folderBrowseBtn.Name = "folderBrowseBtn";
            this.folderBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.folderBrowseBtn.TabIndex = 5;
            this.folderBrowseBtn.Text = "Browse";
            this.folderBrowseBtn.UseVisualStyleBackColor = true;
            this.folderBrowseBtn.Click += new System.EventHandler(this.folderBrowseBtn_Click);
            // 
            // dropboxFolderBrowseBtn
            // 
            this.dropboxFolderBrowseBtn.Location = new System.Drawing.Point(369, 65);
            this.dropboxFolderBrowseBtn.Name = "dropboxFolderBrowseBtn";
            this.dropboxFolderBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.dropboxFolderBrowseBtn.TabIndex = 6;
            this.dropboxFolderBrowseBtn.Text = "Browse";
            this.dropboxFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.dropboxFolderBrowseBtn.Click += new System.EventHandler(this.dropboxFolderBrowseBtn_Click);
            // 
            // resultsTxt
            // 
            this.resultsTxt.Location = new System.Drawing.Point(15, 226);
            this.resultsTxt.Multiline = true;
            this.resultsTxt.Name = "resultsTxt";
            this.resultsTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTxt.Size = new System.Drawing.Size(429, 343);
            this.resultsTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Results";
            // 
            // folderRecurse
            // 
            this.folderRecurse.AutoSize = true;
            this.folderRecurse.Location = new System.Drawing.Point(98, 43);
            this.folderRecurse.Name = "folderRecurse";
            this.folderRecurse.Size = new System.Drawing.Size(66, 17);
            this.folderRecurse.TabIndex = 9;
            this.folderRecurse.Text = "Recurse";
            this.folderRecurse.UseVisualStyleBackColor = true;
            // 
            // dropboxFolderRecurse
            // 
            this.dropboxFolderRecurse.AutoSize = true;
            this.dropboxFolderRecurse.Location = new System.Drawing.Point(98, 93);
            this.dropboxFolderRecurse.Name = "dropboxFolderRecurse";
            this.dropboxFolderRecurse.Size = new System.Drawing.Size(66, 17);
            this.dropboxFolderRecurse.TabIndex = 10;
            this.dropboxFolderRecurse.Text = "Recurse";
            this.dropboxFolderRecurse.UseVisualStyleBackColor = true;
            // 
            // searchPattern
            // 
            this.searchPattern.Location = new System.Drawing.Point(98, 116);
            this.searchPattern.Name = "searchPattern";
            this.searchPattern.Size = new System.Drawing.Size(119, 20);
            this.searchPattern.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Search Pattern";
            // 
            // copyMissing
            // 
            this.copyMissing.AutoSize = true;
            this.copyMissing.Location = new System.Drawing.Point(98, 143);
            this.copyMissing.Name = "copyMissing";
            this.copyMissing.Size = new System.Drawing.Size(114, 17);
            this.copyMissing.TabIndex = 13;
            this.copyMissing.Text = "Copy missing files?";
            this.copyMissing.UseVisualStyleBackColor = true;
            this.copyMissing.CheckedChanged += new System.EventHandler(this.copyMissing_CheckedChanged);
            // 
            // moveMissing
            // 
            this.moveMissing.AutoSize = true;
            this.moveMissing.Location = new System.Drawing.Point(98, 166);
            this.moveMissing.Name = "moveMissing";
            this.moveMissing.Size = new System.Drawing.Size(117, 17);
            this.moveMissing.TabIndex = 14;
            this.moveMissing.Text = "Move missing files?";
            this.moveMissing.UseVisualStyleBackColor = true;
            this.moveMissing.CheckedChanged += new System.EventHandler(this.moveMissing_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 622);
            this.Controls.Add(this.moveMissing);
            this.Controls.Add(this.copyMissing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchPattern);
            this.Controls.Add(this.dropboxFolderRecurse);
            this.Controls.Add(this.folderRecurse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultsTxt);
            this.Controls.Add(this.dropboxFolderBrowseBtn);
            this.Controls.Add(this.folderBrowseBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.folderTxt);
            this.Controls.Add(this.dropboxFolderTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Are all these files in Dropbox already?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dropboxFolderTxt;
        private System.Windows.Forms.TextBox folderTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button folderBrowseBtn;
        private System.Windows.Forms.Button dropboxFolderBrowseBtn;
        private System.Windows.Forms.TextBox resultsTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox folderRecurse;
        private System.Windows.Forms.CheckBox dropboxFolderRecurse;
        private System.Windows.Forms.TextBox searchPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox copyMissing;
        private System.Windows.Forms.CheckBox moveMissing;
    }
}

