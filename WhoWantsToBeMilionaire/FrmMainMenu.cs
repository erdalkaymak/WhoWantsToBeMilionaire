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
    public partial class FrmMainMenu : Form
    {
        private SoundPlayer mainTheme;
        
        public FrmMainMenu()
        {
            InitializeComponent();
            
            {
                Thread t = new Thread(new ThreadStart(StartForm));
                t.Start();
                Thread.Sleep(5000);
                PlayMainTheme();
                t.Abort();
            }
          
        }
        public FrmMainMenu(bool isSecond)
        {
            InitializeComponent();
            PlayMainTheme();
        }

        public void StartForm()
        {
            Application.Run(new Welcome());
            
        }
      
        public void PlayMainTheme()
        {
            mainTheme = new SoundPlayer("mainTheme.wav");
            mainTheme.PlayLooping();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainTheme.Stop();
            this.Hide();
            FrmQuiz frm = new FrmQuiz();
            frm.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mainTheme.Stop();
            MessageBox.Show("Oyundan Çıkılıyor...", "Çıkış işlemi");
            Application.Exit();
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            mainTheme.Stop();
            FrmNewPlayer frm = new FrmNewPlayer();
            frm.ShowDialog();
            mainTheme.PlayLooping();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            mainTheme.Stop();
            FrmAdminLogin frm = new FrmAdminLogin();
            frm.ShowDialog();
            mainTheme.PlayLooping();
        }
    }
}
