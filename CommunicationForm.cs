using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace systemprogramming
{
    public partial class CommunicationForm : Form
    {
        public CommunicationForm()
        {
            InitializeComponent();
        }

        private void CommunicationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSendMessange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMessange.Text))
            {
                MessageBox.Show("Please enter a message.");
                return;
            }

            lstMessange.Items.Add("Sent: " + txtMessange.Text);
            txtMessange.Clear();
        }

        private void btnReceiveMessange_Click(object sender, EventArgs e)
        {
            lstMessange.Items.Add("Received: Hello! Message received successfully.");
        }

        private void btnClearMessange_Click(object sender, EventArgs e)
        {
            lstMessange.Items.Clear();
            txtMessange.Clear();

            MessageBox.Show("All messages cleared successfully!");
        }

            private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
