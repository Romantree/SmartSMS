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
        //void SetPictureBoxBorderStyle(PictureBox pictureBox, BorderStyle borderStyle);
        //void AddPictureBoxHandlers(PictureBox pictureBox);


        // View 핸들러
        event EventHandler ShowMainContentView;
        event EventHandler ShowMessageView;
        event EventHandler ShowSettingView;
        event EventHandler ShowServerView;
        event EventHandler ShowOpcListView;
        event EventHandler ShowRealtimeView;
        event EventHandler ExitApplication; //단순 클릭으로 나가기
       
        void ShowView(Control control);


    }
}
