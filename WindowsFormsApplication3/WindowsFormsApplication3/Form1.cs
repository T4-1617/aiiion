using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //int tal1;
            //int tal2;
            //int calc;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int calc = tal1 + tal2;
            listView1.Items.Add(string.Format("{0} + {1} = {2}", tal1.ToString(), tal2.ToString(), calc.ToString()));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int calc = tal1 - tal2;
            listView1.Items.Add(string.Format("{0} - {1} = {2}", tal1.ToString(), tal2.ToString(), calc, ToString()));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int calc = tal1 * tal2;
            listView1.Items.Add(string.Format("{0} * {1} = {2}", tal1.ToString(), tal2.ToString(), calc, ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tal1 = int.Parse(textBox1.Text);
            int tal2 = int.Parse(textBox2.Text);
            int calc = tal1 / tal2;
            listView1.Items.Add(string.Format("{0} / {1} = {2}", tal1.ToString(), tal2.ToString(), calc, ToString()));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

    }
}
