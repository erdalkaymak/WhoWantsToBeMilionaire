using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhoWantsToBeMilionaire.DataAccessLayer;

namespace WhoWantsToBeMilionaire
{
    public partial class FrmAdminPanelQuizEdit : Form
    {
        int id;
        MyQuizRepository rep;
        List<int> cmb;
        public FrmAdminPanelQuizEdit()
        {
            id = -1;
            InitializeComponent();
            rep = new MyQuizRepository();
            cmb= new List<int>();
            List();
            comboBox1.DataSource = cmb;
        }

        public void List()
        {
            for (int i = 1; i <= 10; i++)
            {
                cmb.Add(i);
            }
        }

        public FrmAdminPanelQuizEdit(MyQuiz entity)
        {
            InitializeComponent();            
            rep = new MyQuizRepository();
            cmb = new List<int>();
            List();
            comboBox1.DataSource = cmb;
            comboBox1.SelectedItem = entity.level;
            txtQuestion.Text= entity.question;
            txtA.Text = entity.A;
            txtB.Text = entity.B;
            txtC.Text = entity.C;
            txtD.Text = entity.D;
            txtTrueAnswer.Text= entity.trueAnswer;
            id = entity.Id;
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyQuiz entity = new MyQuiz();

            entity.question = txtQuestion.Text;
            entity.A = txtA.Text;
            entity.B = txtB.Text;
            entity.C = txtC.Text;
            entity.D = txtD.Text;
            entity.trueAnswer = txtTrueAnswer.Text;
            entity.level = Convert.ToInt32(comboBox1.SelectedValue);
            
            if (id == -1)
            {
                rep.Insert(entity);
            }

            else
            {
                entity.Id = id;
                rep.Update(entity);
            }
            Close();
        }
    }
}
