using System;
using System.IO;
using System.Windows.Forms;

namespace WinDIRs
{
    public partial class DIRReader : Form
    {
        private const string NEWLINE = "\n";
        private int iniRowCount = 0;
        private bool stopNow = false;

        public DIRReader() => InitializeComponent();

        #region UI Button Events

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (fbdPath.ShowDialog() == DialogResult.OK)
                txtPath.Text = fbdPath.SelectedPath;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            stopNow = false;
            iniRowCount = 0;
            btnStart.Text = "Restart";
            btnStop.Focus();

            txtStart.Text = System.DateTime.Now.ToString();
            lblRowCountValue.Text = rtbShowLines.Text = txtStop.Text = string.Empty;

            Application.DoEvents();

            string path = @txtPath.Text;

            if (!System.IO.Directory.Exists(path))
                return;
            else if (File.Exists(path))
                ProcessFile(path);
            else if (Directory.Exists(path))
                ProcessDirectory(path);
            else
                rtbShowLines.Text += (NEWLINE + DateTime.Now.ToString() + path + " is not valid path ");

            txtStop.Text = System.DateTime.Now.ToString();
            Application.DoEvents();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopNow = true;
        }

        #endregion UI Button Events

        /// <summary>
        /// Recursive method to find sub directories and files
        /// </summary>
        /// <param name="targetDir"></param>
        public void ProcessDirectory(string targetDir)
        {
            try
            {
                // Process the list of files found in targetDir.
                string[] fileEntries = Directory.GetFiles(targetDir);
                foreach (string fileName in fileEntries)
                {
                    if (stopNow)
                        return;
                    ProcessFile(fileName);
                }

                // Recurse into subdirectories of targetDir.
                string[] subdirectories = Directory.GetDirectories(targetDir);
                foreach (string subdirectory in subdirectories)
                {
                    if (stopNow)
                        return;
                    ProcessDirectory(subdirectory);
                }
            }
            catch { }
        }

        /// <summary>
        /// Show File names in Rich Text Box
        /// </summary>
        /// <param name="path"></param>
        public void ProcessFile(string path)
        {
            if (stopNow)
                return;

            lblRowCountValue.Text = iniRowCount.ToString();
            iniRowCount += 1;
            Application.DoEvents();

            if (rbNone.Checked)
                rtbShowLines.Text = string.Empty;
            else if (rbLatest500.Checked)
            {
                if (iniRowCount % 500 == 0)
                    rtbShowLines.Text = string.Empty;
                rtbShowLines.Text += (NEWLINE + DateTime.Now.ToString() + " File Name : " + Path.GetFileName(path));
            }
            else if (rbAll.Checked)
            {
                rtbShowLines.Text += (NEWLINE + DateTime.Now.ToString() + " File Name : " + Path.GetFileName(path));
            }
        }
    }
}