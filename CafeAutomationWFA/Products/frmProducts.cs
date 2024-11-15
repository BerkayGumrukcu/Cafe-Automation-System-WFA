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
using Entities.DAL;
using Entities.Models;

namespace CafeAutomationWFA.Products
{
    public partial class frmProducts : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private ProductDAL prdDal = new ProductDAL();
        public frmProducts()
        {
            InitializeComponent();
            List();
        }

        private void List()
        {
            gridControl1.DataSource = prdDal.ProductList(context);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSaveProduct frm = new frmSaveProduct(new Product());
            frm.ShowDialog();
            if (frm.save)
            {
                List();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmSaveProduct frm = new frmSaveProduct(prdDal.GetByFilter(context,p => p.Id==selectedId));
            frm.ShowDialog();
            if (frm.save)
            {
                List();
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

            if (MessageBox.Show("Seçili ürün silinecek, Onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prdDal.Delete(context,p => p.Id == selectedId);
                prdDal.Save(context);
                List();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}