using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            if (checkBox1.Checked)
                s = checkBox1.Text+",";
            if (checkBox2.Checked)
                s = s + checkBox2.Text+",";
            if (checkBox3.Checked)
                s = s + checkBox3.Text+",";
            label1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = "";
            foreach (string i in checkedListBox1.CheckedItems)
                d = d + i + ",";
            label2.Text = d;
        }
    }
}
