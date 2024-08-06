using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.Repositories
{
   public  class MainRepository
    {
        public DataTable dataTable;
        private string connectionString = "Data Source=(local);Initial Catalog=mydb;User ID=SooHo;Password=1234;TrustServerCertificate=True";

        public DataTable GetErrorEventData()
        {
             dataTable = new DataTable();
            string query = "SELECT  REPLACE(FORMAT(date, 'MM-dd'), '2024', '') AS Date , ErrorCount FROM ErrorEvent WHERE date BETWEEN '2024-08-01' AND '2024-08-07'";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                    
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // 예외 처리를 로그로 남기거나 필요에 따라 처리
                    throw new Exception("데이터를 가져오는 동안 오류가 발생했습니다: " + ex.Message);
                }
            }
            return dataTable;
        }

        public bool SaveImage(string model, string fileName, byte[] imageData, string description, string createdBy)
        {
            if (imageData == null)
            {
                throw new ArgumentNullException(nameof(imageData), "Image data cannot be null");
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO PLC_Images (PLC_Model, Image_File_Name, Image_Data, Description, Created_By) " +
                                   "VALUES (@Model, @FileName, @ImageData, @Description, @CreatedBy)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Model", model);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
                        cmd.Parameters.AddWithValue("@ImageData", imageData);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@CreatedBy", createdBy);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                Console.WriteLine(ex.Message);
                return false;
            }
        }



    }
}
