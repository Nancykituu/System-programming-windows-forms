namespace systemprogramming
{
    partial class ProcessControlForm
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
            LbLProcessHeading = new Label();
            btnStartProcess = new Button();
            btnStopProcess = new Button();
            btnListProcess = new Button();
            btnBack = new Button();
            LstProcesses = new ListBox();
            SuspendLayout();
            // 
            // LbLProcessHeading
            // 
            LbLProcessHeading.AutoSize = true;
            LbLProcessHeading.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbLProcessHeading.Location = new Point(135, 9);
            LbLProcessHeading.Name = "LbLProcessHeading";
            LbLProcessHeading.Size = new Size(220, 24);
            LbLProcessHeading.TabIndex = 0;
            LbLProcessHeading.Text = "PROCESS CONTROL";
            // 
            // btnStartProcess
            // 
            btnStartProcess.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartProcess.Location = new Point(135, 62);
            btnStartProcess.Name = "btnStartProcess";
            btnStartProcess.Size = new Size(180, 40);
            btnStartProcess.TabIndex = 1;
            btnStartProcess.Text = "START PROCESS";
            btnStartProcess.UseVisualStyleBackColor = true;
            btnStartProcess.Click += btnStartProcess_Click;
            // 
            // btnStopProcess
            // 
            btnStopProcess.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStopProcess.Location = new Point(135, 128);
            btnStopProcess.Name = "btnStopProcess";
            btnStopProcess.Size = new Size(180, 40);
            btnStopProcess.TabIndex = 2;
            btnStopProcess.Text = "STOP PROCESS";
            btnStopProcess.UseVisualStyleBackColor = true;
            btnStopProcess.Click += btnStopProcess_Click;
            // 
            // btnListProcess
            // 
            btnListProcess.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListProcess.Location = new Point(135, 195);
            btnListProcess.Name = "btnListProcess";
            btnListProcess.Size = new Size(180, 40);
            btnListProcess.TabIndex = 3;
            btnListProcess.Text = "LIST PROCESSES";
            btnListProcess.UseVisualStyleBackColor = true;
            btnListProcess.Click += btnListProcess_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(135, 281);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "BACK TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // LstProcesses
            // 
            LstProcesses.FormattingEnabled = true;
            LstProcesses.Location = new Point(468, 56);
            LstProcesses.Name = "LstProcesses";
            LstProcesses.Size = new Size(250, 169);
            LstProcesses.Sorted = true;
            LstProcesses.TabIndex = 5;
            // 
            // ProcessControlForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
            Controls.Add(LstProcesses);
            Controls.Add(btnBack);
            Controls.Add(btnListProcess);
            Controls.Add(btnStopProcess);
            Controls.Add(btnStartProcess);
            Controls.Add(LbLProcessHeading);
            Name = "ProcessControlForm";
            Text = "PROCESS CONTROL MANAGEMENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LbLProcessHeading;
        private Button button1;
        private Button button2;
        private Button btnListProcess;
        private Button btnBack;
        private Button btnStartProcess;
        private Button btnStopProcess;
        private ListBox LstProcesses;
    }
}