using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLab4Ex5
{
    public partial class Form1 : Form
    {
        List<Results> results = new List<Results>();
        
        public string SolData
        {
            get { return richTextBox1.Text; }

            set
            {
                string[] counts = value.Split(':');
                label2.Text = "Левая граница:" + counts[0] + " правая граница:" + counts[1];
                int first = (int)Math.Ceiling(double.Parse(counts[0]) * 100);
                int last = (int)Math.Ceiling(double.Parse(counts[1]) * 100);
                for (int i = first; i < last; i += 10)
                {
                    Results res = new Results();
                    res.first = i / 100.0;
                    res.second = Math.Round(Math.Sin(res.first), 2);
                    results.Add(res);
                }


                if (last / 100 != last)
                {
                    Results res = new Results();
                    res.first = double.Parse(counts[1]);
                    res.second = Math.Round(Math.Sin(res.first), 2);
                    results.Add(res);
                }


                StringBuilder sb = new StringBuilder();
                foreach (Results item in results)
                {
                    sb.Append(item.ToString() + "\n");
                }
                richTextBox1.Text = sb.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show(this);
            
        }

        public Form1()
        {
            InitializeComponent();
            
        }

       
    }
}
