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
    public partial class FrmAdminLogin : Form
    {
        AdminsRepository rep;
        string name, password;
        public FrmAdminLogin()
        {
            InitializeComponent();
            rep = new AdminsRepository();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            password = txtPassword.Text;
            if(rep.isLogin(name, password))
            {
                this.Hide();
                FrmAdminPanel frm = new FrmAdminPanel();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya Parola");
                return;
            }
            Close();
        }
    }
}
