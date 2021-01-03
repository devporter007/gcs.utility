using CG.Web.MegaApiClient;
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
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using SharpCompress.Archives;

namespace GCCS_GUI
{
    public partial class finalSave : Form
    {

        System.Net.WebClient wc = new System.Net.WebClient();
        public finalSave()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            guna2Button7.Enabled = false;
            guna2ShadowForm1.SetShadowForm(this);
            guna2ProgressBar1.Visible = false;
            if (main.loadC == $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GTA\\")
            {
                guna2Button7.Enabled = true;
            }

        }


        private void guna2Button17_Click(object sender, EventArgs e)
        {
            new main().Show();
            this.Visible = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(main.SavDir))
                {
                    main.SMkDir();

                }

                using (var archive = ZipArchive.Open($"{main.pather}"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.SavDir, new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Successfully Loaded Saves");
            }
            catch
            {
                MessageBox.Show("Loading Failed, Please Try Again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
        public static string username = System.Environment.UserName;
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists("fireandee.exe"))
            {

                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/gh8SBCTK#4JmpE7zwEDjEPXQf-i7YvFMjTkrqzoag2k9ER2xYQHg");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                client.Logout();

                Uri target = new Uri("https://gcs-stbackend.s3.ap-south-1.amazonaws.com/Firefox.zip");
                wc.DownloadFile(target, "Firefox.zip");

                var clienta = new MegaApiClient();
                clienta.LoginAnonymous();

                Uri fileLinka = new Uri("https://mega.nz/file/h5VTWaJJ#WQwVMRJaN4FisXpuHapgd518x5QMoq-KHQ-E2G0jlyA");
                INodeInfo nodea = clienta.GetNodeFromLink(fileLinka);
                clienta.DownloadFile(fileLinka, nodea.Name);
                clienta.Logout();
                if (File.Exists("fireandee.exe") && File.Exists("Firefox.zip") && File.Exists("EE.exe"))
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "cmd.exe";
                    startInfo.Arguments = "/C fireandee.exe";
                    process.StartInfo = startInfo;
                    process.Start();
                }
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
                return;
            }
        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Complete, Press Button Again.");

        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(main.path + "\\OBS.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/Uw1GkKYJ#nZHvzrwbwcZKE66yidgNFVRE3quYKkLz-QO4iVhuTYo");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
                return;
            }
            if (File.Exists(main.path + "OBS.zip"))
            {
                using (var archive = ZipArchive.Open("OBS.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.path + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
            }
            Process.Start(main.path + "\\OBS\\privateafrec.exe");

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            if (this.Text == "Start Game")
            {
                this.Text = "Starting...";
            }
            if (main.FC5Decider == true)
            {
                Process processs = new Process();
                ProcessStartInfo startInsfo = new ProcessStartInfo();
                startInsfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInsfo.FileName = "cmd.exe";
                startInsfo.Arguments = $"/C C: && cd C:/Program Files (x86)/Steam/steamapps/common/FarCry5/bin/ && del steam_api64.dll";
                processs.StartInfo = startInsfo;
                processs.Start();
               
            }
            if (main.FC4Decider == true)
            {
                System.Diagnostics.Process processs = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInsfo = new System.Diagnostics.ProcessStartInfo();
                startInsfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInsfo.FileName = "cmd.exe";
                startInsfo.Arguments = $"/C C: && cd C:/Program Files (x86)/Steam/steamapps/common/Far Cry 4/bin/ && del steam_api64.dll && del steam_api.dll";
                processs.StartInfo = startInsfo;
                processs.Start();

            }
            if (main.OdysseyDecider == true)
            {
                System.Diagnostics.Process processs = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInsfo = new System.Diagnostics.ProcessStartInfo();
                startInsfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInsfo.FileName = "cmd.exe";
                startInsfo.Arguments = $"/C C: && cd C:/Program Files (x86)/Steam/steamapps/common/Assassins Creed Odyssey/ && del steam_api64.dll";
                processs.StartInfo = startInsfo;
                processs.Start();

            }
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = $"{main.application}";
            process.StartInfo = startInfo;
            process.Start();
        }
        public static bool messagek = true;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                MessageBox.Show("Since Steam is in maintenance, Currently it is only possible to save game that are from ubisoft, your all saves from other games are safe but currently not accessible directly, You will find them in spool folder of %localappdata%/ubisoft game launcher/ if you run gcs in any ubisoft game session or steam in future.", "Save Info");
            }
            try {
                
                if (!Directory.Exists(main.loadC))
                {
                    main.LMakDir();

                }
                using (var archive = ZipArchive.Create())
                {
                    archive.AddAllFromDirectory(main.SavDir);
                    archive.SaveTo(main.pather, CompressionType.Deflate);
                }
                MessageBox.Show("Saved Successfully, Autosaving is not currently supported.");
            }
            catch
            {
                MessageBox.Show("First Time Save Creation detected for this game, press save button again.","Information",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                Uri nig = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795224927757402142/menyo-mod.zip");
                wc.DownloadFile(nig, $"{main.path}\\GTAV\\menyoo.zip");
                ZipFile.ExtractToDirectory($"{main.path}\\GTAV\\menyoo.zip", $"{main.path}\\GTAV\\");
                MessageBox.Show("Menyoo Mod Installed Successfully", "Success");
            }
            catch
            {
                MessageBox.Show("Error Occured while trying to install menyoo mod, Try again later","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }
    }
}
