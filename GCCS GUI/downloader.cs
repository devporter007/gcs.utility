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

namespace GCCS_GUI
{
    public partial class downloader : Form
    {
        WebClient wc = new WebClient();
        public downloader()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            guna2ProgressBar1.Visible = false;

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2ProgressBar1.Visible = true;
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            Uri target = new Uri(guna2TextBox1.Text);
            
            wc.DownloadFileAsync(target, guna2TextBox2.Text);
          
        }
        private void FileDownloadComplete(object sender,AsyncCompletedEventArgs e)
        {
            MessageBox.Show("File Download Complete");
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            guna2ProgressBar1.Value = e.ProgressPercentage;
        }
    }
}
