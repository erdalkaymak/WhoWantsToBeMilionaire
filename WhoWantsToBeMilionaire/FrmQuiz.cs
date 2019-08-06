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
using WhoWantsToBeMilionaire.DataAccessLayer;


namespace WhoWantsToBeMilionaire
{
    public partial class FrmQuiz : Form
    {
        private SoundPlayer wait,wrong,correct,final;
        DialogResult cikis;
        MyQuiz quiz;
        MyQuizRepository rep ;
        int senderId;
        public static int id;
        public static int  zaman;

        public FrmQuiz()
        {
            id = 0;
            InitializeComponent();
            rep = new MyQuizRepository();
            quiz = new MyQuiz();
            cikis = new DialogResult();
            wait = new SoundPlayer("wait.wav");
            correct = new SoundPlayer("correct.wav");
            wrong = new SoundPlayer("wrong.wav");
            wait.Play();
            zaman = 30;
            timer1.Enabled = true;
            refresh();            
        }
      
        public void refresh(Button button)
        {
          
            if (id < rep.ListId().Count())
            {
                zaman--;
                quiz = rep.Search(rep.ListId()[id]);
                txtQuestion.Text = quiz.question;
                A.Text = "A) " + quiz.A;
                B.Text = "B) " + quiz.B;
                C.Text = "C) " + quiz.C;
                D.Text = "D) " + quiz.D;
                button.BackColor = Color.Black;
                lblTime.Text = "";
                lblTime.Visible = true;
                id++;
                

                if (id > 6)
                {
                    timer1.Enabled = false;
                    lblTime.Visible = false;
                }
            }

            else
            {
                wait.Stop();
                this.Hide();               
                this.Close();
            }
            
             
        }

        public void refresh()
        {
            quiz = rep.Search(rep.ListId()[id]);
            txtQuestion.Text = quiz.question;
            A.Text = "A) " + quiz.A;
            B.Text = "B) " + quiz.B;
            C.Text = "C) " + quiz.C;
            D.Text = "D) " + quiz.D;
            lblTime.Text = "30";
            id++;
        }


        public bool isTrue(Button button)
        {            
            bool isTrue = false;

            if (button.Name == quiz.trueAnswer.TrimEnd())
            {
                isTrue = true;
                button.BackColor = Color.Green;
            }

            else
            {
                isTrue = false;
                button.BackColor = Color.Red;               
            }

            return isTrue;

        }


        public void DeleteAll()
        {
            txtQuestion.Text ="";
            A.Text = "";
            B.Text = "";
            C.Text = "";
            D.Text = "";
            lblTime.Text = "";
            wait.Play();
           
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            lblTime.Text = zaman.ToString();
            if (zaman==0)
            {
                timer1.Enabled = false;
                FrmGameOver frm = new FrmGameOver();
                frm.ShowDialog();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            wait.Stop();
            MessageBox.Show("Oyundan çıkılıyor ...","Çıkış işlemi");
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

            FrmMainMenu frm = new FrmMainMenu(true);
            frm.ShowDialog();
            this.Hide();
        }

       

        public void ButtonOp(Button btn)
        {
            wait.Stop();
            Message(btn);

            if (cikis == DialogResult.Yes)
            {
                if (isTrue(btn))
                {
                    correct.Play();
                    MessageBox.Show("Tebrikler Bildiniz ! Doğru Cevap :  " + quiz.trueAnswer, "Cevap");
                    this.Hide();
                    FrmPrize frm = new FrmPrize();
                    frm.ShowDialog();                   
                    DeleteAll();
                    refresh(btn);
                    this.Show();
                    timer1.Enabled = true;
                    
                    
                }
                else
                {                   
                    wrong.Play();
                    MessageBox.Show("Doğru cevap : " + quiz.trueAnswer,"Cevap");
                    this.Hide();
                    if (id < 3)
                    {
                        FrmGameOver frm = new FrmGameOver();
                        frm.ShowDialog();
                    }
                    if(id>2 && id < 8 || id>7 && id<13)
                    {
                        senderId = id;
                        FrmPrize frm = new FrmPrize(senderId);
                        frm.ShowDialog();

                    }
                    
                }
            }
           
        }

        public void Message(Button btn)
        {
            cikis = MessageBox.Show(btn.Text+" Son kararınız mı ?", "Uyarı", MessageBoxButtons.YesNo); 
            if (cikis == DialogResult.Yes)
            {
                final = new SoundPlayer("final.wav");
                final.Play();
                timer1.Enabled = false;
            }

            else 
            {
                timer1.Enabled = false;
                btn.BackColor = Color.Black;
                wait.Play();                               
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
                      
            Button btn = sender as Button;

            switch (btn.Tag)
            {
                
                case "1":
                    A.BackColor = Color.Orange;
                    ButtonOp(A);
                    zaman = 31;
                    break;
                case "2":
                    B.BackColor = Color.Orange;
                    ButtonOp(B);
                    zaman = 31;
                    break;
                case "3":
                    C.BackColor = Color.Orange;
                    ButtonOp(C);
                    zaman = 31;
                    break;
                case "4":
                    D.BackColor = Color.Orange;
                    ButtonOp(D);
                    zaman = 31;
                    break;
            }


        }
    }
}
