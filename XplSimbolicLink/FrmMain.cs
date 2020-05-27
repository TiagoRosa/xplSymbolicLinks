using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace XplSimbolicLink
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            txtSource.Text = folderBrowserDialog1.SelectedPath;
            string[] folders = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);

            chkFolders.Items.Clear();
            chkFolders.Items.AddRange(folders);

            lblTotalFolders.Text += folders.Length.ToString();
        }

        private void BtnDestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            txtDestination.Text = folderBrowserDialog1.SelectedPath;
        }

        private void ChkAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkFolders.Items.Count; i++)
            {
                if (chkAll.Checked)
                {
                    chkFolders.SetItemChecked(i, true);
                }
                else
                {
                    chkFolders.SetItemChecked(i, false);
                }

            }
            string count = chkFolders.CheckedItems.Count.ToString();
            lblFolderSelected.Text = "Folders Selected: " + count;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtDestination.Text))
            {
                MessageBox.Show("Please select a destination", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtSource.Text))
            {
                MessageBox.Show("Please select a source", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (chkFolders.CheckedItems.Count<=0)
            {
                MessageBox.Show("You must select at least one folder", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            progressBar1.Maximum = chkFolders.Items.Count;
            progressBar1.Minimum = 0;

            for (int i = 0; i < chkFolders.Items.Count; i++)
            {
                if (chkFolders.GetItemChecked(i))
                {
                    string linkSource = chkFolders.Items[i].ToString();

                    string linkDestination = txtDestination.Text + linkSource.Replace(txtSource.Text, "");

                    Process process = new Process();
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C mklink /J \"" + linkDestination + "\" \"" + linkSource + "\"";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                progressBar1.Value = (i + 1);
            }
            MessageBox.Show("Successfully created links!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChkFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            string count = chkFolders.CheckedItems.Count.ToString();
            lblFolderSelected.Text = "Folders Selected: " + count;
        }
    }
}
