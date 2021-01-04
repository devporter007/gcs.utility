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
using System.IO.Compression;
using System.Security.Policy;
using System.IO;
using System.Reflection;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using System.Diagnostics;

namespace GCCS_GUI
{
    public partial class main : Form
    {
        System.Net.WebClient wc = new System.Net.WebClient();

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("GCS is in super maintenance mode, some things WILL not work", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2ShadowForm1.SetShadowForm(this);

            guna2Button24.Visible = false;
            guna2Button20.Visible = false;
            guna2Button22.Visible = false;
            guna2Button21.Visible = false;
            guna2ProgressBar1.Visible = false;
            guna2Button25.Visible = false;
            guna2Button26.Visible = false;
            guna2Button27.Visible = false;
            guna2Button28.Visible = false;
            guna2Button30.Visible = false;
            guna2Button19.Visible = false;
            guna2Button31.Visible = false;
            guna2Button32.Visible = false;
            guna2Button35.Visible = false;
            guna2Button36.Visible = false;

        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = false;
            guna2Button2.Visible = false;
            guna2Button3.Visible = false;
            guna2Button4.Visible = false;
            guna2Button5.Visible = false;
            guna2Button6.Visible = false;
            guna2Button7.Visible = false;
            guna2Button8.Visible = false;
            guna2Button9.Visible = false;
            guna2Button10.Visible = false;
            guna2Button11.Visible = false;
            guna2Button12.Visible = false;
            guna2Button13.Visible = false;
            guna2Button14.Visible = false;
            guna2Button15.Visible = false;
            guna2Button16.Visible = false;
            //guna2Button19.Visible = false;
            guna2Button24.Visible = true;
            guna2Button18.Visible = false;
            guna2Button20.Visible = true;
            guna2Button22.Visible = true;
            guna2Button21.Visible = true;
            guna2Button25.Visible = true;
            guna2Button26.Visible = true;
            guna2Button27.Visible = true;
            guna2Button28.Visible = true;
            guna2Button19.Visible = true;
            guna2Button30.Visible = true;
            guna2Button31.Visible = true;
            guna2Button32.Visible = true;
            guna2Button35.Visible = true;
            guna2Button36.Visible = true;

        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running Far Cry 5 Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch FC-5 from GFN and then use GCS");
                    return;
                }
            }
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FarCry5\\";
            SavDir = "C:\\Users\\Public\\Documents\\uPlay\\CODEX\\Saves\\FarCry5\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FarCry5\\cmg_load.zip";
            FC5Decider = true;
            application = "C:/Program Files (x86)/Steam/steamapps/common/FarCry5/bin/FarCry5.exe";


