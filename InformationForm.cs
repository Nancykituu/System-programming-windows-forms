using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace systemprogramming
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void btnViewInformation_Click(object sender, EventArgs e)
        {
            txtInformation.Text =
    "OPERATING SYSTEM: " + Environment.OSVersion + Environment.NewLine +
    "COMPUTER NAME: " + Environment.MachineName + Environment.NewLine +
    "PROCESSOR COUNT: " + Environment.ProcessorCount + Environment.NewLine +
    "64-BIT OPERATING SYSTEM: " + Environment.Is64BitOperatingSystem + Environment.NewLine +
    "CURRENT DATE AND TIME: " + DateTime.Now;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
