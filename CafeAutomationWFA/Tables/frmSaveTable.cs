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
    public partial class frmSaveTable : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private TableDAL tableDal = new TableDAL();
        private Table _entity;
        public bool save = false;
        public frmSaveTable(Table entity)
        {

            InitializeComponent();
            _entity = entity;
            txtTableName.DataBindings.Add("Text", _entity, "TableName");
            memoDescription.DataBindings.Add("Text", _entity, "Description");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_entity.Id == 0)
            {
                _entity.Status = false;
                _entity.IsReserved = false;
                _entity.AddedDate = DateTime.Now;
                _entity.LastUpdatedDate = DateTime.Now;
                _entity.Operation = "Yeni Masa Eklendi.";
            }else if (_entity.Id != 0)
            {
                _entity.LastUpdatedDate = DateTime.Now;
                _entity.Operation = "Masa Güncellendi.";
            }
            
            if (tableDal.AddOrUpdate(context, _entity))
            {
                tableDal.Save(context);
                save = true;
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}