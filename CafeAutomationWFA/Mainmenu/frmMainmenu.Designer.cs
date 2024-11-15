namespace CafeAutomationWFA.Mainmenu
{
    partial class frmMainmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainmenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnTables = new DevExpress.XtraBars.BarButtonItem();
            this.btnTableAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenuAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnProduct = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsers = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoles = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoviz = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelper = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnTables,
            this.btnTableAccount,
            this.btnMenu,
            this.btnMenuAccount,
            this.btnProduct,
            this.btnProductAccount,
            this.btnUsers,
            this.btnUserAccount,
            this.btnRoles,
            this.btnDoviz,
            this.barButtonItem2,
            this.btnHelper,
            this.btnAbout,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(950, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnTables
            // 
            this.btnTables.Caption = "Masalar";
            this.btnTables.Id = 1;
            this.btnTables.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTables.ImageOptions.SvgImage")));
            this.btnTables.Name = "btnTables";
            this.btnTables.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTables_ItemClick);
            // 
            // btnTableAccount
            // 
            this.btnTableAccount.Caption = "Masa Hareketleri";
            this.btnTableAccount.Id = 2;
            this.btnTableAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTableAccount.ImageOptions.SvgImage")));
            this.btnTableAccount.Name = "btnTableAccount";
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Menüler";
            this.btnMenu.Id = 3;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMenu_ItemClick);
            // 
            // btnMenuAccount
            // 
            this.btnMenuAccount.Caption = "Menü Hareketleri";
            this.btnMenuAccount.Id = 4;
            this.btnMenuAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenuAccount.ImageOptions.SvgImage")));
            this.btnMenuAccount.Name = "btnMenuAccount";
            // 
            // btnProduct
            // 
            this.btnProduct.Caption = "Ürünler";
            this.btnProduct.Id = 5;
            this.btnProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProduct.ImageOptions.SvgImage")));
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProduct_ItemClick);
            // 
            // btnProductAccount
            // 
            this.btnProductAccount.Caption = "Ürün Hareketleri";
            this.btnProductAccount.Id = 6;
            this.btnProductAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProductAccount.ImageOptions.SvgImage")));
            this.btnProductAccount.Name = "btnProductAccount";
            // 
            // btnUsers
            // 
            this.btnUsers.Caption = "Kullanıcılar";
            this.btnUsers.Id = 7;
            this.btnUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUsers.ImageOptions.SvgImage")));
            this.btnUsers.Name = "btnUsers";
            // 
            // btnUserAccount
            // 
            this.btnUserAccount.Caption = "Kullanıcı Hareketleri";
            this.btnUserAccount.Id = 10;
            this.btnUserAccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUserAccount.ImageOptions.SvgImage")));
            this.btnUserAccount.Name = "btnUserAccount";
            // 
            // btnRoles
            // 
            this.btnRoles.Caption = "Rol Tanımla";
            this.btnRoles.Id = 11;
            this.btnRoles.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRoles.ImageOptions.SvgImage")));
            this.btnRoles.Name = "btnRoles";
            // 
            // btnDoviz
            // 
            this.btnDoviz.Caption = "Döviz";
            this.btnDoviz.Id = 12;
            this.btnDoviz.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoviz.ImageOptions.SvgImage")));
            this.btnDoviz.Name = "btnDoviz";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 13;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnHelper
            // 
            this.btnHelper.Caption = "Yardım";
            this.btnHelper.Id = 14;
            this.btnHelper.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHelper.ImageOptions.SvgImage")));
            this.btnHelper.Name = "btnHelper";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "Hakkımızda";
            this.btnAbout.Id = 15;
            this.btnAbout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAbout.ImageOptions.SvgImage")));
            this.btnAbout.Name = "btnAbout";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Cafe İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTables);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTableAccount);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Masalar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenu);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMenuAccount);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Menüler";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProduct);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductAccount);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Ürünler";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUsers);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUserAccount);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRoles);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Kullanıcılar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ayarlar";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoviz);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHelper);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ayarlar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 402);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(950, 24);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bs";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmMainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 426);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMainmenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cafe Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnTables;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnTableAccount;
        private DevExpress.XtraBars.BarButtonItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnMenuAccount;
        private DevExpress.XtraBars.BarButtonItem btnProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnProductAccount;
        private DevExpress.XtraBars.BarButtonItem btnUsers;
        private DevExpress.XtraBars.BarButtonItem btnUserAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnRoles;
        private DevExpress.XtraBars.BarButtonItem btnDoviz;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnHelper;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}