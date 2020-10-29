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

            guna2ShadowForm1.SetShadowForm(this);
            guna2Button24.Visible = false;
            guna2Button20.Visible = false;
            guna2Button22.Visible = false;
            guna2Button21.Visible = false;
            guna2ProgressBar1.Visible = false;
            guna2Button25.Visible = false;
            guna2Button26.Visible = false;

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
            guna2Button19.Visible = false;
            guna2Button24.Visible = true;
            guna2Button18.Visible = false;
            guna2Button20.Visible = true;
            guna2Button22.Visible = true;
            guna2Button21.Visible = true;
            guna2Button25.Visible = true;
            guna2Button26.Visible = true;
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SavDir = "C:\\Users\\Public\\Documents\\uPlay\\CODEX\\Saves\\FarCry5\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FarCry5\\cmg_load.zip";
            FC5Decider = true;
            application = "cd C:/Program Files (x86)/Steam/steamapps/common/FarCry5/bin/ && C: && FarCry5.exe";


            if (!File.Exists(main.path + "\\FarCero5.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/B8sU3Dba#QhcCgH2Qd2kIvkiy0xUFsi1uGc8vc1foytSBoMEiYiY");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
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
            SavDir = $"C:\\Users\\{username}\\AppData\\Roaming\\uplay_emu\\EMPRESS\\5059\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\cmg_load.zip";
            OdysseyDecider = true;
            application = "cd C:/Program Files (x86)/Steam/steamapps/common/Assassins Creed Odyssey/ && C: && ACOdyssey.exe";
            if (!File.Exists(main.path + "\\Odyssey.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/cotm0BCb#A19qte6kfyshiyivVlmmDPJuwCUYdCPQryqQdZ-gedk");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
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
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\227300\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\EU2.zip";
            application = "C: && cd C:/Program Files (x86)/Steam/steamapps/common/Euro Truck Simulator 2/bin/win_x64/eurotrucks2.exe";
            if (!File.Exists(main.path + "\\euro-truck-2.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/xg0FBCDB#V8KmcToalQ71-JikqrHVAA-y78AXbdb8FJnWXK4VBSg");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
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
            if (!File.Exists(main.path + "\\Engine.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/kwVS3b7A#kJdyJRx3U6iD4o6e_MuucU79ndKAtWYf7dJ94bSvGiE");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show("Downloaded Completed, Press button again");
                client.Logout();
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
            guna2ProgressBar1.Visible = true;
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\863550\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\cmg_loadHITMAN2.zip";
            application = "C: && cd C:/Program Files (x86)/Steam/steamapps/common/HITMAN2/ && Launcher.exe";
            if (!File.Exists(main.path + "\\hm2.zip"))
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://cdn.discordapp.com/attachments/728493236154269707/762372067953082418/hm2.zip");
                wc.DownloadFileAsync(target, "hm2.zip");

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
            guna2ProgressBar1.Visible = true;
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\752590\\";
            pather = $"C:\\Program Files (x86)\\Steam\\music\\_database\\cmg_SteamClientMusic.db";
            application = "cd C:/Program Files (x86)/Steam/steamapps/common/A Plague Tale Innocence/ && C: && APlagueTaleInnocence_x64.exe";

            if (!File.Exists(main.path + "\\plagcra.zip"))
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://cdn.discordapp.com/attachments/613186365911203845/762370705068523551/plagcra.zip");
                wc.DownloadFileAsync(target, "plagcra.zip");

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
            guna2ProgressBar1.Visible = true;
            SavDir = $"C:\\Program Files (x86)\\Steam\\steamapps\\common\\Far Cry 4\\bin\\save3dmgames\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\FarCry5\\cmg_fc4.zip";
            FC4Decider = true;
            application = "cd C:/Program Files (x86)/Steam/steamapps/common/Far Cry 4/bin/ && C: && FarCry4.exe";

            if (!File.Exists(main.path + "\\bin.zip"))
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://cdn.discordapp.com/attachments/728493236154269707/753173730640789594/bin.zip");
                wc.DownloadFileAsync(target, "bin.zip");

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
            guna2ProgressBar1.Visible = true;
            SavDir = $"C:\\Users\\Public\\Documents\\uPlay\\CODEX\\Saves\\AssassinsCreedIIIRemastered\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Assassin's Creed III Remastered\\cmg_load.zip";
            application = "cd C:/Program Files (x86)/Steam/steamapps/common/Assassin's Creed III Remastered/ && C: && ACIII.launcher.exe";
            if (!File.Exists(main.path + "\\ac3-r.zip"))
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://cdn.discordapp.com/attachments/752467920638050304/768470728352727070/ac3-r.zip");
                wc.DownloadFileAsync(target, "ac3-r.zip");

                return;
            }

            if (File.Exists(main.path + "\\ac3-r.zip"))
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
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\minedung.zip";
            application = $"B: && cd {main.path}\\ && minecraft_server.exe";
            GameName = "MinDung.zip";
            Decider = "https://drive.google.com/uc?id=11ajpHocRxhAgOzdAZUYPUWU6Ox3TLeGs";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\Public\\Documents\\Steam\\CODEX\\952060\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\ACOdyssey\\resident3.zip";
            application = $"B: && cd {main.path}\\ && cd Resident.Evil.3 && cd RE3 && re3.exe";
            GameName = "Resident.Evil.3.zip";
            Decider = "https://drive.google.com/uc?id=1tNHiI4d8cEIpTs9Zey9lPCXua2Ll2aVt";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Saved Games\\id Software\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\DoomVK\\doomsav.zip";
            application = $"B: && cd {main.path}\\ && DOOMEternalx64vk.exe";
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
            application = $"B: && cd {main.path}\\ && cd PlanetZoo && PlanetZoo.exe";
            GameName = "PlanetZoo.rar";
            Decider = "https://drive.google.com/uc?id=1VWGoT0lGxmH2LMQv2uuwnRdTiwaa8y22";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Saved Games\\Frontier Developments\\Planet Coaster\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\PlanetCoaster\\PlanetCoasterSAV.zip";
            application = $"B: && cd {main.path}\\ && cd \"Planet Coaster\" && PlanetCoaster.exe";
            GameName = "PlanetCoaster.rar";
            Decider = "https://drive.google.com/uc?id=1SzhlkRnkIR7zUR40U--MuXUBTUoHjBhZ";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Documents\\CPY_SAVES\\CPY\\750920\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\SOTR\\SOTR.zip";
            application = $"B: && cd {main.path}\\ && SOTTR.exe";
            GameName = "SOTR.zip";
            Decider = "https://drive.google.com/uc?id=1HQwVso9TJt_cSSwODtn6vrLhO7hwTr1r";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
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
            SavDir = $"";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\GhostRunner\\GhostRunner.zip";
            application = $"B: && cd {main.path}\\ && cd Ghostrunner && Ghostrunner.exe";
            GameName = "GhostRunner.zip";
            Decider = "https://drive.google.com/uc?id=1GKhRMtgZC6me_k_ro0iDHM77xqe-Ld86";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            DeathDecider = true;
            application = "C: && cd C:/Program Files (x86)/Steam/steamapps/common && cd \"Death Stranding\" && ds.exe";
            GameName = "DS-Patch.rar -O\"C:/Program Files (x86)/Steam/steamapps/common/Death Stranding\"";
            Decider = "https://drive.google.com/uc?id=1boILKcvDO1-DU0RLNMaCS-jygQXxR1nf";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Documents\\My Games\\Mafia Definitive Edition\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\MafiaDE\\MafiaDE.zip";
            application = $"B: && cd {main.path}\\ && cd Mafia.Definitive.Edition && cd \"Mafia - Definitive Edition\" && launcher.exe";
            GameName = "Mafia.Definitive.Edition.zip";
            Decider = "https://drive.google.com/uc?id=1-BmBJm3wVQJ6SBQT82TH1lMOPeX3QeY5";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            application = "C: && cd C:/Program Files (x86)/Steam/steamapps/common && cd \"Marvels Avengers\" && avengers.exe";
            if (!File.Exists(main.path + "\\Avengers.zip"))
            {
                var client = new MegaApiClient();
                client.LoginAnonymous();

                Uri fileLink = new Uri("https://mega.nz/file/c592hAIb#5WMUEv38RaxOTP6lwoWYQrmphhP0UKIZqvSp_CWD13g");
                INodeInfo node = client.GetNodeFromLink(fileLink);
                client.DownloadFile(fileLink, node.Name);
                MessageBox.Show($"Downloaded Completed, Press button again");
                client.Logout();
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
                new finalSave().Show();
                this.Hide();
                return;
            }


        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            new VersionAndAbout().Show();
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
            guna2Button19.Visible = true;
            guna2Button24.Visible = false;
            guna2Button18.Visible = true;
            guna2Button21.Visible = false;
            guna2Button22.Visible = false;
            guna2Button20.Visible = false;
            guna2Button25.Visible = false;
            guna2Button26.Visible = false;

        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            SavDir = $"C:\\Users\\{username}\\Saved Games\\CrysisRemastered\\SaveGames\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\CrysisRem\\CrysisRem.zip";
            application = $"B: && cd {main.path}\\ && cd \"Crysis Remastered\" && cd Bin64 && CrysisRemastered.exe";
            GameName = "CrysisRemastered.zip";
            Decider = "https://drive.google.com/uc?id=1jxs3QiG_4mnDp-7g8aixjH9pUbpflPiQ";
            Class1.Decider = Decider;
            new gdrive().Show();
            this.Hide();
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highly Unstable, Use on your own risk");
            guna2ProgressBar1.Visible = true;
            SavDir = $"C:\\Users\\{username}\\AppData\\Roaming\\Goldberg SocialClub Emu Saves\\";
            pather = $"C:\\Users\\{username}\\AppData\\Local\\Ubisoft Game Launcher\\spool\\Assassin's Creed III Remastered\\itsrdr2bitch.zip";
            application = "B: && cd D && Launcher.exe";
            if (!File.Exists(main.path + "\\rdr2automator.exe"))
            {
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                Uri target = new Uri("https://github.com/devporter007/gcs.utility/releases/download/0.0.00001/rdr2automator.exe");
                wc.DownloadFileAsync(target, "rdr2automator.exe");

                return;
            }

            if (File.Exists(main.path + "\\rdr2automator.exe"))
            {
                Process.Start(main.path + "\\rdr2automator.exe");
                new finalSave().Show();
                this.Hide();
                return;
            }
            
        }
    }
}
