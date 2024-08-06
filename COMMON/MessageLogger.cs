using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carriage_SMS_Project.COMMON
{
     class MessageLogger
    { 
        private ListBox listBox;
    private string logFilePath;

    public MessageLogger(ListBox listBox, string logFilePath)
    {
        this.listBox = listBox;
        this.logFilePath = logFilePath;
    }

    // 로그 메시지를 리스트박스와 파일에 출력하는 함수
    public void LogMessage(string message)
    {
        string logMessage = GetLogMessageWithTimestamp(message);
        AddLogToListBox(logMessage);
        SaveLogToFile(logMessage);
    }

    // 현재 시간을 추가한 로그 메시지 반환
    private string GetLogMessageWithTimestamp(string message)
    {
        string timestamp = DateTime.Now.ToString("[yyyy.MM.dd_HH:mm:ss] ");
        return timestamp + message;
    }

    // 리스트박스에 로그 메시지 추가
    private void AddLogToListBox(string logMessage)
    {
        listBox.Items.Add(logMessage);

        // 리스트박스가 너무 길어지면 가장 오래된 메시지 하나 삭제
        if (listBox.Items.Count > 1000)
        {
            listBox.Items.RemoveAt(0);
        }

        // 맨 아래에 스크롤
        listBox.SelectedIndex = listBox.Items.Count - 1;
    }

    // 파일에 로그 메시지 저장
    private void SaveLogToFile(string logMessage)
    {
        try
        {
            using (StreamWriter sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine(logMessage);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"파일 작업 중 예외 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
}