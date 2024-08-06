using Carriage_SMS_Project.Presenters;
using Carriage_SMS_Project.Repositories;
using Carriage_SMS_Project.Repositories.IRepository;
using Carriage_SMS_Project.Views;
using Carriage_SMS_Project.Views.IViews;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project
{
    internal static class Program
    {

       //MessageView 클래스에서 IConfiguration을 사용하여 설정 값을 불러오고 저장
        public static IConfiguration Configuration { get; private set; }
        private static Mutex mutex = new Mutex(true, "{8EE6B365-3F50-4E3A-84A0-F40E17BFFD75}");//*z
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder()
                     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                     .AddJsonFile("appsetting.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

        
            IMainView view = new MainView();
            new MainPresenter(view);

            if (mutex.WaitOne(TimeSpan.Zero, true))//*
            {
                Application.Run((Form)view);
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                mutex.ReleaseMutex(); //*

                //추가 
                //IMainView view = new MainView();
                //Application.Run((Form)view);
            }
            else
            {
                MessageBox.Show("응 안돼");

            }


        }

    }
}
