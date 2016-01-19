using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge.Video.DirectShow;

namespace cui_yuan
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            InitCam();
        }

        private void InitCam()
        {
            comboBox_videoPlayer.DataSource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBox_videoPlayer.DisplayMember = "name";
            comboBox_videoPlayer.ValueMember = "MonikerString";

            if (comboBox_videoPlayer.Items.Count == 0)
            {
                MessageBox.Show("没有找到摄像头. 请插好摄像头并重启软件");
            }

            comboBox_videoPlayer.SelectedIndex = 0;
        }
    }
}
