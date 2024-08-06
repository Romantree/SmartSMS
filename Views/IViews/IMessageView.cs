using Carriage_SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Views.IViews
{
    public interface IMessageView
    {
        void MessageUserList(List<MessageModel> messageModel);
        //Properties - Fields
        void ShowUpdateCompleteMessage();
        void ShowErrorMessage(string message);
        void LoadComboBoxItems(DataGridViewComboBoxColumn comboBoxColumn, string columnName);


        int UserId { get; set; }
        string UserCheck { get; set; }
        string UserMessage { get; set; }
        string UserName1 { get; set; }
        string UserName2 { get; set; }
        string UserName3 { get; set; }


    }
}
