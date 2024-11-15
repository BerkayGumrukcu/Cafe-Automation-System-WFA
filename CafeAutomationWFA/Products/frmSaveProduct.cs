using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.DAL;
using Entities.Models;

namespace CafeAutomationWFA.Products
{
    public partial class frmSaveProduct : DevExpress.XtraEditors.XtraForm
    {
        private MenuDAL menuDal = new MenuDAL();
        private ProductDAL productDal = new ProductDAL();
        private Product _entity;
        private CafeContext context = new CafeContext();
        public bool save = false;

        public void BreakdownImage()
        {
            pictureEdit1.Image = null;
        }


        public frmSaveProduct(Product entity)
        {
            InitializeComponent();
            _entity = entity;
            lookUpMenu.Properties.DataSource = menuDal.GetAll(context);
            lookUpMenu.DataBindings.Add("EditValue", _entity, "MenuId");
            txtProductName.DataBindings.Add("Text", _entity, "ProductName");
            txtProductCode.DataBindings.Add("Text", _entity, "ProductCode");
            calcUnitPrice1.DataBindings.Add("Text", _entity, "UnitPrice1",true);
            calcUnitPrice2.DataBindings.Add("Text", _entity, "UnitPrice2",true);
            calcUnitPrice3.DataBindings.Add("Text", _entity, "UnitPrice3", true);
            memoDescription.DataBindings.Add("Text", _entity, "Description");
            dateDateTime.DataBindings.Add("Text", _entity, "Date", true);
            if (_entity.Id != 0)
            {
                if (_entity.Image != null)
                {
                    pictureEdit1.Image = Image.FromFile(_entity.Image);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation() != "")
            {
                string pathLocation = $"{Application.StartupPath}\\Image\\{txtProductName.Text}-{txtProductCode.Text}.png"; 
                File.Copy(pictureEdit1.GetLoadedImageLocation(),pathLocation);
                _entity.Image = $"Image\\{txtProductName.Text}-{txtProductCode.Text}.png";
            }

            if (productDal.AddOrUpdate(context,_entity))
            {
                productDal.Save(context);
                save = true;
                if (save == true)
                {
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}