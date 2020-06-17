namespace SteamLike
{
    partial class SteamLike
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearchingStatus = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTagsSave = new System.Windows.Forms.Button();
            this.btnDiscSave = new System.Windows.Forms.Button();
            this.btnTagEdit = new System.Windows.Forms.Button();
            this.btnDescEdit = new System.Windows.Forms.Button();
            this.btnSaveTitleChange = new System.Windows.Forms.Button();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.btnEditGameName = new System.Windows.Forms.Button();
            this.btnImageChange = new System.Windows.Forms.Button();
            this.lblGamePath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTags = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.pbGameImage = new System.Windows.Forms.PictureBox();
            this.lblErrors = new System.Windows.Forms.Label();
            this.llblChangeSearch = new System.Windows.Forms.LinkLabel();
            this.btnSearchForGames = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.pbUserProfileImage = new System.Windows.Forms.PictureBox();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGameDisplay = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSearchingStatus
            // 
            this.lblSearchingStatus.AutoSize = true;
            this.lblSearchingStatus.Location = new System.Drawing.Point(82, 21);
            this.lblSearchingStatus.Name = "lblSearchingStatus";
            this.lblSearchingStatus.Size = new System.Drawing.Size(14, 13);
            this.lblSearchingStatus.TabIndex = 22;
            this.lblSearchingStatus.Text = "X";
            this.lblSearchingStatus.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(893, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTagsSave);
            this.panel1.Controls.Add(this.btnDiscSave);
            this.panel1.Controls.Add(this.btnTagEdit);
            this.panel1.Controls.Add(this.btnDescEdit);
            this.panel1.Controls.Add(this.btnSaveTitleChange);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Controls.Add(this.btnEditGameName);
            this.panel1.Controls.Add(this.btnImageChange);
            this.panel1.Controls.Add(this.lblGamePath);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbTags);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.pbGameImage);
            this.panel1.Location = new System.Drawing.Point(159, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 407);
            this.panel1.TabIndex = 20;
            // 
            // btnTagsSave
            // 
            this.btnTagsSave.Location = new System.Drawing.Point(506, 340);
            this.btnTagsSave.Name = "btnTagsSave";
            this.btnTagsSave.Size = new System.Drawing.Size(48, 23);
            this.btnTagsSave.TabIndex = 13;
            this.btnTagsSave.Text = "Save";
            this.btnTagsSave.UseVisualStyleBackColor = true;
            this.btnTagsSave.Visible = false;
            // 
            // btnDiscSave
            // 
            this.btnDiscSave.Location = new System.Drawing.Point(506, 205);
            this.btnDiscSave.Name = "btnDiscSave";
            this.btnDiscSave.Size = new System.Drawing.Size(48, 23);
            this.btnDiscSave.TabIndex = 12;
            this.btnDiscSave.Text = "Save";
            this.btnDiscSave.UseVisualStyleBackColor = true;
            this.btnDiscSave.Visible = false;
            // 
            // btnTagEdit
            // 
            this.btnTagEdit.Location = new System.Drawing.Point(506, 369);
            this.btnTagEdit.Name = "btnTagEdit";
            this.btnTagEdit.Size = new System.Drawing.Size(77, 23);
            this.btnTagEdit.TabIndex = 11;
            this.btnTagEdit.Text = "Edit Tags";
            this.btnTagEdit.UseVisualStyleBackColor = true;
            // 
            // btnDescEdit
            // 
            this.btnDescEdit.Location = new System.Drawing.Point(506, 233);
            this.btnDescEdit.Name = "btnDescEdit";
            this.btnDescEdit.Size = new System.Drawing.Size(87, 23);
            this.btnDescEdit.TabIndex = 10;
            this.btnDescEdit.Text = "Edit Description";
            this.btnDescEdit.UseVisualStyleBackColor = true;
            // 
            // btnSaveTitleChange
            // 
            this.btnSaveTitleChange.Location = new System.Drawing.Point(454, 4);
            this.btnSaveTitleChange.Name = "btnSaveTitleChange";
            this.btnSaveTitleChange.Size = new System.Drawing.Size(48, 23);
            this.btnSaveTitleChange.TabIndex = 9;
            this.btnSaveTitleChange.Text = "Save";
            this.btnSaveTitleChange.UseVisualStyleBackColor = true;
            this.btnSaveTitleChange.Visible = false;
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.Location = new System.Drawing.Point(234, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(258, 24);
            this.tbTitle.TabIndex = 8;
            this.tbTitle.Text = "Name";
            // 
            // btnEditGameName
            // 
            this.btnEditGameName.Location = new System.Drawing.Point(506, 4);
            this.btnEditGameName.Name = "btnEditGameName";
            this.btnEditGameName.Size = new System.Drawing.Size(56, 23);
            this.btnEditGameName.TabIndex = 7;
            this.btnEditGameName.Text = "Edit";
            this.btnEditGameName.UseVisualStyleBackColor = true;
            // 
            // btnImageChange
            // 
            this.btnImageChange.Location = new System.Drawing.Point(4, 284);
            this.btnImageChange.Name = "btnImageChange";
            this.btnImageChange.Size = new System.Drawing.Size(99, 23);
            this.btnImageChange.TabIndex = 6;
            this.btnImageChange.Text = "Change Image";
            this.btnImageChange.UseVisualStyleBackColor = true;
            // 
            // lblGamePath
            // 
            this.lblGamePath.AutoSize = true;
            this.lblGamePath.Location = new System.Drawing.Point(503, 33);
            this.lblGamePath.Name = "lblGamePath";
            this.lblGamePath.Size = new System.Drawing.Size(57, 13);
            this.lblGamePath.TabIndex = 5;
            this.lblGamePath.Text = "GamePath";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tags:";
            // 
            // tbTags
            // 
            this.tbTags.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTags.Location = new System.Drawing.Point(234, 281);
            this.tbTags.Multiline = true;
            this.tbTags.Name = "tbTags";
            this.tbTags.ReadOnly = true;
            this.tbTags.Size = new System.Drawing.Size(258, 112);
            this.tbTags.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Location = new System.Drawing.Point(234, 33);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(264, 224);
            this.tbDescription.TabIndex = 2;
            // 
            // pbGameImage
            // 
            this.pbGameImage.Location = new System.Drawing.Point(4, 4);
            this.pbGameImage.Name = "pbGameImage";
            this.pbGameImage.Size = new System.Drawing.Size(204, 274);
            this.pbGameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGameImage.TabIndex = 1;
            this.pbGameImage.TabStop = false;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrors.Location = new System.Drawing.Point(4, 537);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(14, 13);
            this.lblErrors.TabIndex = 19;
            this.lblErrors.Text = "X";
            this.lblErrors.Visible = false;
            // 
            // llblChangeSearch
            // 
            this.llblChangeSearch.AutoSize = true;
            this.llblChangeSearch.Location = new System.Drawing.Point(3, 46);
            this.llblChangeSearch.Name = "llblChangeSearch";
            this.llblChangeSearch.Size = new System.Drawing.Size(125, 13);
            this.llblChangeSearch.TabIndex = 18;
            this.llblChangeSearch.TabStop = true;
            this.llblChangeSearch.Text = "Change Search Location";
            // 
            // btnSearchForGames
            // 
            this.btnSearchForGames.Location = new System.Drawing.Point(0, 16);
            this.btnSearchForGames.Name = "btnSearchForGames";
            this.btnSearchForGames.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForGames.TabIndex = 17;
            this.btnSearchForGames.Text = "Search";
            this.btnSearchForGames.UseVisualStyleBackColor = true;
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(75, 502);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(65, 23);
            this.btnAddGame.TabIndex = 16;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = true;
            // 
            // pbUserProfileImage
            // 
            this.pbUserProfileImage.Location = new System.Drawing.Point(939, 4);
            this.pbUserProfileImage.Name = "pbUserProfileImage";
            this.pbUserProfileImage.Size = new System.Drawing.Size(47, 42);
            this.pbUserProfileImage.TabIndex = 15;
            this.pbUserProfileImage.TabStop = false;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(853, 4);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(80, 13);
            this.lblWelcomeMessage.TabIndex = 14;
            this.lblWelcomeMessage.Text = "Welcome, User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Games";
            // 
            // lbGameDisplay
            // 
            this.lbGameDisplay.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbGameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGameDisplay.ForeColor = System.Drawing.Color.Black;
            this.lbGameDisplay.FormattingEnabled = true;
            this.lbGameDisplay.ItemHeight = 20;
            this.lbGameDisplay.Location = new System.Drawing.Point(0, 89);
            this.lbGameDisplay.Name = "lbGameDisplay";
            this.lbGameDisplay.Size = new System.Drawing.Size(153, 404);
            this.lbGameDisplay.TabIndex = 12;
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 554);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblSearchingStatus);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.llblChangeSearch);
            this.Controls.Add(this.btnSearchForGames);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.pbUserProfileImage);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGameDisplay);
            this.Name = "Default";
            this.Text = "MySteam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSearchingStatus;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTagsSave;
        private System.Windows.Forms.Button btnDiscSave;
        private System.Windows.Forms.Button btnTagEdit;
        private System.Windows.Forms.Button btnDescEdit;
        private System.Windows.Forms.Button btnSaveTitleChange;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Button btnEditGameName;
        private System.Windows.Forms.Button btnImageChange;
        private System.Windows.Forms.Label lblGamePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTags;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.PictureBox pbGameImage;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.LinkLabel llblChangeSearch;
        private System.Windows.Forms.Button btnSearchForGames;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.PictureBox pbUserProfileImage;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbGameDisplay;
    }
}

