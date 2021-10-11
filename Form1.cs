using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRAPECITY_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tipPerPerson, totalPerPerson;
            tipPerPerson = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)) / (100 * double.Parse(textBox3.Text));
            textBox4.Text = tipPerPerson.ToString();
            totalPerPerson = (double.Parse(textBox1.Text) / double.Parse(textBox3.Text)) + double.Parse(textBox4.Text);
            textBox5.Text = totalPerPerson.ToString();
        }
    }
}
