using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeMilionaire
{
    public partial class FrmGameOver : Form
    {
        private SoundPlayer wrong,gameOver;
        public FrmGameOver()
        {
            InitializeComponent();
            gameOver = new SoundPlayer("gameOver.wav");
            gameOver.Play();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            gameOver.Stop();
            MessageBox.Show("Oyundan Çıkılıyor ...", "Çıkış işlemi");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gameOver.Stop();
            this.Hide();
            FrmMainMenu frm = new FrmMainMenu(true);
            frm.ShowDialog();
        }
    }
}
