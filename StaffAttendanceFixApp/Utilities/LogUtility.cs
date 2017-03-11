using System;
using System.Collections.Specialized;
using Afiniti.Framework.LoggingTracing;

namespace StaffAttendanceFixApp.Utilities
{
    public static class LogUtility
    {
        public static void WriteLog(string currentlyProcessedFileName, string excepMessage, string logFileName)
        {
            var content = new StringCollection
            {
                "Time :" + DateTime.Now,
                "File Name :" + currentlyProcessedFileName,
                "Message :" + excepMessage,
                "=======================================================================================\n"
            };

            Log.WriteLog(content, logFileName);
        }
    }
}
