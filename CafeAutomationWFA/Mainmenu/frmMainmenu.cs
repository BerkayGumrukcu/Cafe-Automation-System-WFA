using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeAutomationWFA.Menus;
using CafeAutomationWFA.Products;
using CafeAutomationWFA.Tables;
using CafeAutomationWFA.Users;
using DevExpress.XtraEditors;

namespace CafeAutomationWFA.Mainmenu
{
    public partial class frmMainmenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        void GetForm(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();
        }


        public frmMainmenu()
        {
            InitializeComponent();
            while (true)
            {
             frmLogin frm = new frmLogin();
             if (frm.ShowDialog() == DialogResult.OK)
             {
                 break;
             }
            }
            
        }

        private void btnProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
                frmProducts frm = new frmProducts();
                if (IsFormOpen(typeof(frmProducts)))
                {
                    MessageBox.Show("Form zaten açık.");
                }
                else
                {
                    GetForm(frm);
                }
        }

        public bool IsFormOpen(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    openForm.BringToFront(); // Bring the form to the front if it's already open
                    return true;
                }
            }
            return false;
        }

        private void btnMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.ShowDialog();
        }

        private void btnTables_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTables frm = new frmTables();
            GetForm(frm);
        }

    }
}