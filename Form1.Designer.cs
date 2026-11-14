namespace systemprogramming
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IbIHeading = new Label();
            grpMainMenu = new GroupBox();
            btnInformation = new Button();
            btnFile = new Button();
            btnMemory = new Button();
            btnCommunication = new Button();
            btnProcess = new Button();
            grpMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // IbIHeading
            // 
            IbIHeading.AutoSize = true;
            IbIHeading.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbIHeading.Location = new Point(201, 22);
            IbIHeading.Name = "IbIHeading";
            IbIHeading.Size = new Size(372, 18);
            IbIHeading.TabIndex = 0;
            IbIHeading.Text = "SYSTEM PROGRAMMING MANAGEMENT SYSTEM";
            IbIHeading.Click += label1_Click;
            // 
            // grpMainMenu
            // 
            grpMainMenu.Controls.Add(btnInformation);
            grpMainMenu.Controls.Add(btnFile);
            grpMainMenu.Controls.Add(btnMemory);
            grpMainMenu.Controls.Add(btnCommunication);
            grpMainMenu.Controls.Add(btnProcess);
            grpMainMenu.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMainMenu.Location = new Point(176, 82);
            grpMainMenu.Name = "grpMainMenu";
            grpMainMenu.Size = new Size(450, 400);
            grpMainMenu.TabIndex = 1;
            grpMainMenu.TabStop = false;
            grpMainMenu.Text = "MAIN MENU";
            // 
            // btnInformation
            // 
            btnInformation.Location = new Point(18, 345);
            btnInformation.Name = "btnInformation";
            btnInformation.Size = new Size(244, 45);
            btnInformation.TabIndex = 4;
            btnInformation.Text = "INFORMATION MANAGEMENT";
            btnInformation.UseVisualStyleBackColor = true;
            btnInformation.Click += btnInformation_Click;
            // 
            // btnFile
            // 
            btnFile.Location = new Point(18, 253);
            btnFile.Name = "btnFile";
            btnFile.Size = new Size(244, 45);
            btnFile.TabIndex = 3;
            btnFile.Text = "FILE MANAGEMENT";
            btnFile.UseVisualStyleBackColor = true;
            btnFile.Click += btnFile_Click;
            // 
            // btnMemory
            // 
            btnMemory.Location = new Point(18, 168);
            btnMemory.Name = "btnMemory";
            btnMemory.Size = new Size(244, 45);
            btnMemory.TabIndex = 2;
            btnMemory.Text = "MEMORY MANAGEMENT";
            btnMemory.UseVisualStyleBackColor = true;
            btnMemory.Click += button3_Click;
            // 
            // btnCommunication
            // 
            btnCommunication.Location = new Point(18, 103);
            btnCommunication.Name = "btnCommunication";
            btnCommunication.Size = new Size(244, 45);
            btnCommunication.TabIndex = 1;
            btnCommunication.Text = "COMMUNICATION";
            btnCommunication.UseVisualStyleBackColor = true;
            btnCommunication.Click += btnCommunication_Click;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(18, 37);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(244, 45);
            btnProcess.TabIndex = 0;
            btnProcess.Text = "PROCESS CONTROL";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(884, 561);
            Controls.Add(grpMainMenu);
            Controls.Add(IbIHeading);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "system programming management system";
            Load += Form1_Load;
            grpMainMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbIHeading;
        private GroupBox grpMainMenu;
        private Button btnInformation;
        private Button button4;
        private Button button3;
        private Button btnCommunication;
        private Button btnProcess;
        private Button btnFile;
        private Button btnMemory;

    }
}
