using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_the_temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                textBox2.Text = (((Int32.Parse(textBox1.Text)) * 9 / 5) + 32).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = (((Int32.Parse(textBox1.Text)) * 9 / 5) - 32).ToString();
        }
    }
}
