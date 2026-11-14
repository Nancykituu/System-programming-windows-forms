namespace systemprogramming
{
    partial class MemoryManagementForm
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
            numMemorySize = new NumericUpDown();
            btnAllocateMemory = new Button();
            btnReleaseMemory = new Button();
            btnViewMemory = new Button();
            btnBack = new Button();
            lstMemoryStatus = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numMemorySize).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(93, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(304, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "MEMORY MANAGEMENT";
            lblHeading.Click += this.lblHeading_Click;
            // 
            // numMemorySize
            // 
            numMemorySize.Location = new Point(489, 77);
            numMemorySize.Maximum = new decimal(new int[] { 1024, 0, 0, 0 });
            numMemorySize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMemorySize.Name = "numMemorySize";
            numMemorySize.Size = new Size(155, 23);
            numMemorySize.TabIndex = 1;
            numMemorySize.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numMemorySize.ValueChanged += this.numMemorySize_ValueChanged;
            // 
            // btnAllocateMemory
            // 
            btnAllocateMemory.Location = new Point(93, 75);
            btnAllocateMemory.Name = "btnAllocateMemory";
            btnAllocateMemory.Size = new Size(177, 23);
            btnAllocateMemory.TabIndex = 2;
            btnAllocateMemory.Text = "ALLOCATE MEMORY";
            btnAllocateMemory.UseVisualStyleBackColor = true;
            btnAllocateMemory.Click += btnAllocateMemory_Click;
            // 
            // btnReleaseMemory
            // 
            btnReleaseMemory.Location = new Point(93, 148);
            btnReleaseMemory.Name = "btnReleaseMemory";
            btnReleaseMemory.Size = new Size(177, 23);
            btnReleaseMemory.TabIndex = 3;
            btnReleaseMemory.Text = "RELEASE MEMORY";
            btnReleaseMemory.UseVisualStyleBackColor = true;
            btnReleaseMemory.Click += btnReleaseMemory_Click;
            // 
            // btnViewMemory
            // 
            btnViewMemory.Location = new Point(93, 225);
            btnViewMemory.Name = "btnViewMemory";
            btnViewMemory.Size = new Size(177, 23);
            btnViewMemory.TabIndex = 4;
            btnViewMemory.Text = "VIEW MEMORY USAGE";
            btnViewMemory.UseVisualStyleBackColor = true;
            btnViewMemory.Click += btnViewMemory_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(93, 308);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(177, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "BACK TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lstMemoryStatus
            // 
            lstMemoryStatus.FormattingEnabled = true;
            lstMemoryStatus.Location = new Point(489, 179);
            lstMemoryStatus.Name = "lstMemoryStatus";
            lstMemoryStatus.Size = new Size(120, 94);
            lstMemoryStatus.TabIndex = 6;
            lstMemoryStatus.SelectedIndexChanged += lstMemoryStatus_SelectedIndexChanged;
            // 
            // MemoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 511);
            Controls.Add(lstMemoryStatus);
            Controls.Add(btnBack);
            Controls.Add(btnViewMemory);
            Controls.Add(btnReleaseMemory);
            Controls.Add(btnAllocateMemory);
            Controls.Add(numMemorySize);
            Controls.Add(lblHeading);
            Name = "MemoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MEMORY MANAGEMENT";
            ((System.ComponentModel.ISupportInitialize)numMemorySize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private NumericUpDown numMemorySize;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btnBack;
        private Button btnViewMemory;
        private Button btnReleaseMemory;
        private Button btnAllocateMemory;
        private ListBox lstMemoryStatus;
    }
}