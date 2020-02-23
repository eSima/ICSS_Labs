using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_EratosfenAlg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder resultText = new System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resultText.AppendFormat("{0} ", trial);
                    }
                }
            }
            else
            {
                resultText.Append("Unable to parse maximum value.");
            }
            return resultText.ToString();
        }

        private async Task<string> Calculate()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1000);
                return GoButt();
            }
            );
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string res = await Calculate();
            lblResult.Text = res.ToString();
        }
    }
}
