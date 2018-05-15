using AudioSwitcher.AudioApi.CoreAudio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeControl
{
    public partial class frmMain : Form
    {

        CoreAudioController sysAudioController = new CoreAudioController();

        // get the playback device
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;

        // get the 
        CoreAudioDevice defaultCaptureDevice = new CoreAudioController().DefaultCaptureDevice;

        public frmMain()
        {
            InitializeComponent();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lblCurrentPlaybackVolume.Text = $"Current Playback Volume: {defaultPlaybackDevice.Volume.ToString()}";
            this.lblCurrentCaptureVolume.Text = $"Current Capture Volume: {defaultCaptureDevice.Volume.ToString()}";
        }

        private void btnSetPlaybackVolume_Click(object sender, EventArgs e)
        {
            defaultPlaybackDevice.Volume = 80;
        }

        private void btnSetCaptureVolume_Click(object sender, EventArgs e)
        {
            defaultCaptureDevice.Volume = 80;
        }
    }
}
