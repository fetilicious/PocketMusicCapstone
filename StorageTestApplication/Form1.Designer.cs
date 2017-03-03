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
            this.createDatabaseButton = new System.Windows.Forms.Button();
            this.upsertButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.RichTextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createBlobClientButton = new System.Windows.Forms.Button();
            this.uploadTestFileButton = new System.Windows.Forms.Button();
            this.fileIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.blobNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.localPathTextBox = new System.Windows.Forms.TextBox();
            this.localPathLabel = new System.Windows.Forms.Label();
            this.deleteTestFileButton = new System.Windows.Forms.Button();
            this.RandomGuidButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createDatabaseButton
            // 
            this.createDatabaseButton.Location = new System.Drawing.Point(12, 12);
            this.createDatabaseButton.Name = "createDatabaseButton";
            this.createDatabaseButton.Size = new System.Drawing.Size(169, 23);
            this.createDatabaseButton.TabIndex = 0;
            this.createDatabaseButton.Text = "Create Test Database";
            this.createDatabaseButton.UseVisualStyleBackColor = true;
            this.createDatabaseButton.Click += new System.EventHandler(this.createDatabaseButton_Click);
            // 
            // upsertButton
            // 
            this.upsertButton.Location = new System.Drawing.Point(12, 41);
            this.upsertButton.Name = "upsertButton";
            this.upsertButton.Size = new System.Drawing.Size(169, 23);
            this.upsertButton.TabIndex = 1;
            this.upsertButton.Text = "Upsert Random Record";
            this.upsertButton.UseVisualStyleBackColor = true;
            this.upsertButton.Click += new System.EventHandler(this.upsertButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 282);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(599, 96);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.Text = "";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(455, 41);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(156, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete Record";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(278, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(333, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(278, 41);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(158, 23);
            this.getButton.TabIndex = 6;
            this.getButton.Text = "Get Record";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // createBlobClientButton
            // 
            this.createBlobClientButton.Location = new System.Drawing.Point(15, 119);
            this.createBlobClientButton.Name = "createBlobClientButton";
            this.createBlobClientButton.Size = new System.Drawing.Size(169, 23);
            this.createBlobClientButton.TabIndex = 8;
            this.createBlobClientButton.Text = "Create Blob Client";
            this.createBlobClientButton.UseVisualStyleBackColor = true;
            this.createBlobClientButton.Click += new System.EventHandler(this.createBlobClientButton_Click);
            // 
            // uploadTestFileButton
            // 
            this.uploadTestFileButton.Location = new System.Drawing.Point(278, 200);
            this.uploadTestFileButton.Name = "uploadTestFileButton";
            this.uploadTestFileButton.Size = new System.Drawing.Size(169, 23);
            this.uploadTestFileButton.TabIndex = 9;
            this.uploadTestFileButton.Text = "Upload Blob";
            this.uploadTestFileButton.UseVisualStyleBackColor = true;
            this.uploadTestFileButton.Click += new System.EventHandler(this.uploadTestFileButton_Click);
            // 
            // fileIdTextBox
            // 
            this.fileIdTextBox.Location = new System.Drawing.Point(278, 122);
            this.fileIdTextBox.Name = "fileIdTextBox";
            this.fileIdTextBox.Size = new System.Drawing.Size(333, 20);
            this.fileIdTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "fileId";
            // 
            // blobNameTextBox
            // 
            this.blobNameTextBox.Location = new System.Drawing.Point(278, 148);
            this.blobNameTextBox.Name = "blobNameTextBox";
            this.blobNameTextBox.Size = new System.Drawing.Size(333, 20);
            this.blobNameTextBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "blobName";
            // 
            // localPathTextBox
            // 
            this.localPathTextBox.Location = new System.Drawing.Point(278, 174);
            this.localPathTextBox.Name = "localPathTextBox";
            this.localPathTextBox.Size = new System.Drawing.Size(333, 20);
            this.localPathTextBox.TabIndex = 14;
            // 
            // localPathLabel
            // 
            this.localPathLabel.AutoSize = true;
            this.localPathLabel.Location = new System.Drawing.Point(217, 177);
            this.localPathLabel.Name = "localPathLabel";
            this.localPathLabel.Size = new System.Drawing.Size(53, 13);
            this.localPathLabel.TabIndex = 15;
            this.localPathLabel.Text = "local path";
            // 
            // deleteTestFileButton
            // 
            this.deleteTestFileButton.Location = new System.Drawing.Point(278, 229);
            this.deleteTestFileButton.Name = "deleteTestFileButton";
            this.deleteTestFileButton.Size = new System.Drawing.Size(169, 23);
            this.deleteTestFileButton.TabIndex = 16;
            this.deleteTestFileButton.Text = "Delete Blob";
            this.deleteTestFileButton.UseVisualStyleBackColor = true;
            this.deleteTestFileButton.Click += new System.EventHandler(this.deleteTestFileButton_Click);
            // 
            // RandomGuidButton
            // 
            this.RandomGuidButton.Location = new System.Drawing.Point(519, 200);
            this.RandomGuidButton.Name = "RandomGuidButton";
            this.RandomGuidButton.Size = new System.Drawing.Size(92, 23);
            this.RandomGuidButton.TabIndex = 17;
            this.RandomGuidButton.Text = "Random Guid";
            this.RandomGuidButton.UseVisualStyleBackColor = true;
            this.RandomGuidButton.Click += new System.EventHandler(this.RandomGuidButton_Click);
            // 
            // DocumentDBTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 390);
            this.Controls.Add(this.RandomGuidButton);
            this.Controls.Add(this.deleteTestFileButton);
            this.Controls.Add(this.localPathLabel);
            this.Controls.Add(this.localPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blobNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileIdTextBox);
            this.Controls.Add(this.uploadTestFileButton);
            this.Controls.Add(this.createBlobClientButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.upsertButton);
            this.Controls.Add(this.createDatabaseButton);
            this.Name = "DocumentDBTestForm";
            this.Text = "DocumentDB Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createDatabaseButton;
        private System.Windows.Forms.Button upsertButton;
        private System.Windows.Forms.RichTextBox resultTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createBlobClientButton;
        private System.Windows.Forms.Button uploadTestFileButton;
        private System.Windows.Forms.TextBox fileIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox blobNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox localPathTextBox;
        private System.Windows.Forms.Label localPathLabel;
        private System.Windows.Forms.Button deleteTestFileButton;
        private System.Windows.Forms.Button RandomGuidButton;
    }
}

