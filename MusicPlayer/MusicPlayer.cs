using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class WindowsMediaPlayerMusic : Form
    {
        public WindowsMediaPlayerMusic()
        {
            InitializeComponent();
        }

        String[] paths, files;

        private void MusicPlayer_Load(object sender, EventArgs e)
        {

        }

        private void MusicPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(1);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "All Supported Audio | *.mp3; *.wma; *.m4a; *.wav | MP3s | *.mp3 | WMAs | *.wma | M4As | *.m4a | WAVs | *.wav ";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                for (int i = 0; i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
                
            }


        }
    }
}
