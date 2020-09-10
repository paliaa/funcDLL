using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BarPlus.funcDLL
{
    public class Func
    {
        public static double TotalSum(double value, string totalValue)
        {
            double lblTotal = double.Parse(totalValue);

            value = lblTotal + value;
            value = Math.Round(value, 2);
            return value;
        }

        public static double TotalSumMinus(double value, string totalValue)
        {
            double lblTotal = double.Parse(totalValue);
            value = lblTotal - value;
            value = Math.Round(value, 2);
            return value;
        }

        public static string NumPadIns(string textBox, int numPad)
        {
            if (textBox == "")
            {
                //tb_kassa.Text = num.ToString();
                textBox = numPad.ToString();
            }
            else if (textBox == "0")
            {
                textBox = "";
                textBox = numPad.ToString();
            }
            else if (textBox != "")
            {
                textBox += numPad.ToString();
            }

            return textBox;
        }

        public static string LogWrite_Info(string log)
        {

            StringBuilder sb = new StringBuilder();
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = m_exePath + "\\" + "log.txt";

            DateTime now = DateTime.Now;

            sb.Append(now + " | INFO: " + log + "\n");

            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();

            return log;
        }

        public static string LogWrite_Warning(string log)
        {

            StringBuilder sb = new StringBuilder();
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = m_exePath + "\\" + "log.txt";

            DateTime now = DateTime.Now;

            sb.Append(now + " | WARNING: " + log + "\n)");

            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();

            return log;
        }

        public static string LogWrite_Error(string log)
        {
            StringBuilder sb = new StringBuilder();
            string m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = m_exePath + "\\" + "log.txt";

            DateTime now = DateTime.Now;

            sb.Append(now + " | ERROR: " + log + "\n");

            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();

            return log;
        }
    }
}
