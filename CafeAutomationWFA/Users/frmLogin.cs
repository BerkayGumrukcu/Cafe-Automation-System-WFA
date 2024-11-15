using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Models;

namespace CafeAutomationWFA.Users
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private bool login;
        CafeContext context = new CafeContext();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!login)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (context.Users.Any(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text))
            {
                login = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve Şifrenizi Kontrol Ediniz.", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}