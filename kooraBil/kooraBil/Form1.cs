using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kooraBil
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyTransport;
        

        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;
            MyTransport = new System.Collections.ArrayList();

            Transport a = new Transport() { Car = "pergout 206 gti", reg = "XYM603", door ="5", hp="136"};
            MyTransport.Add(a);
            listBox1.Items.Add(a);
            listBox1.DisplayMember = "name";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;

            Transport a = (Transport)MyTransport[listBox1.SelectedIndex];
           
        }






        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
