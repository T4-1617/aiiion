using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_15
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList people;
        Boolean admin;
        int i = 0;
        Boolean[] id = new bool [100];
        public Form1()
        {
            InitializeComponent();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             admin = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            admin = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            people id[0] = new people() { firstname = textBox1.Text, lastname = textBox2.Text,};
            while(i > 0)
            {
                if(admin == false)
                listBox1.Items.Add(i);
            }
        }
    }
}
