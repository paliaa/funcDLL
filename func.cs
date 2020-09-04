using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
