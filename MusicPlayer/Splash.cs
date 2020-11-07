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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                WindowsMediaPlayerMusic frm2 = new WindowsMediaPlayerMusic();
                frm2.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            
        }
    }
}
