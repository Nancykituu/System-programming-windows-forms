namespace systemprogramming
{
    partial class CommunicationForm
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
            txtMessange = new TextBox();
            lstMessange = new ListBox();
            btnSendMessange = new Button();
            btnReceiveMessange = new Button();
            btnClearMessange = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(119, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(408, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "COMMUNICATION MANAGEMENT";
            // 
            // txtMessange
            // 
            txtMessange.Location = new Point(422, 44);
            txtMessange.Name = "txtMessange";
            txtMessange.Size = new Size(380, 23);
            txtMessange.TabIndex = 1;
            txtMessange.Text = "Leave blank";
            // 
            // lstMessange
            // 
            lstMessange.FormattingEnabled = true;
            lstMessange.Location = new Point(422, 86);
            lstMessange.Name = "lstMessange";
            lstMessange.Size = new Size(400, 199);
            lstMessange.TabIndex = 2;
            // 
            // btnSendMessange
            // 
            btnSendMessange.Location = new Point(41, 75);
            btnSendMessange.Name = "btnSendMessange";
            btnSendMessange.Size = new Size(130, 23);
            btnSendMessange.TabIndex = 3;
            btnSendMessange.Text = "SEND MESSANGE";
            btnSendMessange.UseVisualStyleBackColor = true;
            btnSendMessange.Click += btnSendMessange_Click;
            // 
            // btnReceiveMessange
            // 
            btnReceiveMessange.Location = new Point(41, 157);
            btnReceiveMessange.Name = "btnReceiveMessange";
            btnReceiveMessange.Size = new Size(130, 23);
            btnReceiveMessange.TabIndex = 4;
            btnReceiveMessange.Text = "RECEIVE MESSANGE";
            btnReceiveMessange.UseVisualStyleBackColor = true;
            btnReceiveMessange.Click += btnReceiveMessange_Click;
            // 
            // btnClearMessange
            // 
            btnClearMessange.Location = new Point(41, 233);
            btnClearMessange.Name = "btnClearMessange";
            btnClearMessange.Size = new Size(130, 23);
            btnClearMessange.TabIndex = 5;
            btnClearMessange.Text = "CLEAR MESSANGE";
            btnClearMessange.UseVisualStyleBackColor = true;
            btnClearMessange.Click += btnClearMessange_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(41, 316);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 23);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CommunicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 511);
            Controls.Add(btnBack);
            Controls.Add(btnClearMessange);
            Controls.Add(btnReceiveMessange);
            Controls.Add(btnSendMessange);
            Controls.Add(lstMessange);
            Controls.Add(txtMessange);
            Controls.Add(lblHeading);
            Name = "CommunicationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "COMMUNICATION MANAGEMENT";
            Load += CommunicationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private TextBox txtMessange;
        private ListBox lstMessange;
        private Button button1;
        private Button btnReceiveMessange;
        private Button btnClearMessange;
        private Button btnBack;
        private Button btnSendMessange;
    }
}