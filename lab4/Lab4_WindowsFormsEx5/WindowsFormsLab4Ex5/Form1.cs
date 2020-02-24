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
          
            set {
                string[] counts = value.Split(':');
                Results res = new Results();
                res.first = Math.Round(Math.Sin(double.Parse(counts[0])), 2);
                res.second = Math.Round(Math.Sin(double.Parse(counts[1])), 2);
                results.Add(res);
                label2.Text = "Левая граница:" + counts[0] + " правая граница:" + counts[1];

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
