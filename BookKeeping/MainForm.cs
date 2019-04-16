using DevExpress;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BookKeeping
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            AddEvents();
            InitSkin();
            InitMenu();
            CreateMDIControl("首页", "", new ucIndex(), null);
        }

        #region 皮肤

        void InitSkin()
        {
            foreach (DevExpress.Skins.SkinContainer cnt in DevExpress.Skins.SkinManager.Default.Skins)
            {
                BarCheckItem item = new BarCheckItem(barMain, false);
                item.Caption = cnt.SkinName;
                barSkin.AddItem(item);
                item.ItemClick += new ItemClickEventHandler(OnSkinClick);
                if (cnt.SkinName == skin.LookAndFeel.SkinName)
                {
                    item.Checked = true;
                    barSkin.Caption = "皮肤:" + item.Caption;
                    barSkin.Hint = barSkin.Caption;
                }
            }
        }

        void OnSkinClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                loading.ShowWaitForm();
                SetSkinItemUnChecked();
                string skinName = e.Item.Caption;
                skin.LookAndFeel.SkinName = skinName;
                barSkin.Caption = "皮肤:" + e.Item.Caption;
                barSkin.Hint = barSkin.Caption;
                ((BarCheckItem)e.Item).Checked = true;
            }
            catch (Exception ex)
            {
               XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                loading.CloseWaitForm();
            }
        }

        private void SetSkinItemUnChecked()
        {
            foreach (BarItemLink ItemLink in barSkin.ItemLinks)
            {
                ((BarCheckItem)ItemLink.Item).Checked = false;
            }
        }

        #endregion

        #region 菜单事件
        void AddEvents()
        {
            barMain.ItemClick += new ItemClickEventHandler(barMain_ItemClick);
        }

        void barMain_ItemClick(object sender, ItemClickEventArgs e)
        {
            bool resetWindowStyle = false;
            if (e.Item == barTabbedMdi)
            {
                resetWindowStyle = true;
                barHorizontal.Checked =
                barVertical.Checked =
                barCascade.Checked = false;                
                InitTabbedMDI();
            }
            else if (e.Item == barVertical)
            {
                resetWindowStyle = true;
                barTabbedMdi.Checked =
                barHorizontal.Checked =
                barCascade.Checked = false;                
                MdiLayout = MdiLayout.TileVertical;
            }
            else if (e.Item == barHorizontal)
            {
                resetWindowStyle = true;
                barTabbedMdi.Checked = 
                barVertical.Checked =
                barCascade.Checked = false;
                MdiLayout = MdiLayout.TileHorizontal;

            }
            else if (e.Item == barCascade)
            {
                resetWindowStyle = true;
                barTabbedMdi.Checked =
                barVertical.Checked =
                barHorizontal.Checked = false;
                MdiLayout = MdiLayout.Cascade;
            }
            if (resetWindowStyle)
                LayoutMdi();
            if (string.IsNullOrEmpty(e.Item.Tag as string)) return;
            if (!ShowOpenedPage(e.Item.Tag as string))
            {
                CreateMDIControl(e.Item.Tag as string, "", new XtraForm(), e.Item.LargeGlyph);
            }
        }
        #endregion

        public bool ShowOpenedPage(string fName)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in xtraTabbedMdiMgr.Pages)
            {
                if (page.Text.Trim().ToUpper() == fName.Trim().ToUpper())
                {
                    xtraTabbedMdiMgr.SelectedPage = page;
                    return true;
                }
            }
            return false;
        }

        #region 初始化菜单

        private void InitMenu()
        {
            string[] strMenus = { "系统管理", "会员管理", "财务管理", "报表管理", "基础资料", "货品管理", "客户管理", "物流管理" };
            var imgindex = 0;
            foreach (var item in strMenus)
            {
                BarLargeButtonItem barLargeItem = new BarLargeButtonItem(barMain, item);
                barLargeItem.LargeGlyph = largeImgs.Images[imgindex];//也可以设置 barLargeItem.LargeImageIndex,但是效果不是很好，可以试试                
                barLargeItem.Hint = item ;
                barLargeItem.Tag = item;
                imgindex++;
                barTop.LinksPersistInfo.Add(new LinkPersistInfo(barLargeItem, true));
                barMain.Items.Add(barLargeItem);
            }
        }

        #endregion

        #region 窗口样式

        System.Windows.Forms.MdiLayout MdiLayout;
        #region 是否MDI窗口
        bool IsTabbedMdi
        {
            get
            {
                return barTabbedMdi.Down;
            }
        }
        #endregion

        #region 初始化MDI窗口

        void InitTabbedMDI()
        {
            xtraTabbedMdiMgr.MdiParent = IsTabbedMdi ? this : null;
            barCascade.Enabled = barHorizontal.Enabled = barVertical.Enabled = IsTabbedMdi ? false : true;
        }
        #endregion
        #endregion

        #region 创建MDI窗口(用户控件)
        public void CreateMDIControl(string strTitle, string strTag, XtraUserControl ctrl, Image image)
        {
            try
            {
                DevExpress.XtraTabbedMdi.XtraMdiTabPage currentPage = null;                
                if (currentPage == null)
                {
                    loading.ShowWaitForm();
                    MdiForm frm = new MdiForm();
                    frm.Visible = false;
                    ctrl.Dock = DockStyle.Fill;
                    frm.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    frm.Text = strTitle;
                    frm.Tag = strTag;
                    ctrl.Tag = strTag;
                    ctrl.Text = strTitle;
                    if (!IsTabbedMdi)
                        frm.ClientSize = new Size(this.Width, this.Height);
                    frm.Controls.Add(ctrl);
                    frm.MdiParent = this;
                    if (image != null)
                    {
                        frm.ShowIcon = true;
                    }
                    else
                        image = base.Icon.ToBitmap();
                    frm.Show();
                    currentPage = xtraTabbedMdiMgr.SelectedPage;
                }
                else
                {
                    xtraTabbedMdiMgr.SelectedPage = currentPage;
                }
                if (currentPage != null && ctrl is ucIndex)
                {
                    currentPage.ShowCloseButton = DefaultBoolean.False;
                }
            }
            catch (Exception ex)
            {
                loading.CloseWaitForm();
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                loading.CloseWaitForm();
                LayoutMdi();
                GC.Collect();
            }
        }

        /// <summary>
        /// 子窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //这里根据状态判断是否需要提示
            //DialogResult dlg = XtraMessageBox.Show("确定要关闭吗?", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //if (dlg == System.Windows.Forms.DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }
    
        #endregion

        #region 创建MDI窗口(普通窗口)
        public void CreateMDIControl(string strTitle, string strTag, XtraForm frmBase, Image image)
        {
            try
            {
                DevExpress.XtraTabbedMdi.XtraMdiTabPage currentPage = null;                
                if (currentPage == null)
                {
                    loading.ShowWaitForm();

                    frmBase.Dock = DockStyle.Fill;
                    frmBase.FormClosing += new FormClosingEventHandler(frm_FormClosing);
                    frmBase.Text = strTitle;
                    frmBase.Tag = strTag;
                    if (!IsTabbedMdi)
                        frmBase.ClientSize = new Size(this.Width, this.Height);
                    frmBase.MdiParent = this;
                    if (image != null)
                    {
                        frmBase.ShowIcon = true;
                    }
                    else
                        image = base.Icon.ToBitmap();
                    frmBase.Show();
                    currentPage = xtraTabbedMdiMgr.SelectedPage;
                    xtraTabbedMdiMgr.SelectedPage.Image = image;
                }
                else
                {
                    xtraTabbedMdiMgr.SelectedPage = currentPage;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            finally
            {
                loading.CloseWaitForm();
                LayoutMdi();
            }
        }

        /// <summary>
        /// 设置窗口布局
        /// </summary>
        public void LayoutMdi()
        {
            if (!IsTabbedMdi)
                LayoutMdi(MdiLayout);
        }

        #endregion

    }
}