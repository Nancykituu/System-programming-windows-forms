using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace systemprogramming
{
    public partial class FileManagementForm : Form
    {
        private string filePath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
    "SystemProgrammingFiles"
);
        public FileManagementForm()
        {
            InitializeComponent();
            Directory.CreateDirectory(filePath);
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            if (Path.GetFileName(fileName) != fileName)
            {
                MessageBox.Show("Enter a file name only, not a folder path.");
                return;
            }

            string fullPath = Path.Combine(filePath, fileName);

            if (File.Exists(fullPath))
            {
                MessageBox.Show("File already exists.");
                return;
            }

            File.Create(fullPath).Close();

            lblStatus.Text = "File created successfully!";
            MessageBox.Show("File created successfully!");
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            if (Path.GetFileName(fileName) != fileName)
            {
                MessageBox.Show("Enter a file name only.");
                return;
            }

            string fullPath = Path.Combine(filePath, fileName);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("File does not exist. Create it first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFileContent.Text))
            {
                MessageBox.Show("Please enter file content.");
                return;
            }

            File.WriteAllText(fullPath, txtFileContent.Text);

            lblStatus.Text = "Content written successfully!";
            MessageBox.Show("Content written successfully!");
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            if (Path.GetFileName(fileName) != fileName)
            {
                MessageBox.Show("Enter a file name only.");
                return;
            }

            string fullPath = Path.Combine(filePath, fileName);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            txtFileContent.Text = File.ReadAllText(fullPath);

            lblStatus.Text = "File read successfully!";
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text.Trim();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            if (Path.GetFileName(fileName) != fileName)
            {
                MessageBox.Show("Enter a file name only.");
                return;
            }

            string fullPath = Path.Combine(filePath, fileName);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("File does not exist.");
                return;
            }

            File.Delete(fullPath);

            txtFileContent.Clear();
            lblStatus.Text = "File deleted successfully!";

            MessageBox.Show("File deleted successfully!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
