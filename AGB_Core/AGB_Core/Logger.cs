using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGB_Core
{
    public static class Logger
    {
        public static event Action<string> UpdateConsole;

        //Methods
        //TODO: Output to file
        public static void PrintLog(string message, string level)
        {
            if (string.IsNullOrEmpty(message) ||
                string.IsNullOrWhiteSpace(message) ||
                message.Length <= 0)
                return;

            message.Trim();
            message = $"{DateTime.Now.ToString("HH:mm:ss.fff")} [{level}] {message}{Environment.NewLine}";

            UpdateConsole(message);
            Console.Write(message);
        }

        //User will only see INFO and WARN - potentially output DEBUG and ERROR to file for customer support
        public static void Info(string message) => PrintLog(message, "INFO");
        public static void Debug(string message) => PrintLog(message, "DEBUG");
        public static void Warn(string message) => PrintLog(message, "WARN");
        public static void Error(string message) => PrintLog(message, "ERROR");

        public static void Exception(string message, Exception exception)
        {
            Error(message + Environment.NewLine);
            Error(exception.ToString());
        }

        public static class Stat
        {
            //TODO: Stat logger
        }
    }
}