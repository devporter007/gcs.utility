﻿using System;
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
    public partial class VersionAndAbout : Form
        
    {
        System.Net.WebClient wc = new System.Net.WebClient();
        public VersionAndAbout()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Sources().Show();
            this.Hide();
        }
    }
}
