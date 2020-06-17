namespace MySteam.Forms
{
    partial class LocationPrompt
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbLocationBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSearchForDirectory = new System.Windows.Forms.Button();
            this.lblBugDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(260, 41);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbLocationBox
            // 
            this.tbLocationBox.Location = new System.Drawing.Point(12, 41);
            this.tbLocationBox.Name = "tbLocationBox";
            this.tbLocationBox.Size = new System.Drawing.Size(214, 20);
            this.tbLocationBox.TabIndex = 1;
            // 
            // btnSearchForDirectory
            // 
            this.btnSearchForDirectory.Location = new System.Drawing.Point(232, 41);
            this.btnSearchForDirectory.Name = "btnSearchForDirectory";
            this.btnSearchForDirectory.Size = new System.Drawing.Size(22, 23);
            this.btnSearchForDirectory.TabIndex = 2;
            this.btnSearchForDirectory.Text = "(IMAGE)";
            this.btnSearchForDirectory.UseVisualStyleBackColor = true;
            this.btnSearchForDirectory.Click += new System.EventHandler(this.btnSearchForDirectory_Click);
            // 
            // lblBugDisplay
            // 
            this.lblBugDisplay.AutoSize = true;
            this.lblBugDisplay.Location = new System.Drawing.Point(12, 79);
            this.lblBugDisplay.Name = "lblBugDisplay";
            this.lblBugDisplay.Size = new System.Drawing.Size(14, 13);
            this.lblBugDisplay.TabIndex = 3;
            this.lblBugDisplay.Text = "X";
            this.lblBugDisplay.Visible = false;
            // 
            // LocationPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 115);
            this.Controls.Add(this.lblBugDisplay);
            this.Controls.Add(this.btnSearchForDirectory);
            this.Controls.Add(this.tbLocationBox);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LocationPrompt";
            this.ShowIcon = false;
            this.Text = "LocationPrompt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationPrompt_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbLocationBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSearchForDirectory;
        private System.Windows.Forms.Label lblBugDisplay;
    }
}