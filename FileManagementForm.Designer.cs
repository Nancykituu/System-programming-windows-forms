namespace systemprogramming
{
    partial class FileManagementForm
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
            lblHeading = new Label();
            btnCreateFile = new Button();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            btnDeleteFile = new Button();
            btnBack = new Button();
            txtFileName = new TextBox();
            txtFileContent = new TextBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(240, -3);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(241, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "FILE MANAGEMENT";
            // 
            // btnCreateFile
            // 
            btnCreateFile.Location = new Point(99, 68);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(131, 23);
            btnCreateFile.TabIndex = 1;
            btnCreateFile.Text = "CREATE FILE";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(99, 146);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(131, 23);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "WRITE TO FILE";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(99, 231);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(131, 23);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "READ FILE";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new Point(99, 283);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new Size(131, 23);
            btnDeleteFile.TabIndex = 4;
            btnDeleteFile.Text = "DELETE FILE";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(99, 386);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(131, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(524, 187);
            txtFileName.Name = "txtFileName";
            txtFileName.PlaceholderText = "Enter file name(if available)";
            txtFileName.Size = new Size(201, 23);
            txtFileName.TabIndex = 6;
            txtFileName.Text = "Leave blank";
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(524, 332);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ScrollBars = ScrollBars.Vertical;
            txtFileContent.Size = new Size(201, 23);
            txtFileContent.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(524, 68);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(134, 15);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "File Management Status";
            // 
            // FileManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 511);
            Controls.Add(lblStatus);
            Controls.Add(txtFileContent);
            Controls.Add(txtFileName);
            Controls.Add(btnBack);
            Controls.Add(btnDeleteFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnWriteFile);
            Controls.Add(btnCreateFile);
            Controls.Add(lblHeading);
            Name = "FileManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FILE MANAGEMENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Button btnCreateFile;
        private Button btnWriteFile;
        private Button button3;
        private Button btnDeleteFile;
        private Button btnBack;
        private TextBox txtFileName;
        private TextBox txtFileContent;
        private Label lblStatus;
        private Button btnReadFile;
    }
}