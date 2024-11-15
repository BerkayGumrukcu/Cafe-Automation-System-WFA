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

namespace CafeAutomationWFA.Tables
{
    public partial class frmTables : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        private TableDAL tableDal = new TableDAL();


        public frmTables()
        {
            InitializeComponent();
            TableList();
        }

        private void TableList()
        {
            gridControl1.DataSource = tableDal.TableList(context);
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            TableList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmSaveTable frm = new frmSaveTable(new Table());
            frm.ShowDialog();
            if (frm.save)
            {
                TableList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

            var table = tableDal.GetByFilter(context, t => t.Id == selectedId);

            frmSaveTable frm = new frmSaveTable(table);
            frm.ShowDialog();
            if (frm.save)
            {
                TableList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

            if (MessageBox.Show("Seçili ürün silinecek, Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tableDal.Delete(context, t => t.Id == selectedId);
                tableDal.Save(context);
                TableList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));

                var table = tableDal.GetByFilter(context, t => t.Id == selectedId);

                if (table.Status)
                {
                    table.Status = false;
                }
                else if (!table.Status)
                {
                    table.Status = true;
                }
                tableDal.Save(context);
                TableList();
            }
        }

        private void btnChangeReserve_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int selectedId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var table = tableDal.GetByFilter(context, t => t.Id == selectedId);

                if (table.IsReserved)
                {
                    table.IsReserved = false;
                }
                else if (!table.IsReserved)
                {
                    table.IsReserved = true;
                }
                tableDal.Save(context);
                TableList();
            }
        }
    }
}