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
    public partial class FrmWinnerMaxPrize : Form
    {
        private SoundPlayer winner;
        public FrmWinnerMaxPrize()
        {
            InitializeComponent();
            label1.Text = "Tebrikler!!! \n Tüm Soruları Bildiniz :) \n  En Yüksek Ödülü Kazandınız ";
            winner = new SoundPlayer("winner.wav");
            winner.PlayLooping();
            lblPlayerName.Text = FrmNewPlayer.name;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            winner.Stop();
            MessageBox.Show("Oyundan Çıkılıyor...", "Çıkış işlemi");
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            winner.Stop();
            this.Hide();
            FrmMainMenu frm = new FrmMainMenu(true);
            frm.ShowDialog();
        }
    }
}
