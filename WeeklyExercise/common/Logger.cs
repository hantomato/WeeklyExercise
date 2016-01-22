using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyExercise
{
    public class Logger
    {
        public static void log(String msg)
        {
            _log(msg);
        }

        public static void log(int msg)
        {
            log(msg.ToString());
        }

        public static void log(long msg)
        {
            log(msg.ToString());
        }

        private static void _log(string message,
                [CallerFilePath] string filePath = "",
                [CallerLineNumber] int lineNumber = 0)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(filePath).Append("(").Append(lineNumber).Append(") : ").Append(message);
            System.Diagnostics.Debug.WriteLine(sb.ToString());
        }

    }
}
