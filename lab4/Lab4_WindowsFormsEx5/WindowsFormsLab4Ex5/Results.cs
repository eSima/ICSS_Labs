using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsLab4Ex5
{
    class Results
    {
        public double first { get; set; }
        public double second { get; set; }

        public override string ToString()
        {
            return first + " " + second;
        }

    }
}
