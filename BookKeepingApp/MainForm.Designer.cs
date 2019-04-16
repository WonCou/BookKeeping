namespace BookKeepingApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSkin = new DevExpress.XtraBars.BarSubItem();
            this.barWindow = new DevExpress.XtraBars.BarSubItem();
            this.barTabbedMdi = new DevExpress.XtraBars.BarCheckItem();
            this.barCascade = new DevExpress.XtraBars.BarCheckItem();
            this.barHorizontal = new DevExpress.XtraBars.BarCheckItem();
            this.barVertical = new DevExpress.XtraBars.BarCheckItem();
            this.barTop = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockMgr = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.largeImgs = new DevExpress.Utils.ImageCollection(this.components);
            this.xtraTabbedMdiMgr = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.skin = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.loading = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::BookKeepingApp.LoadingForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockMgr)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.largeImgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiMgr)).BeginInit();
            this.SuspendLayout();
            // 
            // barMain
            // 
            this.barMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.barTop,
            this.bar3});
            this.barMain.DockControls.Add(this.barDockControlTop);
            this.barMain.DockControls.Add(this.barDockControlBottom);
            this.barMain.DockControls.Add(this.barDockControlLeft);
            this.barMain.DockControls.Add(this.barDockControlRight);
            this.barMain.DockManager = this.dockMgr;
            this.barMain.Form = this;
            this.barMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barSkin,
            this.barWindow,
            this.barTabbedMdi,
            this.barCascade,
            this.barHorizontal,
            this.barVertical});
            this.barMain.LargeImages = this.largeImgs;
            this.barMain.MainMenu = this.barTop;
            this.barMain.MaxItemId = 13;
            this.barMain.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSkin, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barWindow, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "快捷菜单";
            // 
            // barSkin
            // 
            this.barSkin.Caption = "皮肤";
            this.barSkin.Id = 7;
            this.barSkin.ImageOptions.Image = global::BookKeepingApp.Properties.Resources.skin;
            this.barSkin.Name = "barSkin";
            // 
            // barWindow
            // 
            this.barWindow.Caption = "窗口";
            this.barWindow.Id = 8;
            this.barWindow.ImageOptions.Image = global::BookKeepingApp.Properties.Resources.window;
            this.barWindow.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barTabbedMdi),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCascade),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHorizontal),
            new DevExpress.XtraBars.LinkPersistInfo(this.barVertical)});
            this.barWindow.Name = "barWindow";
            // 
            // barTabbedMdi
            // 
            this.barTabbedMdi.Caption = "选项卡式";
            this.barTabbedMdi.Id = 9;
            this.barTabbedMdi.Name = "barTabbedMdi";
            // 
            // barCascade
            // 
            this.barCascade.Caption = "层叠";
            this.barCascade.Id = 10;
            this.barCascade.Name = "barCascade";
            // 
            // barHorizontal
            // 
            this.barHorizontal.Caption = "水平";
            this.barHorizontal.Id = 11;
            this.barHorizontal.Name = "barHorizontal";
            // 
            // barVertical
            // 
            this.barVertical.Caption = "垂直";
            this.barVertical.Id = 12;
            this.barVertical.Name = "barVertical";
            // 
            // barTop
            // 
            this.barTop.BarName = "Main menu";
            this.barTop.DockCol = 0;
            this.barTop.DockRow = 0;
            this.barTop.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTop.OptionsBar.MultiLine = true;
            this.barTop.OptionsBar.UseWholeRow = true;
            this.barTop.Text = "主菜单";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem3)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "公司:Demo";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "用户:admin";
            this.barStaticItem2.Id = 1;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "版本:V1.0.0.0";
            this.barStaticItem3.Id = 2;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barMain;
            this.barDockControlTop.Size = new System.Drawing.Size(751, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 409);
            this.barDockControlBottom.Manager = this.barMain;
            this.barDockControlBottom.Size = new System.Drawing.Size(751, 29);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barMain;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 358);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(751, 51);
            this.barDockControlRight.Manager = this.barMain;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 358);
            // 
            // dockMgr
            // 
            this.dockMgr.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockMgr.Form = this;
            this.dockMgr.MenuManager = this.barMain;
            this.dockMgr.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(241)))));
            this.hideContainerLeft.Controls.Add(this.dockPanel1);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 51);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(24, 358);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("87339eb1-5104-4218-a620-d6b5ab137021");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 358);
            this.dockPanel1.Text = "导航";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 329);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // largeImgs
            // 
            this.largeImgs.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImgs.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImgs.ImageStream")));
            this.largeImgs.Images.SetKeyName(0, "1.png");
            this.largeImgs.Images.SetKeyName(1, "2.png");
            this.largeImgs.Images.SetKeyName(2, "3.png");
            this.largeImgs.Images.SetKeyName(3, "4.png");
            this.largeImgs.Images.SetKeyName(4, "5.png");
            this.largeImgs.Images.SetKeyName(5, "6.png");
            this.largeImgs.Images.SetKeyName(6, "7.png");
            this.largeImgs.Images.SetKeyName(7, "8.png");
            // 
            // xtraTabbedMdiMgr
            // 
            this.xtraTabbedMdiMgr.MdiParent = this;
            // 
            // skin
            // 
            this.skin.LookAndFeel.SkinName = "Office 2010 Silver";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 438);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "主窗口";
            ((System.ComponentModel.ISupportInitialize)(this.barMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockMgr)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.largeImgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiMgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar barTop;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.Utils.ImageCollection largeImgs;
        private DevExpress.XtraBars.Docking.DockManager dockMgr;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiMgr;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarSubItem barSkin;
        private DevExpress.XtraBars.BarSubItem barWindow;
        private DevExpress.LookAndFeel.DefaultLookAndFeel skin;
        private DevExpress.XtraBars.BarCheckItem barTabbedMdi;
        private DevExpress.XtraBars.BarCheckItem barCascade;
        private DevExpress.XtraBars.BarCheckItem barHorizontal;
        private DevExpress.XtraBars.BarCheckItem barVertical;
        private DevExpress.XtraSplashScreen.SplashScreenManager loading;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
    }
}