using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace systemprogramming
{
    public partial class MemoryManagementForm : Form
    {
        private int allocatedMemory = 0;
        private const int TotalMemory = 1024;
        public MemoryManagementForm()
        {
            InitializeComponent();
        }
        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void numMemorySize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAllocateMemory_Click(object sender, EventArgs e)
        {
            int amount = (int)numMemorySize.Value;

            if (allocatedMemory + amount > TotalMemory)
            {
                MessageBox.Show("Not enough memory available.");
                return;
            }

            allocatedMemory += amount;

            lstMemoryStatus.Items.Add("Allocated " + amount +
                " MB. Total used: " + allocatedMemory + " MB");
        }

        private void btnReleaseMemory_Click(object sender, EventArgs e)
        {
            int amount = (int)numMemorySize.Value;

            if (amount > allocatedMemory)
            {
                MessageBox.Show("Cannot release more memory than allocated.");
                return;
            }

            allocatedMemory -= amount;

            lstMemoryStatus.Items.Add("Released " + amount +
                " MB. Total used: " + allocatedMemory + " MB");
        }
        private void btnViewMemory_Click(object sender, EventArgs e)
        {
            int freeMemory = TotalMemory - allocatedMemory;

            MessageBox.Show(
                "Total Memory: " + TotalMemory + " MB\n" +
                "Used Memory: " + allocatedMemory + " MB\n" +
                "Free Memory: " + freeMemory + " MB",
                "Memory Usage"
            );
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstMemoryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
