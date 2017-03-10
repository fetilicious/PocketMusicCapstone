namespace StorageTestApplication
{
    partial class DocumentDBTestForm
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
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RandomGuidButton = new System.Windows.Forms.Button();
            this.deleteTestFileButton = new System.Windows.Forms.Button();
            this.localPathLabel = new System.Windows.Forms.Label();
            this.localPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.blobNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileIdTextBox = new System.Windows.Forms.TextBox();
            this.uploadTestFileButton = new System.Windows.Forms.Button();
            this.createBlobClientButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.upsertButton = new System.Windows.Forms.Button();
            this.createDatabaseButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.getAllMusicButton = new System.Windows.Forms.Button();
            this.getMusicButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.musicIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteMusicButton = new System.Windows.Forms.Button();
            this.upsertRandomMusicButton = new System.Windows.Forms.Button();
            this.createMusicManagerButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.createPlaylistManagerButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 344);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(642, 96);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(642, 313);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RandomGuidButton);
            this.tabPage1.Controls.Add(this.deleteTestFileButton);
            this.tabPage1.Controls.Add(this.localPathLabel);
            this.tabPage1.Controls.Add(this.localPathTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.blobNameTextBox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.fileIdTextBox);
            this.tabPage1.Controls.Add(this.uploadTestFileButton);
            this.tabPage1.Controls.Add(this.createBlobClientButton);
            this.tabPage1.Controls.Add(this.getButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(this.deleteButton);
            this.tabPage1.Controls.Add(this.upsertButton);
            this.tabPage1.Controls.Add(this.createDatabaseButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DocumentDB";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RandomGuidButton
            // 
            this.RandomGuidButton.Location = new System.Drawing.Point(526, 202);
            this.RandomGuidButton.Name = "RandomGuidButton";
            this.RandomGuidButton.Size = new System.Drawing.Size(92, 23);
            this.RandomGuidButton.TabIndex = 33;
            this.RandomGuidButton.Text = "Random Guid";
            this.RandomGuidButton.UseVisualStyleBackColor = true;
            this.RandomGuidButton.Click += new System.EventHandler(this.RandomGuidButton_Click);
            // 
            // deleteTestFileButton
            // 
            this.deleteTestFileButton.Location = new System.Drawing.Point(285, 231);
            this.deleteTestFileButton.Name = "deleteTestFileButton";
            this.deleteTestFileButton.Size = new System.Drawing.Size(169, 23);
            this.deleteTestFileButton.TabIndex = 32;
            this.deleteTestFileButton.Text = "Delete Blob";
            this.deleteTestFileButton.UseVisualStyleBackColor = true;
            this.deleteTestFileButton.Click += new System.EventHandler(this.deleteTestFileButton_Click);
            // 
            // localPathLabel
            // 
            this.localPathLabel.AutoSize = true;
            this.localPathLabel.Location = new System.Drawing.Point(224, 179);
            this.localPathLabel.Name = "localPathLabel";
            this.localPathLabel.Size = new System.Drawing.Size(53, 13);
            this.localPathLabel.TabIndex = 31;
            this.localPathLabel.Text = "local path";
            // 
            // localPathTextBox
            // 
            this.localPathTextBox.Location = new System.Drawing.Point(285, 176);
            this.localPathTextBox.Name = "localPathTextBox";
            this.localPathTextBox.Size = new System.Drawing.Size(333, 20);
            this.localPathTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "blobName";
            // 
            // blobNameTextBox
            // 
            this.blobNameTextBox.Location = new System.Drawing.Point(285, 150);
            this.blobNameTextBox.Name = "blobNameTextBox";
            this.blobNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.blobNameTextBox.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "fileId";
            // 
            // fileIdTextBox
            // 
            this.fileIdTextBox.Location = new System.Drawing.Point(285, 124);
            this.fileIdTextBox.Name = "fileIdTextBox";
            this.fileIdTextBox.Size = new System.Drawing.Size(333, 20);
            this.fileIdTextBox.TabIndex = 26;
            // 
            // uploadTestFileButton
            // 
            this.uploadTestFileButton.Location = new System.Drawing.Point(285, 202);
            this.uploadTestFileButton.Name = "uploadTestFileButton";
            this.uploadTestFileButton.Size = new System.Drawing.Size(169, 23);
            this.uploadTestFileButton.TabIndex = 25;
            this.uploadTestFileButton.Text = "Upload Blob";
            this.uploadTestFileButton.UseVisualStyleBackColor = true;
            this.uploadTestFileButton.Click += new System.EventHandler(this.uploadTestFileButton_Click);
            // 
            // createBlobClientButton
            // 
            this.createBlobClientButton.Location = new System.Drawing.Point(22, 121);
            this.createBlobClientButton.Name = "createBlobClientButton";
            this.createBlobClientButton.Size = new System.Drawing.Size(169, 23);
            this.createBlobClientButton.TabIndex = 24;
            this.createBlobClientButton.Text = "Create Blob Client";
            this.createBlobClientButton.UseVisualStyleBackColor = true;
            this.createBlobClientButton.Click += new System.EventHandler(this.createBlobClientButton_Click);
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(285, 43);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(158, 23);
            this.getButton.TabIndex = 23;
            this.getButton.Text = "Get Record";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Id";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(285, 14);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(333, 20);
            this.idTextBox.TabIndex = 21;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(462, 43);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(156, 23);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete Record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // upsertButton
            // 
            this.upsertButton.Location = new System.Drawing.Point(19, 43);
            this.upsertButton.Name = "upsertButton";
            this.upsertButton.Size = new System.Drawing.Size(169, 23);
            this.upsertButton.TabIndex = 19;
            this.upsertButton.Text = "Upsert Random Record";
            this.upsertButton.UseVisualStyleBackColor = true;
            this.upsertButton.Click += new System.EventHandler(this.upsertButton_Click);
            // 
            // createDatabaseButton
            // 
            this.createDatabaseButton.Location = new System.Drawing.Point(19, 14);
            this.createDatabaseButton.Name = "createDatabaseButton";
            this.createDatabaseButton.Size = new System.Drawing.Size(169, 23);
            this.createDatabaseButton.TabIndex = 18;
            this.createDatabaseButton.Text = "Create Test Database";
            this.createDatabaseButton.UseVisualStyleBackColor = true;
            this.createDatabaseButton.Click += new System.EventHandler(this.createDatabaseButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.userNameTextBox);
            this.tabPage2.Controls.Add(this.getAllMusicButton);
            this.tabPage2.Controls.Add(this.getMusicButton);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.musicIdTextBox);
            this.tabPage2.Controls.Add(this.deleteMusicButton);
            this.tabPage2.Controls.Add(this.upsertRandomMusicButton);
            this.tabPage2.Controls.Add(this.createMusicManagerButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(634, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MusicManager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "UserName";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(283, 108);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.userNameTextBox.TabIndex = 29;
            // 
            // getAllMusicButton
            // 
            this.getAllMusicButton.Location = new System.Drawing.Point(283, 134);
            this.getAllMusicButton.Name = "getAllMusicButton";
            this.getAllMusicButton.Size = new System.Drawing.Size(169, 23);
            this.getAllMusicButton.TabIndex = 28;
            this.getAllMusicButton.Text = "Get All Music";
            this.getAllMusicButton.UseVisualStyleBackColor = true;
            this.getAllMusicButton.Click += new System.EventHandler(this.getAllMusicButton_Click);
            // 
            // getMusicButton
            // 
            this.getMusicButton.Location = new System.Drawing.Point(283, 38);
            this.getMusicButton.Name = "getMusicButton";
            this.getMusicButton.Size = new System.Drawing.Size(158, 23);
            this.getMusicButton.TabIndex = 27;
            this.getMusicButton.Text = "Get Music";
            this.getMusicButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Id";
            // 
            // musicIdTextBox
            // 
            this.musicIdTextBox.Location = new System.Drawing.Point(283, 9);
            this.musicIdTextBox.Name = "musicIdTextBox";
            this.musicIdTextBox.Size = new System.Drawing.Size(333, 20);
            this.musicIdTextBox.TabIndex = 25;
            // 
            // deleteMusicButton
            // 
            this.deleteMusicButton.Location = new System.Drawing.Point(460, 38);
            this.deleteMusicButton.Name = "deleteMusicButton";
            this.deleteMusicButton.Size = new System.Drawing.Size(156, 23);
            this.deleteMusicButton.TabIndex = 24;
            this.deleteMusicButton.Text = "Delete Music";
            this.deleteMusicButton.UseVisualStyleBackColor = true;
            this.deleteMusicButton.Click += new System.EventHandler(this.deleteMusicButton_Click);
            // 
            // upsertRandomMusicButton
            // 
            this.upsertRandomMusicButton.Location = new System.Drawing.Point(6, 35);
            this.upsertRandomMusicButton.Name = "upsertRandomMusicButton";
            this.upsertRandomMusicButton.Size = new System.Drawing.Size(169, 23);
            this.upsertRandomMusicButton.TabIndex = 20;
            this.upsertRandomMusicButton.Text = "Upsert Random Music";
            this.upsertRandomMusicButton.UseVisualStyleBackColor = true;
            this.upsertRandomMusicButton.Click += new System.EventHandler(this.upsertRandomMusicButton_Click);
            // 
            // createMusicManagerButton
            // 
            this.createMusicManagerButton.Location = new System.Drawing.Point(6, 6);
            this.createMusicManagerButton.Name = "createMusicManagerButton";
            this.createMusicManagerButton.Size = new System.Drawing.Size(169, 23);
            this.createMusicManagerButton.TabIndex = 19;
            this.createMusicManagerButton.Text = "Create Manager";
            this.createMusicManagerButton.UseVisualStyleBackColor = true;
            this.createMusicManagerButton.Click += new System.EventHandler(this.createMusicManagerButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.createPlaylistManagerButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(634, 287);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PlaylistManager";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // createPlaylistManagerButton
            // 
            this.createPlaylistManagerButton.Location = new System.Drawing.Point(18, 17);
            this.createPlaylistManagerButton.Name = "createPlaylistManagerButton";
            this.createPlaylistManagerButton.Size = new System.Drawing.Size(169, 23);
            this.createPlaylistManagerButton.TabIndex = 20;
            this.createPlaylistManagerButton.Text = "Create Manager";
            this.createPlaylistManagerButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "User Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Create Manager";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(333, 20);
            this.textBox2.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Playlist Id";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(286, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(333, 20);
            this.textBox3.TabIndex = 31;
            // 
            // DocumentDBTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 452);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultTextBox);
            this.Name = "DocumentDBTestForm";
            this.Text = "Storage Test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button RandomGuidButton;
        private System.Windows.Forms.Button deleteTestFileButton;
        private System.Windows.Forms.Label localPathLabel;
        private System.Windows.Forms.TextBox localPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox blobNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fileIdTextBox;
        private System.Windows.Forms.Button uploadTestFileButton;
        private System.Windows.Forms.Button createBlobClientButton;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button upsertButton;
        private System.Windows.Forms.Button createDatabaseButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button getAllMusicButton;
        private System.Windows.Forms.Button getMusicButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox musicIdTextBox;
        private System.Windows.Forms.Button deleteMusicButton;
        private System.Windows.Forms.Button upsertRandomMusicButton;
        private System.Windows.Forms.Button createMusicManagerButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createPlaylistManagerButton;
    }
}

