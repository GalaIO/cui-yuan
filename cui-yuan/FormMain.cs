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
        }

        public bool Init()
        {
            bool ret = true;

            ret &= InitCam() ;

            return ret;
        }

        private bool InitCam()
        {
            comboBox_videoPlayer.DataSource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            comboBox_videoPlayer.DisplayMember = "name";
            comboBox_videoPlayer.ValueMember = "MonikerString";

            if (comboBox_videoPlayer.Items.Count == 0)
            {
                MessageBox.Show("没有找到摄像头. 请插好摄像头后，点击确定");
                return false;
            }

            comboBox_videoPlayer.SelectedIndex = 0;
            return true;
        }

        private void StartCam()
        {
            videoPlayer_shopin.VideoSource = new VideoCaptureDevice(comboBox_videoPlayer.SelectedValue.ToString()); ;
            videoPlayer_shopin.Start();
        }

        private bool StopCam()
        {
            if (videoPlayer_shopin.VideoSource != null)
            {
                videoPlayer_shopin.VideoSource.SignalToStop();
                videoPlayer_shopin.VideoSource.WaitForStop();
                return !videoPlayer_shopin.VideoSource.IsRunning;
            }
            return true;
        }

        private void tabPage_Shopin_Enter(object sender, EventArgs e)
        {
            if (!StopCam())
            {
                MessageBox.Show("摄像头被占用，无法打开摄像头");
                return;
            }
            StartCam();
        }

        private void tabPage_Shopin_Leave(object sender, EventArgs e)
        {
            if ( !StopCam())
            {
                MessageBox.Show("摄像头没有正常关闭");
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!StopCam())
            {
                MessageBox.Show("摄像头没有正常关闭");
            }
        }
    }
}
