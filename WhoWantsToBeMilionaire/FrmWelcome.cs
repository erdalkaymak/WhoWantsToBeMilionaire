using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeMilionaire
{
    public partial class Welcome : Form
    {
        private SoundPlayer mainSoundPlayer;
        public Welcome()
        {
                       
            InitializeComponent();
            mainSoundPlayer = new SoundPlayer("main.wav");
            mainSoundPlayer.Play();

        }

       




    }
}
