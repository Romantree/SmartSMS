using Carriage_SMS_Project.COMMON;
using Carriage_SMS_Project.Models;
using Carriage_SMS_Project.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        Logger logger;


        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\TList.accdb;Persist Security Info=False;";

        public List<MessageModel> GetAllList()
        {
            var MessageList = new List<MessageModel>();
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM TList1";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MessageList.Add(new MessageModel
                            {
                                Sabun = reader.GetInt32(0),
                                Check = reader.GetString(1), // Convert "True"/"False" string to boolean
                                Message = reader.GetString(2),
                                Name1 = reader.GetString(3),
                                Name2 = reader.GetString(4),
                                Name3 = reader.GetString(5),
                            });
                        }
                    }
                }
            }

            return MessageList;
        }

        public List<string> GetDistinctValues(string columnName)
        {
            if (string.IsNullOrEmpty(columnName))
            {
                throw new ArgumentException("열 이름이 비었습니다.", nameof(columnName));
            }

            var values = new List<string>();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT DISTINCT [{columnName}] FROM TList1";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            if (!string.IsNullOrEmpty(value) && !values.Contains(value))
                            {
                                values.Add(value);
                            }
                        }
                    }
                }
            }
            values.Insert(0, "None");

            return values;
        }


        public void UpdateMessage(MessageModel message)
        {
            string sql = "UPDATE TList2 SET CheckFlag = @Check, Message = @Message, Name1 = @Name1, Name2 = @Name2, Name3 = @Name3 WHERE Sabun = @Sabun";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(sql, connection);
                command.Parameters.AddWithValue("@Check", message.Check);
                command.Parameters.AddWithValue("@Message", message.Message);
                command.Parameters.AddWithValue("@Name1", message.Name1);
                command.Parameters.AddWithValue("@Name2", message.Name2);
                command.Parameters.AddWithValue("@Name3", message.Name3);
                command.Parameters.AddWithValue("@Sabun", message.Sabun);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Logger.Instance.LogUpdate(message);
                    }
                    else
                    {
                        // 업데이트된 행이 없는 경우 예외 처리 또는 로깅
                        throw new Exception("메시지 업데이트 오류: 업데이트된 행이 없습니다.");
                    }
                }
                catch (Exception ex)
                {

                    Logger.Instance.LogException(ex);

                    throw new Exception("메시지 업데이트 오류: " + ex.Message);
                }
            }
        }



    }

}