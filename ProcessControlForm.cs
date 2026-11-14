using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace systemprogramming
{
    public partial class ProcessControlForm : Form
    {
        private System.Diagnostics.Process? currentProcess;
        public ProcessControlForm()
        {
            InitializeComponent();
        }
        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("START BUTTON IS WORKING"); try
            {
                currentProcess = new System.Diagnostics.Process();

                currentProcess.StartInfo.FileName = "notepad.exe";
                currentProcess.Start();

                MessageBox.Show("Process started successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStopProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProcess != null && !currentProcess.HasExited)
                {
                    currentProcess.Kill();
                    currentProcess = null;

                    MessageBox.Show("Process stopped successfully!");
                }
                else
                {
                    MessageBox.Show("No running process found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListProcess_Click(object sender, EventArgs e)
        {
            LstProcesses.Items.Clear();

            foreach (var process in System.Diagnostics.Process.GetProcesses())
            {
                LstProcesses.Items.Add(process.ProcessName);
            }
        }

            private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
                