using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views.IViews
{
    public interface IMainView
    {
        //UI
        void SetPictureBoxBorderStyle(PictureBox pictureBox, BorderStyle borderStyle);
        void AddPictureBoxHandlers(PictureBox pictureBox);


        event EventHandler ShowMainContentView;
        event EventHandler ShowMessageView;
        event EventHandler ShowSettingView;
        event EventHandler ShowTagListView;
        event EventHandler ShowServerView;
        event EventHandler ShowOpcView;
        event EventHandler ExitApplication;

        void ShowView(Control control);


    }
}
