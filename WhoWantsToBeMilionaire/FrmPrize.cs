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
    public partial class FrmPrize : Form
    {
        private SoundPlayer prize;
        int resultId;
        public static String txt ="";
        public FrmPrize()
        {
            InitializeComponent();
            prize = new SoundPlayer("Prize.wav");
            prize.Play();
            
        }
        public FrmPrize(int id)
        {
            resultId = id;
            InitializeComponent();
            prize = new SoundPlayer("Prize.wav");
            prize.Play();
        }

        public void textAndColorChange(Label lbl)
        {
            txtOdul.Text = " Tebrikler Kazanılan Ödül " + lbl.Text;
            txt = "Tebrikler "+lbl.Text+" Kazandınız";
            lbl.BackColor = Color.Orange;
        }

        private void FrmPrize_Load(object sender, EventArgs e)
        {
            if (resultId == 0)
            {
                if (FrmQuiz.id == 1)
                {
                    textAndColorChange(lbl1);
                }

                else if (FrmQuiz.id == 2)
                {
                    textAndColorChange(lbl2);
                }

                else if (FrmQuiz.id == 3)
                {
                    textAndColorChange(lbl3);

                }
                else if (FrmQuiz.id == 4)
                {
                    textAndColorChange(lbl4);
                }

                else if (FrmQuiz.id == 5)
                {
                    textAndColorChange(lbl5);
                }
                else if (FrmQuiz.id == 6)
                {
                    textAndColorChange(lbl6);
                }

                else if (FrmQuiz.id == 7)
                {
                    textAndColorChange(lbl7);
                }

                else if (FrmQuiz.id == 8)
                {
                    textAndColorChange(lbl8);
                }

                else if (FrmQuiz.id == 9)
                {
                    textAndColorChange(lbl9);
                }

                else if (FrmQuiz.id == 10)
                {
                    textAndColorChange(lbl10);
                }

                else if (FrmQuiz.id == 11)
                {
                    textAndColorChange(lbl11);
                }

                else if (FrmQuiz.id == 12)
                {
                    btnCekil.Text = "Çekinizi Alabilirsiniz";
                    btnDevamEt.Text = "Oyunu Kazandınız Ödülünüz";
                    textAndColorChange(lbl12);
                    
                }
               
            }

            if (resultId > 2 && resultId < 8)
            {
                refresh();
                textAndColorChange(lbl2);
                
            }


            if (resultId > 7 && resultId < 13)
            {
                refresh();
                textAndColorChange(lbl7);
                
            }

           
        }

        public void refresh()
        {
            if (resultId > 2)
            {
                btnDevamEt.Text = "Oyun Bitti";
                btnCekil.Text = "Çekinizi Alabilirsiniz";
            }
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (resultId >2)
            {
                
                FrmGameOver frm = new FrmGameOver();
                frm.ShowDialog();
                
            }
            if (FrmQuiz.id == 12)
            {
                FrmWinnerMaxPrize frm = new FrmWinnerMaxPrize();
                frm.ShowDialog();
            }
            prize.Stop();
            
        }

        private void btnCekil_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewGame frm = new FrmNewGame();
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            prize.Stop();
            MessageBox.Show("Oyundan Çıkılıyor...", "Çıkış işlemi");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu frm = new FrmMainMenu(true);
            frm.ShowDialog();
        }
    }
}