            if (!File.Exists(main.path + "\\FarCero5.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/B8sU3Dba#QhcCgH2Qd2kIvkiy0xUFsi1uGc8vc1foytSBoMEiYiY");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                client.Logout();
                if (File.Exists(main.path + "FarCero5.zip"))
                {
                    using (var archive = ZipArchive.Open("FarCero5.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.FC5Path + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + "FarCero5.zip"))
            {
                using (var archive = ZipArchive.Open("FarCero5.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.FC5Path + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }

        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            new downloader().Show();
        }
        private void FileDownloadComplete(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Press Button Again!");
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running Assassin's Creed Odyssey Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch Assassin's Creed Odyssey from GFN and then use GCS");
                    return;
                }
            }
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\";
            SavDir = $"C:\\Users\\{username}\\AppData\\Roaming\\uplay_emu\\EMPRESS\\5059\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\cmg_load.zip";
            OdysseyDecider = true;
            application = "C:/Program Files (x86)/Steam/steamapps/common/Assassins Creed Odyssey/ACOdyssey.exe";
            if (!File.Exists(main.path + "\\Odyssey.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/cotm0BCb#A19qte6kfyshiyivVlmmDPJuwCUYdCPQryqQdZ-gedk");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
                if (File.Exists(main.path + "Odyssey.zip"))
                {
                    using (var archive = ZipArchive.Open("Odyssey.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.OdysseyPath + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + "Odyssey.zip"))
            {
                using (var archive = ZipArchive.Open("Odyssey.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.OdysseyPath + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running Euro Truck 2 Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch Euro Truck 2 from GFN and then use GCS");
                    return;
                }
            }
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\";
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\227300\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\EU2.zip";
            application = "C:/Program Files (x86)/Steam/steamapps/common/Euro Truck Simulator 2/bin/win_x64/eurotrucks2.exe";
            if (!File.Exists(main.path + "\\euro-truck-2.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/xg0FBCDB#V8KmcToalQ71-JikqrHVAA-y78AXbdb8FJnWXK4VBSg");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
                if (File.Exists(main.path + "euro-truck-2.zip"))
                {
                    using (var archive = ZipArchive.Open("euro-truck-2.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.EU2Path + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + "euro-truck-2.zip"))
            {
                using (var archive = ZipArchive.Open("euro-truck-2.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.EU2Path + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://pastebin.com/LBSQFSsa , CHECK THIS GUIDE BEFORE EVEN THINKING ABOUT PLAYING THIS GAME","Important",MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (!File.Exists(main.path + "\\Engine.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/kwVS3b7A#kJdyJRx3U6iD4o6e_MuucU79ndKAtWYf7dJ94bSvGiE");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
                if (File.Exists(main.path + "Engine.zip"))
                {
                    using (var archive = ZipArchive.Open("Engine.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.LIS2Path + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + "Engine.zip"))
            {
                using (var archive = ZipArchive.Open("Engine.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.LIS2Path + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running Hitman 2 Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch Hitman 2 Session Brow");
                    return;
                }
            }

            
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\863550\\";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\cmg_loadHITMAN2.zip";
            application = "C:/Program Files (x86)/Steam/steamapps/common/HITMAN2/Launcher.exe";
            if (!File.Exists(main.path + "\\hm2.zip"))
            {
           
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://cdn.discordapp.com/attachments/728493236154269707/762372067953082418/hm2.zip");
                wc.DownloadFile(target, "hm2.zip");
                if (File.Exists(main.path + "\\hm2.zip"))
                {
                    using (var archive = ZipArchive.Open("hm2.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.hitmanPath + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }



            if (File.Exists(main.path + "\\hm2.zip"))
            {
                using (var archive = ZipArchive.Open("hm2.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.hitmanPath + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }

        }
        public static void SMkDir() {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C mkdir \"{SavDir}\"";
            process.StartInfo = startInfo;
            process.Start();
        }
        public static bool Mafia; 
        public static string loadC;
        public static bool DeathDecider;
        public static string username = System.Environment.UserName;
        public static string pather;
        public static string SavDir;
        public static bool FC5Decider;
        public static bool OdysseyDecider;
        public static bool FC4Decider;
        public static string application;
        public static string GameName;
        public static string GameName2;
        public string Decider;
        public static bool DoomDecider;
        public static string path = AppDomain.CurrentDomain.BaseDirectory;
        public static string hitmanPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\HITMAN2";
        public static string FC5Path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\FarCry5";
        public static string OdysseyPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assassins Creed Odyssey";
        public static string EU2Path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Euro Truck Simulator 2";
        public static string LIS2Path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Life is Strange 2";
        public static string PlagPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\A Plague Tale Innocence";
        public static string FC4Path = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Far Cry 4";
        public static string ACIIIPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assassin's Creed III Remastered";
        public static string AvengersPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Marvels Avengers";
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running Plague Tale Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch Plague Tale from GFN and then use GCS");
                    return;
                }
            }
       
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\752590\\";
            pather = $"C:\\Program Files (x86)\\Steam\\music\\_database\\cmg_SteamClientMusic.db";
            loadC = $"C:\\Program Files (x86)\\Steam\\music\\_database\\";
            application = "C:/Program Files (x86)/Steam/steamapps/common/A Plague Tale Innocence/APlagueTaleInnocence_x64.exe";

            if (!File.Exists(main.path + "\\plagcra.zip"))
            {
              
              
                Uri target = new Uri("https://cdn.discordapp.com/attachments/613186365911203845/762370705068523551/plagcra.zip");
                wc.DownloadFile(target, "plagcra.zip");
                if (File.Exists(main.path + "\\plagcra.zip"))
                {
                    using (var archive = ZipArchive.Open("plagcra.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.PlagPath + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }

                return;
            }

            if (File.Exists(main.path + "\\plagcra.zip"))
            {
                using (var archive = ZipArchive.Open("plagcra.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.PlagPath + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running Far Cry 4 Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch FC-4 from GFN and then use GCS");
                    return;
                }
            }
         
            SavDir = $"C:\\Program Files (x86)\\Steam\\steamapps\\common\\Far Cry 4\\bin\\save3dmgames\\";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FarCry5\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FarCry5\\cmg_fc4.zip";
            FC4Decider = true;
            application = "C:/Program Files (x86)/Steam/steamapps/common/Far Cry 4/bin/FarCry4.exe";

            if (!File.Exists(main.path + "\\bin.zip"))
            {
                
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://cdn.discordapp.com/attachments/728493236154269707/753173730640789594/bin.zip");
                wc.DownloadFile(target, "bin.zip");
                if (File.Exists(main.path + "\\bin.zip"))
                {
                    using (var archive = ZipArchive.Open("bin.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.FC4Path + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }

            if (File.Exists(main.path + "\\bin.zip"))
            {
                using (var archive = ZipArchive.Open("bin.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.FC4Path + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (messagek == true)
            {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running AC-3:Remastered Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch AC3:Remastered from GFN and then use GCS");
                    return;
                }
            }
            SavDir = "C:\\Users\\Public\\Documents\\uPlay\\CODEX\\Saves\\AssassinsCreedIIIRemastered\\";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Assassin's Creed III Remastered\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Assassin's Creed III Remastered\\cmg_load.zip";
            application = "C:/Program Files (x86)/Steam/steamapps/common/Assassin's Creed III Remastered/ACIII.launcher.exe";
            if (!File.Exists(main.path + "\\ac3-r.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/thsGlTIR#QvPK4vIZZPLawKVxtRFho780o0AV1CVlArokgbT6ZTo");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
                if (File.Exists(main.path + "ac3-r.zip"))
                {
                    using (var archive = ZipArchive.Open("ac3-r.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.ACIIIPath + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + "ac3-r.zip"))
            {
                using (var archive = ZipArchive.Open("ac3-r.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.ACIIIPath + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Saved Games\\Mojang Studios\\Dungeons\\";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\minedung.zip";
            application = $"{main.path}\\minecraft_server.exe";
            GameName = "MinDung.zip";
            Decider = "https://drive.google.com/uc?id=11ajpHocRxhAgOzdAZUYPUWU6Ox3TLeGs";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\952060\\";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\resident3.zip";
            application = $"{main.path}\\Resident.Evil.3\\RE3\\re3.exe";
            GameName = "Resident.Evil.3.zip";
            Decider = "https://drive.google.com/uc?id=1ad2-_KROUJ7oijAPluqj_uXWX4ZDszij";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Saved Games\\id Software\\";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\DoomVK\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\DoomVK\\doomsav.zip";
            application = $"{main.path}\\DOOMEternalx64vk.exe";
            GameName = "doom eternal part 1.rar";
            GameName2 = "doom eternal part 2.rar";
            DoomDecider = true;
            Decider = "https://drive.google.com/uc?id=1kO9l2LJefh6IBdb0idx_gFZKOG4U-83n & https://drive.google.com/uc?id=1zBVY6Kh_liYYfWbF1NNPo8KUEqQPH1k5";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            application = $"{main.path}\\The.Dark.Pictures.Anthology.Little.Hope\\The Dark Pictures Anthology\\LittleHope.exe";
            GameName = "The.Dark.Pictures.Anthology.Little.Hope.zip";
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\DARKPICTURES\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\DARKPICTURES\\LITTLEHOPE.zip";
            SavDir = $"C:\\Users\\{username}\\AppData\\Local\\LittleHope\\Saved\\SaveGames";
            Decider = "https://drive.google.com/uc?id=1txLcnj_n4H8qmUKDYSVTt2JRcmwCDYaS";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\PlanetCoaster\\";
            SavDir = $"C:\\Users\\{username}\\Saved Games\\Frontier Developments\\Planet Coaster\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\PlanetCoaster\\PlanetCoasterSAV.zip";
            application = $"{main.path}\\Planet Coaster\\PlanetCoaster.exe";
            GameName = "PlanetCoaster.rar";
            Decider = "https://drive.google.com/uc?id=1SzhlkRnkIR7zUR40U--MuXUBTUoHjBhZ";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\SOTR\\";
            SavDir = $"C:\\Users\\{username}\\Documents\\CPY_SAVES\\CPY\\750920\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\SOTR\\SOTR.zip";
            application = $"{main.path}\\SOTTR.exe";
            GameName = "SOTR.zip";
            Decider = "https://drive.google.com/uc?id=1HQwVso9TJt_cSSwODtn6vrLhO7hwTr1r";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GTA IV\\";
            SavDir = $"C:\\Users\\{username}\\AppData\\Local\\Rockstar Games\\GTA IV\\savegames\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GTAIV\\GTAIV.zip";
            GameName = "GTAIV.zip";
            Decider = "https://drive.google.com/uc?id=1qoe4P_IM8KpQWnWs1bf4ni_xjfPL9CUS";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
         
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GhostRunner\\";
            SavDir = $"C:\\Users\\{username}\\AppData\\Local\\Ghostrunner\\Saved\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GhostRunner\\GhostRunner.zip";
            application = $"{main.path}\\GhostRunner\\Ghostrunner\\Binaries\\Win64\\Ghostrunner-Win64-Shipping.exe";
            GameName = "GhostRunner.zip";
            Decider = "https://drive.google.com/uc?id=1f0wIE6Q3Ilyaw9xowHIQXeINwzBq1qT2";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you on Death Stranding Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
            {
                MessageBox.Show("Use Death Stranding Session and then use GCS");
                return;
            }
            if(dialogResult == DialogResult.Yes) {
                DeathDecider = true;
                application = "C:/Program Files (x86)/Steam/steamapps/common/Death Stranding/ds.exe";

                if (!File.Exists(main.path + "\\Crack.zip"))
                {
                    Uri target = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795233781358395422/Crack.zip");
                    wc.DownloadFile(target, "Crack.zip");
                    if (File.Exists(main.path + "\\Crack.zip"))
                    {
                        using (var archive = ZipArchive.Open("Crack.zip"))
                        {
                            foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                            {
                                entry.WriteToDirectory("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Death Stranding\\", new ExtractionOptions()
                                {
                                    ExtractFullPath = true,
                                    Overwrite = true
                                });
                            }
                        }
                        MessageBox.Show("Files Extracted Successfully");
                        new finalSave().Show();
                        this.Hide();
                        return;
                    }
                    return;
                }



                if (File.Exists(main.path + "\\Crack.zip"))
                {
                    using (var archive = ZipArchive.Open("Crack.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Death Stranding\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }

                this.Hide();
            }
            
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            Mafia = true;
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\MafiaDE\\";
            SavDir = $"C:\\Users\\{username}\\Documents\\My Games\\Mafia Definitive Edition\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\MafiaDE\\MafiaDE.zip";
            application = $"{main.path}\\Mafia.Definitive.Edition\\Mafia - Definitive Edition\\launcher.exe";
            GameName = "Mafia.Definitive.Edition.zip";
            Decider = "https://drive.google.com/uc?id=1-BmBJm3wVQJ6SBQT82TH1lMOPeX3QeY5";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            application = "C:/Program Files (x86)/Steam/steamapps/common/Marvels Avengers/avengers.exe";
            if (!File.Exists(main.path + "\\Avengers.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/k1lxAYgT#Dk9sbL9MbTbGVGxPQw6Cz9NB9B4IGAljL4kNvXGPlRk");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
             //   MessageBox.Show($"Downloaded Completed, Press button again");
                client.Logout();

                var clienta = new MegaApiClient();
                clienta.LoginAnonymous();

                Uri fileLinka = new Uri("https://mega.nz/file/Q8s2xRxb#gnT0Yr2brZTrbFrsr7RcSand6GBO0w_nDISZ2pIWpic");
                INodeInfo nodea = clienta.GetNodeFromLink(fileLinka);
                clienta.DownloadFile(fileLinka, nodea.Name);
                
                clienta.Logout();
                if (File.Exists(main.path + $"\\Avengers.zip"))
                {
                    using (var archive = ZipArchive.Open("Avengers.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory(main.AvengersPath + "\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    string strCmdText;
                    strCmdText = $"/C B: && B:\\ && cd GCS && move bigfile.update2.000.000.tiger \"{main.AvengersPath}\\\"";
                    Process.Start("CMD.exe", strCmdText);
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + $"\\Avengers.zip"))
            {
                using (var archive = ZipArchive.Open("Avengers.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(main.AvengersPath + "\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                string strCmdText;
                strCmdText = $"/C B: && B:\\ && cd GCS && move bigfile.update2.000.000.tiger \"{main.AvengersPath}\\\"";
                Process.Start("CMD.exe", strCmdText);
                new finalSave().Show();
                this.Hide();
                return;
            }


        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            new VersionAndAbout().Show();
        }
        public static void LMakDir()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = $"/C mkdir \"{loadC}\"";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void guna2Button24_Click(object sender, EventArgs e)
        {
            guna2Button1.Visible = true;
            guna2Button2.Visible = true;
            guna2Button3.Visible = true;
            guna2Button4.Visible = true;
            guna2Button5.Visible = true;
            guna2Button6.Visible = true;
            guna2Button7.Visible = true;
            guna2Button8.Visible = true;
            guna2Button9.Visible = true;
            guna2Button10.Visible = true;
            guna2Button11.Visible = true;
            guna2Button12.Visible = true;
            guna2Button13.Visible = true;
            guna2Button14.Visible = true;
            guna2Button15.Visible = true;
            guna2Button16.Visible = true;
            //guna2Button19.Visible = true;
            guna2Button24.Visible = false;
            guna2Button18.Visible = true;
            guna2Button21.Visible = false;
            guna2Button22.Visible = false;
            guna2Button20.Visible = false;
            guna2Button25.Visible = false;
            guna2Button26.Visible = false;
            guna2Button27.Visible = false;
            guna2Button28.Visible = true;
            guna2Button28.Visible = false;
            guna2Button19.Visible = false;
            guna2Button30.Visible = false;
            guna2Button31.Visible = false;
            guna2Button32.Visible = false;
            guna2Button35.Visible = false;
            guna2Button36.Visible = false;


        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\CrysisRem\\";
            SavDir = $"C:\\Users\\{username}\\Saved Games\\CrysisRemastered\\SaveGames\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\CrysisRem\\CrysisRem.zip";
            application = $"{main.path}\\Crysis Remastered\\Bin64\\CrysisRemastered.exe";
            GameName = "CrysisRemastered.zip";
            Decider = "https://drive.google.com/uc?id=1jxs3QiG_4mnDp-7g8aixjH9pUbpflPiQ";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game uses files from arcade", "Credits", MessageBoxButtons.OK);
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone");
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Assassin's Creed III Remastered\\";
            SavDir = $"C:\\Users\\{username}\\AppData\\Roaming\\Goldberg SocialClub Emu Saves\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Assassin's Creed III Remastered\\itsrdr2bitch.zip";
            application = $"{main.path}\\RDR2\\Launcher.exe";
            if (!File.Exists(main.path + "\\dinker.exe"))
            {
                Uri config = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795002711031939072/rclone.conf");
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.23/dinker.exe");
                wc.DownloadFile(config, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone\\rclone.conf");
                wc.DownloadFile(target, "dinker.exe");
                if (File.Exists(main.path + "\\dinker.exe"))
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = $"{main.path}\\dinker.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            Arguments = $"copy -P \"Dropbox:Red Dead Redemption 2\" {main.path}\\RDR2"
                        }
                    }.Start();
                    new finalSave().Show();
                    this.Hide();

                    //string strCmdText = $"/C dinker.exe -P Sensie-Disk:\\GCS\\OBS.zip \"C:\\Users\\91912\\Documents\\rclone-v1.53.3-windows-amd64_2\\\"";

                }
                return;
            }
            if (File.Exists(main.path + "\\dinker.exe"))
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{main.path}\\dinker.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardError = false,
                        Arguments = $"copy -P Sensie-Disk:\\D\\ {main.path}\\RDR2 --drive-acknowledge-abuse"
                    }
                }.Start();
                new finalSave().Show();
                this.Hide();
            }
            
        }

        private void guna2Button20_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.guna2Button20, "Quick Access");
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credits to Arcade for Star Wars Jedi Fallen Order", "Credits");
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone");
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\STARWARSJEDI\\";
            SavDir = $"C:\\Users\\{username}\\Saved Games\\Respawn\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\STARWARSJEDI\\SAVDE.zip";
            application = $"{main.path}\\SWJFO\\SwGame\\Binaries\\Win64\\starwarsjedifallenorder.exe";

            if (!File.Exists(main.path + "\\dinker.exe"))
            {
                Uri config = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795002711031939072/rclone.conf");
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.23/dinker.exe");
                wc.DownloadFile(config, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone\\rclone.conf");
                wc.DownloadFile(target, "dinker.exe");
                if (File.Exists(main.path + "\\dinker.exe"))
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = $"{main.path}\\dinker.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            Arguments = $"copy -P \"ArcadeBackup2:FireForce/Star Wars Jedi Fallen Order\" {main.path}\\SWJFO --drive-acknowledge-abuse"
                        }
                    }.Start();
                    new finalSave().Show();
                    this.Hide();

                    //string strCmdText = $"/C dinker.exe -P Sensie-Disk:\\GCS\\OBS.zip \"C:\\Users\\91912\\Documents\\rclone-v1.53.3-windows-amd64_2\\\"";

                }
                return;
            }
            if (File.Exists(main.path + "\\dinker.exe"))
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{main.path}\\dinker.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardError = false,
                        Arguments = $"copy -P \"ArcadeBackup2:FireForce/Star Wars Jedi Fallen Order\" {main.path}\\SWJFO --drive-acknowledge-abuse"
                    }
                }.Start();
                new finalSave().Show();
                this.Hide();
            }


        }

        public static bool sr3m;
        private void guna2Button28_Click(object sender, EventArgs e)
        {
            sr3m = true;
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\SAINTSROW3\\";
            SavDir = $"C:\\Users\\{username}\\AppData\\Local\\Saints Row The Third\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\SAINTSROW3\\SAVDE.zip";
            application = $"{main.path}\\Saints.Row.The.Third.Remastered\\Saints Row The Third Remastered\\SRTTR.exe";
            GameName = "Saints.Row.The.Third.Remastered.zip";
            Decider = "https://drive.google.com/uc?id=1qhXYcIBIqVH7X3XRFfNGaZocisqAWZ1-";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

        public static string search;
        public static bool fcdawn;
        private void guna2Button19_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("FC New Dawn is Partially Supported, Game will not launch by pressing Start Game(Use CMD to Launch Game)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            fcdawn = true;
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FCNEWDAWN\\";
            SavDir = $"C:\\Users\\Public\\Documents\\uPlay\\CODEX\\Saves\\FarCryNewDawn\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FCNEWDAWN\\SAV.zip";
            application = $"{main.path}\\Wolfenstein.Youngblood\\Wolfenstein Youngblood\\Youngblood_x64vk.exe";
            GameName = "FarCryNewDawn.zip";
            Decider = "https://drive.google.com/uc?id=1jFThJgQjuqHOW32SBj6IK1m0_WLsyC0F";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();

        }
        public static bool wolfy;
        private void guna2Button30_Click(object sender, EventArgs e)
        {
            wolfy = true;
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\WOLFEN\\";
            SavDir = $"C:\\Users\\{username}\\Saved Games\\MachineGames\\Wolfenstein Youngblood\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\WOLFEN\\SAV.zip";
            application = $"{main.path}\\Wolfenstein.Youngblood\\Wolfenstein Youngblood\\Youngblood_x64vk.exe";
            GameName = "Wolfenstein.Youngblood.zip";
            Decider = "https://drive.google.com/uc?id=1jFThJgQjuqHOW32SBj6IK1m0_WLsyC0F";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        public static bool messagek = true;
        private void guna2Button31_Click(object sender, EventArgs e)
        {
            if (messagek == true) {
                messagek = false;
                DialogResult dialogResult = MessageBox.Show("Are you running AC Rogue Session?", "N/Y", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Launch AC Rogue(Steam) from GFN and then use GCS");
                    return;
                }
            }
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACRogue\\";
            SavDir = $"C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assassin's Creed Rogue\\save3dmgames\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACRogue\\RogueSave.zip";
            application = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assassin's Creed Rogue\\ACC.exe";
            if (!File.Exists(main.path + "\\ACR.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/8wMGBZDY#uPlldqgaZgon2T0Zha3hrEQxKdQ6Lm4UPCXx3p_ECpw");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
                if (File.Exists(main.path + "ACR.zip"))
                {
                    using (var archive = ZipArchive.Open("ACR.zip"))
                    {
                        foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                        {
                            entry.WriteToDirectory("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assassin's Creed Rogue\\", new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });
                        }
                    }
                    MessageBox.Show("Files Extracted Successfully");
                    new finalSave().Show();
                    this.Hide();
                    return;
                }
                return;
            }
            if (File.Exists(main.path + "ACR.zip"))
            {
                using (var archive = ZipArchive.Open("ACR.zip"))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Assassin's Creed Rogue\\", new ExtractionOptions()
                        {
                            ExtractFullPath = true,
                            Overwrite = true
                        });
                    }
                }
                MessageBox.Show("Files Extracted Successfully");
                new finalSave().Show();
                this.Hide();
                return;
            }
        }

        public static string RcloneArguement;
       
        private void guna2Button32_Click(object sender, EventArgs e)
        {
            if (cpdropbox == true)
            {
                RcloneArguement = $"copy -P \"privbox:Cyberpunk 2077\" {main.path}\\CP2077";
            }
            else
            {
                RcloneArguement = $"copy -P \"swap:CP6/Cyberpunk 2077\" {main.path}\\CP2077 --drive-acknowledge-abuse";
            }
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone");
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Cyberpunk2077\\";
            SavDir = $"C:\\Users\\{username}\\Saved Games\\CD Projekt Red\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Cyberpunk2077\\cyberpunk.zip";
            application = $"{main.path}\\CP2077\\bin\\x64\\Cyberpunk2077.exe";
            if (!File.Exists(main.path + "\\dinker.exe"))
            {
                Uri config = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795002711031939072/rclone.conf");
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.23/dinker.exe");
                wc.DownloadFile(config, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone\\rclone.conf");
                wc.DownloadFile(target, "dinker.exe");
                if (File.Exists(main.path + "\\dinker.exe"))
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = $"{main.path}\\dinker.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            Arguments = RcloneArguement
                        }
                    }.Start();
                    new finalSave().Show();
                    this.Hide();

                    //string strCmdText = $"/C dinker.exe -P Sensie-Disk:\\GCS\\OBS.zip \"C:\\Users\\91912\\Documents\\rclone-v1.53.3-windows-amd64_2\\\"";

                }
                return;
            }
            if (File.Exists(main.path + "\\dinker.exe"))
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{main.path}\\dinker.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardError = false,
                        Arguments = RcloneArguement
                    }
                }.Start();
                new finalSave().Show();
                this.Hide();
            }
        }

        private void guna2Button33_Click(object sender, EventArgs e)
        {
            if (!File.Exists(main.path + "\\WinX.zip")) {
                Uri target = new Uri("https://gcs-stbackend.s3.ap-south-1.amazonaws.com/WinX.zip");
                wc.DownloadFile(target, "WinX.zip");
                System.Threading.Thread.Sleep(2000);
                if (File.Exists(main.path + "\\WinX.zip"))
                {
                    using (var archive = ZipArchive.Open("WinX.zip"))
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
                    if (File.Exists(main.path + "\\WinXShell\\start.bat"))
                    {
                        Process.Start(main.path + "\\WinXShell\\start.bat");
                        return;
                    }
                    return;
                }
                return;
            }
            

        }

        private void guna2Button34_Click(object sender, EventArgs e)
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

        private void guna2Button35_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credits to Arcade for Horizon Zero Dawn", "Credits");
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone");
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\HZD\\";
            SavDir = $"C:\\Users\\{username}\\Documents\\Horizon Zero Dawn\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\HZD\\HZD.zip";
            application = $"{main.path}\\HZD\\HorizonZeroDawn.exe";
            if (!File.Exists(main.path + "\\dinker.exe"))
            {
                Uri config = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795002711031939072/rclone.conf");
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.23/dinker.exe");
                wc.DownloadFile(config, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone\\rclone.conf");
                wc.DownloadFile(target, "dinker.exe");
                if (File.Exists(main.path + "\\dinker.exe"))
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = $"{main.path}\\dinker.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            Arguments = $"copy -P \"ArcadeBackup2:FireForce/Horizon Zero Dawn/\" {main.path}\\HZD --drive-acknowledge-abuse"
                        }
                    }.Start();
                    new finalSave().Show();
                    this.Hide();

                    //string strCmdText = $"/C dinker.exe -P Sensie-Disk:\\GCS\\OBS.zip \"C:\\Users\\91912\\Documents\\rclone-v1.53.3-windows-amd64_2\\\"";

                }
                return;
            }
            if (File.Exists(main.path + "\\dinker.exe"))
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{main.path}\\dinker.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardError = false,
                        Arguments = $"copy -P \"ArcadeBackup2:FireForce/Horizon Zero Dawn/\" {main.path}\\HZD --drive-acknowledge-abuse"
                    }
                }.Start();
                new finalSave().Show();
                this.Hide();
            }
        }

        private void guna2Button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credits to Arcade for GTA V", "Credits");
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone");
            loadC = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GTA\\";
            SavDir = $"C:\\Users\\{username}\\AppData\\Roaming\\Goldberg SocialClub Emu Saves\\GTA V\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GTA\\V.zip";
            application = $"{main.path}\\EE.exe";
            if (!File.Exists(main.path + "\\dinker.exe"))
            {
                Uri config = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795002711031939072/rclone.conf");
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.23/dinker.exe");
                wc.DownloadFile(config, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.config\\rclone\\rclone.conf");
                wc.DownloadFile(target, "dinker.exe");
                if (File.Exists(main.path + "\\dinker.exe"))
                {
                    new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = $"{main.path}\\dinker.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            Arguments = $"copy -P \"Dropbox:Grand Theft Auto V\" {main.path}\\GTAV"
                        }
                    }.Start();
                    if (!Directory.Exists($"C:\\Users\\{username}\\AppData\\Roaming\\Goldberg SocialClub Emu Saves"))
                    {
                        Uri nig = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795224989301080104/GTA-V-SAVES-PROPER.zip");
                        wc.DownloadFile(nig, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\saves.zip");
                        ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\saves.zip", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\");
                    }
                    new finalSave().Show();
                    this.Hide();

                    //string strCmdText = $"/C dinker.exe -P Sensie-Disk:\\GCS\\OBS.zip \"C:\\Users\\91912\\Documents\\rclone-v1.53.3-windows-amd64_2\\\"";

                }
                return;
            }
            if (File.Exists(main.path + "\\dinker.exe"))
            {
                new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = $"{main.path}\\dinker.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardError = false,
                        Arguments = $"copy -P \"ArcadeBackup2:FireForce/Grand Theft Auto V\" {main.path}\\GTAV --drive-acknowledge-abuse"
                    }
                }.Start();
                if (!Directory.Exists($"C:\\Users\\{username}\\AppData\\Roaming\\Goldberg SocialClub Emu Saves"))
                {
                    Uri nig = new Uri("https://cdn.discordapp.com/attachments/771442981102288896/795201017393315870/GTA-V-SAVES-PROPER.zip");
                    wc.DownloadFile(nig, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\saves.zip");
                    ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\saves.zip", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Roaming\\");
                }
                new finalSave().Show();
                this.Hide();
            }
        }
        public static bool cpdropbox;
        private void guna2Button37_Click(object sender, EventArgs e)
        {
                DialogResult dialogResult = MessageBox.Show("Do you want to change download server for cyberpunk 2077?(Yes for Dropbox and No for Gdrive)", "Swap Disk", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Download Disk :- Google Drive");
                    return;
                }

           
            MessageBox.Show("Download Disk :- Dropbox","Successfully Set");
            cpdropbox = true;
        }
    }
}
