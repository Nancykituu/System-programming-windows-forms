namespace systemprogramming
{
    partial class InformationForm
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
            txtInformation = new TextBox();
            btnViewInformation = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.Location = new Point(151, 23);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(464, 32);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "SYSTEM INFORMATION MANAGEMENT";
            // 
            // txtInformation
            // 
            txtInformation.Location = new Point(21, 58);
            txtInformation.Multiline = true;
            txtInformation.Name = "txtInformation";
            txtInformation.ReadOnly = true;
            txtInformation.ScrollBars = ScrollBars.Vertical;
            txtInformation.Size = new Size(600, 250);
            txtInformation.TabIndex = 1;
            // 
            // btnViewInformation
            // 
            btnViewInformation.Location = new Point(161, 327);
            btnViewInformation.Name = "btnViewInformation";
            btnViewInformation.Size = new Size(200, 45);
            btnViewInformation.TabIndex = 2;
            btnViewInformation.Text = "VIEW SYSTEM INFORMATION";
            btnViewInformation.UseVisualStyleBackColor = true;
            btnViewInformation.Click += btnViewInformation_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(161, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 45);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK TO MENU";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // InformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(834, 511);
            Controls.Add(btnBack);
            Controls.Add(btnViewInformation);
            Controls.Add(txtInformation);
            Controls.Add(lblHeading);
            Name = "InformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information Management";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private TextBox txtInformation;
        private Button btnViewInformation;
        private Button btnBack;
    }
}