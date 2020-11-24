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
using CG.Web.MegaApiClient;
using System.IO.MemoryMappedFiles;

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
            if (main.Mafia == true || main.sr3m == true || main.wolfy == true)
            {
                guna2Button1.Enabled = true;
            }
            guna2ShadowForm1.SetShadowForm(this);
            guna2TextBox1.Text = Class1.Decider;

        }

        public static string mirror;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is useful only if you get exhausted error on gdrive!", "Information");
            if (main.Mafia == true)
            {
                mirror = "https://drive.google.com/uc?id=1Unbo1ZodG4KORh-zXGHL-At5qNMaZLvD";
            }
            else if (main.sr3m == true)
            {
                mirror = "https://drive.google.com/uc?id=1Wl7UNCkPgOkCIySZgb2iHV2DOCjoE3QP";
            }
            else if (main.wolfy == true)
            {
                mirror = "https://drive.google.com/uc?id=1AMPI7AYCD7Srb-QcTdeznQTnFD7rhAfq";
            }
            Class1.Decider = mirror;
            guna2TextBox1.Text = Class1.Decider;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists("fireandee.exe"))
            {
       
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/gh8SBCTK#4JmpE7zwEDjEPXQf-i7YvFMjTkrqzoag2k9ER2xYQHg");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                client.Logout();

                var clientv = new MegaApiClient();
                clientv.LoginAnonymous();

                Uri fileLinkv = new Uri("https://mega.nz/file/g49gyRgT#ppKAGJhkjpwR7Ftbhf6htFvM-FKIQYOdCuNvVk9Ywuc");
                INodeInfo nodev = clientv.GetNodeFromLink(fileLinkv);
                clientv.DownloadFile(fileLinkv, nodev.Name);
                clientv.Logout();

                var clienta = new MegaApiClient();
                clienta.LoginAnonymous();

                Uri fileLinka = new Uri("https://mega.nz/file/h5VTWaJJ#WQwVMRJaN4FisXpuHapgd518x5QMoq-KHQ-E2G0jlyA");
                INodeInfo nodea = clienta.GetNodeFromLink(fileLinka);
                clienta.DownloadFile(fileLinka, nodea.Name);
                MessageBox.Show("Press Button Again!", "Proceed");
                clienta.Logout();
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
            if (main.DeathDecider == true)
            {
                strCmdText = $"/C 8z.exe x {main.GameName}";
                Process.Start("CMD.exe", strCmdText);
            }
            this.Hide();
            new finalSave().Show();
            

        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
