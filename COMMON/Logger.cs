using Carriage_SMS_Project.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carriage_SMS_Project.COMMON
{
    public class Logger
    {

        private static Logger instance;
        private static readonly object lockObj = new object();
        private readonly string logsDirectory;

        private Logger()
        {
            logsDirectory = @"D:\Logs"; // 로그 파일이 저장될 기본 디렉토리 경로 설정

        }

        public static Logger Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                    return instance;
                }
            }
        }

        public void LogUpdate(MessageModel message)

        {
            EnsureLogsDirectoryExists(); // 로그 폴더 확인 및 생성
            string logFileName = $"update_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string logFilePath = Path.Combine(logsDirectory, logFileName);

            string logContent = $"[{DateTime.Now}] 메시지 업데이트: Sabun = {message.Sabun}, CheckFlag = {message.Check}, Message = {message.Message}, Name1 = {message.Name1}, Name2 = {message.Name2}, Name3 = {message.Name3}";

            CreateLogFile(logFilePath, logContent);
        }



        public void LogException(Exception ex)
        {
            EnsureLogsDirectoryExists(); // 로그 폴더 확인 및 생성

            string logFileName = $"update_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string logFilePath = Path.Combine(logsDirectory, logFileName);
            string logContent = $"[{DateTime.Now}] 예외 발생: {ex.Message}{Environment.NewLine}Stack Trace: {ex.StackTrace}";

            CreateLogFile(logFilePath, logContent);
        }
        public void CreateLogFile(string filePath, string content)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(content);
            }
        }

        private void EnsureLogsDirectoryExists()
        {
            if (!Directory.Exists(logsDirectory))
            {
                Directory.CreateDirectory(logsDirectory);
            }
        }
    }
}
