using Carriage_SMS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Repositories.IRepository
{
    public interface IMessageRepository
    {
        List<MessageModel> GetAllList();
        List<string> GetDistinctValues(string columnName);

        void UpdateMessage(MessageModel message);

    }
}
