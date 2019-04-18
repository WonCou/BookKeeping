using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookKeepingApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 注册DevExpress皮肤
            //Add by xiongq 2012/04/10
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            #endregion
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
            Application.Run(new LoginForm());
        }
    }
}
