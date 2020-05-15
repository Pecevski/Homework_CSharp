using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{
    public class AdminExceptionLogger
    {
        private string FilePath { get; set; } = @"C:\Users\Dell\source\repos\ExceptionHandling\AdminExceptionLogger.txt";

        public void AdminLogException(Exception ex)
        {           
            StreamWriter sw = new StreamWriter(FilePath);

            sw.WriteLine($"{ex.GetType().Name} {ex.Message} {ex.StackTrace}");

            sw.Close();
        }
    }
}
