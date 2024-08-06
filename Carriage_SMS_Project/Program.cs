using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Views;
using Carriage_SMS_Project.Views.IViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
 
            //추가 
            //IMainView view = new MainView();
            //Application.Run((Form)view);

            Application.Run(new MainView());
        }
    }
}
