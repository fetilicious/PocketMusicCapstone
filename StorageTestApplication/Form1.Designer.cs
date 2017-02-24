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
            // DocumentDBTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 390);
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
    }
}

