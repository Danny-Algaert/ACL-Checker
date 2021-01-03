namespace EVE_ACL_Checker
{
    partial class ACL_Checker
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tableLayoutPanelInput = new System.Windows.Forms.TableLayoutPanel();
            this.MainsACLTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.AltAssociationsTextBox = new System.Windows.Forms.TextBox();
            this.AltsACLTextBox = new System.Windows.Forms.TextBox();
            this.MainsACLFilePanel = new System.Windows.Forms.Panel();
            this.MainsACLFileButton = new System.Windows.Forms.Button();
            this.MainsACLFileLabel = new System.Windows.Forms.Label();
            this.AltsACLFilePanel = new System.Windows.Forms.Panel();
            this.AltsACLFileLabel = new System.Windows.Forms.Label();
            this.AltsACLFileButton = new System.Windows.Forms.Button();
            this.AltAssociationsFilePanel = new System.Windows.Forms.Panel();
            this.AltAssociationsFileButton = new System.Windows.Forms.Button();
            this.AltAssociationsFileLabel = new System.Windows.Forms.Label();
            this.OutputFilePanel = new System.Windows.Forms.Panel();
            this.OutputFileButton = new System.Windows.Forms.Button();
            this.OutputFileLabel = new System.Windows.Forms.Label();
            this.MembersACLAnalyzeButton = new System.Windows.Forms.Button();
            this.AltsACLAnalyzeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tableLayoutPanelInput.SuspendLayout();
            this.MainsACLFilePanel.SuspendLayout();
            this.AltsACLFilePanel.SuspendLayout();
            this.AltAssociationsFilePanel.SuspendLayout();
            this.OutputFilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // tableLayoutPanelInput
            // 
            this.tableLayoutPanelInput.AutoSize = true;
            this.tableLayoutPanelInput.ColumnCount = 4;
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelInput.Controls.Add(this.MainsACLTextBox, 0, 1);
            this.tableLayoutPanelInput.Controls.Add(this.OutputTextBox, 3, 1);
            this.tableLayoutPanelInput.Controls.Add(this.AltAssociationsTextBox, 2, 1);
            this.tableLayoutPanelInput.Controls.Add(this.AltsACLTextBox, 1, 1);
            this.tableLayoutPanelInput.Controls.Add(this.MainsACLFilePanel, 0, 0);
            this.tableLayoutPanelInput.Controls.Add(this.AltsACLFilePanel, 1, 0);
            this.tableLayoutPanelInput.Controls.Add(this.AltAssociationsFilePanel, 2, 0);
            this.tableLayoutPanelInput.Controls.Add(this.OutputFilePanel, 3, 0);
            this.tableLayoutPanelInput.Controls.Add(this.MembersACLAnalyzeButton, 0, 2);
            this.tableLayoutPanelInput.Controls.Add(this.AltsACLAnalyzeButton, 1, 2);
            this.tableLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelInput.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            this.tableLayoutPanelInput.RowCount = 3;
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanelInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelInput.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanelInput.TabIndex = 0;
            // 
            // MainsACLTextBox
            // 
            this.MainsACLTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainsACLTextBox.Location = new System.Drawing.Point(3, 39);
            this.MainsACLTextBox.Multiline = true;
            this.MainsACLTextBox.Name = "MainsACLTextBox";
            this.MainsACLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainsACLTextBox.Size = new System.Drawing.Size(194, 372);
            this.MainsACLTextBox.TabIndex = 0;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputTextBox.Location = new System.Drawing.Point(603, 39);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(194, 372);
            this.OutputTextBox.TabIndex = 3;
            // 
            // AltAssociationsTextBox
            // 
            this.AltAssociationsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AltAssociationsTextBox.Location = new System.Drawing.Point(403, 39);
            this.AltAssociationsTextBox.Multiline = true;
            this.AltAssociationsTextBox.Name = "AltAssociationsTextBox";
            this.AltAssociationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AltAssociationsTextBox.Size = new System.Drawing.Size(194, 372);
            this.AltAssociationsTextBox.TabIndex = 2;
            // 
            // AltsACLTextBox
            // 
            this.AltsACLTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AltsACLTextBox.Location = new System.Drawing.Point(203, 39);
            this.AltsACLTextBox.Multiline = true;
            this.AltsACLTextBox.Name = "AltsACLTextBox";
            this.AltsACLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AltsACLTextBox.Size = new System.Drawing.Size(194, 372);
            this.AltsACLTextBox.TabIndex = 1;
            // 
            // MainsACLFilePanel
            // 
            this.MainsACLFilePanel.Controls.Add(this.MainsACLFileButton);
            this.MainsACLFilePanel.Controls.Add(this.MainsACLFileLabel);
            this.MainsACLFilePanel.Location = new System.Drawing.Point(3, 3);
            this.MainsACLFilePanel.Name = "MainsACLFilePanel";
            this.MainsACLFilePanel.Size = new System.Drawing.Size(192, 30);
            this.MainsACLFilePanel.TabIndex = 4;
            // 
            // MainsACLFileButton
            // 
            this.MainsACLFileButton.Location = new System.Drawing.Point(114, 3);
            this.MainsACLFileButton.Name = "MainsACLFileButton";
            this.MainsACLFileButton.Size = new System.Drawing.Size(75, 23);
            this.MainsACLFileButton.TabIndex = 4;
            this.MainsACLFileButton.Text = "Open";
            this.MainsACLFileButton.UseVisualStyleBackColor = true;
            this.MainsACLFileButton.Click += new System.EventHandler(this.MainsACLFileButton_Click);
            // 
            // MainsACLFileLabel
            // 
            this.MainsACLFileLabel.AutoSize = true;
            this.MainsACLFileLabel.Location = new System.Drawing.Point(3, 8);
            this.MainsACLFileLabel.Name = "MainsACLFileLabel";
            this.MainsACLFileLabel.Size = new System.Drawing.Size(73, 13);
            this.MainsACLFileLabel.TabIndex = 0;
            this.MainsACLFileLabel.Text = "Members ACL";
            // 
            // AltsACLFilePanel
            // 
            this.AltsACLFilePanel.Controls.Add(this.AltsACLFileLabel);
            this.AltsACLFilePanel.Controls.Add(this.AltsACLFileButton);
            this.AltsACLFilePanel.Location = new System.Drawing.Point(203, 3);
            this.AltsACLFilePanel.Name = "AltsACLFilePanel";
            this.AltsACLFilePanel.Size = new System.Drawing.Size(192, 30);
            this.AltsACLFilePanel.TabIndex = 5;
            // 
            // AltsACLFileLabel
            // 
            this.AltsACLFileLabel.AutoSize = true;
            this.AltsACLFileLabel.Location = new System.Drawing.Point(3, 8);
            this.AltsACLFileLabel.Name = "AltsACLFileLabel";
            this.AltsACLFileLabel.Size = new System.Drawing.Size(47, 13);
            this.AltsACLFileLabel.TabIndex = 0;
            this.AltsACLFileLabel.Text = "Alts ACL";
            // 
            // AltsACLFileButton
            // 
            this.AltsACLFileButton.Location = new System.Drawing.Point(114, 3);
            this.AltsACLFileButton.Name = "AltsACLFileButton";
            this.AltsACLFileButton.Size = new System.Drawing.Size(75, 23);
            this.AltsACLFileButton.TabIndex = 5;
            this.AltsACLFileButton.Text = "Open";
            this.AltsACLFileButton.UseVisualStyleBackColor = true;
            this.AltsACLFileButton.Click += new System.EventHandler(this.AltsACLFileButton_Click);
            // 
            // AltAssociationsFilePanel
            // 
            this.AltAssociationsFilePanel.Controls.Add(this.AltAssociationsFileButton);
            this.AltAssociationsFilePanel.Controls.Add(this.AltAssociationsFileLabel);
            this.AltAssociationsFilePanel.Location = new System.Drawing.Point(403, 3);
            this.AltAssociationsFilePanel.Name = "AltAssociationsFilePanel";
            this.AltAssociationsFilePanel.Size = new System.Drawing.Size(192, 30);
            this.AltAssociationsFilePanel.TabIndex = 6;
            // 
            // AltAssociationsFileButton
            // 
            this.AltAssociationsFileButton.Location = new System.Drawing.Point(114, 3);
            this.AltAssociationsFileButton.Name = "AltAssociationsFileButton";
            this.AltAssociationsFileButton.Size = new System.Drawing.Size(75, 23);
            this.AltAssociationsFileButton.TabIndex = 6;
            this.AltAssociationsFileButton.Text = "Open";
            this.AltAssociationsFileButton.UseVisualStyleBackColor = true;
            this.AltAssociationsFileButton.Click += new System.EventHandler(this.AltAssociationsFileButton_Click);
            // 
            // AltAssociationsFileLabel
            // 
            this.AltAssociationsFileLabel.AutoSize = true;
            this.AltAssociationsFileLabel.Location = new System.Drawing.Point(3, 8);
            this.AltAssociationsFileLabel.Name = "AltAssociationsFileLabel";
            this.AltAssociationsFileLabel.Size = new System.Drawing.Size(81, 13);
            this.AltAssociationsFileLabel.TabIndex = 0;
            this.AltAssociationsFileLabel.Text = "Alt Associations";
            // 
            // OutputFilePanel
            // 
            this.OutputFilePanel.Controls.Add(this.OutputFileButton);
            this.OutputFilePanel.Controls.Add(this.OutputFileLabel);
            this.OutputFilePanel.Location = new System.Drawing.Point(603, 3);
            this.OutputFilePanel.Name = "OutputFilePanel";
            this.OutputFilePanel.Size = new System.Drawing.Size(194, 30);
            this.OutputFilePanel.TabIndex = 7;
            // 
            // OutputFileButton
            // 
            this.OutputFileButton.Location = new System.Drawing.Point(116, 3);
            this.OutputFileButton.Name = "OutputFileButton";
            this.OutputFileButton.Size = new System.Drawing.Size(75, 23);
            this.OutputFileButton.TabIndex = 7;
            this.OutputFileButton.Text = "Save As";
            this.OutputFileButton.UseVisualStyleBackColor = true;
            this.OutputFileButton.Click += new System.EventHandler(this.OutputFileButton_Click);
            // 
            // OutputFileLabel
            // 
            this.OutputFileLabel.AutoSize = true;
            this.OutputFileLabel.Location = new System.Drawing.Point(3, 8);
            this.OutputFileLabel.Name = "OutputFileLabel";
            this.OutputFileLabel.Size = new System.Drawing.Size(92, 13);
            this.OutputFileLabel.TabIndex = 0;
            this.OutputFileLabel.Text = "Save Your Output";
            // 
            // MembersACLAnalyzeButton
            // 
            this.MembersACLAnalyzeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembersACLAnalyzeButton.Location = new System.Drawing.Point(3, 417);
            this.MembersACLAnalyzeButton.Name = "MembersACLAnalyzeButton";
            this.MembersACLAnalyzeButton.Size = new System.Drawing.Size(194, 30);
            this.MembersACLAnalyzeButton.TabIndex = 8;
            this.MembersACLAnalyzeButton.Text = "Analyze Members";
            this.MembersACLAnalyzeButton.UseVisualStyleBackColor = true;
            this.MembersACLAnalyzeButton.Click += new System.EventHandler(this.MembersACLAnalyzeButton_Click);
            // 
            // AltsACLAnalyzeButton
            // 
            this.AltsACLAnalyzeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AltsACLAnalyzeButton.Location = new System.Drawing.Point(203, 417);
            this.AltsACLAnalyzeButton.Name = "AltsACLAnalyzeButton";
            this.AltsACLAnalyzeButton.Size = new System.Drawing.Size(194, 30);
            this.AltsACLAnalyzeButton.TabIndex = 9;
            this.AltsACLAnalyzeButton.Text = "AnalyzeAlts";
            this.AltsACLAnalyzeButton.UseVisualStyleBackColor = true;
            this.AltsACLAnalyzeButton.Click += new System.EventHandler(this.AltsACLAnalyzeButton_Click);
            // 
            // ACL_Checker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelInput);
            this.Name = "ACL_Checker";
            this.Text = "ACL_Checker";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tableLayoutPanelInput.ResumeLayout(false);
            this.tableLayoutPanelInput.PerformLayout();
            this.MainsACLFilePanel.ResumeLayout(false);
            this.MainsACLFilePanel.PerformLayout();
            this.AltsACLFilePanel.ResumeLayout(false);
            this.AltsACLFilePanel.PerformLayout();
            this.AltAssociationsFilePanel.ResumeLayout(false);
            this.AltAssociationsFilePanel.PerformLayout();
            this.OutputFilePanel.ResumeLayout(false);
            this.OutputFilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.TextBox MainsACLTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.TextBox AltAssociationsTextBox;
        private System.Windows.Forms.TextBox AltsACLTextBox;
        private System.Windows.Forms.Panel MainsACLFilePanel;
        private System.Windows.Forms.Button MainsACLFileButton;
        private System.Windows.Forms.Label MainsACLFileLabel;
        private System.Windows.Forms.Panel AltsACLFilePanel;
        private System.Windows.Forms.Label AltsACLFileLabel;
        private System.Windows.Forms.Button AltsACLFileButton;
        private System.Windows.Forms.Panel AltAssociationsFilePanel;
        private System.Windows.Forms.Button AltAssociationsFileButton;
        private System.Windows.Forms.Label AltAssociationsFileLabel;
        private System.Windows.Forms.Panel OutputFilePanel;
        private System.Windows.Forms.Button OutputFileButton;
        private System.Windows.Forms.Label OutputFileLabel;
        private System.Windows.Forms.Button MembersACLAnalyzeButton;
        private System.Windows.Forms.Button AltsACLAnalyzeButton;
    }
}