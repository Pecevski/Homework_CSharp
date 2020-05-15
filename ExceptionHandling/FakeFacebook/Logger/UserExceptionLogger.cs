using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{
    public class UserExceptionLogger
    {
        private string FilePath { get; set; } = @"C:\Users\Dell\source\repos\ExceptionHandling\ExeptionLogger.txt";

        public void LogException(Exception ex)
        {
            //open connection to file
            StreamWriter sw = new StreamWriter(FilePath);

            //write in file
            sw.WriteLine($"{ex.GetType().Name} {ex.Message} {ex.StackTrace}");

            //close connection to file
            sw.Close();
        }
    }
}
