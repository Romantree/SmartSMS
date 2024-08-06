using Carriage_SMS_Project.Views.IViews;
//using Carriage_SMS_Project.Models;
//using Carriage_SMS_Project._Repositories;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carriage_SMS_Project.Views;

namespace Carriage_SMS_Project.Presenters
{
    public class MainPresenter
    {
        private readonly IMainView _mainView;

        public MainPresenter(IMainView view)
        {

            _mainView = view;
            // View에서 발생한 이벤트에 대한 처리
            _mainView.ShowMainContentView += (sender, e) => _mainView.ShowView(new MainContentView());
            _mainView.ShowMessageView += (sender, e) => _mainView.ShowView(new MessageView());
            _mainView.ShowOpcView += (sender, e) => _mainView.ShowView(new OpcView());
            _mainView.ShowTagListView += (sender, e) => _mainView.ShowView(new TagListView());
            _mainView.ShowServerView += (sender, e) => _mainView.ShowView(new ServerView());
            _mainView.ShowSettingView += (sender, e) => _mainView.ShowView(new SettingView());


            _mainView.ExitApplication += (sender, e) => Application.Exit();
        }

        private void OnMainView(object sender, EventArgs e)
        {
            // MainView 이벤트 처리 로직
        }

        private void OnShowMessageView(object sender, EventArgs e)
        {
            // ShowMessageView 이벤트 처리 로직
        }

        private void OnShowSettingView(object sender, EventArgs e)
        {
            // ShowSettingView 이벤트 처리 로직
        }

        private void OnShowOpcView(object sender, EventArgs e)
        {
            // ShowOpcView 이벤트 처리 로직
        }

        private void OnShowTagListView(object sender, EventArgs e)
        {
            // ShowTagListView 이벤트 처리 로직
        }


    }
}

