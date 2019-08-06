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
    public partial class FrmAdminPanel : Form
    {
        MyQuizRepository rep;
        UsersRepository repU;

        public FrmAdminPanel()
        {
            InitializeComponent();           
            refreshQuiz();
            refreshUsers();
        }

        public void refreshQuiz()
        {
            rep = new MyQuizRepository();
            dtgvQuiz.DataSource = rep.List();            
        }

        public void refreshUsers()
        {
            repU = new UsersRepository();
            dtgvUsers.DataSource = repU.List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAdminPanelQuizEdit frm = new FrmAdminPanelQuizEdit();
            frm.ShowDialog();
            refreshQuiz();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtgvQuiz.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir satırı seçiniz", "Silme İşlemi");
                return;
            }
            else
            {
                MyQuiz entity = (MyQuiz)dtgvQuiz.SelectedRows[0].DataBoundItem;
                rep.Delete(entity.Id);
                refreshQuiz();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtgvQuiz.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen düzeltmek istediğiniz bir satırı seçiniz", "Güncelleme İşlemi");
                return;
            }
            else
            {
                MyQuiz entity =(MyQuiz) dtgvQuiz.SelectedRows[0].DataBoundItem;
                FrmAdminPanelQuizEdit frm = new FrmAdminPanelQuizEdit(entity);
                frm.ShowDialog();
                refreshQuiz();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dtgvUsers.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir satırı seçiniz", "Silme İşlemi");
                return;
            }
            Users user = (Users)dtgvUsers.SelectedRows[0].DataBoundItem;
            repU.Delete(user.id);
            refreshUsers();
        }

        
    }
}
