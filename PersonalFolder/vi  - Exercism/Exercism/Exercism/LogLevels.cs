using System;

namespace Exercism
{


    static class LogLine
    {
        public static string Message(string logLine)
        {
            int signo = logLine.IndexOf(":") + 2;
            string text = logLine.Remove(0, signo);
            return text.Trim();
        }

        public static string LogLevel(string logLine)
        {
            string result;
            int index1, index2;
            index1 = logLine.IndexOf("[") + 1;
            index2 = logLine.IndexOf("]") - 1;
            result = logLine.Substring(index1, index2);
            return result.ToLower();
        }

        public static string Reformat(string logLine)
        {
            return ($"{Message(logLine)} ({LogLevel(logLine)})");
        }
    }
}

