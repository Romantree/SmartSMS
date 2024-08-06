using Carriage_SMS_Project.Models;
using Carriage_SMS_Project.Repositories.IRepository;
using Carriage_SMS_Project.Views.IViews;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Presenters 
{
    public class MessagePresenter
    {
        private readonly IMessageView messageView;
        private readonly IMessageRepository messageRepository;

        public MessagePresenter(IMessageView messageView, IMessageRepository messageRepository)
        {
            this.messageView = messageView ?? throw new ArgumentNullException(nameof(messageView));
            this.messageRepository = messageRepository ?? throw new ArgumentNullException(nameof(messageRepository));
        }

        public void LoadData()
        {
            var messageModel = messageRepository.GetAllList() ?? new List<MessageModel>();
            messageView.MessageUserList(messageModel);
        }
        public void UpdateMessages(DataGridView dataGridView)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    MessageModel messageModel = new MessageModel
                    {

                        Check = (bool)(row.Cells["_check"].EditedFormattedValue ?? false) ? "True" : "False",
                        Message = row.Cells["_message"].Value?.ToString() ?? "",
                        Name1 = row.Cells["_name1"].Value?.ToString() ?? "",
                        Name2 = row.Cells["_name2"].Value?.ToString() ?? "",
                        Name3 = row.Cells["_name3"].Value?.ToString() ?? "",
                        Sabun = Convert.ToInt32(row.Cells["_sabun"].Value ?? 0)
                    };

                    messageRepository.UpdateMessage(messageModel);
                }

                messageView.ShowUpdateCompleteMessage();
            }
            catch (Exception ex)
            {
                messageView.ShowErrorMessage("메시지 업데이트 중 오류 발생: " + ex.Message);
            }
        }

       
      
        public void LoadComboBoxItems(DataGridViewComboBoxColumn comboBoxColumn, string columnName)
        {
            try
            {
                List<string> items = messageRepository.GetDistinctValues(columnName);
                comboBoxColumn.Items.Clear();
                comboBoxColumn.Items.AddRange(items.ToArray());
                
            }
            catch (Exception ex)
            {
                throw new Exception("콤보박스 아이템 로드 오류: " + ex.Message);
            }
        }

    }
}