using Carriage_SMS_Project.Views.IViews;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Presenters
{

    public class MainUiPresenter
    {
        private readonly IMainView view;


        public MainUiPresenter(IMainView view)
        {
            this.view = view;
        }

        public void AddPictureBoxHandlers(PictureBox pictureBox)
        {
            view.AddPictureBoxHandlers(pictureBox);
        }

        public void PictureBoxMouseEnter(PictureBox pictureBox)
        {
            // 테두리 그리기
            view.SetPictureBoxBorderStyle(pictureBox, BorderStyle.FixedSingle);
        }

        public void PictureBoxMouseLeave(PictureBox pictureBox)
        {
            // 이전의 테두리 스타일로 변경
            if (pictureBox.Tag != null)
            {
                view.SetPictureBoxBorderStyle(pictureBox, (BorderStyle)pictureBox.Tag);
                pictureBox.Tag = null;
            }
        }
    }

}

    