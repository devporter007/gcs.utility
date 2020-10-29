using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using SharpCompress.Archives;
using System.IO;
using System.Diagnostics;

namespace GCCS_GUI
{
    public partial class gdrive : Form
        
    {
        System.Net.WebClient wc = new System.Net.WebClient();
        public gdrive()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            guna2TextBox1.Text = Class1.Decider;

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature Not Available");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists("fireandee.exe"))
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.0.00001/fireandee.exe");
                wc.DownloadFileAsync(target, "fireandee.exe");
                return;

            }
            if (File.Exists("fireandee.exe"))
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C fireandee.exe";
                process.StartInfo = startInfo;
                process.Start();
            }
        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File Download Complete");

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = $"/C 8z.exe x \"{main.GameName}\"";
            Process.Start("CMD.exe", strCmdText);
            if (main.DoomDecider == true)
            {
                strCmdText = $"/C 8z.exe x \"{main.GameName2}\" && pause";
                Process.Start("CMD.exe", strCmdText);
            }
            
            this.Hide();
            new finalSave().Show();
            

        }
    }
}
