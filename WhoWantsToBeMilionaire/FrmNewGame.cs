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
    public partial class FrmNewGame : Form
    {
        private SoundPlayer correct;
        DialogResult result;
        public FrmNewGame()
        {
            InitializeComponent();
            correct = new SoundPlayer("correct.wav");
            correct.Play();
            result = new DialogResult();
            txtOdulYeni.Text = FrmPrize.txt;
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu frm = new FrmMainMenu(true);
            frm.ShowDialog();
            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            correct.Stop();
            result=MessageBox.Show("Oyundan Çıkmak İstediğinize Eminmisiniz","Uyarı",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Oyundan Çıkılıyor...", "Çıkış işlemi");
                Application.Exit();
            }
           
           
        }
    }
}
