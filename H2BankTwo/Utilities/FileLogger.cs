using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace H2BankTwo.Utilities
{
    static class FileLogger
    {

        static string fileName = "/logfile.txt";
        static string directory = "Logs";
        public static void WrithToLog(string logMessage)
        {
            if (!File.Exists(directory + fileName))
            {
                if (!Directory.Exists("Logs"))
                {
                    Directory.CreateDirectory("Logs");
                }
                File.Create(directory + fileName);
            }
            File.AppendAllText(directory + fileName, DateTime.Now.ToString() + " " + logMessage + Environment.NewLine);




        }

        public static string ReadFromLog()
        {
            string returnString = "";
            foreach (string line in File.ReadLines(directory + fileName))
            {
                returnString += line + "\n";
            }
            return returnString;
        }

    }
}
