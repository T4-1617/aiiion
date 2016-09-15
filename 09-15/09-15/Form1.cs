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
        String admin;
        int i = 0;
        public Form1()
        {
            InitializeComponent();



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
             admin = "kund";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            admin = "Anställd";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            people i = new people() { firstname = textBox1.Text, lastname = textBox2.Text, status = admin};
            while(i > 0)
            {
                
            }
        }
    }
}
