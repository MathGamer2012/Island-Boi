using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;


namespace Island_Boi.Forms
{
    public partial class frmBookDonate : Form
    {
        public frmBookDonate()
        {
            InitializeComponent();
        }
        FilterInfoCollection filter;
        VideoCaptureDevice capDevice;

        private void frmBookDonate_Load(object sender, EventArgs e)
        {
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in filter)
            {
                comboBoxWebCam.Items.Add(info.Name);
            }
            comboBoxWebCam.SelectedIndex = 0;
        }

        private void btnCheckDisplay_Click(object sender, EventArgs e)
        {
            capDevice = new VideoCaptureDevice(filter[comboBoxWebCam.SelectedIndex].MonikerString);
            capDevice.NewFrame += CapDevice_NewFrame;
            capDevice.Start();
            timer.Start();
        }

        private void CapDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox_Camera.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        private void frmBookDonate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (capDevice != null)
            {
                if (capDevice.IsRunning)
                {
                    capDevice.Stop();
                }
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Camera.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result res = barcode.Decode((Bitmap)pictureBox_Camera.Image);
                if (res != null)
                {
                    txtDisplay.Text = res.ToString();
                    timer.Stop();
                    if (capDevice.IsRunning)
                    {
                        capDevice.Stop();
                    }
                }
            }
        }
    }
}
