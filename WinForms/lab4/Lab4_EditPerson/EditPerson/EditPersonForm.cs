using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        Person p;

        public EditPersonForm(Person p)
        {
            InitializeComponent();
            this.P1 = p;
            this.FirstName = p.FirstName;
            this.LastName = p.LastName;
            this.Age = p.Age;
        }

        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }
        }

        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }
        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }
        }

        internal Person P { get => P1; set => P1 = value; }
        internal Person P1 { get => p; set => p = value; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            P1.FirstName = this.FirstName;
            P1.LastName = this.LastName;
            P1.Age = this.Age;
            MessageBox.Show("Сотрудник: " + P1.ToString());
        }
    }
}
