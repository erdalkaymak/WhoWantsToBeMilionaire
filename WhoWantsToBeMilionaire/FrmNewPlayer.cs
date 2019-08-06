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
    public partial class FrmNewPlayer : Form
    {
        UsersRepository rep;
        public static string  name="";
        Users user;

        public FrmNewPlayer()
        {
            InitializeComponent();
            rep = new UsersRepository();
            user = new Users();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.userName = txtName.Text;
            name = txtName.Text;
            rep.Insert(user);
            MessageBox.Show("Kullanıcı kaydı başarıyla oluşturuldu","Kayıt Başarılı");
            Close();
        }
    }
}
